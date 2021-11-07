// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileNotificationFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3333152110, 18728, 18120, 189, 191, 129, 160, 71, 222, 160, 212)]
  [ExclusiveTo(typeof (TileNotification))]
  internal interface ITileNotificationFactory
  {
    TileNotification CreateTileNotification(XmlDocument content);
  }
}
