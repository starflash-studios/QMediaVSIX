// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlock2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1159752268, 2638, 20415, 174, 233, 51, 93, 90, 32, 95, 110)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TextBlock))]
  [WebHostHidden]
  internal interface ITextBlock2
  {
    SolidColorBrush SelectionHighlightColor { get; set; }

    int MaxLines { get; set; }

    TextLineBounds TextLineBounds { get; set; }

    OpticalMarginAlignment OpticalMarginAlignment { get; set; }

    bool IsColorFontEnabled { get; set; }

    TextReadingOrder TextReadingOrder { get; set; }
  }
}
