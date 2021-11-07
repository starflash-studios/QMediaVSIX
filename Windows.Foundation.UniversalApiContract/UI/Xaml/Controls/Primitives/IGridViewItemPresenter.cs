// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IGridViewItemPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (GridViewItemPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(558862352, 22242, 18465, 138, 28, 35, 5, 112, 154, 249, 75)]
  [WebHostHidden]
  internal interface IGridViewItemPresenter
  {
    bool SelectionCheckMarkVisualEnabled { get; set; }

    Brush CheckHintBrush { get; set; }

    Brush CheckSelectingBrush { get; set; }

    Brush CheckBrush { get; set; }

    Brush DragBackground { get; set; }

    Brush DragForeground { get; set; }

    Brush FocusBorderBrush { get; set; }

    Brush PlaceholderBackground { get; set; }

    Brush PointerOverBackground { get; set; }

    Brush SelectedBackground { get; set; }

    Brush SelectedForeground { get; set; }

    Brush SelectedPointerOverBackground { get; set; }

    Brush SelectedPointerOverBorderBrush { get; set; }

    Thickness SelectedBorderThickness { get; set; }

    double DisabledOpacity { get; set; }

    double DragOpacity { get; set; }

    double ReorderHintOffset { get; set; }

    HorizontalAlignment GridViewItemPresenterHorizontalContentAlignment { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of GridViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of GridViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    VerticalAlignment GridViewItemPresenterVerticalContentAlignment { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of GridViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of GridViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    Thickness GridViewItemPresenterPadding { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] set; }

    Thickness PointerOverBackgroundMargin { get; set; }

    Thickness ContentMargin { get; set; }
  }
}
