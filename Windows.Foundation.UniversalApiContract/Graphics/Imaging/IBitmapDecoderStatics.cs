// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapDecoderStatics
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
  [Guid(1133300518, 48367, 20117, 186, 214, 35, 168, 34, 229, 141, 1)]
  [ExclusiveTo(typeof (BitmapDecoder))]
  internal interface IBitmapDecoderStatics
  {
    Guid BmpDecoderId { get; }

    Guid JpegDecoderId { get; }

    Guid PngDecoderId { get; }

    Guid TiffDecoderId { get; }

    Guid GifDecoderId { get; }

    Guid JpegXRDecoderId { get; }

    Guid IcoDecoderId { get; }

    IVectorView<BitmapCodecInformation> GetDecoderInformationEnumerator();

    [Overload("CreateAsync")]
    [RemoteAsync]
    IAsyncOperation<BitmapDecoder> CreateAsync(
      IRandomAccessStream stream);

    [Overload("CreateWithIdAsync")]
    [RemoteAsync]
    IAsyncOperation<BitmapDecoder> CreateAsync(
      Guid decoderId,
      IRandomAccessStream stream);
  }
}
