// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MenuBarItemAutomationPeer
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
  /// <summary>Exposes MenuBarItem types to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IMenuBarItemAutomationPeerFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  public class MenuBarItemAutomationPeer : 
    FrameworkElementAutomationPeer,
    IMenuBarItemAutomationPeer,
    IExpandCollapseProvider,
    IInvokeProvider
  {
    /// <summary>Initializes a new instance of the MenuBarItemAutomationPeer class using the specified MenuBarItem.</summary>
    /// <param name="owner">The specified MenuBarItem.</param>
    [MethodImpl]
    public extern MenuBarItemAutomationPeer(MenuBarItem owner);

    /// <summary>Gets the state, expanded or collapsed, of the MenuBarItem.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Hides all nodes, controls, or content that are descendants of the MenuBarItem.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Displays all child nodes, controls, or content of the MenuBarItem.</summary>
    [MethodImpl]
    public extern void Expand();

    /// <summary>Sends a request to click the MenuBarItem associated with the automation peer.</summary>
    [MethodImpl]
    public extern void Invoke();
  }
}
