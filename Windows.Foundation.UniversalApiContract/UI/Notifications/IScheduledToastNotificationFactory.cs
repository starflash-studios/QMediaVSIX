// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotificationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3888042385, 3001, 16777, 131, 148, 49, 118, 27, 71, 111, 215)]
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  internal interface IScheduledToastNotificationFactory
  {
    ScheduledToastNotification CreateScheduledToastNotification(
      XmlDocument content,
      DateTime deliveryTime);

    ScheduledToastNotification CreateScheduledToastNotificationRecurring(
      XmlDocument content,
      DateTime deliveryTime,
      TimeSpan snoozeInterval,
      uint maximumSnoozeCount);
  }
}
