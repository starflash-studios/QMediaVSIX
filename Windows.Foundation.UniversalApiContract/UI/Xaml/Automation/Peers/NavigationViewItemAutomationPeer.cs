// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.NavigationViewItemAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes **NavigationViewItem ** types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Composable(typeof (INavigationViewItemAutomationPeerFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class NavigationViewItemAutomationPeer : 
    ListViewItemAutomationPeer,
    INavigationViewItemAutomationPeer
  {
    /// <summary>Initializes a new instance of the **NavigationViewItemAutomationPeer** class.</summary>
    /// <param name="owner">The **NavigationViewItem ** control instance to create the peer for.</param>
    [MethodImpl]
    public extern NavigationViewItemAutomationPeer(NavigationViewItem owner);
  }
}
