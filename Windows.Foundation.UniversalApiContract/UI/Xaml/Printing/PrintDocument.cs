// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.PrintDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  /// <summary>Defines a reusable object that sends output to a printer.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IPrintDocumentFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPrintDocumentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public class PrintDocument : DependencyObject, IPrintDocument
  {
    /// <summary>Initializes a new instance of the PrintDocument class.</summary>
    [MethodImpl]
    public extern PrintDocument();

    /// <summary>Gets a document source reference for this PrintDocument.</summary>
    /// <returns>An object representing the document source. </returns>
    public extern IPrintDocumentSource DocumentSource { [MethodImpl] get; }

    /// <summary>Occurs when the PrintManager requests the collection of print pages to be shown in the preview window.</summary>
    public extern event PaginateEventHandler Paginate;

    /// <summary>Occurs when the PrintManager requests a particular print page to be shown in the preview window.</summary>
    public extern event GetPreviewPageEventHandler GetPreviewPage;

    /// <summary>Occurs when the PrintManager requests the final collection of pages to send to the printer.</summary>
    public extern event AddPagesEventHandler AddPages;

    /// <summary>Adds a XAML root visual element to the print list.</summary>
    /// <param name="pageVisual">The root visual element of the page to add to the print list.</param>
    [MethodImpl]
    public extern void AddPage(UIElement pageVisual);

    /// <summary>Indicates that the application will not add more pages to the print list, and that the print list is ready to be released.</summary>
    [MethodImpl]
    public extern void AddPagesComplete();

    /// <summary>Sets the number of pages prepared for print preview and added to the print list.</summary>
    /// <param name="count">The number of pages included in the preview.</param>
    /// <param name="type">A value of the enumeration that specifies how to determine the page count.</param>
    [MethodImpl]
    public extern void SetPreviewPageCount(int count, PreviewPageCountType type);

    /// <summary>Sets the specified print page as the current print preview page.</summary>
    /// <param name="pageNumber">The sequence number of the page to preview.</param>
    /// <param name="pageVisual">The root visual object for the requested print page.</param>
    [MethodImpl]
    public extern void SetPreviewPage(int pageNumber, UIElement pageVisual);

    /// <summary>References the low-level print preview dialog API and invalidates the current print preview.</summary>
    [MethodImpl]
    public extern void InvalidatePreview();

    /// <summary>Identifies the DocumentSource dependency property.</summary>
    /// <returns>The identifier for the DocumentSource dependency property.</returns>
    public static extern DependencyProperty DocumentSourceProperty { [MethodImpl] get; }
  }
}
