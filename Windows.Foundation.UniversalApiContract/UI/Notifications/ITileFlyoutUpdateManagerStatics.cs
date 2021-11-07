// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileFlyoutUpdateManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(70662923, 6848, 19353, 136, 231, 173, 168, 62, 149, 61, 72)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TileFlyoutUpdateManager))]
  internal interface ITileFlyoutUpdateManagerStatics
  {
    [Overload("CreateTileFlyoutUpdaterForApplication")]
    TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication();

    [Overload("CreateTileFlyoutUpdaterForApplicationWithId")]
    TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication(string applicationId);

    TileFlyoutUpdater CreateTileFlyoutUpdaterForSecondaryTile(string tileId);

    XmlDocument GetTemplateContent(TileFlyoutTemplateType type);
  }
}
