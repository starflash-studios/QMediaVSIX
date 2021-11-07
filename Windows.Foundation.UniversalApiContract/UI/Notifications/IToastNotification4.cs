// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotification))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(353716533, 10474, 18215, 136, 233, 197, 134, 128, 226, 209, 24)]
  internal interface IToastNotification4
  {
    NotificationData Data { get; set; }

    ToastNotificationPriority Priority { get; set; }
  }
}
