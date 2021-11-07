// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFlyoutPresenterAutomationPeerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(4082111839, 35108, 17600, 186, 68, 101, 63, 231, 159, 30, 251)]
  [ExclusiveTo(typeof (FlyoutPresenterAutomationPeer))]
  internal interface IFlyoutPresenterAutomationPeerFactory
  {
    FlyoutPresenterAutomationPeer CreateInstanceWithOwner(
      FlyoutPresenter owner,
      object baseInterface,
      out object innerInterface);
  }
}
