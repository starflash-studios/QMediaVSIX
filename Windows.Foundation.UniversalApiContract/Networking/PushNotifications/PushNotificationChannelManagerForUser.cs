// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  /// <summary>Creates objects that you use to retrieve push notification channels from the Windows Push Notification Services (WNS). These channels are bound to the current user through an app or secondary tile.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class PushNotificationChannelManagerForUser : 
    IPushNotificationChannelManagerForUser,
    IPushNotificationChannelManagerForUser2
  {
    /// <summary>Creates an object, bound to the calling app, through which you retrieve a push notification channel from Windows Push Notification Services (WNS).</summary>
    /// <returns>The object, bound to the calling app, that is used to request a PushNotificationChannel from the Windows Push Notification Services (WNS).</returns>
    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsync")]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();

    /// <summary>Creates an object, bound to a specified app, through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the app to bind to the push notification channel. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>The object, bound to the app specified in *applicationId*, that is used to request a PushNotificationChannel from the Windows Push Notification Services (WNS).</returns>
    [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(
      string applicationId);

    /// <summary>Creates an object, bound to a secondary tile, through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The tile can be a secondary tile of the calling app or any other app in the same package.</summary>
    /// <param name="tileId">The ID of the secondary tile to bind to the push notification channel.</param>
    /// <returns>The object, bound to the secondary tile, that is used to request a PushNotificationChannel from the Windows Push Notification Services (WNS).</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(
      string tileId);

    /// <summary>Gets the user.</summary>
    /// <returns>The user.</returns>
    public extern User User { [MethodImpl] get; }

    /// <summary>Creates an object bound to a specified app through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app.</summary>
    /// <param name="appServerKey">An uncompressed key in ANSI X9.62 format. This value is from the P-256 curve defined in the Secure Hash Standard specification.</param>
    /// <param name="channelId">The ID of the push notification channel.</param>
    /// <returns>The object, bound to the app server specified in appServerKey, that is used to request a PushNotificationChannel from WNS.</returns>
    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId);

    /// <summary>Creates an object bound to a specified app through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app.</summary>
    /// <param name="appServerKey">An uncompressed key in ANSI X9.62 format. This value is from the P-256 curve defined in the Secure Hash Standard specification.</param>
    /// <param name="channelId">The ID of the push notification channel.</param>
    /// <param name="appId">The package-relative application identifier (PRAID) of the app to bind to the push notification channel. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>The object, bound to the app server specified in appServerKey, that is used to request a PushNotificationChannel from WNS.</returns>
    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsyncWithId")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId,
      string appId);
  }
}
