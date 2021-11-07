// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.HubSectionAutomationPeer
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
  /// <summary>Exposes HubSection types to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IHubSectionAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class HubSectionAutomationPeer : 
    FrameworkElementAutomationPeer,
    IHubSectionAutomationPeer,
    IScrollItemProvider
  {
    /// <summary>Initializes a new instance of the HubSectionAutomationPeer class.</summary>
    /// <param name="owner">The HubSection to create the peer for.</param>
    [MethodImpl]
    public extern HubSectionAutomationPeer(HubSection owner);

    /// <summary>Scrolls the content area of the parent container in order to display the item within the visible region (viewport) of the container.</summary>
    [MethodImpl]
    public extern void ScrollIntoView();
  }
}
