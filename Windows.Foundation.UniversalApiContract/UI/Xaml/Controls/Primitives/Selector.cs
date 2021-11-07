// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.Selector
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a control that enables a user to select an item from a collection of items.</summary>
  [Static(typeof (ISelectorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (ISelectorFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class Selector : ItemsControl, ISelector
  {
    /// <summary>Gets or sets the index of the selected item.</summary>
    /// <returns>The index of the selected item. The default is -1, which indicates that no item is selected.</returns>
    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the selected item.</summary>
    /// <returns>The selected item. The default is null.</returns>
    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the value of the selected item, obtained by using the SelectedValuePath.</summary>
    /// <returns>The value of the selected item, obtained by using the SelectedValuePath, or null if no item is selected. The default value is null.</returns>
    public extern object SelectedValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the property path that is used to get the SelectedValue property of the SelectedItem property.</summary>
    /// <returns>The property path that is used to get the SelectedValue property of the SelectedItem property. The default is String.Empty.</returns>
    public extern string SelectedValuePath { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether a Selector should keep the SelectedItem synchronized with the current item in the Items property.</summary>
    /// <returns>**true** if the SelectedItem is always synchronized with the current item in the ItemCollection; **false** if the SelectedItem is never synchronized with the current item; **null** if the SelectedItem is synchronized with the current item only if the Selector uses an ICollectionView. The default value is **null**/indeterminate.</returns>
    public extern IReference<bool> IsSynchronizedWithCurrentItem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the currently selected item changes.</summary>
    public extern event SelectionChangedEventHandler SelectionChanged;

    /// <summary>Identifies the SelectedIndex dependency property.</summary>
    /// <returns>The identifier for the SelectedIndex dependency property.</returns>
    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedItem dependency property.</summary>
    /// <returns>The identifier for the SelectedItem dependency property.</returns>
    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the SelectedValue dependency property.</summary>
    /// <returns>The identifier for the SelectedValue dependency property.</returns>
    public static extern DependencyProperty SelectedValueProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the SelectedValuePath dependency property.</summary>
    /// <returns>The identifier for the SelectedValuePath dependency property.</returns>
    public static extern DependencyProperty SelectedValuePathProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsSynchronizedWithCurrentItem dependency property.</summary>
    /// <returns>The identifier for the IsSynchronizedWithCurrentItem dependency property.</returns>
    public static extern DependencyProperty IsSynchronizedWithCurrentItemProperty { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the specified Selector has the focus.</summary>
    /// <param name="element">The Selector to evaluate.</param>
    /// <returns>**true** to indicate that the Selector has the focus; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool GetIsSelectionActive(DependencyObject element);
  }
}
