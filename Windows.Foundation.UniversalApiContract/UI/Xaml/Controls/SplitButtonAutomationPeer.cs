// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SplitButtonAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Exposes SplitButton types to Microsoft UI Automation.</summary>
  [WebHostHidden]
  [Composable(typeof (ISplitButtonAutomationPeerFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class SplitButtonAutomationPeer : 
    FrameworkElementAutomationPeer,
    ISplitButtonAutomationPeer,
    IExpandCollapseProvider,
    IInvokeProvider
  {
    /// <summary>Initializes a new instance of the SplitButtonAutomationPeer class.</summary>
    /// <param name="owner">The SplitButton control instance to create the peer for.</param>
    [MethodImpl]
    public extern SplitButtonAutomationPeer(SplitButton owner);

    /// <summary>Gets the state, expanded or collapsed, of the control.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Hides the control's drop down menu.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Displays the control's drop down menu.</summary>
    [MethodImpl]
    public extern void Expand();

    /// <summary>Sends a request to click the button associated with the automation peer.</summary>
    [MethodImpl]
    public extern void Invoke();
  }
}
