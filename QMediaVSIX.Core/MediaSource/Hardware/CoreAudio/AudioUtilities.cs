using System.Diagnostics;
using System.Runtime.InteropServices;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

// ReSharper disable once CommentTypo
/// <summary>
/// Courtesy of <see href="https://stackoverflow.com/a/20982715/11519246">Simon Mourier</see>.
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
public static class AudioUtilities {
    static IAudioSessionManager2? GetAudioSessionManager() {
        IMMDevice? Speakers = GetSpeakers();
        if ( Speakers == null ) {
            return null;
        }

        // win7+ only
        if ( Speakers.Activate(typeof(IAudioSessionManager2).GUID, Clsctx.CLSCTX_ALL, IntPtr.Zero, out object O) != 0 || O == null ) {
            return null;
        }

        return O as IAudioSessionManager2;
    }

    public static AudioDevice? GetSpeakersDevice() => CreateDevice(GetSpeakers());

    static AudioDevice? CreateDevice( IMMDevice? Dev ) {
        if ( Dev == null ) {
            return null;
        }

        Dev.GetId(out string ID);
        Dev.GetState(out Device_State State);
        Dictionary<string, object?> Properties = new Dictionary<string, object?>();
        Dev.OpenPropertyStore(Stgm.STGM_READ, out IPropertyStore Store);
        if ( Store != null ) {
            Store.GetCount(out int PropCount);
            for ( int J = 0; J < PropCount; J++ ) {
                if ( Store.GetAt(J, out Propertykey Pk) == 0 ) {
                    Propvariant Value = new Propvariant();
                    // ReSharper disable once UnusedVariable
                    int HR = Store.GetValue(ref Pk, ref Value);
                    object? V = Value.GetValue();
                    try {
                        if ( Value.vt != Vartype.VT_BLOB ) // for some reason, this fails?
                        {
                            Marshal.ThrowExceptionForHR(PropVariantClear(ref Value));
                        }
                    } catch {
                    }
                    string Name = Pk.ToString();
                    Properties[Name] = V;
                }
            }
        }
        return new AudioDevice(ID, (AudioDeviceState)State, Properties);
    }

    public static IList<AudioDevice> GetAllDevices() {
        List<AudioDevice> List = new List<AudioDevice>();
        IMMDeviceEnumerator? DeviceEnumerator = null;
        try {
            DeviceEnumerator = new MMDeviceEnumerator() as IMMDeviceEnumerator;
        } catch {
        }
        if ( DeviceEnumerator == null ) {
            return List;
        }

        DeviceEnumerator.EnumAudioEndpoints(EDataFlow.EAll, Device_State.MASK_ALL, out IMMDeviceCollection? Collection);
        if ( Collection is null ) {
            return List;
        }

        Collection.GetCount(out int Count);
        for ( int I = 0; I < Count; I++ ) {
            Collection.Item(I, out IMMDevice Dev);
            if ( Dev != null && CreateDevice(Dev) is { } AD ) {
                List.Add(AD);
            }
        }
        return List;
    }

    static IMMDevice? GetSpeakers() {
        // get the speakers (1st render + multimedia) device
        try {
            if ( new MMDeviceEnumerator() is IMMDeviceEnumerator DeviceEnumerator ) {
                DeviceEnumerator.GetDefaultAudioEndpoint(EDataFlow.ERender, ERole.EMultimedia, out IMMDevice Speakers);
                return Speakers;
            }
            throw new ArgumentNullException(nameof(DeviceEnumerator));
        } catch {
            return null;
        }
    }

    public static IList<AudioSession> GetAllSessions() {
        List<AudioSession> List = new List<AudioSession>();
        IAudioSessionManager2? Mgr = GetAudioSessionManager();
        if ( Mgr == null ) {
            return List;
        }

        Mgr.GetSessionEnumerator(out IAudioSessionEnumerator SessionEnumerator);
        SessionEnumerator.GetCount(out int Count);

        for ( int I = 0; I < Count; I++ ) {
            SessionEnumerator.GetSession(I, out IAudioSessionControl Ctl);

            if ( Ctl is IAudioSessionControl2 Ctl2 ) {
                List.Add(new AudioSession(Ctl2, null));
            }
        }
        Marshal.ReleaseComObject(SessionEnumerator);
        Marshal.ReleaseComObject(Mgr);
        return List;
    }

    public static AudioSession? GetProcessSession() {
        int ID = Environment.ProcessId;
        foreach ( AudioSession Session in GetAllSessions() ) {
            if ( Session.ProcessId == ID ) {
                return Session;
            }

            Session.Dispose();
        }
        return null;
    }

    [DllImport("ole32.dll")]
    static extern int PropVariantClear( ref Propvariant Pvar );

    [ComImport]
    [Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
    class MMDeviceEnumerator {
    }

    [Flags]
    enum Clsctx {
        CLSCTX_INPROC_SERVER = 0x1,
        CLSCTX_INPROC_HANDLER = 0x2,
        CLSCTX_LOCAL_SERVER = 0x4,
        CLSCTX_REMOTE_SERVER = 0x10,
        CLSCTX_ALL = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER | CLSCTX_LOCAL_SERVER | CLSCTX_REMOTE_SERVER
    }

    enum Stgm {
        STGM_READ = 0x00000000,
    }

    enum EDataFlow {
        ERender,
        ECapture,
        EAll,
    }

    enum ERole {
        EConsole,
        EMultimedia,
        ECommunications,
    }

    enum Device_State {
        ACTIVE = 0x00000001,
        DISABLED = 0x00000002,
        NOTPRESENT = 0x00000004,
        UNPLUGGED = 0x00000008,
        MASK_ALL = 0x0000000F
    }

    [StructLayout(LayoutKind.Sequential)]
    readonly struct Propertykey {
        readonly Guid fmtid;
        readonly int pid;

        public override string ToString() => fmtid.ToString("B") + " " + pid;
    }

    // NOTE: we only define what we handle
    [Flags]
    enum Vartype : short {
        VT_I4 = 3,
        VT_BOOL = 11,
        VT_UI4 = 19,
        VT_LPWSTR = 31,
        VT_BLOB = 65,
        VT_CLSID = 72,
    }

    [StructLayout(LayoutKind.Sequential)]
    readonly struct Propvariant {
        public readonly Vartype vt;
        readonly ushort wReserved1;
        readonly ushort wReserved2;
        readonly ushort wReserved3;
        readonly PropvarianTunion union;

        public object? GetValue() =>
            vt switch {
                Vartype.VT_BOOL   => union.boolVal != 0,
                Vartype.VT_LPWSTR => Marshal.PtrToStringUni(union.pwszVal),
                Vartype.VT_UI4    => union.lVal,
                Vartype.VT_CLSID  => Marshal.PtrToStructure(union.puuid, typeof(Guid)),
                _                 => vt + ":?"
            };
    }

    [StructLayout(LayoutKind.Explicit)]
    struct PropvarianTunion {
        [FieldOffset(0)] public readonly int lVal;
        [FieldOffset(0)] readonly ulong uhVal;
        [FieldOffset(0)] public readonly short boolVal;
        [FieldOffset(0)] public readonly IntPtr pwszVal;
        [FieldOffset(0)] public readonly IntPtr puuid;
    }

    [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IMMDeviceEnumerator {
        [PreserveSig]
        int EnumAudioEndpoints( EDataFlow DataFlow, Device_State DWStateMask, out IMMDeviceCollection? PPDevices );

        [PreserveSig]
        int GetDefaultAudioEndpoint( EDataFlow DataFlow, ERole Role, out IMMDevice PPEndpoint );

        [PreserveSig]
        int GetDevice( [MarshalAs(UnmanagedType.LPWStr)] string PwstrId, out IMMDevice PPDevice );

        [PreserveSig]
        int RegisterEndpointNotificationCallback( IMMNotificationClient PClient );

        [PreserveSig]
        int UnregisterEndpointNotificationCallback( IMMNotificationClient PClient );
    }

    [Guid("7991EEC9-7E89-4D85-8390-6C703CEC60C0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IMMNotificationClient {
        void OnDeviceStateChanged( [MarshalAs(UnmanagedType.LPWStr)] string PwstrDeviceId, Device_State DWNewState );
        void OnDeviceAdded( [MarshalAs(UnmanagedType.LPWStr)] string PwstrDeviceId );
        void OnDeviceRemoved( [MarshalAs(UnmanagedType.LPWStr)] string DeviceId );
        void OnDefaultDeviceChanged( EDataFlow Flow, ERole Role, string PwstrDefaultDeviceId );
        void OnPropertyValueChanged( [MarshalAs(UnmanagedType.LPWStr)] string PwstrDeviceId, Propertykey Key );
    }

    [Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IMMDeviceCollection {
        [PreserveSig]
        int GetCount( out int PCDevices );

        [PreserveSig]
        int Item( int NDevice, out IMMDevice PPDevice );
    }

    [Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IMMDevice {
        [PreserveSig]
        int Activate( [MarshalAs(UnmanagedType.LPStruct)] Guid Riid, Clsctx DWClsCtx, IntPtr PActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object PPInterface );

        [PreserveSig]
        int OpenPropertyStore( Stgm StgmAccess, out IPropertyStore PPProperties );

        [PreserveSig]
        int GetId( [MarshalAs(UnmanagedType.LPWStr)] out string PpstrId );

        [PreserveSig]
        int GetState( out Device_State PdwState );
    }

    [Guid("6f79d558-3e96-4549-a1d1-7d75d2288814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    // ReSharper disable once UnusedType.Local
    interface IPropertyDescription {
        [PreserveSig]
        int GetPropertyKey( out Propertykey Pkey );

        [PreserveSig]
        int GetCanonicalName( out IntPtr PpszName );

        [PreserveSig]
        int GetPropertyType( out short Pvartype );

        [PreserveSig]
        int GetDisplayName( out IntPtr PpszName );

        // WARNING: the rest is undefined. you *can't* implement it, only use it.
    }

    [Guid("886d8eeb-8cf2-4446-8d02-cdba1dbdcf99"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IPropertyStore {
        [PreserveSig]
        int GetCount( out int CProps );

        [PreserveSig]
        int GetAt( int IProp, out Propertykey Pkey );

        [PreserveSig]
        int GetValue( ref Propertykey Key, ref Propvariant PV );

        [PreserveSig]
        int SetValue( ref Propertykey Key, ref Propvariant Propvar );

        [PreserveSig]
        int Commit();
    }

    [Guid("BFA971F1-4D5E-40BB-935E-967039BFBEE4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    // ReSharper disable once UnusedType.Local
    interface IAudioSessionManager {
        [PreserveSig]
        int GetAudioSessionControl( [MarshalAs(UnmanagedType.LPStruct)] Guid AudioSessionGuid, int StreamFlags, out IAudioSessionControl SessionControl );

        [PreserveSig]
        int GetSimpleAudioVolume( [MarshalAs(UnmanagedType.LPStruct)] Guid AudioSessionGuid, int StreamFlags, ISimpleAudioVolume AudioVolume );
    }

    [Guid("77AA99A0-1BD6-484F-8BC7-2C654C9A9B6F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IAudioSessionManager2 {
        [PreserveSig]
        int GetAudioSessionControl( [MarshalAs(UnmanagedType.LPStruct)] Guid AudioSessionGuid, int StreamFlags, out IAudioSessionControl SessionControl );

        [PreserveSig]
        int GetSimpleAudioVolume( [MarshalAs(UnmanagedType.LPStruct)] Guid AudioSessionGuid, int StreamFlags, ISimpleAudioVolume AudioVolume );

        [PreserveSig]
        int GetSessionEnumerator( out IAudioSessionEnumerator SessionEnum );

        [PreserveSig]
        int RegisterSessionNotification( IAudioSessionNotification SessionNotification );

        [PreserveSig]
        int UnregisterSessionNotification( IAudioSessionNotification SessionNotification );

        int RegisterDuckNotificationNotImpl();
        int UnregisterDuckNotificationNotImpl();
    }

    [Guid("641DD20B-4D41-49CC-ABA3-174B9477BB08"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IAudioSessionNotification {
        void OnSessionCreated( IAudioSessionControl NewSession );
    }

    [Guid("E2F5BB11-0570-40CA-ACDD-3AA01277DEE8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IAudioSessionEnumerator {
        [PreserveSig]
        int GetCount( out int SessionCount );

        [PreserveSig]
        int GetSession( int SessionCount, out IAudioSessionControl Session );
    }

    [Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionControl2 {
        // IAudioSessionControl
        [PreserveSig]
        int GetState( out AudioSessionState PRetVal );

        [PreserveSig]
        int GetDisplayName( [MarshalAs(UnmanagedType.LPWStr)] out string PRetVal );

        [PreserveSig]
        int SetDisplayName( [MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int GetIconPath( [MarshalAs(UnmanagedType.LPWStr)] out string PRetVal );

        [PreserveSig]
        int SetIconPath( [MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int GetGroupingParam( out Guid PRetVal );

        [PreserveSig]
        int SetGroupingParam( [MarshalAs(UnmanagedType.LPStruct)] Guid Override, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int RegisterAudioSessionNotification( IAudioSessionEvents NewNotifications );

        [PreserveSig]
        int UnregisterAudioSessionNotification( IAudioSessionEvents NewNotifications );

        // IAudioSessionControl2
        [PreserveSig]
        int GetSessionIdentifier( [MarshalAs(UnmanagedType.LPWStr)] out string PRetVal );

        [PreserveSig]
        int GetSessionInstanceIdentifier( [MarshalAs(UnmanagedType.LPWStr)] out string PRetVal );

        [PreserveSig]
        int GetProcessId( out int PRetVal );

        [PreserveSig]
        int IsSystemSoundsSession();

        [PreserveSig]
        int SetDuckingPreference( bool OptOut );
    }

    [Guid("F4B1A599-7266-4319-A8CA-E70ACB11E8CD"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionControl {
        [PreserveSig]
        int GetState( out AudioSessionState PRetVal );

        [PreserveSig]
        int GetDisplayName( [MarshalAs(UnmanagedType.LPWStr)] out string PRetVal );

        [PreserveSig]
        int SetDisplayName( [MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int GetIconPath( [MarshalAs(UnmanagedType.LPWStr)] out string PRetVal );

        [PreserveSig]
        int SetIconPath( [MarshalAs(UnmanagedType.LPWStr)] string Value, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int GetGroupingParam( out Guid PRetVal );

        [PreserveSig]
        int SetGroupingParam( [MarshalAs(UnmanagedType.LPStruct)] Guid Override, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int RegisterAudioSessionNotification( IAudioSessionEvents NewNotifications );

        [PreserveSig]
        int UnregisterAudioSessionNotification( IAudioSessionEvents NewNotifications );
    }

    [Guid("24918ACC-64B3-37C1-8CA9-74A66E9957A8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IAudioSessionEvents {
        void OnDisplayNameChanged( [MarshalAs(UnmanagedType.LPWStr)] string NewDisplayName, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );
        void OnIconPathChanged( [MarshalAs(UnmanagedType.LPWStr)] string NewIconPath, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );
        void OnSimpleVolumeChanged( float NewVolume, bool NewMute, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );
        void OnChannelVolumeChanged( int ChannelCount, IntPtr NewChannelVolumeArray, int ChangedChannel, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );
        void OnGroupingParamChanged( [MarshalAs(UnmanagedType.LPStruct)] Guid NewGroupingParam, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );
        void OnStateChanged( AudioSessionState NewState );
        void OnSessionDisconnected( AudioSessionDisconnectReason DisconnectReason );
    }

    [Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface ISimpleAudioVolume {
        [PreserveSig]
        int SetMasterVolume( float FLevel, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int GetMasterVolume( out float PFLevel );

        [PreserveSig]
        int SetMute( bool BMute, [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext );

        [PreserveSig]
        int GetMute( out bool PBMute );
    }
}