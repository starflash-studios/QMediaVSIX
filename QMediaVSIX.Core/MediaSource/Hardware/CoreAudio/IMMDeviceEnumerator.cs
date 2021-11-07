using System.Runtime.InteropServices;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <inheritdoc cref="VolumeMixer"/>
[ComImport,
 Guid("A95664D2-9614-4F35-A746-DE8DB63617E6"),
 InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IMMDeviceEnumerator {
	int NotImpl1();

	[PreserveSig]
	int GetDefaultAudioEndpoint( EDataFlow DataFlow, ERole Role, out IMMDevice PPDevice );

	// the rest is not implemented
}