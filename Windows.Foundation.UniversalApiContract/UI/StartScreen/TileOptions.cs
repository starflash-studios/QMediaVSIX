// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.TileOptions
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Specifies options available to a secondary tile.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TileOptions : uint
  {
    /// <summary>Default. Do not show the name on a secondary tile of any size.</summary>
    /// <deprecated type="deprecate">TileOptions.None may be altered or unavailable for release after Windows Phone 8.1.</deprecated>
    [Deprecated("TileOptions.None may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] None = 0,
    /// <summary>Display the name on the medium version of the tile.</summary>
    /// <deprecated type="deprecate">TileOptions.ShowNameOnLogo may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.VisualElements.ShowNameOnSquare150x150Logo.</deprecated>
    [Deprecated("TileOptions.ShowNameOnLogo may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.VisualElements.ShowNameOnSquare150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] ShowNameOnLogo = 1,
    /// <summary>Display the name on the wide version of the tile.</summary>
    /// <deprecated type="deprecate">TileOptions.ShowNameWideOnLogo may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.VisualElements.ShowNameOnWide310x150Logo.</deprecated>
    [Deprecated("TileOptions.ShowNameWideOnLogo may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.VisualElements.ShowNameOnWide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] ShowNameOnWideLogo = 2,
    /// <summary>The tile will be reacquired from the cloud when the parent app is installed by the user, using their Microsoft account, on another computer.</summary>
    /// <deprecated type="deprecate">TileOptions.CopyOnDeployment may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.RoamingEnabled to control roaming behavior.</deprecated>
    [Deprecated("TileOptions.CopyOnDeployment may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile.RoamingEnabled to control roaming behavior.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] CopyOnDeployment = 4,
  }
}
