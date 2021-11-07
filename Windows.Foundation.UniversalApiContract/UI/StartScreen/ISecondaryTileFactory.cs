// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTile))]
  [Guid(1475685536, 20924, 19135, 142, 191, 98, 122, 3, 152, 176, 90)]
  internal interface ISecondaryTileFactory
  {
    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    SecondaryTile CreateTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference);

    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    SecondaryTile CreateWideTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference,
      Uri wideLogoReference);

    SecondaryTile CreateWithId(string tileId);
  }
}
