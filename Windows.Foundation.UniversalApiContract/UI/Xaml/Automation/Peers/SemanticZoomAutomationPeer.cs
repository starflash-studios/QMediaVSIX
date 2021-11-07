// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.SemanticZoomAutomationPeer
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
  /// <summary>Exposes SemanticZoom types to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ISemanticZoomAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class SemanticZoomAutomationPeer : 
    FrameworkElementAutomationPeer,
    ISemanticZoomAutomationPeer,
    IToggleProvider
  {
    /// <summary>Initializes a new instance of the SemanticZoomAutomationPeer class.</summary>
    /// <param name="owner">The SemanticZoom to create a peer for.</param>
    [MethodImpl]
    public extern SemanticZoomAutomationPeer(SemanticZoom owner);

    /// <summary>Gets a value that indicates whether the Toggle method can be called and result in a toggled view.</summary>
    /// <returns>**true** if calling Toggle will result in a toggled view; otherwise, **false**.</returns>
    public extern ToggleState ToggleState { [MethodImpl] get; }

    /// <summary>Cycles through the toggle states of a control.</summary>
    [MethodImpl]
    public extern void Toggle();
  }
}
