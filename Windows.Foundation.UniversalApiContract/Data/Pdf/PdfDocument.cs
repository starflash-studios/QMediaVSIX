// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  /// <summary>Represents a Portable Document Format (PDF) document.</summary>
  [Static(typeof (IPdfDocumentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PdfDocument : IPdfDocument
  {
    /// <summary>Gets a page from a Portable Document Format (PDF) document.</summary>
    /// <param name="pageIndex">The location of the Portable Document Format (PDF) page relative to its parent document.</param>
    /// <returns>The Portable Document Format (PDF) page.</returns>
    [MethodImpl]
    public extern PdfPage GetPage(uint pageIndex);

    /// <summary>Gets the number of pages in the Portable Document Format (PDF) document.</summary>
    /// <returns>The number of pages in the Portable Document Format (PDF) document.</returns>
    public extern uint PageCount { [MethodImpl] get; }

    /// <summary>Gets whether the Portable Document Format (PDF) document is password-protected.</summary>
    /// <returns>True if the Portable Document Format (PDF) document is password-protected; otherwise, false.</returns>
    public extern bool IsPasswordProtected { [MethodImpl] get; }

    /// <summary>Outputs an asynchronous operation. When the operation completes, a PdfDocument object is returned, which represents a Portable Document Format (PDF) document.</summary>
    /// <param name="file">The file, which represents a Portable Document Format (PDF) document.</param>
    /// <returns>The asynchronous operation.</returns>
    [Overload("LoadFromFileAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromFileAsync(
      IStorageFile file);

    /// <summary>Outputs an asynchronous operation. When the operation completes, a PdfDocument object is returned, which represents a Portable Document Format (PDF) document. Use this method if the Portable Document Format (PDF) document is password-protected.</summary>
    /// <param name="file">The file, which represents a Portable Document Format (PDF) document.</param>
    /// <param name="password">The password to open the Portable Document Format (PDF) document, if it requires one.</param>
    /// <returns>The asynchronous operation.</returns>
    [Overload("LoadFromFileWithPasswordAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromFileAsync(
      IStorageFile file,
      string password);

    /// <summary>Creates a PdfDocument object, representing a Portable Document Format (PDF) document, from a stream of data that represents a Portable Document Format (PDF) document in the file system.</summary>
    /// <param name="inputStream">The stream of data, which represents a Portable Document Format (PDF) document.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("LoadFromStreamAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream);

    /// <summary>Creates a PdfDocument object, representing a Portable Document Format (PDF) document, from a stream of data that represents a Portable Document Format (PDF) document in the file system. Use this method if the Portable Document Format (PDF) document is password-protected.</summary>
    /// <param name="inputStream">The stream of data, which represents a Portable Document Format (PDF) document.</param>
    /// <param name="password">The password to open the Portable Document Format (PDF) document, if it requires one.</param>
    /// <returns>The asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("LoadFromStreamWithPasswordAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PdfDocument> LoadFromStreamAsync(
      IRandomAccessStream inputStream,
      string password);
  }
}
