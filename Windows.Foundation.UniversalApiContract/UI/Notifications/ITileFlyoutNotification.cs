// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileFlyoutNotification
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (TileFlyoutNotification))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2589176417, 50956, 17086, 178, 243, 244, 42, 169, 125, 52, 229)]
  internal interface ITileFlyoutNotification
  {
    XmlDocument Content { get; }

    IReference<DateTime> ExpirationTime { set; get; }
  }
}
