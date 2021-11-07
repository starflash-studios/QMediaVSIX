using System.Diagnostics;
using System.Runtime.InteropServices;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

// ReSharper disable once CommentTypo
/// <summary>
/// Courtesy of <see href="https://stackoverflow.com/a/25584074/11519246">Anders Carstensen</see>.
/// </summary>
/// <remarks>
/// This code is licensed under Creative Commons Attribution-ShareAlike 4.0 Internal (CC BY-SA 4.0).
/// <br/>You are free to:
/// <list type="bullet"><item>
/// <term>Share</term>
/// <description> copy and redistribute the material in any medium or format</description>
/// </item><item>
/// <term>Adapt</term>
/// <description> remix, transform, and build upon the material for any purpose, even commercially.</description>
/// </item></list>
/// This is a human-readable summary of (and not a substitute for) the <see href="https://creativecommons.org/licenses/by-sa/4.0/legalcode">license</see>.
/// <para/>For more information, please visit: <see href="https://creativecommons.org/licenses/by-sa/4.0/"/>
/// </remarks>
public class VolumeMixer {
    public static float? GetApplicationVolume( int Pid ) {
        ISimpleAudioVolume? Volume = GetVolumeObject(Pid);
        if ( Volume == null ) {
            return null;
        }

        Volume.GetMasterVolume(out float Level);
        Marshal.ReleaseComObject(Volume);
        return Level * 100;
    }

    public static bool? GetApplicationMute( int Pid ) {
        ISimpleAudioVolume? Volume = GetVolumeObject(Pid);
        if ( Volume == null ) {
            return null;
        }

        Volume.GetMute(out bool Mute);
        Marshal.ReleaseComObject(Volume);
        return Mute;
    }

    public static void SetApplicationVolume( int Pid, float Level ) {
        ISimpleAudioVolume? Volume = GetVolumeObject(Pid);
        if ( Volume == null ) {
            return;
        }

        Guid GUID = Guid.Empty;
        Volume.SetMasterVolume(Level / 100, ref GUID);
        Marshal.ReleaseComObject(Volume);
    }

    public static void SetApplicationMute( int Pid, bool Mute ) {
        ISimpleAudioVolume? Volume = GetVolumeObject(Pid);
        if ( Volume == null ) {
            return;
        }

        Guid GUID = Guid.Empty;
        Volume.SetMute(Mute, ref GUID);
        Marshal.ReleaseComObject(Volume);
    }

    private static ISimpleAudioVolume? GetVolumeObject( int Pid ) {
        // get the speakers (1st render + multimedia) device
        // ReSharper disable once SuspiciousTypeConversion.Global
        //IMMDeviceEnumerator DeviceEnumerator = (IMMDeviceEnumerator)new MMDeviceEnumerator();
        IMMDeviceEnumerator? DeviceEnumerator = MMDeviceEnumeratorFactory.CreateInstance();
        if ( DeviceEnumerator is null ) { throw new ArgumentNullException(nameof(DeviceEnumerator)); }
        DeviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.ERender, ERole.EMultimedia, out IMMDevice Speakers);

        // activate the session manager. we need the enumerator
        Guid Iid_IAudioSessionManager2 = typeof(IAudioSessionManager2).GUID;
        Speakers.Activate(ref Iid_IAudioSessionManager2, 0, IntPtr.Zero, out object O);
        IAudioSessionManager2 Mgr = (IAudioSessionManager2)O;

        // enumerate sessions for on this device
        Mgr.GetSessionEnumerator(out IAudioSessionEnumerator SessionEnumerator);
        SessionEnumerator.GetCount(out int Count);

        // search for an audio session with the required name
        // NOTE: we could also use the process id instead of the app name (with IAudioSessionControl2)
        ISimpleAudioVolume? VolumeControl = null;
        for ( int I = 0; I < Count; I++ ) {
            SessionEnumerator.GetSession(I, out IAudioSessionControl2 Ctl);
            Ctl.GetProcessId(out int Cpid);

            if ( Cpid == Pid ) {
                // ReSharper disable once SuspiciousTypeConversion.Global
                VolumeControl = Ctl as ISimpleAudioVolume;
                break;
            }
            Marshal.ReleaseComObject(Ctl);
        }
        Marshal.ReleaseComObject(SessionEnumerator);
        Marshal.ReleaseComObject(Mgr);
        Marshal.ReleaseComObject(Speakers);
        Marshal.ReleaseComObject(DeviceEnumerator);
        return VolumeControl;
    }
}