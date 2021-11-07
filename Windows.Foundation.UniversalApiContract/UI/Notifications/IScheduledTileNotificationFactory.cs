// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledTileNotificationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(864228234, 39104, 19515, 187, 214, 74, 99, 60, 124, 252, 41)]
  [ExclusiveTo(typeof (ScheduledTileNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScheduledTileNotificationFactory
  {
    ScheduledTileNotification CreateScheduledTileNotification(
      XmlDocument content,
      DateTime deliveryTime);
  }
}
