// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContentPresenterStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(4287357586, 44840, 18411, 165, 195, 220, 68, 206, 212, 15, 210)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ContentPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IContentPresenterStatics4
  {
    DependencyProperty TextWrappingProperty { get; }

    DependencyProperty MaxLinesProperty { get; }

    DependencyProperty LineStackingStrategyProperty { get; }

    DependencyProperty LineHeightProperty { get; }

    DependencyProperty BorderBrushProperty { get; }

    DependencyProperty BorderThicknessProperty { get; }

    DependencyProperty CornerRadiusProperty { get; }

    DependencyProperty PaddingProperty { get; }

    DependencyProperty BackgroundProperty { get; }

    DependencyProperty HorizontalContentAlignmentProperty { get; }

    DependencyProperty VerticalContentAlignmentProperty { get; }
  }
}
