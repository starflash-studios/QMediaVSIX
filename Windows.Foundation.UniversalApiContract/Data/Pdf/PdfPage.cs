// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfPage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Data.Pdf
{
  /// <summary>Represents a single page in a Portable Document Format (PDF) document.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PdfPage : IPdfPage, IClosable
  {
    /// <summary>Outputs a stream of data, which represents a Portable Document Format (PDF) page's contents, as an asynchronous action. This asynchronous action can be used to create an image of the Portable Document Format (PDF) page.</summary>
    /// <param name="outputStream">The stream of data, which represents a Portable Document Format (PDF) page's content.</param>
    /// <returns>The asynchronous action.</returns>
    [Overload("RenderToStreamAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RenderToStreamAsync(IRandomAccessStream outputStream);

    /// <summary>Takes a set of display settings, applies them to the output of a Portable Document Format (PDF) page's contents, and creates a stream with the customized, rendered output as an asynchronous action. This asynchronous action can be used to create a customized display image of the Portable Document Format (PDF) page.</summary>
    /// <param name="outputStream">The stream of data, which represents a Portable Document Format (PDF) page's contents.</param>
    /// <param name="options">The requested set of display settings to apply to the display image that is output based on the Portable Document Format (PDF) page.</param>
    /// <returns>The asynchronous action.</returns>
    [Overload("RenderWithOptionsToStreamAsync")]
    [MethodImpl]
    public extern IAsyncAction RenderToStreamAsync(
      IRandomAccessStream outputStream,
      PdfPageRenderOptions options);

    /// <summary>Begins building the Portable Document Format (PDF) page. After this method finishes, the Portable Document Format (PDF) page is completely built.</summary>
    /// <returns>Represents the fully-built Portable Document Format (PDF) page.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction PreparePageAsync();

    /// <summary>Gets the relative position of the Portable Document Format (PDF) page within its parent Portable Document Format (PDF) document.</summary>
    /// <returns>The position of the Portable Document Format (PDF) page relative to its parent Portable Document Format (PDF) document.</returns>
    public extern uint Index { [MethodImpl] get; }

    /// <summary>Gets the Portable Document Format (PDF) page's size based on its related CropBox, MediaBox, and Rotation property values.</summary>
    /// <returns>The Portable Document Format (PDF) page's computed size.</returns>
    public extern Size Size { [MethodImpl] get; }

    /// <summary>Gets the group of dimension properties for a single page in a Portable Document Format (PDF) document.</summary>
    /// <returns>The group of page dimension properties.</returns>
    public extern PdfPageDimensions Dimensions { [MethodImpl] get; }

    /// <summary>Gets the number of degrees that the Portable Document Format (PDF) page will be rotated when it's displayed or printed.</summary>
    /// <returns>The number of degrees to rotate the Portable Document Format (PDF) page, expressed as one of the enumeration values.</returns>
    public extern PdfPageRotation Rotation { [MethodImpl] get; }

    /// <summary>Gets the Portable Document Format (PDF) page's preferred magnification factor.</summary>
    /// <returns>The magnification scaling factor to display or print the Portable Document Format (PDF) page.</returns>
    public extern float PreferredZoom { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();
  }
}
