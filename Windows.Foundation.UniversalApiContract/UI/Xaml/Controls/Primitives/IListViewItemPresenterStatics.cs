// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(1694803290, 5597, 17147, 170, 93, 45, 140, 226, 233, 194, 148)]
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListViewItemPresenterStatics
  {
    DependencyProperty SelectionCheckMarkVisualEnabledProperty { get; }

    DependencyProperty CheckHintBrushProperty { get; }

    DependencyProperty CheckSelectingBrushProperty { get; }

    DependencyProperty CheckBrushProperty { get; }

    DependencyProperty DragBackgroundProperty { get; }

    DependencyProperty DragForegroundProperty { get; }

    DependencyProperty FocusBorderBrushProperty { get; }

    DependencyProperty PlaceholderBackgroundProperty { get; }

    DependencyProperty PointerOverBackgroundProperty { get; }

    DependencyProperty SelectedBackgroundProperty { get; }

    DependencyProperty SelectedForegroundProperty { get; }

    DependencyProperty SelectedPointerOverBackgroundProperty { get; }

    DependencyProperty SelectedPointerOverBorderBrushProperty { get; }

    DependencyProperty SelectedBorderThicknessProperty { get; }

    DependencyProperty DisabledOpacityProperty { get; }

    DependencyProperty DragOpacityProperty { get; }

    DependencyProperty ReorderHintOffsetProperty { get; }

    DependencyProperty ListViewItemPresenterHorizontalContentAlignmentProperty { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty ListViewItemPresenterVerticalContentAlignmentProperty { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty ListViewItemPresenterPaddingProperty { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty PointerOverBackgroundMarginProperty { get; }

    DependencyProperty ContentMarginProperty { get; }
  }
}
