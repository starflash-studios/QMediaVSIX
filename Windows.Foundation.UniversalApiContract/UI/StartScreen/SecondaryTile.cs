// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.SecondaryTile
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.StartScreen
{
  /// <summary>Creates, enumerates, and provides information about a secondary tile.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ISecondaryTileFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  [Activatable(typeof (ISecondaryTileFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISecondaryTileStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SecondaryTile : ISecondaryTile, ISecondaryTile2
  {
    [MethodImpl]
    public extern SecondaryTile(
      string tileId,
      string displayName,
      string arguments,
      Uri square150x150Logo,
      TileSize desiredSize);

    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern SecondaryTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference);

    [Deprecated("SecondaryTile(string, string, string, string, Windows.UI.StartScreen.TileOptions, Windows.Foundation.Uri, Windows.Foundation.Uri) may be altered or unavailable for releases after Windows Phone 8.1. Instead, use SecondaryTile(string, string, string, Windows.Foundation.Uri, Windows.UI.StartScreen.TileSize).", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern SecondaryTile(
      string tileId,
      string shortName,
      string displayName,
      string arguments,
      TileOptions tileOptions,
      Uri logoReference,
      Uri wideLogoReference);

    /// <summary>Creates a SecondaryTile object with a specific ID. This form of the constructor should be used to create a secondary tile object to perform a tile update or deletion.</summary>
    /// <param name="tileId">A string that will uniquely identify the tile within your app. Choose a unique ID that is descriptive and meaningful to your app. If you provide the same ID as that of an existing secondary tile, the existing secondary tile will be overwritten.</param>
    [MethodImpl]
    public extern SecondaryTile(string tileId);

    /// <summary>Creates a SecondaryTile object. The caller must then set any mandatory properties through the object before attempting to pin, update, or delete the tile.</summary>
    [MethodImpl]
    public extern SecondaryTile();

    /// <summary>Gets or sets a unique string to identify the tile within the package. This property is required when you create or delete a tile.</summary>
    /// <returns>A unique identifier, meaningful to your app. It is limited to 64 characters and must begin with a number or letter and be composed of the characters a-z, A-Z, 0-9, period (.), or underscore (_). It cannot contain spaces, commas, or any of these characters: | &gt; &lt; " / ? * \ ; : ! '</returns>
    public extern string TileId { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets an app-defined set of information that is passed from the secondary tile to the app on activation. This property is required when you create a tile.</summary>
    /// <returns>The argument string, of 2048 or fewer characters. This contents of this string are understood by the app. Any string longer than 2048 characters will cause an exception to be thrown. This string is passed to the app through the LaunchActivatedEventArgs.Arguments property.</returns>
    public extern string Arguments { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a short name to display directly on the tile. </summary>
    /// <returns>The short name. Anything over 40 characters will be truncated. The user has the option to change this value as part of the pinning process.</returns>
    public extern string ShortName { [Deprecated("ShortName may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("ShortName may be altered or unavailable for releases after Windows 8.1. Instead, use DisplayName.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets a name that is associated with and displayed on the tile. This name is displayed on the tile in Start, in the tile's tooltip, next to the small tile representation in the **Apps** list, and in some Control Panel applications. This property is required when you create a tile. It is the equivalent of the display name declared in the manifest for the app's main tile. </summary>
    /// <returns>The display name. This string is limited to 256 characters, but in reality should be kept short to avoid truncation.</returns>
    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the logo image used in a medium tile. This property is required when you create either a square or a wide tile.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Logo { [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("Logo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square150x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the small logo image, used in search results, the All Programs list, and other locations in the UI.</summary>
    /// <returns>The location of the image. This must be expressed using this scheme: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri SmallLogo { [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("SmallLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Square30x30Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the logo image used in a wide secondary tile. This property is required when you create a wide secondary tile and gives the user the option of a wide tile when they resize the tile.</summary>
    /// <returns>The location of the image. This can be expressed using one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri WideLogo { [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("WideLogo may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.Wide310x150Logo.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the location of a badge logo image to represent the secondary tile on the lock screen. By supplying this image, you declare that the secondary tile is eligible to display a badge on the lock screen. If you also want the secondary tile to be eligible for the lock screen's detailed tile slot, you must also set the LockScreenDisplayBadgeAndTileText property to **True**.</summary>
    /// <returns>A Uniform Resource Identifier (URI) that specifies the logo image file location.</returns>
    public extern Uri LockScreenBadgeLogo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets whether the secondary tile is eligible to display both a badge and a detailed tile on the lock screen. If you set this property to **True**, you must also provide a badge image through the LockScreenBadgeLogo property. If you do not want to use the detailed tile capability, provide a badge image through the LockScreenBadgeLogo property and set LockScreenDisplayBadgeAndTileText to **False**.</summary>
    /// <returns>**True** if the secondary tile can have a lock screen presence; otherwise, **False**.</returns>
    public extern bool LockScreenDisplayBadgeAndTileText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets options available to a secondary tile.</summary>
    /// <returns>One or more enumeration values. See TileOptions for the full list of valid values.</returns>
    public extern TileOptions TileOptions { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets whether the tile should use dark or light text.</summary>
    /// <returns>One of the two values that specifies either the default dark or default light text.</returns>
    public extern ForegroundText ForegroundText { [Deprecated("TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ShowNameOnSquare150x150Logo, VisualElements.ShowNameOnWide310x150Logo, and RoamingEnabled.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("ForegroundText may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.ForegroundText.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the tile's background color.</summary>
    /// <returns>The background color.</returns>
    public extern Color BackgroundColor { [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("BackgroundColor may be altered or unavailable for releases after Windows 8.1. Instead, use VisualElements.BackgroundColor.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Displays the **Pin to Start**  flyout, through which the user can confirm that they want to create the secondary tile, which in turn creates the tile. Overloads of this method let you specify the on-screen location of the flyout.</summary>
    /// <returns>An object used to launch the asynchronous create operation as well as to retrieve information about it.</returns>
    [Overload("RequestCreateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateAsync();

    /// <summary>Displays the **Pin to Start**  flyout above a specified location, through which the user can confirm that they want to create the secondary tile, which in turn creates the tile.</summary>
    /// <param name="invocationPoint">The point used as the lower-right corner of the **Pin to Start**  flyout.</param>
    /// <returns>An object that provides information concerning the asynchronous create operation.</returns>
    [Overload("RequestCreateAsyncWithPoint")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateAsync(Point invocationPoint);

    /// <summary>Displays the **Pin to Start**  flyout above a specified area. This flyout is used by the user to confirm that they want to create the secondary tile, which in turn creates the tile.</summary>
    /// <param name="selection">The area that the flyout is displayed directly above.</param>
    /// <returns>An object that provides information concerning the asynchronous create operation.</returns>
    [Overload("RequestCreateAsyncWithRect")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateForSelectionAsync(Rect selection);

    /// <summary>Displays the **Pin to Start**  flyout at the specified side of a specified area. This flyout is used by the user to confirm that they want to create the secondary tile, which in turn creates the tile.</summary>
    /// <param name="selection">The area to one side of which the flyout will be displayed.</param>
    /// <param name="preferredPlacement">The side of the rectangle where the flyout should appear.</param>
    /// <returns>An object that provides information concerning the asynchronous create operation.</returns>
    [Overload("RequestCreateAsyncWithRectAndPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestCreateForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    /// <summary>Displays the **Unpin from Start**  flyout. This flyout lets the user confirm removal of the secondary tile.</summary>
    /// <returns>An object that provides information concerning the asynchronous delete operation.</returns>
    [Overload("RequestDeleteAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteAsync();

    /// <summary>Displays the **Unpin from Start**  flyout at a specified point. This flyout lets the user confirm removal of the secondary tile.</summary>
    /// <param name="invocationPoint">The point used as the lower-right corner of the **Pin to Start**  flyout.</param>
    /// <returns>An object that provides information concerning the asynchronous delete operation.</returns>
    [Overload("RequestDeleteAsyncWithPoint")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteAsync(Point invocationPoint);

    /// <summary>Displays the **Unpin from Start**  flyout above a specified area. This flyout lets the user confirm removal of the secondary tile.</summary>
    /// <param name="selection">The area that the secondary tile is displayed directly above.</param>
    /// <returns>An object that provides information concerning the asynchronous delete operation.</returns>
    [Overload("RequestDeleteAsyncWithRect")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteForSelectionAsync(Rect selection);

    /// <summary>Displays the **Unpin from Start**  flyout at the specified side of a specified area. This flyout lets the user confirm removal of the secondary tile.</summary>
    /// <param name="selection">The area to the side of which the flyout will be displayed.</param>
    /// <param name="preferredPlacement">One of the enumeration values that specifies the side of the rectangle where the flyout should be shown.</param>
    /// <returns>An object that provides information concerning the asynchronous delete operation.</returns>
    [Overload("RequestDeleteAsyncWithRectAndPlacement")]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestDeleteForSelectionAsync(
      Rect selection,
      Placement preferredPlacement);

    /// <summary>Updates a secondary tile after that tile is pinned to the Start screen.</summary>
    /// <returns>An object used to launch the asynchronous create operation as well as to retrieve information about it.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> UpdateAsync();

    /// <summary>Gets or sets a phonetic version of the secondary tile name. Used with character-based languages for UI sorting purposes.</summary>
    /// <returns>The phonetic name.</returns>
    public extern string PhoneticName { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets an object through which you can get or set a secondary tile's background color, foreground text, tile images, and app name display options. As of Windows 8.1, the properties of this object replace these SecondaryTile properties: </summary>
    /// <returns>An object that represents the secondary tile.</returns>
    public extern SecondaryTileVisualElements VisualElements { [MethodImpl] get; }

    /// <summary>Gets or sets a value that determines whether the secondary tile will be reacquired through the cloud when the parent app is installed by the user, using their Microsoft account, on another computer. Note that as of Windows 8.1, roaming is the default behavior. This is the opposite of the default Windows 8 behavior, where roaming was opt-in.</summary>
    /// <returns>Set to **true** if roaming is enabled; otherwise, **false**. The default is **true**. </returns>
    public extern bool RoamingEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Fired when a call is made to RequestCreateAsync.</summary>
    public extern event TypedEventHandler<SecondaryTile, VisualElementsRequestedEventArgs> VisualElementsRequested;

    /// <summary>Checks whether a specific secondary tile exists for the calling app.</summary>
    /// <param name="tileId">The unique ID string that was assigned to the tile when it was created.</param>
    /// <returns>**True** if the tile exists in the calling application; otherwise, **false**.</returns>
    [MethodImpl]
    public static extern bool Exists(string tileId);

    /// <summary>Retrieves a list of secondary tiles created for the calling app.</summary>
    /// <returns>An enumeration object that allows you to examine the set of tiles.</returns>
    [RemoteAsync]
    [Overload("FindAllAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync();

    /// <summary>Retrieves a list of secondary tiles created for another app in the same package as the calling app.</summary>
    /// <param name="applicationId">The package-relative application identifier (PRAID) of the app. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the Application element.</param>
    /// <returns>An enumeration object that allows you to examine the set of tiles.</returns>
    [Overload("FindAllForApplicationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryTile>> FindAllAsync(
      string applicationId);

    /// <summary>Retrieves a list of secondary tiles created for all of the apps in the package of the calling app.</summary>
    /// <returns>An enumeration object that allows you to examine the set of tiles.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<SecondaryTile>> FindAllForPackageAsync();
  }
}
