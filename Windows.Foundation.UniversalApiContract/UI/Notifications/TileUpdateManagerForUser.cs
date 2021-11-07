// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileUpdateManagerForUser
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  /// <summary>Creates TileUpdater objects used to change and update **Start** menu tiles for a specific user. This class also provides access to the XML content of the system-provided tile templates so that you can customize that content for use in updating your tiles.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class TileUpdateManagerForUser : ITileUpdateManagerForUser
  {
    /// <summary>Creates and initializes a new instance of the TileUpdater, which lets you change the appearance of the calling app's tile for the bound user.</summary>
    /// <returns>The object you will use to send changes to the app's tile for the current user.</returns>
    [Overload("CreateTileUpdaterForApplication")]
    [MethodImpl]
    public extern TileUpdater CreateTileUpdaterForApplicationForUser();

    /// <summary>Creates a new TileUpdater for a tile for the bound user. The tile can belong to the calling app or any other app in the same package. The TileUpdater lets a developer change the appearance of that tile.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the tile. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>The object you will use to send changes to the tile identified by *applicationId*.</returns>
    [Overload("CreateTileUpdaterForApplicationWithId")]
    [MethodImpl]
    public extern TileUpdater CreateTileUpdaterForApplication(string applicationId);

    /// <summary>Creates a new TileUpdater, which enables you to change the appearance of a secondary tile for the bound user. The tile can belong to the calling app or any other app in the same package.</summary>
    /// <param name="tileId">A unique ID for the tile.</param>
    /// <returns>The object you will use to send updates to the tile identified by *tileID*.</returns>
    [MethodImpl]
    public extern TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    /// <summary>Gets the user that receives the toast notifications created by this object.</summary>
    /// <returns>The user that receives the toast notifications created by this object.</returns>
    public extern User User { [MethodImpl] get; }
  }
}
