// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapEncoder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(734292195, 57848, 19284, 149, 232, 50, 145, 149, 81, 206, 98)]
  [ExclusiveTo(typeof (BitmapEncoder))]
  internal interface IBitmapEncoder
  {
    BitmapCodecInformation EncoderInformation { get; }

    BitmapProperties BitmapProperties { get; }

    BitmapProperties BitmapContainerProperties { get; }

    bool IsThumbnailGenerated { get; set; }

    uint GeneratedThumbnailWidth { get; set; }

    uint GeneratedThumbnailHeight { get; set; }

    BitmapTransform BitmapTransform { get; }

    void SetPixelData(
      BitmapPixelFormat pixelFormat,
      BitmapAlphaMode alphaMode,
      uint width,
      uint height,
      double dpiX,
      double dpiY,
      [Range(0, 2147483647)] byte[] pixels);

    [RemoteAsync]
    [Overload("GoToNextFrameAsync")]
    IAsyncAction GoToNextFrameAsync();

    [Overload("GoToNextFrameWithEncodingOptionsAsync")]
    [RemoteAsync]
    IAsyncAction GoToNextFrameAsync(
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    [RemoteAsync]
    IAsyncAction FlushAsync();
  }
}
