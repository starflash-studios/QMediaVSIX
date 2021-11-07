// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewItemAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3296590784, 64204, 16420, 167, 59, 23, 236, 78, 102, 38, 84)]
  [ExclusiveTo(typeof (ListViewItemAutomationPeer))]
  [WebHostHidden]
  internal interface IListViewItemAutomationPeerFactory
  {
    ListViewItemAutomationPeer CreateInstanceWithOwner(
      ListViewItem owner,
      object baseInterface,
      out object innerInterface);
  }
}
