// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3506855436, 14029, 18508, 185, 53, 10, 153, 183, 83, 207, 0)]
  [ExclusiveTo(typeof (PushNotificationReceivedEventArgs))]
  internal interface IPushNotificationReceivedEventArgs
  {
    bool Cancel { set; get; }

    PushNotificationType NotificationType { get; }

    ToastNotification ToastNotification { get; }

    TileNotification TileNotification { get; }

    BadgeNotification BadgeNotification { get; }

    RawNotification RawNotification { get; }
  }
}
