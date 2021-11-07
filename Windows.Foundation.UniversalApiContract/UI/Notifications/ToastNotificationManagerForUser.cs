// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  /// <summary>Creates ToastNotifier objects that you use to raise toast notifications for the bound user. This class also provides access to the XML content of the system-provided toast templates so that you can customize that content for use in your notifications.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class ToastNotificationManagerForUser : 
    IToastNotificationManagerForUser,
    IToastNotificationManagerForUser2
  {
    /// <summary>Creates a new ToastNotifier for the calling application and the bound user that lets you raise a toast notification.</summary>
    /// <returns>The object you will use to send the toast notification to the app for the bound user.</returns>
    [Overload("CreateToastNotifier")]
    [MethodImpl]
    public extern ToastNotifier CreateToastNotifier();

    /// <summary>Creates a new ToastNotification for the bound user and the specified app, usually another app in the same package.</summary>
    /// <param name="applicationId">The unique ID of the app.</param>
    /// <returns>The object you will use to send the toast notification to the tile.</returns>
    [Overload("CreateToastNotifierWithId")]
    [MethodImpl]
    public extern ToastNotifier CreateToastNotifier(string applicationId);

    /// <summary>Gets the ToastNotificationHistory object.</summary>
    /// <returns>The ToastNotificationHistory object.</returns>
    public extern ToastNotificationHistory History { [MethodImpl] get; }

    /// <summary>Gets the user that receives the toast notifications created by this object.</summary>
    /// <returns>The user that receives the toast notifications created by this object.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Creates a new ToastNotification for the bound user and app for the specified notification group.</summary>
    /// <param name="collectionId">The ID of the ToastNotificationCollection that represents the notification group you want to send.</param>
    /// <returns>The object you will use to send the toast notifications.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ToastNotifier> GetToastNotifierForToastCollectionIdAsync(
      string collectionId);

    /// <summary>Starts the retrieval of notification history for the specified notification group.</summary>
    /// <param name="collectionId">The ID of the notification group whose history you want to retrieve.</param>
    /// <returns>An object that represents the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ToastNotificationHistory> GetHistoryForToastCollectionIdAsync(
      string collectionId);

    /// <summary>Creates a ToastCollectionManager that you can use to save, update, and clear notification groups for the current app.</summary>
    /// <returns>An object you can use to save, update, and clear notification groups.</returns>
    [Overload("GetToastCollectionManager")]
    [MethodImpl]
    public extern ToastCollectionManager GetToastCollectionManager();

    /// <summary>Creates a ToastCollectionManager that you can use to save, update, and clear notification groups for the specified app.</summary>
    /// <param name="appId">The ID of the app whose notification groups you want to manipulate.</param>
    /// <returns>An object you can use to save, update, and clear notification groups.</returns>
    [Overload("GetToastCollectionManagerWithAppId")]
    [MethodImpl]
    public extern ToastCollectionManager GetToastCollectionManager(
      string appId);
  }
}
