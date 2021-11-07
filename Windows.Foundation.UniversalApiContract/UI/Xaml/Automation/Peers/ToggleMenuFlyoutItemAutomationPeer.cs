// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ToggleMenuFlyoutItemAutomationPeer
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
  /// <summary>Exposes ToggleMenuFlyoutItem types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IToggleMenuFlyoutItemAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ToggleMenuFlyoutItemAutomationPeer : 
    FrameworkElementAutomationPeer,
    IToggleMenuFlyoutItemAutomationPeer,
    IToggleProvider
  {
    /// <summary>Initializes a new instance of the ToggleMenuFlyoutItemAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern ToggleMenuFlyoutItemAutomationPeer(ToggleMenuFlyoutItem owner);

    /// <summary>Gets the toggle state of the control.</summary>
    /// <returns>The toggle state of the control.</returns>
    public extern ToggleState ToggleState { [MethodImpl] get; }

    /// <summary>Cycles through the toggle states of a control.</summary>
    [MethodImpl]
    public extern void Toggle();
  }
}
