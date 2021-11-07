// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ILowLagPhotoControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [Guid(1834765776, 64223, 16733, 174, 230, 59, 170, 82, 147, 0, 201)]
  [ExclusiveTo(typeof (LowLagPhotoControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILowLagPhotoControl
  {
    MediaRatio GetHighestConcurrentFrameRate(IMediaEncodingProperties captureProperties);

    MediaRatio GetCurrentFrameRate();

    bool ThumbnailEnabled { get; set; }

    MediaThumbnailFormat ThumbnailFormat { get; set; }

    uint DesiredThumbnailSize { get; set; }

    uint HardwareAcceleratedThumbnailSupported { get; }
  }
}
