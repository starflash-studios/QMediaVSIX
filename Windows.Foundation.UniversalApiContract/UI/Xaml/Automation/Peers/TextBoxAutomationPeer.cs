// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.TextBoxAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes TextBox types to Microsoft UI Automation.</summary>
  [Composable(typeof (ITextBoxAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class TextBoxAutomationPeer : FrameworkElementAutomationPeer, ITextBoxAutomationPeer
  {
    /// <summary>Initializes a new instance of the TextBoxAutomationPeer class.</summary>
    /// <param name="owner">The TextBox to create a peer for.</param>
    [MethodImpl]
    public extern TextBoxAutomationPeer(TextBox owner);
  }
}
