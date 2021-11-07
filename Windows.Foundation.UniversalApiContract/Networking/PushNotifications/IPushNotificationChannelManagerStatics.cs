// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [Guid(2343541605, 30625, 17800, 189, 25, 134, 21, 41, 169, 220, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PushNotificationChannelManager))]
  internal interface IPushNotificationChannelManagerStatics
  {
    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsync")]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();

    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(
      string applicationId);

    [RemoteAsync]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(
      string tileId);
  }
}
