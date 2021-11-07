// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationHistory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Manages the toast notifications for an app including the ability the clear all toast history and removing individual toasts.</summary>
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ToastNotificationHistory : 
    IToastNotificationHistory2,
    IToastNotificationHistory
  {
    /// <summary>Gets notification history, for all notifications sent by this app, from action center.</summary>
    /// <returns>A collection of toasts.</returns>
    [Overload("GetHistory")]
    [MethodImpl]
    public extern IVectorView<ToastNotification> GetHistory();

    /// <summary>Gets notification history, for a toast with the specified tag label, from action center.</summary>
    /// <param name="applicationId">The tag label for the toast being queried-for.</param>
    /// <returns>A collection of toasts.</returns>
    [Overload("GetHistoryWithId")]
    [MethodImpl]
    public extern IVectorView<ToastNotification> GetHistory(
      string applicationId);

    /// <summary>Removes a group of toast notifications, identified by the specified group label, from action center.</summary>
    /// <param name="group">The group label of the toast notifications to be removed.</param>
    [Overload("RemoveGroup")]
    [MethodImpl]
    public extern void RemoveGroup(string group);

    /// <summary>Removes a group of toast notifications sent by the another app inside the same app package from action center using the group label.</summary>
    /// <param name="group">The group label of the toast notifications to be removed.</param>
    /// <param name="applicationId">The app ID of the app within the same app package of the calling app.</param>
    [Overload("RemoveGroupWithId")]
    [MethodImpl]
    public extern void RemoveGroup(string group, string applicationId);

    /// <summary>Removes an individual toast notification from action center, identified by the combination of tag label, group label and app ID.</summary>
    /// <param name="tag">The tag label of the toast notification to be removed.</param>
    /// <param name="group">The group label of the toast notification to be removed.</param>
    /// <param name="applicationId">The app ID of the app that sent the specified toast notification. This app must be part of the same app package as the app making this remove request.</param>
    [Overload("RemoveGroupedTagWithId")]
    [MethodImpl]
    public extern void Remove(string tag, string group, string applicationId);

    /// <summary>Removes a toast notification from the action using the notification's tag and group labels.</summary>
    /// <param name="tag">The tag label of the toast notification to be removed.</param>
    /// <param name="group">The group label of the toast notification to be removed.</param>
    [Overload("RemoveGroupedTag")]
    [MethodImpl]
    public extern void Remove(string tag, string group);

    /// <summary>Removes an individual toast, with the specified tag label, from action center.</summary>
    /// <param name="tag">The tag label of the toast notification to be removed.</param>
    [Overload("Remove")]
    [MethodImpl]
    public extern void Remove(string tag);

    /// <summary>Removes all notifications sent by this app from action center.</summary>
    [Overload("Clear")]
    [MethodImpl]
    public extern void Clear();

    /// <summary>Removes all notifications from action center that were sent by another app inside the same app package.</summary>
    /// <param name="applicationId">The ID of the app inside the app package whose notifications are to be deleted.</param>
    [Overload("ClearWithId")]
    [MethodImpl]
    public extern void Clear(string applicationId);
  }
}
