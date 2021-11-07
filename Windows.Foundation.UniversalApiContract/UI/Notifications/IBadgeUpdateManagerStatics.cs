// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IBadgeUpdateManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(859836330, 28117, 16645, 174, 188, 155, 80, 252, 164, 146, 218)]
  [ExclusiveTo(typeof (BadgeUpdateManager))]
  internal interface IBadgeUpdateManagerStatics
  {
    [Overload("CreateBadgeUpdaterForApplication")]
    BadgeUpdater CreateBadgeUpdaterForApplication();

    [Overload("CreateBadgeUpdaterForApplicationWithId")]
    BadgeUpdater CreateBadgeUpdaterForApplication(string applicationId);

    BadgeUpdater CreateBadgeUpdaterForSecondaryTile(string tileId);

    XmlDocument GetTemplateContent(BadgeTemplateType type);
  }
}
