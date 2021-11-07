// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfPage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  [ExclusiveTo(typeof (PdfPage))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2645864648, 21280, 19708, 173, 118, 73, 63, 218, 208, 229, 148)]
  internal interface IPdfPage
  {
    [RemoteAsync]
    [Overload("RenderToStreamAsync")]
    IAsyncAction RenderToStreamAsync(IRandomAccessStream outputStream);

    [Overload("RenderWithOptionsToStreamAsync")]
    IAsyncAction RenderToStreamAsync(
      IRandomAccessStream outputStream,
      PdfPageRenderOptions options);

    [RemoteAsync]
    IAsyncAction PreparePageAsync();

    uint Index { get; }

    Size Size { get; }

    PdfPageDimensions Dimensions { get; }

    PdfPageRotation Rotation { get; }

    float PreferredZoom { get; }
  }
}
