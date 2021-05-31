#region Copyright (C) 2017-2021  Starflash Studios

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License (Version 3.0)
// as published by the Free Software Foundation.
// 
// More information can be found here: https://www.gnu.org/licenses/gpl-3.0.en.html

#endregion

using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CSCore.CoreAudioAPI;

namespace AudioUtils {
    /// <summary> Represents a cached instance of an audio-playing <see cref="System.Diagnostics.Process"/> retrieved via <see cref="CSCore"/>. </summary>
    public readonly struct AudioProgram {
        /// <summary>The current process. Equivalent to <see cref="AudioSessionControl2.Process"/>.</summary>
        public readonly Process Process;

        /// <summary>The volume controller.</summary>
        public readonly SimpleAudioVolume VolumeControl;

        /// <summary>The session controller.</summary>
        public readonly AudioSessionControl2 SessionControl;

        /// <summary>Initialises a new instance of the <see cref="AudioProgram"/> struct, retrieving the <see cref="SimpleAudioVolume"/> and <see cref="AudioSessionControl2"/> interfaces from the given <paramref name="Session"/> utilising <see cref="CSCore.Win32.ComObject.QueryInterface{T}"/>.</summary>
        /// <param name="Session">The session.</param>
        public AudioProgram(AudioSessionControl Session) : this(Session.QueryInterface<SimpleAudioVolume>(), Session.QueryInterface<AudioSessionControl2>()) { }

        /// <summary>Initialises a new instance of the <see cref="AudioProgram"/> struct, retrieving the <see cref="System.Diagnostics.Process"/> from the <paramref name="SessionControl"/>.</summary>
        /// <param name="VolumeControl">The volume controller.</param>
        /// <param name="SessionControl">The session controller.</param>
        public AudioProgram(SimpleAudioVolume VolumeControl, AudioSessionControl2 SessionControl) : this(VolumeControl, SessionControl, SessionControl.Process) { }

        /// <summary>Initialises a new instance of the <see cref="AudioProgram"/> struct.</summary>
        /// <param name="VolumeControl">The volume controller.</param>
        /// <param name="SessionControl">The session controller.</param>
        /// <param name="Process">The process.</param>
        public AudioProgram(SimpleAudioVolume VolumeControl, AudioSessionControl2 SessionControl, Process Process) {
            this.VolumeControl = VolumeControl;
            this.SessionControl = SessionControl;
            this.Process = Process;
        }

        /// <summary>Gets or sets the volume of the <see cref="AudioProgram"/>.</summary>
        /// <value>The application volume (<see cref="float"/> ranging between <c>0.0f</c> and <c>1.0f</c>).</value>
        public float Volume {
            get => VolumeControl.MasterVolume;
            set => VolumeControl.MasterVolume = value;
        }

        /// <summary>Gets or sets a value indicating whether this instance is muted.</summary>
        /// <value><see langword="true"/> if this instance is muted; otherwise, <see langword="false"/>.</value>
        public bool IsMuted {
            get => VolumeControl.IsMuted;
            set => VolumeControl.IsMuted = value;
        }

        /// <inheritdoc/>
        public override string ToString() {
            StringBuilder SB = new StringBuilder();
            SB.Append('[');
            SB.Append(Process.Id.ToString("#00000"));
            SB.Append('/');
            SB.Append(Process.SessionId);
            SB.Append("] ");

            string MachineName = Process.MachineName;
            if (!string.IsNullOrEmpty(MachineName) && MachineName != ".") {
                SB.Append(Process.MachineName);
                SB.Append(':');
            }
            SB.Append(Process.ProcessName);

            string Title = Process.MainWindowTitle;
            if (!string.IsNullOrEmpty(Title)) {
                SB.Append(" (");
                SB.Append(Title);
                SB.Append(") ");
            } else {
                SB.Append(' ');
            }

            //SB.Append("; Session: ");
            //SB.Append(SessionControl);

            //SB.Append("; Volume: ");
            //SB.Append(VolumeControl);
            SB.Append('<');
            SB.Append(Volume.ToString("P0"));
            SB.Append("::");
            SB.Append(IsMuted ? "Muted>" : "Active>");

            return SB.ToString();
        }

        /// <summary>Gets the default <see cref="AudioSessionManager2"/> within the Multimedia Audio Endpoint following the given <paramref name="DataFlow"/> direction. Ensure sure this function is invoked from an MTA thread (not the main/UI thread).</summary>
        /// <param name="DataFlow">The direction of data flow.</param>
        /// <returns><see cref="AudioSessionManager2"/></returns>
        public static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow DataFlow = DataFlow.Render) {
            using (MMDeviceEnumerator Enumerator = new MMDeviceEnumerator()) {
                using (MMDevice Device = Enumerator.GetDefaultAudioEndpoint(DataFlow, Role.Multimedia)) {
                    //Debug.WriteLine("DefaultDevice: " + Device.FriendlyName);
                    AudioSessionManager2 SessionManager = AudioSessionManager2.FromMMDevice(Device);
                    return SessionManager;
                }
            }
        }

        /// <summary>Retrieves all active audio programs found within <see cref="GetDefaultAudioSessionManager2(DataFlow)"/>.</summary>
        /// <returns><see cref="IEnumerable{AudioProgram}"/></returns>
        public static IEnumerable<AudioProgram> GetAudioPrograms() {
            using (AudioSessionManager2 SessionManager = GetDefaultAudioSessionManager2(DataFlow.Render)) {
                using (AudioSessionEnumerator SessionEnumerator = SessionManager.GetSessionEnumerator()) {
                    foreach (AudioSessionControl Session in SessionEnumerator) {
                        yield return new AudioProgram(Session);
                        //using (SimpleAudioVolume SimpleVolume = Session.QueryInterface<SimpleAudioVolume>()) {
                        //    using (AudioSessionControl2 SessionControl = Session.QueryInterface<AudioSessionControl2>()) {
                        //        Process P = SessionControl.Process;
                        //        SimpleVolume.GetMasterVolumeNative(out float V);
                        //        SimpleVolume.GetMuteInternal(out NativeBool M);

                        //        Console.WriteLine($"{P.Id:#000000}] {Session.DisplayName} ({P.ProcessName} > {P.MainWindowTitle}); {V} ({M})");

                        //        if (P.Id == 016752) {
                        //            Console.WriteLine($"\t{SimpleVolume.SetMasterVolumeNative(0.35f, Guid.NewGuid())}");
                        //        }
                        //        //if (SessionControl.ProcessID == 2436) {
                        //        //    SimpleVolume.MasterVolume = 0.5f;
                        //        //}
                        //    }
                        //}
                    }
                }
            }
        }
    }
}