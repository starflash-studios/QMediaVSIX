// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ListViewItemDataAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes ListView items to Microsoft UI Automation, using a data representation of the item so that the peer supports scrolling to that item with data awareness.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IListViewItemDataAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class ListViewItemDataAutomationPeer : 
    SelectorItemAutomationPeer,
    IListViewItemDataAutomationPeer,
    IScrollItemProvider
  {
    /// <summary>Initializes a new instance of the ListViewItemDataAutomationPeer class.</summary>
    /// <param name="item">The specific data item.</param>
    /// <param name="parent">The automation peer for the ListViewBase derived type that contains the item.</param>
    [MethodImpl]
    public extern ListViewItemDataAutomationPeer(object item, ListViewBaseAutomationPeer parent);

    /// <summary>Scrolls the content area of the parent container in order to display the peer's data within the visible region (viewport) of the container.</summary>
    [MethodImpl]
    public extern void ScrollIntoView();
  }
}
