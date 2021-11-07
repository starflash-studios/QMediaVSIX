// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DropDownButtonAutomationPeer
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
  /// <summary>Exposes DropDownButton types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IDropDownButtonAutomationPeerFactory), CompositionType.Public, 458752, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public class DropDownButtonAutomationPeer : 
    ButtonAutomationPeer,
    IDropDownButtonAutomationPeer,
    IExpandCollapseProvider
  {
    /// <summary>Initializes a new instance of the DropDownButtonAutomationPeer class.</summary>
    /// <param name="owner">The DropDownButton control instance to create the peer for.</param>
    [MethodImpl]
    public extern DropDownButtonAutomationPeer(DropDownButton owner);

    /// <summary>Gets the state, expanded or collapsed, of the control.</summary>
    /// <returns>A value of the enumeration.</returns>
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    /// <summary>Hides the control's drop down menu.</summary>
    [MethodImpl]
    public extern void Collapse();

    /// <summary>Displays the control's drop down menu.</summary>
    [MethodImpl]
    public extern void Expand();
  }
}
