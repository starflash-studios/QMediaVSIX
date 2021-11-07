// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Defines the content, associated metadata and events, and expiration time of a toast notification.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IToastNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ToastNotification : 
    IToastNotification,
    IToastNotification2,
    IToastNotification3,
    IToastNotification4,
    IToastNotification6
  {
    /// <summary>Creates and initializes a new instance of the ToastNotification.</summary>
    /// <param name="content">The XML content that defines the toast notification.</param>
    [MethodImpl]
    public extern ToastNotification(XmlDocument content);

    /// <summary>Gets the XML that defines the current toast notification.</summary>
    /// <returns>The object that contains the XML.</returns>
    public extern XmlDocument Content { [MethodImpl] get; }

    /// <summary>Gets or sets the time after which a toast notification should not be displayed.</summary>
    /// <returns>The date and time after which the toast is no longer considered current or valid and should not be displayed.</returns>
    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Occurs when a toast notification leaves the screen, either by expiring or being explicitly dismissed by the user. Apps that are running subscribe to this event.</summary>
    public extern event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed;

    /// <summary>Occurs when user activates a toast notification through a click or touch. Apps that are running subscribe to this event.</summary>
    public extern event TypedEventHandler<ToastNotification, object> Activated;

    /// <summary>Occurs when an error is caused when Windows attempts to raise a toast notification. Apps that are running subscribe to this event.</summary>
    public extern event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed;

    /// <summary>Gets or sets the unique identifier of this notification within the notification Group.</summary>
    /// <returns>Gets or sets the unique identifier of this notification within the notification Group.</returns>
    public extern string Tag { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the group identifier for the notification.</summary>
    /// <returns>The group identifier for the notification.</returns>
    public extern string Group { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether a toast's pop-up UI is displayed on the user's screen.</summary>
    /// <returns>Set to **true** to suppress the popup message; otherwise, false. The default value is false, meaning the toast's pop-up message will be shown. Setting this property to **true** places the toast notification silently into the action center. This enables your app to communicate with the user without interrupting them.</returns>
    public extern bool SuppressPopup { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies whether notification mirroring is allowed.</summary>
    /// <returns>A value that specifies whether notification mirroring is allowed.</returns>
    public extern NotificationMirroring NotificationMirroring { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a remote id for the notification that enables the system to correlate this notification with another one generated on another device.</summary>
    /// <returns>A remote id for the notification that enables the system to correlate this notification with another one generated on another device.</returns>
    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets additional information about the status of the toast notification.</summary>
    /// <returns>An object that provides additional information about the status of the toast notification, such as the progress of the action described by the notification.</returns>
    public extern NotificationData Data { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the priority of the toast notification.</summary>
    /// <returns>The priority of the toast notification.</returns>
    public extern ToastNotificationPriority Priority { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>
    /// </summary>
    /// <returns>
    /// </returns>
    public extern bool ExpiresOnReboot { [MethodImpl] get; [MethodImpl] set; }
  }
}
