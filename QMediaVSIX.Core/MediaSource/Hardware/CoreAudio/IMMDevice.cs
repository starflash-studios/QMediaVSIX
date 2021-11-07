using System.Runtime.InteropServices;

namespace QMediaVSIX.Core.MediaSource.Hardware.CoreAudio;

/// <inheritdoc cref="VolumeMixer"/>
[Guid("D666063F-1587-4E43-81F1-B948E807363F"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface IMMDevice {
	[PreserveSig]
	int Activate( ref Guid Iid, int DWClsCtx, IntPtr PActivationParams, [MarshalAs(UnmanagedType.IUnknown)] out object PPInterface );

	// the rest is not implemented
}