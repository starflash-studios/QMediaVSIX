// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.Management.UserNotificationListener
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications.Management
{
  /// <summary>Reads and manages a user's notifications.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (IUserNotificationListenerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserNotificationListener : IUserNotificationListener
  {
    /// <summary>Requests the user's permission to manage notifications.</summary>
    /// <returns>A value that specifies whether the user chose to provide access to notification.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<UserNotificationListenerAccessStatus> RequestAccessAsync();

    /// <summary>Gets a value that indicates whether the UserNotificationListener has access to the user's notifications.</summary>
    /// <returns>A value that indicates whether the UserNotificationListener has access to the user's notifications.</returns>
    [MethodImpl]
    public extern UserNotificationListenerAccessStatus GetAccessStatus();

    /// <summary>Occurs when a notification is added or removed.</summary>
    public extern event TypedEventHandler<UserNotificationListener, UserNotificationChangedEventArgs> NotificationChanged;

    /// <summary>Asynchronously retrieves notifications that match the specified notification kind.</summary>
    /// <param name="kinds">The type of notification to retrieve.</param>
    /// <returns>A collection of notifications of the specified type.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<UserNotification>> GetNotificationsAsync(
      NotificationKinds kinds);

    /// <summary>Retrieves the specified notification.</summary>
    /// <param name="notificationId">The ID of the notification to retrieve.</param>
    /// <returns>The notification if it exists; otherwise, **null**.</returns>
    [MethodImpl]
    public extern UserNotification GetNotification(uint notificationId);

    /// <summary>Clears the notification.</summary>
    [MethodImpl]
    public extern void ClearNotifications();

    /// <summary>Removes the specified notification.</summary>
    /// <param name="notificationId">The ID of the notification to remove.</param>
    [MethodImpl]
    public extern void RemoveNotification(uint notificationId);

    /// <summary>Gets a UserNotificationListener for the current user.</summary>
    /// <returns>A UserNotificationListener for the current user.</returns>
    public static extern UserNotificationListener Current { [MethodImpl] get; }
  }
}
