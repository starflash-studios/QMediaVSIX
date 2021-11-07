// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListBoxItemDataAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ListBoxItemDataAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3616689686, 48525, 18018, 169, 149, 32, 255, 154, 5, 96, 147)]
  internal interface IListBoxItemDataAutomationPeerFactory
  {
    ListBoxItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ListBoxAutomationPeer parent,
      object baseInterface,
      out object innerInterface);
  }
}
