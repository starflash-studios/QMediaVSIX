// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.GridViewItemPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the visual elements of a GridViewItem. When developing for Windows 10, use ListViewItemPresenter instead of GridViewItemPresenter in your item container style, both for ListView and for GridView. If you edit a copy of the default item container styles then you will get the correct type.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGridViewItemPresenterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IGridViewItemPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class GridViewItemPresenter : ContentPresenter, IGridViewItemPresenter
  {
    /// <summary>Initializes a new instance of the GridViewItemPresenter class.</summary>
    [MethodImpl]
    public extern GridViewItemPresenter();

    /// <summary>Gets or sets a value that indicates whether the check mark is shown when the item is selected.</summary>
    /// <returns>**true** to show the selection check mark; otherwise, **false**. The default is **true**.</returns>
    public extern bool SelectionCheckMarkVisualEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the check mark hint.</summary>
    /// <returns>The brush used to render the check mark hint.</returns>
    public extern Brush CheckHintBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the check mark on an item while it's being selected using a swipe interaction.</summary>
    /// <returns>The brush used to render the check mark on an item while it's being selected using a swipe interaction.</returns>
    public extern Brush CheckSelectingBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the check mark on a selected item.</summary>
    /// <returns>The brush used to render the check mark on a selected item.</returns>
    public extern Brush CheckBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the background of an item that's being dragged.</summary>
    /// <returns>The brush used to render the background of an item that's being dragged.</returns>
    public extern Brush DragBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the foreground of an item that's being dragged.</summary>
    /// <returns>The brush used to render the foreground of an item that's being dragged.</returns>
    public extern Brush DragForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the border of an item that has focus.</summary>
    /// <returns>The brush used to render the border of an item that has focus.</returns>
    public extern Brush FocusBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the placeholder background for an item.</summary>
    /// <returns>The brush used to render the placeholder background for an item.</returns>
    public extern Brush PlaceholderBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the background of an item that has the pointer over it.</summary>
    /// <returns>The brush used to render the background of an item that has the pointer over it.</returns>
    public extern Brush PointerOverBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the background of an item that's selected.</summary>
    /// <returns>The brush used to render the background of an item that's selected.</returns>
    public extern Brush SelectedBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the foreground of an item that's selected.</summary>
    /// <returns>The brush used to render the foreground of an item that's selected.</returns>
    public extern Brush SelectedForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the background of an item that's selected and has the pointer over it.</summary>
    /// <returns>The brush used to render the background of an item that's selected and has the pointer over it.</returns>
    public extern Brush SelectedPointerOverBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the border of an item that's selected and has the pointer over it.</summary>
    /// <returns>The brush used to render the border of an item that's selected and has the pointer over it.</returns>
    public extern Brush SelectedPointerOverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the border around an item that's selected.</summary>
    /// <returns>The thickness of the border around an item that's selected, as a Thickness value.</returns>
    public extern Thickness SelectedBorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the opacity of an item that is disabled.</summary>
    /// <returns>The opacity of an item that is disabled. The value should be between 0 and 1. 0 is no opacity (transparent), 1 is full opacity (renders normally). The effective default value at run-time comes from themes.</returns>
    public extern double DisabledOpacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the opacity of an item that's being dragged.</summary>
    /// <returns>The opacity of an item that's being dragged. The value should be between 0 and 1. 0 is no opacity (transparent), 1 is full opacity (renders normally). The effective default value at run-time comes from themes.</returns>
    public extern double DragOpacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount that the reorder hint is offset.</summary>
    /// <returns>The amount that the reorder hint is offset, in pixels. The effective default value at run-time comes from themes.</returns>
    public extern double ReorderHintOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal alignment of the content being presented.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern HorizontalAlignment GridViewItemPresenterHorizontalContentAlignment { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of GridViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of GridViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment of the content being presented.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern VerticalAlignment GridViewItemPresenterVerticalContentAlignment { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of GridViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of GridViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the padding between the presenter and the GridView.</summary>
    /// <returns>A Thickness value.</returns>
    public extern Thickness GridViewItemPresenterPadding { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the margin of the background displayed for pointer-over input actions in the GridView item cell, versus the cell.</summary>
    /// <returns>A Thickness value.</returns>
    public extern Thickness PointerOverBackgroundMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an internal margin between presented content and its presenter.</summary>
    /// <returns>A Thickness value.</returns>
    public extern Thickness ContentMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the SelectionCheckMarkVisualEnabled dependency property.</summary>
    /// <returns>The identifier for the SelectionCheckMarkVisualEnabled dependency property.</returns>
    public static extern DependencyProperty SelectionCheckMarkVisualEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the CheckHintBrush dependency property.</summary>
    /// <returns>The identifier for the CheckHintBrush dependency property.</returns>
    public static extern DependencyProperty CheckHintBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the CheckSelectingBrush dependency property.</summary>
    /// <returns>The identifier for the CheckSelectingBrush dependency property.</returns>
    public static extern DependencyProperty CheckSelectingBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the CheckBrush dependency property.</summary>
    /// <returns>The identifier for the CheckBrush dependency property.</returns>
    public static extern DependencyProperty CheckBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the DragBackground dependency property.</summary>
    /// <returns>The identifier for the DragBackground dependency property.</returns>
    public static extern DependencyProperty DragBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the DragForeground dependency property.</summary>
    /// <returns>The identifier for the DragForeground dependency property.</returns>
    public static extern DependencyProperty DragForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusBorderBrush dependency property.</summary>
    /// <returns>The identifier for the FocusBorderBrush dependency property.</returns>
    public static extern DependencyProperty FocusBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderBackground dependency property.</summary>
    /// <returns>The identifier for the PlaceholderBackground dependency property.</returns>
    public static extern DependencyProperty PlaceholderBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the PointerOverBackground dependency property.</summary>
    /// <returns>The identifier for the PointerOverBackground dependency property.</returns>
    public static extern DependencyProperty PointerOverBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedBackground dependency property.</summary>
    /// <returns>The identifier for the SelectedBackground dependency property.</returns>
    public static extern DependencyProperty SelectedBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedForeground dependency property.</summary>
    /// <returns>The identifier for the SelectedForeground dependency property.</returns>
    public static extern DependencyProperty SelectedForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedPointerOverBackground dependency property.</summary>
    /// <returns>The identifier for the SelectedPointerOverBackground dependency property.</returns>
    public static extern DependencyProperty SelectedPointerOverBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedPointerOverBorderBrush dependency property.</summary>
    /// <returns>The identifier for the SelectedPointerOverBorderBrush dependency property.</returns>
    public static extern DependencyProperty SelectedPointerOverBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedBorderThickness dependency property.</summary>
    /// <returns>The identifier for the SelectedBorderThickness dependency property.</returns>
    public static extern DependencyProperty SelectedBorderThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisabledOpacity dependency property.</summary>
    /// <returns>The identifier for the DisabledOpacity dependency property.</returns>
    public static extern DependencyProperty DisabledOpacityProperty { [MethodImpl] get; }

    /// <summary>Identifies the DragOpacity dependency property.</summary>
    /// <returns>The identifier for the DragOpacity dependency property.</returns>
    public static extern DependencyProperty DragOpacityProperty { [MethodImpl] get; }

    /// <summary>Identifies the ReorderHintOffset dependency property.</summary>
    /// <returns>The identifier for the ReorderHintOffset dependency property.</returns>
    public static extern DependencyProperty ReorderHintOffsetProperty { [MethodImpl] get; }

    /// <summary>Identifies the GridViewItemPresenterHorizontalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the GridViewItemPresenterHorizontalContentAlignment dependency property.</returns>
    public static extern DependencyProperty GridViewItemPresenterHorizontalContentAlignmentProperty { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of GridViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the GridViewItemPresenterVerticalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the GridViewItemPresenterVerticalContentAlignment dependency property.</returns>
    public static extern DependencyProperty GridViewItemPresenterVerticalContentAlignmentProperty { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of GridViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the GridViewItemPresenterPadding dependency property.</summary>
    /// <returns>The identifier for the GridViewItemPresenterPadding dependency property.</returns>
    public static extern DependencyProperty GridViewItemPresenterPaddingProperty { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the PointerOverBackgroundMargin dependency property.</summary>
    /// <returns>The identifier for the PointerOverBackgroundMargin dependency property.</returns>
    public static extern DependencyProperty PointerOverBackgroundMarginProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentMargin dependency property.</summary>
    /// <returns>The identifier for the ContentMargin dependency property.</returns>
    public static extern DependencyProperty ContentMarginProperty { [MethodImpl] get; }
  }
}
