// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ListBox
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
  /// <summary>Presents a list of items the user can select from.</summary>
  [WebHostHidden]
  [Static(typeof (IListBoxStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IListBoxStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IListBoxFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ListBox : Selector, IListBox, IListBox2
  {
    /// <summary>Initializes a new instance of the ListBox class.</summary>
    [MethodImpl]
    public extern ListBox();

    /// <summary>Gets the list of currently selected items for the ListBox control.</summary>
    /// <returns>The list of currently selected items for the ListBox control.</returns>
    public extern IVector<object> SelectedItems { [MethodImpl] get; }

    /// <summary>Gets or sets the selection behavior for the ListBox control.</summary>
    /// <returns>One of the SelectionMode values.</returns>
    public extern SelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Causes the object to scroll into view.</summary>
    /// <param name="item">The object to scroll to.</param>
    [MethodImpl]
    public extern void ScrollIntoView(object item);

    /// <summary>Selects all the items in the ListBox control.</summary>
    [MethodImpl]
    public extern void SelectAll();

    /// <summary>Gets or sets a value that indicates whether item selection changes when keyboard focus changes.</summary>
    /// <returns>**true** if item selection changes when keyboard focus changes; otherwise, **false**. The default is **true**.</returns>
    public extern bool SingleSelectionFollowsFocus { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the SingleSelectionFollowsFocus dependency property.</summary>
    /// <returns>The identifier for the SingleSelectionFollowsFocus dependency property.</returns>
    public static extern DependencyProperty SingleSelectionFollowsFocusProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionMode dependency property.</summary>
    /// <returns>The identifier for the SelectionMode dependency property.</returns>
    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }
  }
}
