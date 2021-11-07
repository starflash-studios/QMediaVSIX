// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemsControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that can be used to present a collection of items.</summary>
  [WebHostHidden]
  [ContentProperty(Name = "Items")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IItemsControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IItemsControlFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class ItemsControl : 
    Control,
    IItemsControl,
    IItemsControl2,
    IItemsControl3,
    IItemsControlOverrides,
    IItemContainerMapping
  {
    /// <summary>Initializes a new instance of the ItemsControl class.</summary>
    [MethodImpl]
    public extern ItemsControl();

    /// <summary>Gets or sets an object source used to generate the content of the ItemsControl.</summary>
    /// <returns>The object that is used to generate the content of the ItemsControl. The default is `null`.</returns>
    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection used to generate the content of the control.</summary>
    /// <returns>The collection that is used to generate the content of the control, if it exists; otherwise, null. The default is an empty collection.</returns>
    public extern ItemCollection Items { [MethodImpl] get; }

    /// <summary>Gets or sets the DataTemplate used to display each item.</summary>
    /// <returns>The template that specifies the visualization of the data objects. The default is null.</returns>
    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom DataTemplateSelector logic class. The DataTemplateSelector referenced by this property returns a template to apply to items.</summary>
    /// <returns>A reference to a custom DataTemplateSelector logic class.</returns>
    public extern DataTemplateSelector ItemTemplateSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the template that defines the panel that controls the layout of items.</summary>
    /// <returns>An ItemsPanelTemplate that defines the panel to use for the layout of the items. The default value for the ItemsControl is an ItemsPanelTemplate that specifies a StackPanel.</returns>
    public extern ItemsPanelTemplate ItemsPanel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name or path of the property that is displayed for each data item.</summary>
    /// <returns>The name or path of the property that is displayed for each the data item in the control. The default is an empty string ("").</returns>
    public extern string DisplayMemberPath { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style that is used when rendering the item containers.</summary>
    /// <returns>The style applied to the item containers. The default is null.</returns>
    public extern Style ItemContainerStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a reference to a custom StyleSelector logic class. The StyleSelector returns different Style values to use for the item container based on characteristics of the object being displayed.</summary>
    /// <returns>A custom StyleSelector logic class.</returns>
    public extern StyleSelector ItemContainerStyleSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the ItemContainerGenerator associated with this ItemsControl.</summary>
    /// <returns>The ItemContainerGenerator associated with this ItemsControl.</returns>
    public extern ItemContainerGenerator ItemContainerGenerator { [MethodImpl] get; }

    /// <summary>Gets or sets the collection of Transition style elements that apply to the item containers of an ItemsControl.</summary>
    /// <returns>The collection of Transition style elements that apply to the item containers of an ItemsControl.</returns>
    public extern TransitionCollection ItemContainerTransitions { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a collection of GroupStyle objects that define the appearance of each level of groups.</summary>
    /// <returns>A collection of GroupStyle objects that define the appearance of each level of groups.</returns>
    public extern IObservableVector<global::Windows.UI.Xaml.Controls.GroupStyle> GroupStyle { [MethodImpl] get; }

    /// <summary>Gets or sets a reference to a custom GroupStyleSelector logic class. The GroupStyleSelector returns different GroupStyle values to use for content based on the characteristics of that content.</summary>
    /// <returns>A reference to a custom GroupStyleSelector logic class.</returns>
    public extern GroupStyleSelector GroupStyleSelector { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether the control is using grouping.</summary>
    /// <returns>**true** if a control is using grouping; otherwise, **false**.</returns>
    public extern bool IsGrouping { [MethodImpl] get; }

    /// <summary>Gets the Panel specified by ItemsPanel.</summary>
    /// <returns>The Panel specified by ItemsPanel. The default is **null**.</returns>
    public extern Panel ItemsPanelRoot { [MethodImpl] get; }

    /// <summary>Returns the group header container that corresponds to the specified container element.</summary>
    /// <param name="itemContainer">The container element to return the group header container for.</param>
    /// <returns>The group header container associated with the specified item container.</returns>
    [MethodImpl]
    public extern DependencyObject GroupHeaderContainerFromItemContainer(
      DependencyObject itemContainer);

    [MethodImpl]
    extern bool IItemsControlOverrides.IsItemItsOwnContainerOverride(
      object item);

    [MethodImpl]
    extern DependencyObject IItemsControlOverrides.GetContainerForItemOverride();

    [MethodImpl]
    extern void IItemsControlOverrides.ClearContainerForItemOverride(
      DependencyObject element,
      object item);

    [MethodImpl]
    extern void IItemsControlOverrides.PrepareContainerForItemOverride(
      DependencyObject element,
      object item);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemsChanged(object e);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemContainerStyleChanged(
      Style oldItemContainerStyle,
      Style newItemContainerStyle);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemContainerStyleSelectorChanged(
      StyleSelector oldItemContainerStyleSelector,
      StyleSelector newItemContainerStyleSelector);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemTemplateChanged(
      DataTemplate oldItemTemplate,
      DataTemplate newItemTemplate);

    [MethodImpl]
    extern void IItemsControlOverrides.OnItemTemplateSelectorChanged(
      DataTemplateSelector oldItemTemplateSelector,
      DataTemplateSelector newItemTemplateSelector);

    [MethodImpl]
    extern void IItemsControlOverrides.OnGroupStyleSelectorChanged(
      GroupStyleSelector oldGroupStyleSelector,
      GroupStyleSelector newGroupStyleSelector);

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

    /// <summary>Returns the index to the item that has the specified, generated container.</summary>
    /// <param name="container">The generated container to retrieve the item index for.</param>
    /// <returns>The index to the item that corresponds to the specified generated container.</returns>
    [MethodImpl]
    public extern int IndexFromContainer(DependencyObject container);

    /// <summary>Returns the container for the item at the specified index within the ItemCollection.</summary>
    /// <param name="index">The index of the item to retrieve.</param>
    /// <returns>The container for the item at the specified index within the item collection, if the item has a container; otherwise, **null**.</returns>
    [MethodImpl]
    public extern DependencyObject ContainerFromIndex(int index);

    /// <summary>Identifies the ItemsSource dependency property.</summary>
    /// <returns>The identifier for the ItemsSource dependency property.</returns>
    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemTemplate dependency property.</summary>
    /// <returns>The identifier for the ItemTemplate dependency property.</returns>
    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemTemplateSelector dependency property.</summary>
    /// <returns>The identifier for the ItemTemplateSelector dependency property.</returns>
    public static extern DependencyProperty ItemTemplateSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemsPanel dependency property.</summary>
    /// <returns>The identifier for the ItemsPanel dependency property.</returns>
    public static extern DependencyProperty ItemsPanelProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisplayMemberPath dependency property.</summary>
    /// <returns>The identifier for the DisplayMemberPath dependency property.</returns>
    public static extern DependencyProperty DisplayMemberPathProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemContainerStyle dependency property.</summary>
    /// <returns>The identifier for the ItemContainerStyle dependency property.</returns>
    public static extern DependencyProperty ItemContainerStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemContainerStyleSelector dependency property.</summary>
    /// <returns>The identifier for the ItemContainerStyleSelector dependency property.</returns>
    public static extern DependencyProperty ItemContainerStyleSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemContainerTransitions dependency property.</summary>
    /// <returns>The identifier for the ItemContainerTransitions dependency property.</returns>
    public static extern DependencyProperty ItemContainerTransitionsProperty { [MethodImpl] get; }

    /// <summary>Identifies the GroupStyleSelector dependency property.</summary>
    /// <returns>The identifier for the GroupStyleSelector dependency property.</returns>
    public static extern DependencyProperty GroupStyleSelectorProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsGrouping dependency property.</summary>
    /// <returns>The identifier for the IsGrouping dependency property.</returns>
    public static extern DependencyProperty IsGroupingProperty { [MethodImpl] get; }

    /// <summary>Returns the ItemsControl that the specified element hosts items for.</summary>
    /// <param name="element">The host element.</param>
    /// <returns>The ItemsControl that the specified element hosts items for, or null.</returns>
    [MethodImpl]
    public static extern ItemsControl GetItemsOwner(DependencyObject element);

    /// <summary>Returns the ItemsControl that owns the specified container element.</summary>
    /// <param name="container">The container element to return the ItemsControl for.</param>
    /// <returns>The ItemsControl that owns the specified container element; otherwise, null.</returns>
    [MethodImpl]
    public static extern ItemsControl ItemsControlFromItemContainer(
      DependencyObject container);
  }
}
