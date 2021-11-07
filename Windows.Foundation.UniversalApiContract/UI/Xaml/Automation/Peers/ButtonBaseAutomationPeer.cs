// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ButtonBaseAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Represents a base class for exposing classes derived from ButtonBase to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IButtonBaseAutomationPeerFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class ButtonBaseAutomationPeer : FrameworkElementAutomationPeer, IButtonBaseAutomationPeer
  {
    /// <summary>Provides base class initialization behavior for ButtonBase derived classes.</summary>
    /// <param name="owner">The owner element to create for.</param>
    [MethodImpl]
    protected extern ButtonBaseAutomationPeer(ButtonBase owner);
  }
}
