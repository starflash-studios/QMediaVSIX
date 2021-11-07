// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutomationPeer7
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (AutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [Guid(2037068423, 58946, 18603, 178, 35, 82, 8, 180, 29, 169, 214)]
  internal interface IAutomationPeer7
  {
    void RaiseNotificationEvent(
      AutomationNotificationKind notificationKind,
      AutomationNotificationProcessing notificationProcessing,
      string displayString,
      string activityId);
  }
}
