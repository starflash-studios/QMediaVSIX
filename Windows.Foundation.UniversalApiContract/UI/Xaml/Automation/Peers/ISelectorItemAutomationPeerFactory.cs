// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISelectorItemAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(1725427195, 30829, 17250, 169, 100, 235, 251, 33, 119, 108, 48)]
  [ExclusiveTo(typeof (SelectorItemAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectorItemAutomationPeerFactory
  {
    SelectorItemAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      SelectorAutomationPeer parent,
      object baseInterface,
      out object innerInterface);
  }
}
