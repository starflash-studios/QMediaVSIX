// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.HyperlinkButtonAutomationPeer
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
  /// <summary>Exposes HyperlinkButton types to Microsoft UI Automation.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IHyperlinkButtonAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class HyperlinkButtonAutomationPeer : 
    ButtonBaseAutomationPeer,
    IHyperlinkButtonAutomationPeer,
    IInvokeProvider
  {
    /// <summary>Initializes a new instance of the HyperlinkButtonAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern HyperlinkButtonAutomationPeer(HyperlinkButton owner);

    /// <summary>Sends a request to click the hyperlink button associated with the automation peer.</summary>
    [MethodImpl]
    public extern void Invoke();
  }
}
