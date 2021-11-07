// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotifier
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotifier))]
  [Guid(1972534163, 1011, 16876, 145, 211, 110, 91, 172, 27, 56, 231)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotifier
  {
    void Show(ToastNotification notification);

    void Hide(ToastNotification notification);

    NotificationSetting Setting { get; }

    void AddToSchedule(ScheduledToastNotification scheduledToast);

    void RemoveFromSchedule(ScheduledToastNotification scheduledToast);

    IVectorView<ScheduledToastNotification> GetScheduledToastNotifications();
  }
}
