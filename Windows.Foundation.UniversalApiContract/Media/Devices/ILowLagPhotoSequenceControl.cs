// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.ILowLagPhotoSequenceControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;

namespace Windows.Media.Devices
{
  [Guid(1037013149, 27926, 16540, 186, 254, 185, 165, 148, 198, 253, 230)]
  [ExclusiveTo(typeof (LowLagPhotoSequenceControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILowLagPhotoSequenceControl
  {
    bool Supported { get; }

    uint MaxPastPhotos { get; }

    float MaxPhotosPerSecond { get; }

    uint PastPhotoLimit { get; set; }

    float PhotosPerSecondLimit { get; set; }

    MediaRatio GetHighestConcurrentFrameRate(IMediaEncodingProperties captureProperties);

    MediaRatio GetCurrentFrameRate();

    bool ThumbnailEnabled { get; set; }

    MediaThumbnailFormat ThumbnailFormat { get; set; }

    uint DesiredThumbnailSize { get; set; }

    uint HardwareAcceleratedThumbnailSupported { get; }
  }
}
