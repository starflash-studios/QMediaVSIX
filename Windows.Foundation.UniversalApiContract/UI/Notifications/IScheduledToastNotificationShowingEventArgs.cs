// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotificationShowingEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ScheduledToastNotificationShowingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(1634989748, 16682, 24108, 166, 237, 160, 32, 154, 239, 154, 9)]
  internal interface IScheduledToastNotificationShowingEventArgs
  {
    bool Cancel { get; set; }

    ScheduledToastNotification ScheduledToastNotification { get; }

    Deferral GetDeferral();
  }
}
