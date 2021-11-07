// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ITreeViewItemAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(1943242943, 7425, 16729, 130, 192, 43, 41, 150, 219, 253, 206)]
  [ExclusiveTo(typeof (TreeViewItemAutomationPeer))]
  internal interface ITreeViewItemAutomationPeerFactory
  {
    TreeViewItemAutomationPeer CreateInstanceWithOwner(
      TreeViewItem owner,
      object baseInterface,
      out object innerInterface);
  }
}
