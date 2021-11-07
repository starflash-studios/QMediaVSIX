// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.VideoStabilizationEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  /// <summary>Represents an effect that stabilizes a video stream.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class VideoStabilizationEffect : IVideoStabilizationEffect, IMediaExtension
  {
    /// <summary>Gets or sets a value indicating whether video stabilization is enabled.</summary>
    /// <returns>True if video stabilization is enabled; otherwise, false.</returns>
    public extern bool Enabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs when the value of the VideoStabilizationEffect.Enabled property changes.</summary>
    public extern event TypedEventHandler<VideoStabilizationEffect, VideoStabilizationEffectEnabledChangedEventArgs> EnabledChanged;

    /// <summary>Gets the recommended video stream configuration for video stabilization, given the specified video device controller and encoding properties.</summary>
    /// <param name="controller">The video device controller.</param>
    /// <param name="desiredProperties">The encoding properties.</param>
    /// <returns>An object representing the optimal video stream configuration for video stabilization.</returns>
    [MethodImpl]
    public extern VideoStreamConfiguration GetRecommendedStreamConfiguration(
      VideoDeviceController controller,
      VideoEncodingProperties desiredProperties);

    /// <summary>Sets properties on the IMediaExtension.</summary>
    /// <param name="configuration">The property set.</param>
    [MethodImpl]
    public extern void SetProperties(IPropertySet configuration);
  }
}
