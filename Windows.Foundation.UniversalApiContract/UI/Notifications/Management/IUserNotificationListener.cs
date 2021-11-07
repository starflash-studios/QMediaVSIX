// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Management.IUserNotificationListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications.Management
{
  [ExclusiveTo(typeof (UserNotificationListener))]
  [Guid(1649753665, 35334, 19695, 130, 21, 96, 51, 165, 190, 75, 3)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserNotificationListener
  {
    [RemoteAsync]
    IAsyncOperation<UserNotificationListenerAccessStatus> RequestAccessAsync();

    UserNotificationListenerAccessStatus GetAccessStatus();

    event TypedEventHandler<UserNotificationListener, UserNotificationChangedEventArgs> NotificationChanged;

    [RemoteAsync]
    IAsyncOperation<IVectorView<UserNotification>> GetNotificationsAsync(
      NotificationKinds kinds);

    UserNotification GetNotification(uint notificationId);

    void ClearNotifications();

    void RemoveNotification(uint notificationId);
  }
}
