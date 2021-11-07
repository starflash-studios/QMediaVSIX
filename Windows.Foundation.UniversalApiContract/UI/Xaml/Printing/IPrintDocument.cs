// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Printing.IPrintDocument
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.Xaml.Printing
{
  [Guid(3829606339, 43417, 18523, 177, 216, 114, 220, 81, 120, 33, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PrintDocument))]
  [WebHostHidden]
  internal interface IPrintDocument
  {
    IPrintDocumentSource DocumentSource { get; }

    event PaginateEventHandler Paginate;

    event GetPreviewPageEventHandler GetPreviewPage;

    event AddPagesEventHandler AddPages;

    void AddPage(UIElement pageVisual);

    void AddPagesComplete();

    void SetPreviewPageCount(int count, PreviewPageCountType type);

    void SetPreviewPage(int pageNumber, UIElement pageVisual);

    void InvalidatePreview();
  }
}
