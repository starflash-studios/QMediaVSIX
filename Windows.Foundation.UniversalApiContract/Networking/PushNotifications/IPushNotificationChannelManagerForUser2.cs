// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerForUser2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.PushNotifications
{
  [ExclusiveTo(typeof (PushNotificationChannelManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3280668266, 31937, 19884, 135, 253, 190, 110, 146, 4, 20, 164)]
  internal interface IPushNotificationChannelManagerForUser2
  {
    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync")]
    [RemoteAsync]
    IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId);

    [RemoteAsync]
    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsyncWithId")]
    IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId,
      string appId);
  }
}
