// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.SecondaryTileVisualElements
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  /// <summary>Contains properties through which you can get or set a secondary tile's background color, foreground text, tile images, and app name display options. The properties in this class replace these SecondaryTile properties: </summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Muse(Version = 100859904)]
  public sealed class SecondaryTileVisualElements : 
    ISecondaryTileVisualElements,
    ISecondaryTileVisualElements2,
    ISecondaryTileVisualElements3,
    ISecondaryTileVisualElements4
  {
    /// <summary>Gets or sets the square30x30 secondary tile image.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Square30x30Logo { [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("SecondaryTileVisualElements.Square30x30Logo may be altered or unavailable for release after Windows 10.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the small secondary tile image.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Square70x70Logo { [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; [Deprecated("SecondaryTileVisualElements.Square70x70Logo may be altered or unavailable for release after Windows Phone 8.1.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets or sets the medium secondary tile image.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Square150x150Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the wide secondary tile image.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Wide310x150Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the large secondary tile image.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Square310x310Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Specifies whether the tile should use dark or light text.</summary>
    /// <returns>One of the two values that specifies either the default dark or default light text.</returns>
    public extern ForegroundText ForegroundText { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the secondary tile's background color.</summary>
    /// <returns>The background color. Specify in #ffffff format. </returns>
    public extern Color BackgroundColor { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Specifies whether the display name should be shown on the medium secondary tile.</summary>
    /// <returns>**True** to show the display name on the tile; otherwise, **false**. The default value is **false**.</returns>
    public extern bool ShowNameOnSquare150x150Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Specifies whether the display name should be shown on the wide secondary tile.</summary>
    /// <returns>**True** to show the display name on the tile; otherwise, **false**. The default value is **false**.</returns>
    public extern bool ShowNameOnWide310x150Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Specifies whether the display name should be shown on the large secondary tile.</summary>
    /// <returns>**True** to dhow the display name on the tile; otherwise, **false**. The default value is **false**.</returns>
    public extern bool ShowNameOnSquare310x310Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the small secondary tile image.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Square71x71Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the square44x44 secondary tile image.</summary>
    /// <returns>The location of the image. This can be expressed as one of these schemes: &lt;termdeflist&gt;&lt;termdef&gt;&lt;name&gt;ms-appx:///&lt;/name&gt;A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.&lt;/termdef&gt;&lt;termdef&gt;&lt;name&gt;ms-appdata:///local/&lt;/name&gt;A file found in the per-user app storage.&lt;/termdef&gt;&lt;/termdeflist&gt;</returns>
    public extern Uri Square44x44Logo { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets an object representing a 3D model asset for use as an app launcher in the Windows Mixed Reality home environment.</summary>
    /// <returns>The mixed reality model.</returns>
    public extern TileMixedRealityModel MixedRealityModel { [MethodImpl] get; }
  }
}
