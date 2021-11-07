// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfPageDimensions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Pdf
{
  /// <summary>Represents the dimensions of a single page in a Portable Document Format (PDF) document.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PdfPageDimensions : IPdfPageDimensions
  {
    /// <summary>Gets the size of a rectangle that defines the boundaries of the area that the Portable Document Format (PDF) page will be displayed or printed to.</summary>
    /// <returns>The size of the Portable Document Format (PDF) page's display or print boundaries.</returns>
    public extern Rect MediaBox { [MethodImpl] get; }

    /// <summary>Gets the size of a rectangle that specifies the cropped region of a Portable Document Format (PDF) page's contents when it is displayed.</summary>
    /// <returns>The size of the Portable Document Format (PDF) page's cropped region.</returns>
    public extern Rect CropBox { [MethodImpl] get; }

    /// <summary>Gets the size of a rectangle that specifies the clipped region of a Portable Document Format (PDF) page's contents when it is displayed.</summary>
    /// <returns>The size of the Portable Document Format (PDF) page's clipped region.</returns>
    public extern Rect BleedBox { [MethodImpl] get; }

    /// <summary>Gets the size of a rectangle that specifies the intended dimensions of the Portable Document Format (PDF) page after it has been trimmed.</summary>
    /// <returns>The Portable Document Format (PDF) page's trimmed dimensions.</returns>
    public extern Rect TrimBox { [MethodImpl] get; }

    /// <summary>Gets the size of a rectangle that contains the Portable Document Format (PDF) page's contents, including any meaningful surrounding white space, as intended by the Portable Document Format (PDF) page's creator.</summary>
    /// <returns>The size of the Portable Document Format (PDF) page's contents and any meaningful surrounding white space.</returns>
    public extern Rect ArtBox { [MethodImpl] get; }
  }
}
