// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.RatingControlAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes **RatingControl ** types to Microsoft UI Automation.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IRatingControlAutomationPeerFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class RatingControlAutomationPeer : 
    FrameworkElementAutomationPeer,
    IRatingControlAutomationPeer
  {
    /// <summary>Initializes a new instance of the **RatingControlAutomationPeer** class.</summary>
    /// <param name="owner">The **RatingControl ** control instance to create the peer for.</param>
    [MethodImpl]
    public extern RatingControlAutomationPeer(RatingControl owner);
  }
}
