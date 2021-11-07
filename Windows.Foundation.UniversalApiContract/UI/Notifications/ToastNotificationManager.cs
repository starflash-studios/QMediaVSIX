// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  /// <summary>Creates ToastNotifier objects that you use to raise toast notifications. This class also provides access to the XML content of the system-provided toast templates so that you can customize that content for use in your notifications.</summary>
  [Static(typeof (IToastNotificationManagerStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IToastNotificationManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IToastNotificationManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (IToastNotificationManagerStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  public static class ToastNotificationManager
  {
    /// <summary>Gets a toast notification manager for the current user.</summary>
    /// <returns>A toast notification manager for the current user.</returns>
    [MethodImpl]
    public static extern ToastNotificationManagerForUser GetDefault();

    /// <summary>Gets a toast notification manager for the specified user.</summary>
    /// <param name="user">The user who will receive the toast notifications.</param>
    /// <returns>A object for creating toast notifications for the specified user.</returns>
    [MethodImpl]
    public static extern ToastNotificationManagerForUser GetForUser(
      User user);

    /// <summary>Specifies whether notification mirroring is allowed. Notification mirroring enables a notification to be broadcast on multiple devices.</summary>
    /// <param name="value">One of the enumeration values.</param>
    [MethodImpl]
    public static extern void ConfigureNotificationMirroring(NotificationMirroring value);

    /// <summary>Gets the ToastNotificationHistory object.</summary>
    /// <returns>The ToastNotificationHistory object.</returns>
    public static extern ToastNotificationHistory History { [MethodImpl] get; }

    /// <summary>Creates and initializes a new instance of the ToastNotification, bound to the calling application, that lets you raise a toast notification to that app.</summary>
    /// <returns>The object you will use to send the toast notification to the app.</returns>
    [Overload("CreateToastNotifier")]
    [MethodImpl]
    public static extern ToastNotifier CreateToastNotifier();

    /// <summary>Creates and initializes a new instance of the ToastNotification, bound to a specified app, usually another app in the same package.</summary>
    /// <param name="applicationId">The unique ID of the app.</param>
    /// <returns>The object you will use to send the toast notification to the tile.</returns>
    [Overload("CreateToastNotifierWithId")]
    [MethodImpl]
    public static extern ToastNotifier CreateToastNotifier(string applicationId);

    /// <summary>Gets the XML content of one of the predefined toast templates so that you can customize it for use in your notification.</summary>
    /// <param name="type">One of the system-provided toast templates.</param>
    /// <returns>The object that contains the template XML.</returns>
    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(ToastTemplateType type);
  }
}
