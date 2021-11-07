// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerStatics3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1191313150, 3806, 19007, 174, 120, 191, 164, 113, 73, 105, 37)]
  [ExclusiveTo(typeof (PushNotificationChannelManager))]
  internal interface IPushNotificationChannelManagerStatics3
  {
    PushNotificationChannelManagerForUser GetDefault();
  }
}
