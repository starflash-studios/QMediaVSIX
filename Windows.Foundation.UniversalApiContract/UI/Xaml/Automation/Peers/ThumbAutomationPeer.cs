// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ThumbAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes Thumb types to Microsoft UI Automation.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IThumbAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class ThumbAutomationPeer : FrameworkElementAutomationPeer, IThumbAutomationPeer
  {
    /// <summary>Initializes a new instance of the ThumbAutomationPeer class.</summary>
    /// <param name="owner">The Thumb to create a peer for.</param>
    [MethodImpl]
    public extern ThumbAutomationPeer(Thumb owner);
  }
}
