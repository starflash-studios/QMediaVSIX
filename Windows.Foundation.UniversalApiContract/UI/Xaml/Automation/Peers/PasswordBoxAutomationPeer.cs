// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.PasswordBoxAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes PasswordBox types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IPasswordBoxAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class PasswordBoxAutomationPeer : FrameworkElementAutomationPeer, IPasswordBoxAutomationPeer
  {
    /// <summary>Initializes a new instance of the PasswordBoxAutomationPeer class.</summary>
    /// <param name="owner">The PasswordBox to create a peer for.</param>
    [MethodImpl]
    public extern PasswordBoxAutomationPeer(PasswordBox owner);
  }
}
