// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewBaseAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewBaseAutomationPeer))]
  [WebHostHidden]
  [Guid(1892926142, 35152, 17991, 147, 98, 253, 0, 47, 143, 248, 46)]
  internal interface IListViewBaseAutomationPeerFactory
  {
    ListViewBaseAutomationPeer CreateInstanceWithOwner(
      ListViewBase owner,
      object baseInterface,
      out object innerInterface);
  }
}
