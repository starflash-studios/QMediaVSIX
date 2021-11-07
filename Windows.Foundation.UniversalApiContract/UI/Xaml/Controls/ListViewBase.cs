// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListViewBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Provides the infrastructure for the ListView and GridView classes.</summary>
  [WebHostHidden]
  [Static(typeof (IListViewBaseStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IListViewBaseStatics5), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IListViewBaseStatics4), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IListViewBaseStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IListViewBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IListViewBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ListViewBase : 
    Selector,
    IListViewBase,
    IListViewBase2,
    IListViewBase3,
    IListViewBase4,
    IListViewBase5,
    IListViewBase6,
    ISemanticZoomInformation
  {
    /// <summary>Provides base-class initialization behavior for classes that are derived from the ListViewBase class.</summary>
    [MethodImpl]
    protected extern ListViewBase();

    /// <summary>Gets the currently selected items.</summary>
    /// <returns>A collection of the currently selected items. The default is an empty collection.</returns>
    public extern IVector<object> SelectedItems { [MethodImpl] get; }

    /// <summary>Gets or sets the selection behavior for a ListViewBase instance.</summary>
    /// <returns>One of the ListViewSelectionMode enumeration values. The default is **Single** selection.</returns>
    public extern ListViewSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the view supports discrete input processing for a *swipe* interaction.</summary>
    /// <returns>**true** if discrete input processing for *swipe* interactions is enabled; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsSwipeEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether items in the view can be dragged as data payload.</summary>
    /// <returns>**True** if items in the view can be dragged as data payload; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanDragItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether items in the view can be reordered through user interaction.</summary>
    /// <returns>**True** if items in the view can be reordered through user interaction; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanReorderItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether items in the view fire an ItemClick event in response to interaction.</summary>
    /// <returns>**true** if interaction fires an ItemClick event; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsItemClickEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the amount of data to fetch for virtualizing/prefetch operations.</summary>
    /// <returns>The amount of data to fetch per interval, in pages. </returns>
    public extern double DataFetchSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the threshold range that governs when the ListViewBase class will begin to prefetch more items.</summary>
    /// <returns>The loading threshold, in terms of pages.</returns>
    public extern double IncrementalLoadingThreshold { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the conditions for prefetch operations by the ListViewBase class.</summary>
    /// <returns>An enumeration value that indicates the conditions that trigger prefetch operations. The default is **Edge**.</returns>
    public extern IncrementalLoadingTrigger IncrementalLoadingTrigger { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when an item in the list view receives an interaction, and the IsItemClickEnabled property is **true**.</summary>
    public extern event ItemClickEventHandler ItemClick;

    /// <summary>Occurs when a drag operation that involves one of the items in the view is initiated.</summary>
    public extern event DragItemsStartingEventHandler DragItemsStarting;

    /// <summary>Scrolls the list to bring the specified data item into view.</summary>
    /// <param name="item">The data item to bring into view.</param>
    [Overload("ScrollIntoView")]
    [MethodImpl]
    public extern void ScrollIntoView(object item);

    /// <summary>Selects all the items in a view.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Initiates the asynchronous request to load more data items, in accordance with the active incremental loading settings.</summary>
    /// <returns>When the operation completes, returns a LoadMoreItemsResult payload.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();

    /// <summary>Scrolls the list to bring the specified data item into view with the specified alignment.</summary>
    /// <param name="item">The data item to bring into view.</param>
    /// <param name="alignment">An enumeration value that specifies whether the item uses **Default** or **Leading** alignment.</param>
    [Overload("ScrollIntoViewWithAlignment")]
    [MethodImpl]
    public extern void ScrollIntoView(object item, ScrollIntoViewAlignment alignment);

    /// <summary>Gets or sets the content for the list header.</summary>
    /// <returns>The content of the list header. The default value is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the view header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to the view header.</summary>
    /// <returns>The collection of Transition style elements that apply to the list header.</returns>
    public extern TransitionCollection HeaderTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the view shows placeholder UI for items during scrolling.</summary>
    /// <returns>**true** if the view shows placeholder UI for items during scrolling; otherwise, **false**. The default is **true**.</returns>
    public extern bool ShowsScrollingPlaceholders { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the data item associated with a UI container changes.</summary>
    public extern event TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> ContainerContentChanging;

    [MethodImpl]
    public extern void SetDesiredContainerUpdateDuration(TimeSpan duration);

    /// <summary>Gets or sets the content for the list footer.</summary>
    /// <returns>The content of the list footer. The default is **null**.</returns>
    public extern object Footer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the view footer.</summary>
    /// <returns>The template that specifies the visualization of the footer object. The default is **null**.</returns>
    public extern DataTemplate FooterTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to the view footer.</summary>
    /// <returns>The collection of Transition style elements that apply to the list footer.</returns>
    public extern TransitionCollection FooterTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the reorder behavior for a ListViewBase instance. When **Enabled**, unsorted and ungrouped lists can be reordered by user manipulation.</summary>
    /// <returns>One of the ListViewReorderMode enumeration values. The default is **Disabled**.</returns>
    public extern ListViewReorderMode ReorderMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a collection of ItemIndexRange objects that describe the currently selected items in the list.</summary>
    /// <returns>The collection of ItemIndexRange objects that describe the currently selected items in the list. The default is an empty collection.</returns>
    public extern IVectorView<ItemIndexRange> SelectedRanges { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether a check box is shown to enable multi-selection.</summary>
    /// <returns>**true** if a check box is shown to enable multi-selection; otherwise, **false**.</returns>
    public extern bool IsMultiSelectCheckBoxEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a drag operation that involves one of the items in the view is ended. In order to receive this event, set the **CanDragItems** property to **True**.</summary>
    public extern event TypedEventHandler<ListViewBase, DragItemsCompletedEventArgs> DragItemsCompleted;

    /// <summary>Occurs when an item container is to be chosen for a data item.</summary>
    public extern event TypedEventHandler<ListViewBase, ChoosingItemContainerEventArgs> ChoosingItemContainer;

    /// <summary>Occurs when an item container is to be chosen for a data group.</summary>
    public extern event TypedEventHandler<ListViewBase, ChoosingGroupHeaderContainerEventArgs> ChoosingGroupHeaderContainer;

    /// <summary>Selects a block of items described by the ItemIndexRange.</summary>
    /// <param name="itemIndexRange">Information about the range of items, including the index of the first and last items in the range, and the number of items.</param>
    [MethodImpl]
    public extern void SelectRange(ItemIndexRange itemIndexRange);

    /// <summary>Deselects a block of items described by the ItemIndexRange.</summary>
    /// <param name="itemIndexRange">Information about the range of items, including the index of the first and last items in the range, and the number of items.</param>
    [MethodImpl]
    public extern void DeselectRange(ItemIndexRange itemIndexRange);

    /// <summary>Gets or sets a value that indicates whether item selection changes when keyboard focus changes.</summary>
    /// <returns>**true** if item selection changes when keyboard focus changes; otherwise, **false**. The default is **true**.</returns>
    public extern bool SingleSelectionFollowsFocus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Returns a value that indicates whether the list view is both the drag source and drop target in a drag-and-drop operation.</summary>
    /// <returns>**true** if the list view is both the drag source and drop target; otherwise, **false**.</returns>
    [MethodImpl]
    public extern bool IsDragSource();

    /// <summary>Attempts to start the animation.</summary>
    /// <param name="animation">The animation to start.</param>
    /// <param name="item">The data item that is animated into view.</param>
    /// <param name="elementName">The name of the element in the ItemTemplate that provides the animated visual.</param>
    /// <returns>**true** if the animation started; **false** if the animation has already been started, if it is no longer active, or if the destination element is the same as the source element.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryStartConnectedAnimationAsync(
      ConnectedAnimation animation,
      object item,
      string elementName);

    /// <summary>Returns a connected animation that's associated with the specified key, data item, and source element.</summary>
    /// <param name="key">The key for the animation.</param>
    /// <param name="item">The data item that is animated out of view.</param>
    /// <param name="elementName">The name of the element in the ItemTemplate that provides the animated visual.</param>
    /// <returns>The animation with the specified key.</returns>
    [MethodImpl]
    public extern ConnectedAnimation PrepareConnectedAnimation(
      string key,
      object item,
      string elementName);

    /// <summary>Gets or sets the SemanticZoom instance that hosts the ListViewBase.</summary>
    /// <returns>The SemanticZoom instance that hosts this view, or **null** if the view is not hosted in a SemanticZoom control. </returns>
    public extern SemanticZoom SemanticZoomOwner { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the ListViewBase instance is the active view in its owning SemanticZoom.</summary>
    /// <returns>**true** if the ListViewBase is the active view; otherwise, **false**.</returns>
    public extern bool IsActiveView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the ListViewBase instance is the zoomed-in view in its owning SemanticZoom.</summary>
    /// <returns>**true** if the ListViewBase is the zoomed-in view; otherwise, **false**.</returns>
    public extern bool IsZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Initializes the changes to related aspects of presentation (such as scrolling UI or state) when the overall view for a SemanticZoom is about to change.</summary>
    [MethodImpl]
    public extern void InitializeViewChange();

    /// <summary>Changes related aspects of presentation when the overall view for a SemanticZoom changes.</summary>
    [MethodImpl]
    public extern void CompleteViewChange();

    /// <summary>Forces content in the view to scroll until the item that's specified by SemanticZoomLocation is visible. Also focuses the item if it finds the item.</summary>
    /// <param name="item">The item in the view to scroll to.</param>
    [MethodImpl]
    public extern void MakeVisible(SemanticZoomLocation item);

    /// <summary>Initializes item-wise operations that are related to a view change when the ListViewBase instance is the source view and the pending destination view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void StartViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Initializes item-wise operations that are related to a view change when the source view is a different view and the pending destination view is the ListViewBase instance.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void StartViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Completes item-wise operations that are related to a view change when the ListViewBase instance is the source view and the new view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void CompleteViewChangeFrom(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Completes item-wise operations that are related to a view change when the ListViewBase instance is the destination view and the source view is a potentially different implementing view.</summary>
    /// <param name="source">The view item as represented in the source view.</param>
    /// <param name="destination">The view item as represented in the destination view.</param>
    [MethodImpl]
    public extern void CompleteViewChangeTo(
      SemanticZoomLocation source,
      SemanticZoomLocation destination);

    /// <summary>Identifies the SingleSelectionFollowsFocus dependency property.</summary>
    /// <returns>The identifier for the SingleSelectionFollowsFocus dependency property.</returns>
    public static extern DependencyProperty SingleSelectionFollowsFocusProperty { [MethodImpl] get; }

    /// <summary>Get the identifier for the IsMultiSelectCheckBoxEnabled dependency property.</summary>
    /// <returns>The identifier for the IsMultiSelectCheckBoxEnabled dependency property.</returns>
    public static extern DependencyProperty IsMultiSelectCheckBoxEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ReorderMode dependency property.</summary>
    /// <returns>The identifier for the ReorderMode dependency property.</returns>
    public static extern DependencyProperty ReorderModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ShowsScrollingPlaceholders dependency property.</summary>
    /// <returns>The identifier for the ShowsScrollingPlaceholders dependency property.</returns>
    public static extern DependencyProperty ShowsScrollingPlaceholdersProperty { [MethodImpl] get; }

    /// <summary>Identifies the Footer dependency property.</summary>
    /// <returns>The identifier for the Footer dependency property.</returns>
    public static extern DependencyProperty FooterProperty { [MethodImpl] get; }

    /// <summary>Identifies the FooterTemplate dependency property.</summary>
    /// <returns>The identifier for the FooterTemplate dependency property.</returns>
    public static extern DependencyProperty FooterTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the FooterTransitions dependency property.</summary>
    /// <returns>The identifier for the FooterTransitions dependency property.</returns>
    public static extern DependencyProperty FooterTransitionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionMode dependency property.</summary>
    /// <returns>The identifier for the SelectionMode dependency property.</returns>
    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSwipeEnabled dependency property.</summary>
    /// <returns>The identifier for the IsSwipeEnabled dependency property.</returns>
    public static extern DependencyProperty IsSwipeEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanDragItems dependency property.</summary>
    /// <returns>The identifier for the CanDragItems dependency property.</returns>
    public static extern DependencyProperty CanDragItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanReorderItems dependency property.</summary>
    /// <returns>The identifier for the CanReorderItems dependency property.</returns>
    public static extern DependencyProperty CanReorderItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsItemClickEnabled dependency property.</summary>
    /// <returns>The identifier for the IsItemClickEnabled dependency property.</returns>
    public static extern DependencyProperty IsItemClickEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the DataFetchSize dependency property.</summary>
    /// <returns>The identifier for the DataFetchSize dependency property.</returns>
    public static extern DependencyProperty DataFetchSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the IncrementalLoadingThreshold dependency property.</summary>
    /// <returns>The identifier for the IncrementalLoadingThreshold dependency property.</returns>
    public static extern DependencyProperty IncrementalLoadingThresholdProperty { [MethodImpl] get; }

    /// <summary>Identifies the IncrementalLoadingTrigger dependency property.</summary>
    /// <returns>The identifier for the IncrementalLoadingTrigger dependency property.</returns>
    public static extern DependencyProperty IncrementalLoadingTriggerProperty { [MethodImpl] get; }

    /// <summary>Identifies the SemanticZoomOwner dependency property.</summary>
    /// <returns>The identifier for the SemanticZoomOwner dependency property.</returns>
    public static extern DependencyProperty SemanticZoomOwnerProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsActiveView dependency property.</summary>
    /// <returns>The identifier for the IsActiveView dependency property.</returns>
    public static extern DependencyProperty IsActiveViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsZoomedInView dependency property.</summary>
    /// <returns>The identifier for the IsZoomedInView dependency property.</returns>
    public static extern DependencyProperty IsZoomedInViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTransitions dependency property.</summary>
    /// <returns>The identifier for the HeaderTransitions dependency property.</returns>
    public static extern DependencyProperty HeaderTransitionsProperty { [MethodImpl] get; }
  }
}
