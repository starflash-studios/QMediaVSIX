#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.Threading.Tasks;

using Windows.Media.Control;

using Microsoft.VisualStudio.Shell;

using QMediaVSIX.Controls;
using QMediaVSIX.Core.MediaSource.Software;

namespace QMediaVSIX.Commands;

[InstanceProvider(nameof(Instance), nameof(Init), nameof(OnFinishedInit))]
public class SessionCommandManager : NotifyPropertyChange {

    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    public static SessionCommandManager? Instance { get; } = null;

    public static SessionCommandManager Init() => new SessionCommandManager();

    static MediaSession? _Active = null;
    public static MediaSession? Active {
        get => _Active;
        set {
            if ( Instance is null ) {
                //If no instance is created yet, there's no reason to raise property change notifications as there will be no receivers anyways. Just change the value and return.
                _Active = value;
                return;
            }
            if ( value != _Active ) {
                Instance.RaisePropertyChanging();
                Debug.WriteLine($"Active session changed to {value}");
                _Active = value;

                if ( value is { } New ) {
                    _ = ThreadHelper.JoinableTaskFactory.StartOnIdle(async () => {
                        //MediaSession StartSession = New;
                        //Debug.WriteLine($"Started position checking loop of {New}.");
                        for (; ; ) {
                            await Task.Delay(2000);
                            if ( _Active != New ) {
                                //Debug.WriteLine("Changed. Aborting loop.");
                                break;
                            }
                            OnSlowPoll(Instance, New.Session.GetPlaybackInfo());
                            //Debug.WriteLine($"Pos: {New.Position} ;; Status: {New.Session.GetPlaybackInfo().PlaybackStatus}");
                        }
                    });
                }

                Instance.RaisePropertyChanged();
            }
        }
    }

    public static Action<Func<Task>> AsyncRunner = null!;

    #region OnSlowPoll Event

    /// <summary>
    /// Event arguments for the <see cref="OnSlowPoll"/> event (<inheritdoc cref="OnSlowPoll"/>).
    /// </summary>
    /// <param name="Sender">The event raiser.</param>
    /// <param name="E">The raised event arguments.</param>
    public delegate void SlowPollEventArgs( SessionCommandManager Sender, GlobalSystemMediaTransportControlsSessionPlaybackInfo E );

    /// <summary>
    /// Invoked when the currently playing <see cref="MediaSession"/> ticks on the slow poll.
    /// </summary>
    public static event SlowPollEventArgs SlowPoll = delegate { };

    /// <summary>
    /// Raises the <see cref="SlowPoll"/> event (<inheritdoc cref="SlowPoll"/>)
    /// </summary>
    /// <param name="Sender">The event raiser.</param>
    /// <param name="E">The raised event arguments.</param>
    public static void OnSlowPoll( SessionCommandManager Sender, GlobalSystemMediaTransportControlsSessionPlaybackInfo E ) => SlowPoll(Sender, E);

    #endregion

    public SessionCommandManager() {
        if ( Instance is not null ) {
            throw new NotSupportedException("May not create multiple instances.");
        }
        AsyncRunner = Tk => _ = ThreadHelper.JoinableTaskFactory.RunAsync(Tk);
        foreach (MediaSession Session in MediaSessionManager.Sessions.Values ) {
            Session.AsyncRunner = AsyncRunner;
        }
        MediaSessionManager.SessionConnected += ( S, _ ) => {
            S.AsyncRunner = AsyncRunner;
        };
        MediaSessionManager.CurrentSessionChanged += ( _, E ) => Active = E;
    }

    public static void RunWhenInitialised(InitialisedEventArgs Act) {
        if ( Instance is { } I ) {
            Act(I);
        } else {
            Initialised += Act;
        }
    }

    static void OnFinishedInit() => OnInitialised(Instance!);

    #region Initialised Event

    /// <summary>
    /// Event arguments for the <see cref="Initialised"/> event (<inheritdoc cref="Initialised"/>).
    /// </summary>
    /// <param name="Sender">The event raiser.</param>
    public delegate void InitialisedEventArgs( SessionCommandManager Sender );

    /// <summary>
    /// Invoked when a <see cref="SessionCommandManager"/> instance is created.
    /// </summary>
    public static event InitialisedEventArgs Initialised = delegate { };

    /// <summary>
    /// Raises the <see cref="Initialised"/> event (<inheritdoc cref="Initialised"/>)
    /// </summary>
    /// <param name="Sender">The event raiser.</param>
    public static void OnInitialised( SessionCommandManager Sender ) => Initialised(Sender);

    #endregion
}