// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.HtmlPrintDocumentSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.WebUI
{
  /// <summary>Manages the document source for app printing.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HtmlPrintDocumentSource : 
    IHtmlPrintDocumentSource,
    IPrintDocumentSource,
    IClosable
  {
    /// <summary>Gets and sets the content of the document source to print.</summary>
    /// <returns>The content of the document source to print.</returns>
    public extern PrintContent Content { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the left margin of the document source.</summary>
    /// <returns>The left margin of the document source.</returns>
    public extern float LeftMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the top margin of the document source.</summary>
    /// <returns>The top margin of the document source.</returns>
    public extern float TopMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the right margin of the document source.</summary>
    /// <returns>The right margin of the document source.</returns>
    public extern float RightMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the bottom margin of the document source.</summary>
    /// <returns>The bottom margin of the document source.</returns>
    public extern float BottomMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets a value that controls whether header and footer are enabled in the document source.</summary>
    /// <returns>A Boolean value that indicates whether header and footer are enabled in the document source. **TRUE** indicates enabled and **FALSE** indicates disabled.</returns>
    public extern bool EnableHeaderFooter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets a value that controls whether content shrinks to fit the document source.</summary>
    /// <returns>A Boolean value that indicates whether content shrinks to fit the document source. **TRUE** indicates content shrinks to fit and **FALSE** otherwise. This property is ignored if the PercentScale property is set.</returns>
    public extern bool ShrinkToFit { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets and sets the size of the document source by percentage.</summary>
    /// <returns>The size of the document source by percentage.</returns>
    public extern float PercentScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the range of pages that prints.</summary>
    /// <returns>The range of pages that prints.</returns>
    public extern string PageRange { [MethodImpl] get; }

    /// <summary>Tries to set the page range of the document source.</summary>
    /// <param name="strPageRange">The page range to set.</param>
    /// <returns>A Boolean value that indicates whether trySetPageRange set the page range in *strPageRange*. **TRUE** indicates the page range was set and **FALSE** otherwise.</returns>
    [MethodImpl]
    public extern bool TrySetPageRange(string strPageRange);

    [MethodImpl]
    public extern void Close();
  }
}
