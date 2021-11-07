// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IGridViewItemAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (GridViewItemAutomationPeer))]
  [WebHostHidden]
  [Guid(4211000182, 61998, 18029, 145, 60, 174, 36, 204, 219, 22, 15)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridViewItemAutomationPeerFactory
  {
    GridViewItemAutomationPeer CreateInstanceWithOwner(
      GridViewItem owner,
      object baseInterface,
      out object innerInterface);
  }
}
