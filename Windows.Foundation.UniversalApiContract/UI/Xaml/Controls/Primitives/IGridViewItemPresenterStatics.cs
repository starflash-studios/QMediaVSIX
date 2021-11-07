// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IGridViewItemPresenterStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3914922180, 10110, 19058, 160, 30, 158, 22, 136, 152, 1, 120)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GridViewItemPresenter))]
  internal interface IGridViewItemPresenterStatics
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

    DependencyProperty GridViewItemPresenterHorizontalContentAlignmentProperty { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of GridViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty GridViewItemPresenterVerticalContentAlignmentProperty { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of GridViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty GridViewItemPresenterPaddingProperty { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty PointerOverBackgroundMarginProperty { get; }

    DependencyProperty ContentMarginProperty { get; }
  }
}
