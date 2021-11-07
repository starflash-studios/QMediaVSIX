// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes a data item in an Items collection to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IItemAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public class ItemAutomationPeer : AutomationPeer, IItemAutomationPeer, IVirtualizedItemProvider
  {
    /// <summary>Initializes a new instance of the ItemAutomationPeer class.</summary>
    /// <param name="item">The specific item to create for.</param>
    /// <param name="parent">The items-control owner to create for.</param>
    [MethodImpl]
    public extern ItemAutomationPeer(object item, ItemsControlAutomationPeer parent);

    /// <summary>Gets the data item in the Items collection that is associated with this ItemAutomationPeer.</summary>
    /// <returns>The data item.</returns>
    public extern object Item { [MethodImpl] get; }

    /// <summary>Gets the ItemsControlAutomationPeer that is associated with the ItemsControl that holds the Items collection.</summary>
    /// <returns>The ItemsControlAutomationPeer associated with the ItemsControl that holds the Items collection.</returns>
    public extern ItemsControlAutomationPeer ItemsControlAutomationPeer { [MethodImpl] get; }

    /// <summary>Makes the virtual item fully accessible as a Microsoft UI Automation element.</summary>
    [MethodImpl]
    public extern void Realize();
  }
}
