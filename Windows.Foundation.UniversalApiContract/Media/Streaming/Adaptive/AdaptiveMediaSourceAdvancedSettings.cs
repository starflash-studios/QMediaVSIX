// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceAdvancedSettings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  /// <summary>Provides advanced settings for an AdaptiveMediaSource.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [DualApiPartition(version = 167772160)]
  public sealed class AdaptiveMediaSourceAdvancedSettings : IAdaptiveMediaSourceAdvancedSettings
  {
    /// <summary>Gets or sets a value indicating whether media segments are known in advance to be fully independent such that each segment can be decoded and rendered without requiring any information from any other media segment.</summary>
    /// <returns>True if the media segments for the AdaptiveMediaSource are independent; otherwise, false.</returns>
    public extern bool AllSegmentsIndependent { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the minimum inbound bits per second required before the adaptive media source will switch up to one of the available encoded bitrates to download.</summary>
    /// <returns>The minimum inbound bits per second before switching to another available encoded bitrate.</returns>
    public extern IReference<double> DesiredBitrateHeadroomRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies how low the inbound bits per second may drop before the adaptive media source will switch down to a different encoding bitrate to download.</summary>
    /// <returns>A floating point value that is the ratio of actual inbound bitrate to the target bitrate.</returns>
    public extern IReference<double> BitrateDowngradeTriggerRatio { [MethodImpl] get; [MethodImpl] set; }
  }
}
