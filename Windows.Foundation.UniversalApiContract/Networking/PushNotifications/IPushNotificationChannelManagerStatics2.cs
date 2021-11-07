// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  [Guid(3024397917, 42985, 19240, 149, 14, 243, 117, 169, 7, 249, 223)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PushNotificationChannelManager))]
  internal interface IPushNotificationChannelManagerStatics2
  {
    PushNotificationChannelManagerForUser GetForUser(User user);
  }
}
