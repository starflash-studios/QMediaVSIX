// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.TileFlyoutUpdateManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  /// <summary>Creates TileFlyoutUpdater objects specific to an app's primary or secondary tile, for use with a tile flyout (mix view) notification. This class also enables you to retrieve a blank tile flyout XML template to which you can add your content to define the tile flyout notification.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ITileFlyoutUpdateManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class TileFlyoutUpdateManager
  {
    /// <summary>Creates a new TileFlyoutUpdater object for the calling app's tile, for use with a tile flyout (mix view) notification.</summary>
    /// <returns>An object that you can use to send notification updates to the calling app's tile flyout, clear the flyout notification, and start and stop [periodic](https://docs.microsoft.com/previous-versions/windows/apps/jj150587(v=win.10)) flyout notifications.</returns>
    [Overload("CreateTileFlyoutUpdaterForApplication")]
    [MethodImpl]
    public static extern TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication();

    /// <summary>Creates a new TileFlyoutUpdater object for a specified tile, for use with a tile flyout (mix view) notification. Because this method overload uses a tile ID, this tile can belong to another app in the same package as the calling app.</summary>
    /// <param name="applicationId">The ID of the app.</param>
    /// <returns>An object that you can use to send notification updates to the tile flyout for the specified app, clear the flyout notification, and start and stop [periodic](https://docs.microsoft.com/previous-versions/windows/apps/jj150587(v=win.10)) flyout notifications.</returns>
    [Overload("CreateTileFlyoutUpdaterForApplicationWithId")]
    [MethodImpl]
    public static extern TileFlyoutUpdater CreateTileFlyoutUpdaterForApplication(
      string applicationId);

    /// <summary>Creates a new TileFlyoutUpdater object for one of an app's secondary tiles, for use with a tile flyout (mix view) notification.</summary>
    /// <param name="tileId">The secondary tile's ID, assigned to the secondary tile when it was created.</param>
    /// <returns>An object that you can use to send notification updates to the secondary tile's flyout, clear the flyout notification, and start and stop [periodic](https://docs.microsoft.com/previous-versions/windows/apps/jj150587(v=win.10)) flyout notifications.</returns>
    [MethodImpl]
    public static extern TileFlyoutUpdater CreateTileFlyoutUpdaterForSecondaryTile(
      string tileId);

    /// <summary>Gets a blank XML template content that defines a tile flyout (mix view) notification. You can then fill in this template as needed, using Document Object Model (DOM)  API.</summary>
    /// <param name="type">The specific template. At this time, the only valid value is **TileFlyoutTemplate01**.</param>
    /// <returns>The template's content represented as an XmlDocument object.</returns>
    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(TileFlyoutTemplateType type);
  }
}
