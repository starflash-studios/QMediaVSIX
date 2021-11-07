// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISettingsFlyoutAutomationPeerFactory
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
  [ExclusiveTo(typeof (SettingsFlyoutAutomationPeer))]
  [Guid(4182205117, 35348, 16612, 148, 167, 63, 51, 201, 34, 233, 69)]
  internal interface ISettingsFlyoutAutomationPeerFactory
  {
    SettingsFlyoutAutomationPeer CreateInstanceWithOwner(
      SettingsFlyout owner,
      object baseInterface,
      out object innerInterface);
  }
}
