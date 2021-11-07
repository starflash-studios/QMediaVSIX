// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapEncoderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2806208167, 42212, 20153, 142, 64, 86, 77, 231, 225, 204, 178)]
  [ExclusiveTo(typeof (BitmapEncoder))]
  internal interface IBitmapEncoderStatics
  {
    Guid BmpEncoderId { get; }

    Guid JpegEncoderId { get; }

    Guid PngEncoderId { get; }

    Guid TiffEncoderId { get; }

    Guid GifEncoderId { get; }

    Guid JpegXREncoderId { get; }

    IVectorView<BitmapCodecInformation> GetEncoderInformationEnumerator();

    [RemoteAsync]
    [Overload("CreateAsync")]
    IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream);

    [RemoteAsync]
    [Overload("CreateWithEncodingOptionsAsync")]
    IAsyncOperation<BitmapEncoder> CreateAsync(
      Guid encoderId,
      IRandomAccessStream stream,
      IIterable<IKeyValuePair<string, BitmapTypedValue>> encodingOptions);

    [RemoteAsync]
    IAsyncOperation<BitmapEncoder> CreateForTranscodingAsync(
      IRandomAccessStream stream,
      BitmapDecoder bitmapDecoder);

    [RemoteAsync]
    IAsyncOperation<BitmapEncoder> CreateForInPlacePropertyEncodingAsync(
      BitmapDecoder bitmapDecoder);
  }
}
