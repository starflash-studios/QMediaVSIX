// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotifier3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (ToastNotifier))]
  [Guid(2926944330, 15116, 20909, 183, 232, 176, 138, 182, 5, 37, 73)]
  internal interface IToastNotifier3
  {
    event TypedEventHandler<ToastNotifier, ScheduledToastNotificationShowingEventArgs> ScheduledToastNotificationShowing;
  }
}
