// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IGridViewItemDataAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GridViewItemDataAutomationPeer))]
  [Guid(2791209608, 30477, 16428, 153, 111, 103, 80, 106, 242, 164, 175)]
  internal interface IGridViewItemDataAutomationPeerFactory
  {
    GridViewItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      GridViewAutomationPeer parent,
      object baseInterface,
      out object innerInterface);
  }
}
