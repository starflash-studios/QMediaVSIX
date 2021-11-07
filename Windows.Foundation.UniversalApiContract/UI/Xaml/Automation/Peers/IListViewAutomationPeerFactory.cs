// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1710461300, 60066, 20036, 139, 230, 76, 202, 40, 205, 2, 136)]
  [ExclusiveTo(typeof (ListViewAutomationPeer))]
  [WebHostHidden]
  internal interface IListViewAutomationPeerFactory
  {
    ListViewAutomationPeer CreateInstanceWithOwner(
      ListView owner,
      object baseInterface,
      out object innerInterface);
  }
}
