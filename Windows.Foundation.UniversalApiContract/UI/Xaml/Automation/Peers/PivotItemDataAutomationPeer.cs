// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.PivotItemDataAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes the data content of a PivotItem to Microsoft UI Automation.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPivotItemDataAutomationPeerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PivotItemDataAutomationPeer : 
    ItemAutomationPeer,
    IPivotItemDataAutomationPeer,
    IScrollItemProvider,
    ISelectionItemProvider,
    IVirtualizedItemProvider
  {
    /// <summary>Initializes a new instance of the PivotItemDataAutomationPeer class.</summary>
    /// <param name="item">The specific data item.</param>
    /// <param name="parent">The automation peer for the Pivot object that contains the item.</param>
    [MethodImpl]
    public extern PivotItemDataAutomationPeer(object item, PivotAutomationPeer parent);

    /// <summary>Scrolls the content area of the parent container in order to display the item within the visible region (viewport) of the container.</summary>
    [MethodImpl]
    public extern void ScrollIntoView();

    /// <summary>Gets a value that indicates whether an item is selected.</summary>
    /// <returns>**true** if the element is selected; otherwise, **false**.</returns>
    public extern bool IsSelected { [MethodImpl] get; }

    /// <summary>Gets the UI automation provider that implements ISelectionProvider and acts as the container for the calling object.</summary>
    /// <returns>The provider that supports ISelectionProvider.</returns>
    public extern IRawElementProviderSimple SelectionContainer { [MethodImpl] get; }

    /// <summary>Adds the current element to the collection of selected items.</summary>
    [MethodImpl]
    public extern void AddToSelection();

    /// <summary>Removes the current element from the collection of selected items.</summary>
    [MethodImpl]
    public extern void RemoveFromSelection();

    /// <summary>Clears any existing selection and then selects the current element.</summary>
    [MethodImpl]
    public extern void Select();

    /// <summary>Makes the virtual item fully accessible as a Microsoft UI Automation element.</summary>
    [MethodImpl]
    public new extern void Realize();
  }
}
