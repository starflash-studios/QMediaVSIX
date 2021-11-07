// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdateManagerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (TileUpdateManager))]
  [Guid(3658849885, 16041, 18822, 141, 132, 176, 157, 94, 18, 39, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITileUpdateManagerStatics
  {
    [Overload("CreateTileUpdaterForApplication")]
    TileUpdater CreateTileUpdaterForApplication();

    [Overload("CreateTileUpdaterForApplicationWithId")]
    TileUpdater CreateTileUpdaterForApplication(string applicationId);

    TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    XmlDocument GetTemplateContent(TileTemplateType type);
  }
}
