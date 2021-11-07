// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationChannelManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  /// <summary>Creates objects that you use to retrieve push notification channels from the Windows Push Notification Services (WNS). These channels are bound to an app or secondary tile.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPushNotificationChannelManagerStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPushNotificationChannelManagerStatics4), 655360, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPushNotificationChannelManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPushNotificationChannelManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public static class PushNotificationChannelManager
  {
    /// <summary>Raised when your push channel is revoked, so that you can immediately request a new channel. This minimizes any downtime resulting from using a revoked WNS channel. The event arguments type is PushNotificationChannelsRevokedEventArgs.</summary>
    public static extern event EventHandler<PushNotificationChannelsRevokedEventArgs> ChannelsRevoked;

    /// <summary>Gets the manager for the active user.</summary>
    /// <returns>A PushNotificationChannelManagerForUser object.</returns>
    [MethodImpl]
    public static extern PushNotificationChannelManagerForUser GetDefault();

    /// <summary>Gets the push notifications for the specified user.</summary>
    /// <param name="user">The user account for the push notifications.</param>
    /// <returns>A PushNotificationChannelManagerForUser object.</returns>
    [MethodImpl]
    public static extern PushNotificationChannelManagerForUser GetForUser(
      User user);

    /// <summary>Creates an object, bound to the calling app, through which you retrieve a push notification channel from Windows Push Notification Services (WNS).</summary>
    /// <returns>The object, bound to the calling app, that is used to request a PushNotificationChannel from the Windows Push Notification Services (WNS).</returns>
    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();

    /// <summary>Creates an object, bound to a specified app, through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app. This overload should only be called from a multi-app package, most apps should use the method with no parameter.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the app to bind to the push notification channel. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>The object, bound to the app specified in *applicationId*, that is used to request a PushNotificationChannel from the Windows Push Notification Services (WNS).</returns>
    [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(
      string applicationId);

    /// <summary>Creates an object, bound to a secondary tile, through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The tile can be a secondary tile of the calling app or any other app in the same package.</summary>
    /// <param name="tileId">The ID of the secondary tile to bind to the push notification channel.</param>
    /// <returns>The object, bound to the secondary tile, that is used to request a PushNotificationChannel from the Windows Push Notification Services (WNS).</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(
      string tileId);
  }
}
