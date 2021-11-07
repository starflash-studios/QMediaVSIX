// Decompiled with JetBrains decompiler
// Type: Windows.Data.Pdf.PdfPageRenderOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Data.Pdf
{
  /// <summary>Represents display settings for a single page of a Portable Document Format (PDF) document, such as the page's background color and its encoding type.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PdfPageRenderOptions : IPdfPageRenderOptions
  {
    /// <summary>Creates and initializes a new instance of display settings for a single page of a Portable Document Format (PDF) document.</summary>
    [MethodImpl]
    public extern PdfPageRenderOptions();

    /// <summary>Gets or sets a portion of the Portable Document Format (PDF) page to be displayed.</summary>
    /// <returns>The portion of the Portable Document Format (PDF) page to be displayed.</returns>
    public extern Rect SourceRect { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the final size of the rendering of the Portable Document Format (PDF) page in device-independent pixels (DIPs).</summary>
    /// <returns>The Portable Document Format (PDF) page's scaling factor relative to the page's destination display width boundary.</returns>
    public extern uint DestinationWidth { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the final size of the rendering of the Portable Document Format (PDF) page in device-independent pixels (DIPs).</summary>
    /// <returns>The Portable Document Format (PDF) page's scaling factor relative to the page's destination display height boundary.</returns>
    public extern uint DestinationHeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Portable Document Format (PDF) page's background color.</summary>
    /// <returns>The Portable Document Format (PDF) page's background color.</returns>
    public extern Color BackgroundColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the Portable Document Format (PDF) page uses the system's high contrast display setting.</summary>
    /// <returns>False to use high contrast; otherwise, true.</returns>
    public extern bool IsIgnoringHighContrast { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Portable Document Format (PDF) page's encoding type to be used while the page is being converted to a bitmap.</summary>
    /// <returns>A BmpEncoderId value representing the unique identifier of the built-in bitmap encoder.</returns>
    public extern Guid BitmapEncoderId { [MethodImpl] get; [MethodImpl] set; }
  }
}
