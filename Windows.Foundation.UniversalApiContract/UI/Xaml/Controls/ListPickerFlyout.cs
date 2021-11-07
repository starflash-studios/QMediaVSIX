// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListPickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that allows a user to pick one or more items from a list. See Remarks.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IListPickerFlyoutStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ListPickerFlyout : PickerFlyoutBase, IListPickerFlyout
  {
    /// <summary>Initializes a new instance of the ListPickerFlyout class.</summary>
    [MethodImpl]
    public extern ListPickerFlyout();

    /// <summary>Gets or sets an object source used to generate the content of the control.</summary>
    /// <returns>The object that is used to generate the content of the control. The default is null.</returns>
    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display each item.</summary>
    /// <returns>The template that specifies the visualization of the data objects. The default is null.</returns>
    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name or path of the property that is displayed for each data item</summary>
    /// <returns>The name or path of the property that is displayed for each the data item in the control. The default is an empty string ("").</returns>
    public extern string DisplayMemberPath { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the selection mode of the picker.</summary>
    /// <returns>The selection mode of the picker.</returns>
    public extern ListPickerFlyoutSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the index of the selected item.</summary>
    /// <returns>The index of the selected item. The default is -1.</returns>
    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the selected item.</summary>
    /// <returns>The selected item. The default is null.</returns>
    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the selected item, obtained by using the SelectedValuePath</summary>
    /// <returns>The value of the selected item, obtained by using the SelectedValuePath, or null if no item is selected. The default value is null.</returns>
    public extern object SelectedValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the property path that is used to get the SelectedValue property of the SelectedItem property.</summary>
    /// <returns>The property path that is used to get the SelectedValue property of the SelectedItem property. The default is String.Empty.</returns>
    public extern string SelectedValuePath { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the list of currently selected items.</summary>
    /// <returns>The list of currently selected items.</returns>
    public extern IVector<object> SelectedItems { [MethodImpl] get; }

    /// <summary>Occurs when the user has selected items.</summary>
    public extern event TypedEventHandler<ListPickerFlyout, ItemsPickedEventArgs> ItemsPicked;

    /// <summary>Begins an asynchronous operation to show the flyout placed in relation to the specified element.</summary>
    /// <param name="target">The element to use as the flyout's placement target.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<object>> ShowAtAsync(
      FrameworkElement target);

    /// <summary>Identifies the ItemsSource dependency property.</summary>
    /// <returns>The identifier for the ItemsSource dependency property.</returns>
    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the ItemTemplate dependency property.</summary>
    /// <returns>The identifier for the ItemTemplate dependency property.</returns>
    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisplayMemberPath dependency property.</summary>
    /// <returns>The identifier for the DisplayMemberPath dependency property.</returns>
    public static extern DependencyProperty DisplayMemberPathProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionMode dependency property.</summary>
    /// <returns>The identifier of the SelectionMode dependency property.</returns>
    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedIndex dependency property.</summary>
    /// <returns>The identifier for the SelectedIndex dependency property.</returns>
    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedItem dependency property.</summary>
    /// <returns>Identifies the SelectedItem dependency property.</returns>
    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedValue dependency property.</summary>
    /// <returns>The identifier for the SelectedValue dependency property.</returns>
    public static extern DependencyProperty SelectedValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedValuePath dependency property.</summary>
    /// <returns>The identifier for the SelectedValuePath dependency property.</returns>
    public static extern DependencyProperty SelectedValuePathProperty { [MethodImpl] get; }
  }
}
