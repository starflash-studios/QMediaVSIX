// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFlipViewItemAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(1762693974, 53477, 19472, 160, 156, 173, 11, 241, 176, 203, 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FlipViewItemAutomationPeer))]
  internal interface IFlipViewItemAutomationPeerFactory
  {
    FlipViewItemAutomationPeer CreateInstanceWithOwner(
      FlipViewItem owner,
      object baseInterface,
      out object innerInterface);
  }
}
