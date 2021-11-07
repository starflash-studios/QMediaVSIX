// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.IPdfDocumentStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1127877471, 49159, 18312, 144, 242, 8, 20, 61, 146, 37, 153)]
  [ExclusiveTo(typeof (PdfDocument))]
  internal interface IPdfDocumentStatics
  {
    [Overload("LoadFromFileAsync")]
    [RemoteAsync]
    IAsyncOperation<PdfDocument> LoadFromFileAsync(IStorageFile file);

    [Overload("LoadFromFileWithPasswordAsync")]
    [RemoteAsync]
    IAsyncOperation<PdfDocument> LoadFromFileAsync(
      IStorageFile file,
      string password);

    [Overload("LoadFromStreamAsync")]
    [RemoteAsync]
    IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream);

    [RemoteAsync]
    [Overload("LoadFromStreamWithPasswordAsync")]
    IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream,
      string password);
  }
}
