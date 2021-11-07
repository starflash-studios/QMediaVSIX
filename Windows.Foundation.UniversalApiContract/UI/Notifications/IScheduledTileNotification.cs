// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IScheduledTileNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ScheduledTileNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(180135637, 39388, 19576, 161, 28, 201, 231, 248, 109, 126, 247)]
  internal interface IScheduledTileNotification
  {
    XmlDocument Content { get; }

    DateTime DeliveryTime { get; }

    IReference<DateTime> ExpirationTime { set; get; }

    string Tag { set; get; }

    string Id { set; get; }
  }
}
