// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IUserNotificationChangedTriggerFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (UserNotificationChangedTrigger))]
  [Guid(3402908524, 27051, 19992, 164, 138, 94, 210, 172, 67, 89, 87)]
  internal interface IUserNotificationChangedTriggerFactory
  {
    UserNotificationChangedTrigger Create(
      NotificationKinds notificationKinds);
  }
}
