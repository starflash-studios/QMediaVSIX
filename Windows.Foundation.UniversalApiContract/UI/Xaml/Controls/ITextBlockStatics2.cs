// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ITextBlockStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (TextBlock))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2282752795, 65316, 19347, 160, 230, 240, 41, 201, 72, 113, 241)]
  internal interface ITextBlockStatics2
  {
    DependencyProperty SelectionHighlightColorProperty { get; }

    DependencyProperty MaxLinesProperty { get; }

    DependencyProperty TextLineBoundsProperty { get; }

    DependencyProperty OpticalMarginAlignmentProperty { get; }

    DependencyProperty IsColorFontEnabledProperty { get; }

    DependencyProperty TextReadingOrderProperty { get; }
  }
}
