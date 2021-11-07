// Decompiled with JetBrains decompiler
// Type: Windows.UI.WebUI.IHtmlPrintDocumentSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Printing;

namespace Windows.UI.WebUI
{
  [Guid(3467003546, 3589, 18042, 171, 201, 54, 236, 29, 76, 220, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HtmlPrintDocumentSource))]
  internal interface IHtmlPrintDocumentSource : IPrintDocumentSource
  {
    PrintContent Content { get; set; }

    float LeftMargin { get; set; }

    float TopMargin { get; set; }

    float RightMargin { get; set; }

    float BottomMargin { get; set; }

    bool EnableHeaderFooter { get; set; }

    bool ShrinkToFit { get; set; }

    float PercentScale { get; set; }

    string PageRange { get; }

    bool TrySetPageRange(string strPageRange);
  }
}
