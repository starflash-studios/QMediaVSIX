// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ItemsControlAutomationPeer))]
  [WebHostHidden]
  [Guid(3297610007, 38312, 18360, 165, 23, 191, 137, 26, 108, 3, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemsControlAutomationPeer2
  {
    ItemAutomationPeer CreateItemAutomationPeer(object item);
  }
}
