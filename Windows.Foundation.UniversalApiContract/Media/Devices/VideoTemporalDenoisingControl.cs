// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.VideoTemporalDenoisingControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  /// <summary>When supported, allows an app to enable temporal denoising for video capture.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class VideoTemporalDenoisingControl : IVideoTemporalDenoisingControl
  {
    /// <summary>Gets a value that indicates if the capture device supports the VideoTemporalDenoisingControl.</summary>
    /// <returns>True if the VideoTemporalDenoisingControl is supported; otherwise, false.</returns>
    public extern bool Supported { [MethodImpl] get; }

    /// <summary>Gets the list of VideoTemporalDenoisingMode values indicating the modes supported by the capture device.</summary>
    /// <returns>The list of supported VideoTemporalDenoisingMode values.</returns>
    public extern IVectorView<VideoTemporalDenoisingMode> SupportedModes { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating the current video temporal denoising mode of the capture device.</summary>
    /// <returns>The current video temporal denoising mode of the capture device.</returns>
    public extern VideoTemporalDenoisingMode Mode { [MethodImpl] get; [MethodImpl] set; }
  }
}
