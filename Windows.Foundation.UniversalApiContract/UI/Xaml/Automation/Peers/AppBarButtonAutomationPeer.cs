// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AppBarButtonAutomationPeer
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
  /// <summary>Exposes AppBarButton types to Microsoft UI Automation.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IAppBarButtonAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class AppBarButtonAutomationPeer : 
    ButtonAutomationPeer,
    IAppBarButtonAutomationPeer,
    IExpandCollapseProvider
  {
    /// <summary>Initializes a new instance of the AppBarButtonAutomationPeer class.</summary>
    /// <param name="owner">The AppBarButton to create the peer for.</param>
    [MethodImpl]
    public extern AppBarButtonAutomationPeer(AppBarButton owner);

    /// <summary>Gets the state, expanded or collapsed, of the control.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Hides all nodes, controls, or content that are descendants of the control.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Displays all child nodes, controls, or content of the control.</summary>
    [MethodImpl]
    public extern void Expand();
  }
}
