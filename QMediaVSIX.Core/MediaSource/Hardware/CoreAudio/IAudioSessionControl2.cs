using System.Runtime.InteropServices;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <inheritdoc cref="VolumeMixer"/>
[Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IAudioSessionControl2 {
	// IAudioSessionControl
	[PreserveSig]
	int NotImpl0();

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
	int NotImpl1();

	[PreserveSig]
	int NotImpl2();

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