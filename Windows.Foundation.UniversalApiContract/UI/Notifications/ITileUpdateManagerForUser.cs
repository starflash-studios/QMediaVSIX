// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ITileUpdateManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1427379016, 12002, 20013, 156, 193, 33, 106, 32, 222, 204, 159)]
  [ExclusiveTo(typeof (TileUpdateManagerForUser))]
  internal interface ITileUpdateManagerForUser
  {
    [Overload("CreateTileUpdaterForApplication")]
    TileUpdater CreateTileUpdaterForApplicationForUser();

    [Overload("CreateTileUpdaterForApplicationWithId")]
    TileUpdater CreateTileUpdaterForApplication(string applicationId);

    TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    User User { get; }
  }
}
