using System.Runtime.InteropServices;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <inheritdoc cref="VolumeMixer"/>
[Guid("87CE5498-68D6-44E5-9215-6DA47EF883D8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ISimpleAudioVolume {
	[PreserveSig]
	int SetMasterVolume( float FLevel, ref Guid EventContext );

	[PreserveSig]
	int GetMasterVolume( out float PFLevel );

	[PreserveSig]
	int SetMute( bool BMute, ref Guid EventContext );

	[PreserveSig]
	int GetMute( out bool PBMute );
}