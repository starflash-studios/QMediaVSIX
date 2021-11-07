// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewItemDataAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewItemDataAutomationPeer))]
  [WebHostHidden]
  [Guid(3504018107, 55061, 17699, 172, 192, 30, 16, 114, 216, 227, 43)]
  internal interface IListViewItemDataAutomationPeerFactory
  {
    ListViewItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ListViewBaseAutomationPeer parent,
      object baseInterface,
      out object innerInterface);
  }
}
