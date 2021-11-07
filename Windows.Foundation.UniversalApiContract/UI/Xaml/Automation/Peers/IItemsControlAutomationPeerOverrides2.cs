// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeerOverrides2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(907919592, 46447, 17897, 128, 254, 16, 160, 251, 15, 225, 119)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsControlAutomationPeer))]
  internal interface IItemsControlAutomationPeerOverrides2
  {
    ItemAutomationPeer OnCreateItemAutomationPeer(object item);
  }
}
