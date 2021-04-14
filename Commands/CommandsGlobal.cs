#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Windows.Media;
using Microsoft.VisualStudio.Shell;

using Windows.Media.Control;

using GSMTCMediaProperties = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionMediaProperties;
using GSMTCSession = Windows.Media.Control.GlobalSystemMediaTransportControlsSession;
using GSMTCSessionManager = Windows.Media.Control.GlobalSystemMediaTransportControlsSessionManager;
using Task = System.Threading.Tasks.Task;

namespace QMediaVSIX.Commands {
    public static class CommandsGlobal {
        public static GSMTCSessionManager? TransportControls;
        public static Action<GSMTCSessionManager, CurrentSessionChangedEventArgs, FuzzyMediaInfo, GSMTCSession?, GSMTCMediaProperties?>? OnSessionChange = null;

        public static async Task PrepareAsync() {
            TransportControls = await GSMTCSessionManager.RequestAsync();
            TransportControls.CurrentSessionChanged += TC_CSC;
        }

        public static void Destruct() {
            if (TransportControls != null) {
                TransportControls.CurrentSessionChanged -= TC_CSC;
            }
        }


        static void TC_CSC( GSMTCSessionManager Sender, CurrentSessionChangedEventArgs Args ) {
            ThreadHelper.JoinableTaskFactory.RunAsync(async () => {
                (FuzzyMediaInfo FMI, GSMTCSession? S, GSMTCMediaProperties? MP) = await FuzzyMediaInfo.GetAsyncEx(TransportControls);
                OnSessionChange?.Invoke(Sender, Args, FMI, S, MP);
            });
        }

        public static async Task<(GSMTCSessionManager? Manager, GSMTCSession? Session, GSMTCMediaProperties? Media)> GetMediaInfoAsync() {
            if (TransportControls == null) {
                TransportControls = await GSMTCSessionManager.RequestAsync();
                if (TransportControls == null) { return (null, null, null); }

                TransportControls.CurrentSessionChanged += TC_CSC;
            }

            GSMTCSession? Session = TransportControls.GetCurrentSession();
            return (TransportControls, Session, await Session?.TryGetMediaPropertiesAsync());
        }

        public static async Task<FuzzyMediaInfo> GetCurrentMediaDetailsAsync() => await FuzzyMediaInfo.GetAsync(TransportControls);

        internal static async Task CurrentSessionControlAsync(QMediaVSIXPackage? Package, Func<GSMTCSession, Task<bool>> SessionCommand, ITwoStageCheck FallbackCheck, VirtualKey? FallbackKey, string FallbackMessage) {
            (FuzzyMediaInfo Old, GSMTCSession? Session, GSMTCMediaProperties? Props) = await FuzzyMediaInfo.GetAsyncEx(TransportControls);
            await FallbackCheck.StageOneAsync(Old, Session, Props);
            int FallbackDelay = Package?.FallbackDelay ?? -1;
            Debug.WriteLine("Got Delay: " + FallbackDelay);
            if (FallbackDelay == 0) {
                Debug.WriteLine("Zero Delay. Fallback Immediately.");
                SimulateKeypress(FallbackKey);
            } else if (Session != null && await SessionCommand.Invoke(Session)) {
                Debug.WriteLine("Successfully invoked command. No fallback required." + (FallbackDelay > 0 ? $" Fuzzy equivalence checks will follow in {FallbackDelay} ms" : " Additionally, delay < 0, therefore no extra fuzzy equivalence checks will be made."));
                if (FallbackDelay > 0 && await DelayedCheckAsync(async () => {
                    (FuzzyMediaInfo New, GSMTCSession? NewSession, GSMTCMediaProperties? NewProps) = await FuzzyMediaInfo.GetAsyncEx(TransportControls);
                    return await FallbackCheck.StageTwoAsync(New, NewSession, NewProps);
                }, FallbackDelay)) {
                    Debug.WriteLine("Session was not null, and the command completed successfully, however the media stayed the since. Since delay > 0, using fallback...");
                    Debug.WriteLine(FallbackMessage);
                    SimulateKeypress(FallbackKey);
                }
            } else if (FallbackDelay > 0) {
                //await Task.Delay(FallbackDelay);
                Debug.WriteLine("Session was null, or couldn't invoke command. Delay was > 0. Using fallback...");
                Debug.WriteLine(FallbackMessage);
                SimulateKeypress(FallbackKey);
            }
        }

        public interface ITwoStageCheck {
            Task StageOneAsync(FuzzyMediaInfo Old, GSMTCSession? Session, GSMTCMediaProperties? Props);
            Task<bool> StageTwoAsync(FuzzyMediaInfo New, GSMTCSession? Session, GSMTCMediaProperties? Props);
        }

        public struct TwoStageCheck_MediaChange : ITwoStageCheck {
            FuzzyMediaInfo _OldMedia;
            public Task StageOneAsync(FuzzyMediaInfo Old, GSMTCSession? Session, GSMTCMediaProperties? Props) {
                _OldMedia = Old;
                return Task.CompletedTask;
            }

            public Task<bool> StageTwoAsync(FuzzyMediaInfo New, GSMTCSession? Session, GSMTCMediaProperties? Props) => Task.FromResult(_OldMedia.Equals(New));
        }

        public struct TwoStageCheck_PlaybackStatusChange : ITwoStageCheck {
            GlobalSystemMediaTransportControlsSessionPlaybackStatus? _OldStatus;
            public Task StageOneAsync(FuzzyMediaInfo Old, GSMTCSession? Session, GSMTCMediaProperties? Props) {
                _OldStatus = Old.Status;
                return Task.CompletedTask;
            }

            public Task<bool> StageTwoAsync( FuzzyMediaInfo New, GSMTCSession? Session, GSMTCMediaProperties? Props ) => Task.FromResult(EqualityComparer<GlobalSystemMediaTransportControlsSessionPlaybackStatus?>.Default.Equals(_OldStatus, New.Status));
        }

        public struct TwoStageCheck_RepeatModeChange : ITwoStageCheck {
            MediaPlaybackAutoRepeatMode? _OldRepeatMode;
            public Task StageOneAsync(FuzzyMediaInfo Old, GSMTCSession? Session, GSMTCMediaProperties? Props) {
                _OldRepeatMode = Session?.GetPlaybackInfo()?.AutoRepeatMode;
                return Task.CompletedTask;
            }

            public Task<bool> StageTwoAsync(FuzzyMediaInfo New, GSMTCSession? Session, GSMTCMediaProperties? Props) => Task.FromResult(EqualityComparer<MediaPlaybackAutoRepeatMode?>.Default.Equals(_OldRepeatMode, Session?.GetPlaybackInfo()?.AutoRepeatMode));
        }

        public struct TwoStageCheck_ShuffleModeChange : ITwoStageCheck {
            bool? _OldShuffleActive;
            public Task StageOneAsync(FuzzyMediaInfo Old, GSMTCSession? Session, GSMTCMediaProperties? Props) {
                _OldShuffleActive = Session?.GetPlaybackInfo()?.IsShuffleActive;
                return Task.CompletedTask;
            }

            public Task<bool> StageTwoAsync(FuzzyMediaInfo New, GSMTCSession? Session, GSMTCMediaProperties? Props) => Task.FromResult(EqualityComparer<bool?>.Default.Equals(_OldShuffleActive, Session?.GetPlaybackInfo()?.IsShuffleActive));
        }

        public static async Task CurrentSessionPlayPauseAsync(QMediaVSIXPackage? Package) => await CurrentSessionControlAsync(Package, async Session => await Session.TryTogglePlayPauseAsync(), new TwoStageCheck_PlaybackStatusChange(), VirtualKey.VK_MEDIA_PLAY_PAUSE, "Unable to attach to / toggle playback of media within current session.");

        public static async Task CurrentSessionSkipPrevAsync(QMediaVSIXPackage? Package) => await CurrentSessionControlAsync(Package, async Session => await Session.TrySkipPreviousAsync(), new TwoStageCheck_MediaChange(), VirtualKey.VK_MEDIA_PREV_TRACK, "Unable to attach to / skip to previous media within current session.");

        public static async Task CurrentSessionSkipNextAsync(QMediaVSIXPackage? Package) => await CurrentSessionControlAsync(Package, async Session => await Session.TrySkipNextAsync(), new TwoStageCheck_MediaChange(), VirtualKey.VK_MEDIA_NEXT_TRACK, "Unable to attach to / skip to next media within current session.");

        public static async Task CurrentSessionShuffleAsync(QMediaVSIXPackage? Package) => await CurrentSessionControlAsync(Package, async Session => await Session.TryChangeShuffleActiveAsync(InvertShuffle(Session.GetPlaybackInfo().IsShuffleActive)), new TwoStageCheck_ShuffleModeChange(), null, "Unable to attach to / toggle media shuffling within current session.");

        public static async Task CurrentSessionRepeatAsync(QMediaVSIXPackage? Package) => await CurrentSessionControlAsync(Package, async Session => await Session.TryChangeAutoRepeatModeAsync(InvertRepeatMode(Session.GetPlaybackInfo().AutoRepeatMode)), new TwoStageCheck_RepeatModeChange(), null, "Unable to attach to / toggle repeat (list mode) of media within current session.");

        internal static bool InvertShuffle(bool? Orig) => Orig switch {
            true => false,
            _    => true
        };

        internal static MediaPlaybackAutoRepeatMode InvertRepeatMode(MediaPlaybackAutoRepeatMode? Orig) {
            switch (Orig) {
                case MediaPlaybackAutoRepeatMode.None:
                case null:
                    return MediaPlaybackAutoRepeatMode.List;
                case MediaPlaybackAutoRepeatMode.Track:
                case MediaPlaybackAutoRepeatMode.List:
                    return MediaPlaybackAutoRepeatMode.None; //TODO: Support track/list repeat mode swapping
                default:
                    throw new ArgumentOutOfRangeException(nameof(Orig), Orig, null);
            }
        }

        public static async Task<bool> DelayedCheckAsync(Func<Task<bool>> Func, int Delay) {
            await Task.Delay(Delay);
            return await Func.Invoke();
        } 

        [Flags] public enum KeyEvent : uint {
            KEYEVENTF_EXTENDEDKEY = 0x0001,
            KEYEVENTF_KEYUP = 0x0002
        }

        [Flags] public enum VirtualKey : byte {
            //https://docs.microsoft.com/en-au/windows/win32/inputdev/virtual-key-codes?redirectedfrom=MSDN
            VK_MEDIA_NEXT_TRACK = 0xB0,
            VK_MEDIA_PREV_TRACK = 0xB1,
            VK_MEDIA_STOP = 0xB2,
            VK_MEDIA_PLAY_PAUSE = 0xB3,
            //...
            VK_LAUNCH_MEDIA_SELECT = 0XB5
            //...
        }

        public static void SimulateKeypress(VirtualKey? KeyCode, KeyEvent EventType = KeyEvent.KEYEVENTF_EXTENDEDKEY) {
            [DllImport("user32.dll"), SuppressMessage("ReSharper", "InconsistentNaming"), SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
            static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

            if (KeyCode == null) { Debug.WriteLine("Attempted to send <null> keypress. Ignored."); return; }
            keybd_event((byte)KeyCode, 0, (uint)EventType | 0, 0);
        }
    }

}
