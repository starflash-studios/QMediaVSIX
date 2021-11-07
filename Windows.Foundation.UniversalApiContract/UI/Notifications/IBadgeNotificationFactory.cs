// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeNotificationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (BadgeNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3992081870, 1560, 19801, 148, 138, 90, 97, 4, 12, 82, 249)]
  internal interface IBadgeNotificationFactory
  {
    BadgeNotification CreateBadgeNotification(XmlDocument content);
  }
}
