// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledToastNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2046130168, 3559, 18637, 151, 64, 155, 55, 4, 144, 200, 56)]
  [ExclusiveTo(typeof (ScheduledToastNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScheduledToastNotification
  {
    XmlDocument Content { get; }

    DateTime DeliveryTime { get; }

    IReference<TimeSpan> SnoozeInterval { get; }

    uint MaximumSnoozeCount { get; }

    string Id { set; get; }
  }
}
