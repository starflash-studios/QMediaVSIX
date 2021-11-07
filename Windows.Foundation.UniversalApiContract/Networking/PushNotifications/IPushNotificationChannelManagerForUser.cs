// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2764330756, 4482, 17095, 136, 144, 245, 99, 196, 137, 13, 196)]
  [ExclusiveTo(typeof (PushNotificationChannelManagerForUser))]
  internal interface IPushNotificationChannelManagerForUser
  {
    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsync")]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();

    [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
    [RemoteAsync]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(
      string applicationId);

    [RemoteAsync]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(
      string tileId);

    User User { get; }
  }
}
