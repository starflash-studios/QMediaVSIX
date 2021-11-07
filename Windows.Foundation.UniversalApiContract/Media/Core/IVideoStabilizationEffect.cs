// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStabilizationEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.Devices;
using Windows.Media.MediaProperties;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (VideoStabilizationEffect))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(134784592, 38552, 20055, 135, 123, 189, 124, 178, 238, 15, 138)]
  internal interface IVideoStabilizationEffect : IMediaExtension
  {
    bool Enabled { set; get; }

    event TypedEventHandler<VideoStabilizationEffect, VideoStabilizationEffectEnabledChangedEventArgs> EnabledChanged;

    VideoStreamConfiguration GetRecommendedStreamConfiguration(
      VideoDeviceController controller,
      VideoEncodingProperties desiredProperties);
  }
}
