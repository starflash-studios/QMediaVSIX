// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ListViewItemPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents the visual elements of a ListViewItem. When developing for Windows 10, use ListViewItemPresenter instead of GridViewItemPresenter in your item container style, both for ListView and for GridView. If you edit a copy of the default item container styles then you will get the correct type.</summary>
  [Static(typeof (IListViewItemPresenterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IListViewItemPresenterStatics3), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IListViewItemPresenterStatics4), 851968, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IListViewItemPresenterFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IListViewItemPresenterStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  public class ListViewItemPresenter : 
    ContentPresenter,
    IListViewItemPresenter,
    IListViewItemPresenter2,
    IListViewItemPresenter3,
    IListViewItemPresenter4
  {
    /// <summary>Initializes a new instance of the ListViewItemPresenter class.</summary>
    [MethodImpl]
    public extern ListViewItemPresenter();

    /// <summary>Gets or sets a value that indicates whether the check mark is shown when the item is selected.</summary>
    /// <returns>**true** to show the selection check mark; otherwise, **false**. The default is **true**.</returns>
    public extern bool SelectionCheckMarkVisualEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the check mark hint. This property is ignored for a Windows 10 app.</summary>
    /// <returns>The brush used to render the check mark hint.</returns>
    public extern Brush CheckHintBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the check mark on an item while it's being selected using a swipe interaction. This property is ignored for a Windows 10 app.</summary>
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

    /// <summary>Gets or sets the brush used to render the border of an item that has focus. Also see FocusSecondaryBorderBrush.</summary>
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

    /// <summary>Gets or sets the brush used to render the border of an item that's selected and has the pointer over it. This property is ignored for a Windows 10 app.</summary>
    /// <returns>The brush used to render the border of an item that's selected and has the pointer over it.</returns>
    public extern Brush SelectedPointerOverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the border around an item that's selected. This property is ignored for a Windows 10 app.</summary>
    /// <returns>The thickness of the border around an item that's selected, as a Thickness value.</returns>
    public extern Thickness SelectedBorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the opacity of an item that is disabled.</summary>
    /// <returns>The opacity of an item that is disabled. The value should be between 0 and 1. 0 is no opacity (transparent), 1 is full opacity (renders normally). The effective default value at run-time comes from themes.</returns>
    public extern double DisabledOpacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the opacity of an item that's being dragged.</summary>
    /// <returns>The opacity of an item that's being dragged. The value should be between 0 and 1. 0 is no opacity (transparent), 1 is full opacity (renders normally). The effective default value at run-time comes from themes.</returns>
    public extern double DragOpacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount that the reorder hint is offset. This property is ignored for a Windows 10 app.</summary>
    /// <returns>The amount that the reorder hint is offset, in pixels. The effective default value at run-time comes from themes.</returns>
    public extern double ReorderHintOffset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal alignment of the content being presented.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern HorizontalAlignment ListViewItemPresenterHorizontalContentAlignment { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment of the content being presented.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern VerticalAlignment ListViewItemPresenterVerticalContentAlignment { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the padding around the presenter.</summary>
    /// <returns>A Thickness value.</returns>
    public extern Thickness ListViewItemPresenterPadding { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets or sets the margin of the background displayed for pointer-over input actions in the ListView item cell, versus the cell. This property is ignored for a Windows 10 app.</summary>
    /// <returns>A Thickness value.</returns>
    public extern Thickness PointerOverBackgroundMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an internal margin between presented content and its presenter.</summary>
    /// <returns>A Thickness value.</returns>
    public extern Thickness ContentMargin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>In a ListView, gets or sets the brush used to render the background of a selected item while the user is pressing it. In a GridView, the item's border is set rather than the background.</summary>
    /// <returns>The brush used to render a selected item's background (ListView ) or border (GridView ) while pressed.</returns>
    public extern Brush SelectedPressedBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>In a ListView, gets or sets the brush used to render the background of an unselected item while the user is pressing it. In a GridView, the item's border is set rather than the background.</summary>
    /// <returns>The brush used to render an unselected item's background (ListView ) or border (GridView ) while pressed.</returns>
    public extern Brush PressedBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>In a ListView in multiple selection mode, gets or sets the brush used to render an item's check box border. In a GridView, the check box background is set rather than the border, and only for unselected items.</summary>
    /// <returns>The brush used to render the check box border (ListView ) or background (GridView ).</returns>
    public extern Brush CheckBoxBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the second color of the border around an item that has focus. Focus is rendered as a composition of two brushes. This property is used together the FocusBorderBrush to specify these two brushes.</summary>
    /// <returns>The brush used to render the second color of the border around an item that has focus.</returns>
    public extern Brush FocusSecondaryBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style of checkbox shown for selecting an item.</summary>
    /// <returns>A value of the enumeration that specifies the style of checkbox to show. The default is **Inline**.</returns>
    public extern ListViewItemPresenterCheckMode CheckMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the foreground when the pointer is over the item.</summary>
    /// <returns>The brush used to render the foreground when the pointer is over the item.</returns>
    public extern Brush PointerOverForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the background of the reveal effect.</summary>
    /// <returns>The brush used to render the background of the reveal effect.</returns>
    public extern Brush RevealBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush used to render the border of the reveal effect.</summary>
    /// <returns>The brush used to render the border of the reveal effect.</returns>
    public extern Brush RevealBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of the border of the reveal effect.</summary>
    /// <returns>The thickness of the border of the reveal effect.</returns>
    public extern Thickness RevealBorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the reveal backgound is shown on top of the content.</summary>
    /// <returns>**true** if the reveal backgound is shown on top of the content; otherwise, **false**.</returns>
    public extern bool RevealBackgroundShowsAboveContent { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedDisabledBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckPressedBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckDisabledBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxPointerOverBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxPressedBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxDisabledBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxSelectedBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxSelectedPointerOverBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxSelectedPressedBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxSelectedDisabledBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxPointerOverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxPressedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CheckBoxDisabledBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius CheckBoxCornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius SelectionIndicatorCornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public extern bool SelectionIndicatorVisualEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern ListViewItemPresenterSelectionIndicatorMode SelectionIndicatorMode { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectionIndicatorBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectionIndicatorPointerOverBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectionIndicatorPressedBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectionIndicatorDisabledBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedPressedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedDisabledBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedInnerBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush PointerOverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SelectedDisabledBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckPressedBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckDisabledBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxPointerOverBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxPressedBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxDisabledBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxSelectedBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxSelectedPointerOverBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxSelectedPressedBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxSelectedDisabledBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxPointerOverBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxPressedBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxDisabledBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty CheckBoxCornerRadiusProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionIndicatorCornerRadiusProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionIndicatorVisualEnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionIndicatorModeProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionIndicatorBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionIndicatorPointerOverBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionIndicatorPressedBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectionIndicatorDisabledBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedPressedBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedDisabledBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedInnerBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty PointerOverBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the RevealBackground dependency property.</summary>
    /// <returns>The identifier for the RevealBackground dependency property.</returns>
    public static extern DependencyProperty RevealBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the RevealBorderBrush dependency property.</summary>
    /// <returns>The identifier for the RevealBorderBrush dependency property.</returns>
    public static extern DependencyProperty RevealBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the RevealBorderThickness dependency property.</summary>
    /// <returns>The identifier for the RevealBorderThickness dependency property.</returns>
    public static extern DependencyProperty RevealBorderThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the RevealBackgroundShowsAboveContent dependency property.</summary>
    /// <returns>The identifier for the RevealBackgroundShowsAboveContent dependency property.</returns>
    public static extern DependencyProperty RevealBackgroundShowsAboveContentProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedPressedBackground dependency property.</summary>
    /// <returns>The identifier for the SelectedPressedBackground dependency property.</returns>
    public static extern DependencyProperty SelectedPressedBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the PressedBackground dependency property.</summary>
    /// <returns>The identifier for the PressedBackground dependency property.</returns>
    public static extern DependencyProperty PressedBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the CheckBoxBrush dependency property.</summary>
    /// <returns>The identifier for the CheckBoxBrush dependency property.</returns>
    public static extern DependencyProperty CheckBoxBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusSecondaryBorderBrush dependency property.</summary>
    /// <returns>The identifier for the FocusSecondaryBorderBrush dependency property.</returns>
    public static extern DependencyProperty FocusSecondaryBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the CheckMode dependency property.</summary>
    /// <returns>The identifier for the CheckMode dependency property.</returns>
    public static extern DependencyProperty CheckModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the PointerOverForeground dependency property.</summary>
    /// <returns>The identifier for the PointerOverForeground dependency property.</returns>
    public static extern DependencyProperty PointerOverForegroundProperty { [MethodImpl] get; }

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

    /// <summary>Identifies the ListViewItemPresenterHorizontalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the ListViewItemPresenterHorizontalContentAlignment dependency property.</returns>
    public static extern DependencyProperty ListViewItemPresenterHorizontalContentAlignmentProperty { [Deprecated("Use ContentPresenter.HorizontalContentAlignment instead of ListViewItemPresenterHorizontalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the ListViewItemPresenterVerticalContentAlignment dependency property.</summary>
    /// <returns>The identifier for the ListViewItemPresenterVerticalContentAlignment dependency property.</returns>
    public static extern DependencyProperty ListViewItemPresenterVerticalContentAlignmentProperty { [Deprecated("Use ContentPresenter.VerticalContentAlignment instead of ListViewItemPresenterVerticalContentAlignment. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the ListViewItemPresenterPadding dependency property.</summary>
    /// <returns>The identifier for the ListViewItemPresenterPadding dependency property.</returns>
    public static extern DependencyProperty ListViewItemPresenterPaddingProperty { [Deprecated("Use ContentPresenter.Padding instead of GridViewItemPresenterPadding. For more info, see MSDN.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Identifies the PointerOverBackgroundMargin dependency property.</summary>
    /// <returns>The identifier for the PointerOverBackgroundMargin dependency property.</returns>
    public static extern DependencyProperty PointerOverBackgroundMarginProperty { [MethodImpl] get; }

    /// <summary>Identifies the ContentMargin dependency property.</summary>
    /// <returns>The identifier for the ContentMargin dependency property.</returns>
    public static extern DependencyProperty ContentMarginProperty { [MethodImpl] get; }
  }
}
