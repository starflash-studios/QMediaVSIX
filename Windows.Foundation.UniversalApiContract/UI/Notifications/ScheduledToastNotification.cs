// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ScheduledToastNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Contains the XML that defines the toast notification that will display at the scheduled time.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IScheduledToastNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.MTA)]
  public sealed class ScheduledToastNotification : 
    IScheduledToastNotification,
    IScheduledToastNotification2,
    IScheduledToastNotification3,
    IScheduledToastNotification4
  {
    [MethodImpl]
    public extern ScheduledToastNotification(XmlDocument content, DateTime deliveryTime);

    [MethodImpl]
    public extern ScheduledToastNotification(
      XmlDocument content,
      DateTime deliveryTime,
      TimeSpan snoozeInterval,
      uint maximumSnoozeCount);

    /// <summary>Gets the XML that defines this scheduled toast notification.</summary>
    /// <returns>The object that contains the XML.</returns>
    public extern XmlDocument Content { [MethodImpl] get; }

    /// <summary>Gets the time that this toast notification is scheduled to be displayed.</summary>
    /// <returns>The time that this toast notification is scheduled to be displayed.</returns>
    public extern DateTime DeliveryTime { [MethodImpl] get; }

    /// <summary>Gets the amount of time between occurrences of the notification.</summary>
    /// <returns>The time between occurrences of the notification. This value will be between 60 seconds and 60 minutes, inclusive.</returns>
    public extern IReference<TimeSpan> SnoozeInterval { [MethodImpl] get; }

    /// <summary>Gets the maximum number of times to display this notification.</summary>
    /// <returns>The maximum number of times to display this notification. This will be a value between 1 and 5, inclusive.</returns>
    public extern uint MaximumSnoozeCount { [MethodImpl] get; }

    /// <summary>Gets a developer-specified value used to identify a specific scheduled toast.</summary>
    /// <returns>The identifier. This string is limited to 16 characters.</returns>
    public extern string Id { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a string that uniquely identifies a toast notification inside a Group.</summary>
    /// <returns>The unique identifier for this notification within a Group.</returns>
    public extern string Tag { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the group identifier for the notification.</summary>
    /// <returns>The group identifier for the notification.</returns>
    public extern string Group { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether a toast's pop-up UI is displayed on the user's screen.</summary>
    /// <returns>Set to **true** to suppress the popup message; otherwise, false. The default value is false, meaning the toast's pop-up message will be shown. Setting this property to **true** places the toast notification silently into the action center. This enables your app to communicate with the user without interrupting them.</returns>
    public extern bool SuppressPopup { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies whether notification mirroring is enabled. (Notification mirroring enables a notification to appear on multiple devices.)</summary>
    /// <returns>**true** to enable notification mirroring; otherwise, **false**.</returns>
    public extern NotificationMirroring NotificationMirroring { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a remote id for the notification that enables the system to correlate this notification with another one generated on another device.</summary>
    /// <returns>A remote id for the notification that enables the system to correlate this notification with another one generated on another device.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the expiration time of the notification.</summary>
    /// <returns>The expiration time of the notification.</returns>
    public extern IReference<DateTime> ExpirationTime { [MethodImpl] get; [MethodImpl] set; }
  }
}
