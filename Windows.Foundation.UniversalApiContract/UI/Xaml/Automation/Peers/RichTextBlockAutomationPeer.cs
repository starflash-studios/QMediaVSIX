// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.RichTextBlockAutomationPeer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  /// <summary>Exposes RichTextBlock types to Microsoft UI Automation.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IRichTextBlockAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class RichTextBlockAutomationPeer : 
    FrameworkElementAutomationPeer,
    IRichTextBlockAutomationPeer
  {
    /// <summary>Initializes a new instance of the RichTextBlockAutomationPeer class.</summary>
    /// <param name="owner">The RichTextBlock to create a peer for.</param>
    [MethodImpl]
    public extern RichTextBlockAutomationPeer(RichTextBlock owner);
  }
}
