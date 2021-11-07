// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Raises a toast notification to the specific app to which the ToastNotifier is bound. This class also lets you schedule and remove toast notifications.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ToastNotifier : IToastNotifier, IToastNotifier2, IToastNotifier3
  {
    /// <summary>Displays the specified toast notification.</summary>
    /// <param name="notification">The object that contains the content of the toast notification to display.</param>
    [MethodImpl]
    public extern void Show(ToastNotification notification);

    /// <summary>Removes the specified toast notification from the screen.</summary>
    /// <param name="notification">The object that specifies the toast to hide.</param>
    [MethodImpl]
    public extern void Hide(ToastNotification notification);

    /// <summary>Gets a value that tells you whether there is an app, user, or system block that prevents the display of a toast notification.</summary>
    /// <returns>**Enabled** if the toast can be shown; otherwise, one or more reasons that the toast will be blocked.</returns>
    public extern NotificationSetting Setting { [MethodImpl] get; }

    /// <summary>Adds a ScheduledToastNotification for later display by Windows.</summary>
    /// <param name="scheduledToast">The scheduled toast notification, which includes its content and timing instructions.</param>
    [MethodImpl]
    public extern void AddToSchedule(ScheduledToastNotification scheduledToast);

    /// <summary>Cancels the scheduled display of a specified ScheduledToastNotification.</summary>
    /// <param name="scheduledToast">The notification to remove from the schedule.</param>
    [MethodImpl]
    public extern void RemoveFromSchedule(ScheduledToastNotification scheduledToast);

    /// <summary>Gets the collection of ScheduledToastNotification objects that this app has scheduled for display.</summary>
    /// <returns>The collection of scheduled toast notifications that the app bound to this notifier has scheduled for timed display.</returns>
    [MethodImpl]
    public extern IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();

    /// <summary>Updates the existing toast notification that has the specified tag and belongs to the specified notification group.</summary>
    /// <param name="data">An object that contains the updated info.</param>
    /// <param name="tag">The identifier of the toast notification to update.</param>
    /// <param name="group">The ID of the ToastCollection that contains the notification.</param>
    /// <returns>A value that indicates the result of the update (failure, success, etc).</returns>
    [Overload("UpdateWithTagAndGroup")]
    [MethodImpl]
    public extern NotificationUpdateResult Update(
      NotificationData data,
      string tag,
      string group);

    /// <summary>Updates the existing toast notification that has the specified tag.</summary>
    /// <param name="data">An object that contains the updated info.</param>
    /// <param name="tag">The identifier of the toast notification to update.</param>
    /// <returns>A value that indicates the result of the update (failure, success, etc).</returns>
    [Overload("UpdateWithTag")]
    [MethodImpl]
    public extern NotificationUpdateResult Update(
      NotificationData data,
      string tag);

    /// <summary>Occurs when the system shows the scheduled toast notification.</summary>
    public extern event TypedEventHandler<ToastNotifier, ScheduledToastNotificationShowingEventArgs> ScheduledToastNotificationShowing;
  }
}
