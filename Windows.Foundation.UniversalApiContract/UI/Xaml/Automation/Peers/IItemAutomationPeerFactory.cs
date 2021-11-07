// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IItemAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ItemAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(688279667, 56893, 19775, 151, 180, 77, 111, 157, 83, 68, 77)]
  internal interface IItemAutomationPeerFactory
  {
    ItemAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ItemsControlAutomationPeer parent,
      object baseInterface,
      out object innerInterface);
  }
}
