// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerStatics4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(3159625467, 30752, 23131, 156, 1, 180, 117, 127, 119, 64, 37)]
  [ExclusiveTo(typeof (PushNotificationChannelManager))]
  internal interface IPushNotificationChannelManagerStatics4
  {
    event EventHandler<PushNotificationChannelsRevokedEventArgs> ChannelsRevoked;
  }
}
