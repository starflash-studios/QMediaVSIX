// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes ToggleButton types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IToggleButtonAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ToggleButtonAutomationPeer : 
    ButtonBaseAutomationPeer,
    IToggleButtonAutomationPeer,
    IToggleProvider
  {
    /// <summary>Initializes a new instance of the ToggleButtonAutomationPeer class.</summary>
    /// <param name="owner">The ToggleButton to create a peer for.</param>
    [MethodImpl]
    public extern ToggleButtonAutomationPeer(ToggleButton owner);

    /// <summary>Gets the toggle state of the control.</summary>
    /// <returns>The toggle state of the control.</returns>
    public extern ToggleState ToggleState { [MethodImpl] get; }

    /// <summary>Cycles through the toggle states of a control.</summary>
    [MethodImpl]
    public extern void Toggle();
  }
}
