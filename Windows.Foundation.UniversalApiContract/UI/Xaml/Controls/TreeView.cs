// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.TreeView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a hierarchical list with expanding and collapsing nodes that contain nested items.</summary>
  [Static(typeof (ITreeViewStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITreeViewStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (ITreeViewFactory), CompositionType.Public, 393216, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public class TreeView : Control, ITreeView, ITreeView2
  {
    /// <summary>Initializes a new instance of the TreeView control.</summary>
    [MethodImpl]
    public extern TreeView();

    /// <summary>Gets or sets the collection of root nodes of the tree.</summary>
    /// <returns>The collection of root nodes of the tree.</returns>
    public extern IVector<TreeViewNode> RootNodes { [MethodImpl] get; }

    /// <summary>Gets or sets the selection behavior for a TreeView instance.</summary>
    /// <returns>An enumeration value that specifies the selection behavior for a TreeView. The default is **Single** selection.</returns>
    public extern TreeViewSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of nodes that are selected in the tree.</summary>
    /// <returns>The collection of nodes that are selected in the tree. The default is an empty collection.</returns>
    public extern IVector<TreeViewNode> SelectedNodes { [MethodImpl] get; }

    /// <summary>Expands the specified node in the tree.</summary>
    /// <param name="value">The tree node to expand.</param>
    [MethodImpl]
    public extern void Expand(TreeViewNode value);

    /// <summary>Collapses the specified node in the tree.</summary>
    /// <param name="value">The tree node to collapse.</param>
    [MethodImpl]
    public extern void Collapse(TreeViewNode value);

    /// <summary>Selects all nodes in the tree.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Occurs when an item in the tree is invoked.</summary>
    public extern event TypedEventHandler<TreeView, TreeViewItemInvokedEventArgs> ItemInvoked;

    /// <summary>Occurs when a node in the tree starts to expand.</summary>
    public extern event TypedEventHandler<TreeView, TreeViewExpandingEventArgs> Expanding;

    /// <summary>Occurs when a node in the tree is collapsed.</summary>
    public extern event TypedEventHandler<TreeView, TreeViewCollapsedEventArgs> Collapsed;

    /// <summary>Returns the TreeViewNode corresponding to the specified container.</summary>
    /// <param name="container">The container to retrieve the TreeViewNode for.</param>
    /// <returns>The node that corresponds to the specified container.</returns>
    [MethodImpl]
    public extern TreeViewNode NodeFromContainer(DependencyObject container);

    /// <summary>Returns the container corresponding to the specified node.</summary>
    /// <param name="node">The node to retrieve the container for.</param>
    /// <returns>A container that corresponds to the specified node, if the node has a container and exists in the collection; otherwise, **null**.</returns>
    [MethodImpl]
    public extern DependencyObject ContainerFromNode(TreeViewNode node);

    /// <summary>Returns the item that corresponds to the specified, generated container.</summary>
    /// <param name="container">The DependencyObject that corresponds to the item to be returned.</param>
    /// <returns>The contained item, or the container if it does not contain an item.</returns>
    [MethodImpl]
    public extern object ItemFromContainer(DependencyObject container);

    /// <summary>Returns the container corresponding to the specified item.</summary>
    /// <param name="item">The item to retrieve the container for.</param>
    /// <returns>A container that corresponds to the specified item, if the item has a container and exists in the collection; otherwise, **null**.</returns>
    [MethodImpl]
    public extern DependencyObject ContainerFromItem(object item);

    /// <summary>Gets or sets a value that indicates whether items in the view can be dragged as data payload.</summary>
    /// <returns>**true** if items in the view can be dragged as data payload; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanDragItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether items in the view can be reordered through user interaction.</summary>
    /// <returns>**true** if items in the view can be reordered through user interaction; otherwise, **false**. The default is **false**.</returns>
    public extern bool CanReorderItems { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display each item.</summary>
    /// <returns>The template that specifies the visualization of the data objects. The default is **null**.</returns>
    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom DataTemplateSelector logic class. The DataTemplateSelector referenced by this property returns a template to apply to items.</summary>
    /// <returns>A reference to a custom DataTemplateSelector logic class.</returns>
    public extern DataTemplateSelector ItemTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style that is used when rendering the item containers.</summary>
    /// <returns>The style applied to the item containers. The default is **null**.</returns>
    public extern Style ItemContainerStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom StyleSelector logic class. The StyleSelector returns different Style values to use for the item container based on characteristics of the object being displayed.</summary>
    /// <returns>A custom StyleSelector logic class.</returns>
    public extern StyleSelector ItemContainerStyleSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to the item containers of a TreeView.</summary>
    /// <returns>The collection of Transition style elements that apply to the item containers of an ItemsControl.</returns>
    public extern TransitionCollection ItemContainerTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object source used to generate the content of the TreeView.</summary>
    /// <returns>The object that is used to generate the content of the TreeView. The default is **null**.</returns>
    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a drag operation that involves one of the items in the view is initiated.</summary>
    public extern event TypedEventHandler<TreeView, TreeViewDragItemsStartingEventArgs> DragItemsStarting;

    /// <summary>Occurs when a drag operation that involves one of the items in the view is ended.</summary>
    public extern event TypedEventHandler<TreeView, TreeViewDragItemsCompletedEventArgs> DragItemsCompleted;

    /// <summary>Identifies the CanDragItems dependency property.</summary>
    /// <returns>The identifier for the CanDragItems dependency property.</returns>
    public static extern DependencyProperty CanDragItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanReorderItems dependency property.</summary>
    /// <returns>The identifier for the CanReorderItems dependency property.</returns>
    public static extern DependencyProperty CanReorderItemsProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemTemplate dependency property.</summary>
    /// <returns>The identifier for the ItemTemplate dependency property.</returns>
    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemTemplateSelector dependency property.</summary>
    /// <returns>The identifier for the ItemTemplateSelector dependency property.</returns>
    public static extern DependencyProperty ItemTemplateSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemContainerStyle dependency property.</summary>
    /// <returns>The identifier for the ItemContainerStyle dependency property.</returns>
    public static extern DependencyProperty ItemContainerStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemContainerStyleSelector dependency property.</summary>
    /// <returns>The identifier for the ItemContainerStyleSelector dependency property.</returns>
    public static extern DependencyProperty ItemContainerStyleSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemContainerTransitions dependency property.</summary>
    /// <returns>The identifier for the ItemContainerTransitions dependency property.</returns>
    public static extern DependencyProperty ItemContainerTransitionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemsSource dependency property.</summary>
    /// <returns>The identifier for the ItemsSource dependency property.</returns>
    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionMode dependency property.</summary>
    /// <returns>The identifier for the SelectionMode dependency property.</returns>
    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }
  }
}
