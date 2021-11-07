// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileUpdateManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  /// <summary>Creates TileUpdater objects used to change and update **Start** menu tiles. This class also provides access to the XML content of the system-provided tile templates so that you can customize that content for use in updating your tiles.</summary>
  [Static(typeof (ITileUpdateManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (ITileUpdateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class TileUpdateManager
  {
    /// <summary>Creates and initializes a new TileUpdateManagerForUser for the specified user, which lets you change the appearance or content of a tile for a specific user.</summary>
    /// <param name="user">The user who will receive the tile updates.</param>
    /// <returns>An object that will update tiles for the specified user.</returns>
    [MethodImpl]
    public static extern TileUpdateManagerForUser GetForUser(User user);

    /// <summary>Creates and initializes a new instance of the TileUpdater, which lets you change the appearance of the calling app's tile.</summary>
    /// <returns>The object you will use to send changes to the app's tile.</returns>
    [Overload("CreateTileUpdaterForApplication")]
    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForApplication();

    /// <summary>Creates and initializes a new instance of the TileUpdater for a tile that belongs to another app in the same package as the calling app. The TileUpdater lets a developer change the appearance of that tile.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the tile. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>The object you will use to send changes to the tile identified by *applicationId*.</returns>
    [Overload("CreateTileUpdaterForApplicationWithId")]
    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForApplication(string applicationId);

    /// <summary>Creates and initializes a new instance of the TileUpdater, which enables you to change the appearance of a secondary tile. The tile can belong to the calling app or any other app in the same package.</summary>
    /// <param name="tileId">A unique ID for the tile.</param>
    /// <returns>The object you will use to send updates to the tile identified by *tileID*.</returns>
    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForSecondaryTile(string tileId);

    /// <summary>Gets the XML content of one of the predefined tile templates so that you can customize it for a tile update.</summary>
    /// <param name="type">The name of the template.</param>
    /// <returns>The object that contains the XML.</returns>
    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(TileTemplateType type);
  }
}
