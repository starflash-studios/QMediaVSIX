// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.KnownSimpleHapticsControllerWaveforms
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  /// <summary>Provides a set of well-known haptic waveform types (based on the Haptic Usage Page HID specification.</summary>
  [Static(typeof (IKnownSimpleHapticsControllerWaveformsStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IKnownSimpleHapticsControllerWaveformsStatics2), 917504, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  public static class KnownSimpleHapticsControllerWaveforms
  {
    public static extern ushort BrushContinuous { [MethodImpl] get; }

    public static extern ushort ChiselMarkerContinuous { [MethodImpl] get; }

    public static extern ushort EraserContinuous { [MethodImpl] get; }

    public static extern ushort Error { [MethodImpl] get; }

    public static extern ushort GalaxyPenContinuous { [MethodImpl] get; }

    public static extern ushort Hover { [MethodImpl] get; }

    public static extern ushort InkContinuous { [MethodImpl] get; }

    public static extern ushort MarkerContinuous { [MethodImpl] get; }

    public static extern ushort PencilContinuous { [MethodImpl] get; }

    public static extern ushort Success { [MethodImpl] get; }

    /// <summary>Gets a click waveform.</summary>
    /// <returns>An unsigned 16-bit waveform ID (0x1003/4099), based on the Haptic Usage Page HID specification.</returns>
    public static extern ushort Click { [MethodImpl] get; }

    /// <summary>Gets a buzz waveform that is generated continuously without interruption until terminated.</summary>
    /// <returns>An unsigned 16-bit waveform ID (0x1004/4100), based on the Haptic Usage Page HID specification.</returns>
    public static extern ushort BuzzContinuous { [MethodImpl] get; }

    /// <summary>Gets a rumble waveform that is generated continuously without interruption until terminated.</summary>
    /// <returns>An unsigned 16-bit waveform ID (0x1005/4101), based on the Haptic Usage Page HID specification.</returns>
    public static extern ushort RumbleContinuous { [MethodImpl] get; }

    /// <summary>Gets a press waveform.</summary>
    /// <returns>An unsigned 16-bit waveform ID (0x1006/4102), based on the Haptic Usage Page HID specification.</returns>
    public static extern ushort Press { [MethodImpl] get; }

    /// <summary>Gets a release waveform.</summary>
    /// <returns>An unsigned 16-bit waveform ID (0x1007/4103), based on the Haptic Usage Page HID specification.</returns>
    public static extern ushort Release { [MethodImpl] get; }
  }
}
