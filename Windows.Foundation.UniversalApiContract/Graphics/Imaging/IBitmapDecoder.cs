// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.IBitmapDecoder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ExclusiveTo(typeof (BitmapDecoder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2901353146, 7540, 19601, 157, 252, 150, 32, 116, 82, 51, 230)]
  internal interface IBitmapDecoder
  {
    BitmapPropertiesView BitmapContainerProperties { get; }

    BitmapCodecInformation DecoderInformation { get; }

    uint FrameCount { get; }

    [RemoteAsync]
    IAsyncOperation<ImageStream> GetPreviewAsync();

    [RemoteAsync]
    IAsyncOperation<BitmapFrame> GetFrameAsync(uint frameIndex);
  }
}
