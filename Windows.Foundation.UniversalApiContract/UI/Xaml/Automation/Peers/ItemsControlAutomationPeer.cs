// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes ItemsControl types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IItemsControlAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ItemsControlAutomationPeer : 
    FrameworkElementAutomationPeer,
    IItemsControlAutomationPeer,
    IItemsControlAutomationPeer2,
    IItemsControlAutomationPeerOverrides2,
    IItemContainerProvider
  {
    /// <summary>Initializes a new instance of the ItemsControlAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern ItemsControlAutomationPeer(ItemsControl owner);

    /// <summary>Creates a new instance of the ItemAutomationPeer for a data item in the Items collection of this ItemsControl.</summary>
    /// <param name="item">The data item that is associated with this ItemAutomationPeer.</param>
    /// <returns>The new ItemAutomationPeer created.</returns>
    [MethodImpl]
    public extern ItemAutomationPeer CreateItemAutomationPeer(object item);

    [MethodImpl]
    extern ItemAutomationPeer IItemsControlAutomationPeerOverrides2.OnCreateItemAutomationPeer(
      object item);

    /// <summary>Retrieves an element by the specified property value.</summary>
    /// <param name="startAfter">The item in the container after which to begin the search.</param>
    /// <param name="automationProperty">The property that contains the value to retrieve.</param>
    /// <param name="value">The value to retrieve.</param>
    /// <returns>The first item that matches the search criterion if such an item exists; otherwise, **null**.</returns>
    [MethodImpl]
    public extern IRawElementProviderSimple FindItemByProperty(
      IRawElementProviderSimple startAfter,
      AutomationProperty automationProperty,
      object value);
  }
}
