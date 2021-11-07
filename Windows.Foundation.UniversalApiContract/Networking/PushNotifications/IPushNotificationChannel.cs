// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.PushNotifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(724045870, 61195, 20281, 155, 138, 163, 193, 148, 222, 112, 129)]
  [ExclusiveTo(typeof (PushNotificationChannel))]
  internal interface IPushNotificationChannel
  {
    string Uri { get; }

    DateTime ExpirationTime { get; }

    void Close();

    event TypedEventHandler<PushNotificationChannel, PushNotificationReceivedEventArgs> PushNotificationReceived;
  }
}
