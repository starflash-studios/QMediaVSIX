// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRichTextBlock2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1059098643, 999, 17672, 150, 74, 145, 174, 218, 179, 209, 30)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RichTextBlock))]
  [WebHostHidden]
  internal interface IRichTextBlock2
  {
    int MaxLines { get; set; }

    TextLineBounds TextLineBounds { get; set; }

    SolidColorBrush SelectionHighlightColor { get; set; }

    OpticalMarginAlignment OpticalMarginAlignment { get; set; }

    bool IsColorFontEnabled { get; set; }

    TextReadingOrder TextReadingOrder { get; set; }
  }
}
