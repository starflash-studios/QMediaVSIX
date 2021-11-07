// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ListBoxItemDataAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes ListBox items to Microsoft UI Automation, using a data representation of the item so that the peer supports scrolling to that item with data awareness.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IListBoxItemDataAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class ListBoxItemDataAutomationPeer : 
    SelectorItemAutomationPeer,
    IListBoxItemDataAutomationPeer,
    IScrollItemProvider
  {
    /// <summary>Initializes a new instance of the ListBoxItemDataAutomationPeer class.</summary>
    /// <param name="item">The specific data item.</param>
    /// <param name="parent">The automation peer for the ListBox that contains the item.</param>
    [MethodImpl]
    public extern ListBoxItemDataAutomationPeer(object item, ListBoxAutomationPeer parent);

    /// <summary>Scrolls the content area of a container object in order to display the control within the visible region (viewport) of the container.</summary>
    [MethodImpl]
    public extern void ScrollIntoView();
  }
}
