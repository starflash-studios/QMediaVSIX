// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingDevicePickerFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  /// <summary>Represents the filter used to determine which devices to show in a casting device picker UI. The filter parameters are OR-ed together to build the resulting filter. In other words, if SupportsAudio and SupportsVideo are both true, the picker will display Audio-only devices, video-only devices, and audio/video devices.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class CastingDevicePickerFilter : ICastingDevicePickerFilter
  {
    /// <summary>Gets and sets whether the devices in the device picker should support audio playback.</summary>
    /// <returns>If true, the picker will show audio-capable casting devices.</returns>
    public extern bool SupportsAudio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets whether the devices in the device picker should support video playback.</summary>
    /// <returns>If true, the picker will show video-capable casting devices.</returns>
    public extern bool SupportsVideo { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets whether the devices in the device picker should support rending still images.</summary>
    /// <returns>If true, the picker will show casting devices capable of rendering still images.</returns>
    public extern bool SupportsPictures { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the casting sources supported.</summary>
    /// <returns>The list of supported casting sources.</returns>
    public extern IVector<CastingSource> SupportedCastingSources { [MethodImpl] get; }
  }
}
