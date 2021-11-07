// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ITreeViewListAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(16095202, 63505, 18266, 191, 230, 41, 15, 231, 7, 250, 136)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (TreeViewListAutomationPeer))]
  internal interface ITreeViewListAutomationPeerFactory
  {
    TreeViewListAutomationPeer CreateInstanceWithOwner(
      TreeViewList owner,
      object baseInterface,
      out object innerInterface);
  }
}
