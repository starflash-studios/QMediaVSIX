// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IToggleMenuFlyoutItemAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToggleMenuFlyoutItemAutomationPeer))]
  [Guid(2486586231, 36716, 18487, 170, 227, 148, 208, 16, 216, 209, 98)]
  internal interface IToggleMenuFlyoutItemAutomationPeerFactory
  {
    ToggleMenuFlyoutItemAutomationPeer CreateInstanceWithOwner(
      ToggleMenuFlyoutItem owner,
      object baseInterface,
      out object innerInterface);
  }
}
