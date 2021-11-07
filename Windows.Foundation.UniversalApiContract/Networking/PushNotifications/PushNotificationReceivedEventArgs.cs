// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Networking.PushNotifications
{
  /// <summary>Encapsulates a push notification that has been received from the app server, identifying the type and supplying the content of the notification. Windows passes this information in the PushNotificationReceived event.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PushNotificationReceivedEventArgs : IPushNotificationReceivedEventArgs
  {
    /// <summary>Gets or sets whether Windows should perform its default handling of the notification.</summary>
    /// <returns>True to prevent default processing of the notification by Windows, otherwise false. The default value is false.</returns>
    public extern bool Cancel { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the type of push notification that has been received from the app server.</summary>
    /// <returns>The type (badge, tile, toast, or raw) of push notification that has been received.</returns>
    public extern PushNotificationType NotificationType { [MethodImpl] get; }

    /// <summary>Gets the content of a toast to display in response to this push notification.</summary>
    /// <returns>Holds the toast information. If NotificationType is not of type **Toast**, this value is **NULL**.</returns>
    public extern ToastNotification ToastNotification { [MethodImpl] get; }

    /// <summary>Gets the content of a tile update to perform in response to this push notification.</summary>
    /// <returns>Holds the update information. If NotificationType is not of type **Tile**, this value is **NULL**.</returns>
    public extern TileNotification TileNotification { [MethodImpl] get; }

    /// <summary>Gets the content of a badge update to perform in response to this push notification.</summary>
    /// <returns>Holds the update information. If NotificationType is not of type **Badge**, this value is **NULL**.</returns>
    public extern BadgeNotification BadgeNotification { [MethodImpl] get; }

    /// <summary>Gets the app-defined content contained in this push notification, the contents of which are used to perform a background task on the app.</summary>
    /// <returns>Encapsulates the app-defined content of the raw notification. If NotificationType is not of type **Raw**, this value is **NULL**.</returns>
    public extern RawNotification RawNotification { [MethodImpl] get; }
  }
}
