﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTileFactory2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(659262011, 21037, 17550, 158, 178, 208, 103, 42, 179, 69, 200)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SecondaryTile))]
  internal interface ISecondaryTileFactory2 : ISecondaryTileFactory
  {
    SecondaryTile CreateMinimalTile(
      string tileId,
      string displayName,
      string arguments,
      Uri square150x150Logo,
      TileSize desiredSize);
  }
}