// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AutoSuggestBoxAutomationPeer
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
  /// <summary>Exposes AutoSuggestBox types to Microsoft UI Automation.</summary>
  [Activatable(typeof (IAutoSuggestBoxAutomationPeerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AutoSuggestBoxAutomationPeer : 
    FrameworkElementAutomationPeer,
    IAutoSuggestBoxAutomationPeer,
    IInvokeProvider
  {
    /// <summary>Initializes a new instance of the AutoSuggestBoxAutomationPeer class.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    public extern AutoSuggestBoxAutomationPeer(AutoSuggestBox owner);

    /// <summary>Sends a request to submit the auto-suggest query to the AutoSuggestBox associated with the automation peer.</summary>
    [MethodImpl]
    public extern void Invoke();
  }
}
