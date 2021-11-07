// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapTileSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a source of tiles to overlay on the MapControl.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapTileSourceStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IMapTileSourceFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapTileSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class MapTileSource : DependencyObject, IMapTileSource, IMapTileSource2
  {
    /// <summary>Initializes a new instance of the MapTileSource class.</summary>
    [MethodImpl]
    public extern MapTileSource();

    /// <summary>Initializes a new instance of the MapTileSource class with the specified data source.</summary>
    /// <param name="dataSource">The data source to use for the tiles.</param>
    [MethodImpl]
    public extern MapTileSource(MapTileDataSource dataSource);

    /// <summary>Initializes a new instance of the MapTileSource class with the specified data source and zoom level range.</summary>
    /// <param name="dataSource">The data source to use for the tiles.</param>
    /// <param name="zoomLevelRange">The zoom level range for the tiles.</param>
    [MethodImpl]
    public extern MapTileSource(MapTileDataSource dataSource, MapZoomLevelRange zoomLevelRange);

    /// <summary>Initializes a new instance of the MapTileSource class with the specified data source, zoom level range, and bounding rectangle.</summary>
    /// <param name="dataSource">The data source to use for the tiles.</param>
    /// <param name="zoomLevelRange">The zoom level range for the tiles.</param>
    /// <param name="bounds">The geographic area of tiles requested.</param>
    [MethodImpl]
    public extern MapTileSource(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds);

    /// <summary>Initializes a new instance of the MapTileSource class with the specified data source, zoom level range, bounding rectangle, and tile size.</summary>
    /// <param name="dataSource">The data source to use for the tiles.</param>
    /// <param name="zoomLevelRange">The zoom level range for the tiles.</param>
    /// <param name="bounds">The geographic area of tiles requested.</param>
    /// <param name="tileSizeInPixels">The size of individual square tiles in pixels.</param>
    [MethodImpl]
    public extern MapTileSource(
      MapTileDataSource dataSource,
      MapZoomLevelRange zoomLevelRange,
      GeoboundingBox bounds,
      int tileSizeInPixels);

    /// <summary>Gets or sets the data source for the tiles.</summary>
    /// <returns>The data source for the tiles.</returns>
    public extern MapTileDataSource DataSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the layer that contains the tiles.</summary>
    /// <returns>The layer that contains the tiles.</returns>
    public extern MapTileLayer Layer { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum and maximum zoom level of the tiles. Tiles are only visible when the ZoomLevel of the MapControl is within the ZoomLevelRange.</summary>
    /// <returns>The minimum and maximum zoom level of the tiles.</returns>
    public extern MapZoomLevelRange ZoomLevelRange { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rectangular area to contain the tiles.</summary>
    /// <returns>The rectangular area to contain the tiles.</returns>
    public extern GeoboundingBox Bounds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether to stretch the current tile while a higher-resolution tile is being downloaded.</summary>
    /// <returns>**true** to stretch the current tile while a higher-resolution tile is being downloaded; otherwise, **false**.</returns>
    public extern bool AllowOverstretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether fading is enabled for the tiles.</summary>
    /// <returns>**true** if fading is enabled for the tiles; otherwise, **false**.</returns>
    public extern bool IsFadingEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether transparency is enabled for the tiles.</summary>
    /// <returns>**true** if transparency is enabled for the tiles; otherwise, **false**.</returns>
    public extern bool IsTransparencyEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether retry is enabled for the tiles.</summary>
    /// <returns>**true** if retry is enabled for the tiles; otherwise, **false**.</returns>
    public extern bool IsRetryEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the z-index of the tiles.</summary>
    /// <returns>The z-index of the tiles.</returns>
    public extern int ZIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the size of the tiles in pixels.</summary>
    /// <returns>The size of the tiles in pixels.</returns>
    public extern int TilePixelSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the MapTileSource is visible.</summary>
    /// <returns>**true** if the MapTileSource is visible; otherwise, **false**.</returns>
    public extern bool Visible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the animation state of this MapTileSource to be displayed in the MapControl.</summary>
    /// <returns>The animation state of this MapTileSource.</returns>
    public extern MapTileAnimationState AnimationState { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether map tiles will begin playback automatically when this MapTileSource gets added to the TileSources property of the MapControl.</summary>
    /// <returns>**true** if playback is automatic; otherwise, **false**. The default is **true**.</returns>
    public extern bool AutoPlay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of frames in the animation of this MapTileSource.</summary>
    /// <returns>The number of frames in the animation of this MapTileSource.</returns>
    public extern int FrameCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time duration of each frame in the animation of this MapTileSource.</summary>
    /// <returns>The time duration of each frame in the animation of this MapTileSource.</returns>
    public extern TimeSpan FrameDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Pauses the animation at the current frame.</summary>
    [MethodImpl]
    public extern void Pause();

    /// <summary>Plays the animation from the current frame.</summary>
    [MethodImpl]
    public extern void Play();

    /// <summary>Stops and resets the animation to be played from the beginning.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Identifies the AnimationState dependency property.</summary>
    /// <returns>The identifier for the AnimationState dependency property.</returns>
    public static extern DependencyProperty AnimationStateProperty { [MethodImpl] get; }

    /// <summary>Identifies the AutoPlay dependency property.</summary>
    /// <returns>The identifier for the AutoPlay dependency property.</returns>
    public static extern DependencyProperty AutoPlayProperty { [MethodImpl] get; }

    /// <summary>Identifies the FrameCount dependency property.</summary>
    /// <returns>The identifier for the FrameCount dependency property.</returns>
    public static extern DependencyProperty FrameCountProperty { [MethodImpl] get; }

    /// <summary>Identifies the FrameDuration dependency property.</summary>
    /// <returns>The identifier for the FrameDuration dependency property.</returns>
    public static extern DependencyProperty FrameDurationProperty { [MethodImpl] get; }

    /// <summary>Identifies the DataSource dependency property.</summary>
    /// <returns>The identifier for the DataSource  dependency property.</returns>
    public static extern DependencyProperty DataSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the Layer dependency property.</summary>
    /// <returns>The identifier for the Layer dependency property.</returns>
    public static extern DependencyProperty LayerProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomLevelRange dependency property.</summary>
    /// <returns>The identifier for the ZoomLevelRange dependency property.</returns>
    public static extern DependencyProperty ZoomLevelRangeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Bounds dependency property.</summary>
    /// <returns>The identifier for the Bounds dependency property.</returns>
    public static extern DependencyProperty BoundsProperty { [MethodImpl] get; }

    /// <summary>Identifies the AllowOverstretch dependency property.</summary>
    /// <returns>The identifier for the AllowOverstretch dependency property.</returns>
    public static extern DependencyProperty AllowOverstretchProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsFadingEnabled dependency property.</summary>
    /// <returns>The identifier for the IsFadingEnabled dependency property.</returns>
    public static extern DependencyProperty IsFadingEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTransparencyEnabled dependency property.</summary>
    /// <returns>The identifier for the IsTransparencyEnabled dependency property.</returns>
    public static extern DependencyProperty IsTransparencyEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsRetryEnabled dependency property.</summary>
    /// <returns>The identifier for the IsRetryEnabled dependency property.</returns>
    public static extern DependencyProperty IsRetryEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZIndex dependency property.</summary>
    /// <returns>The identifier for the ZIndex dependency property.</returns>
    public static extern DependencyProperty ZIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the TilePixelSize dependency property.</summary>
    /// <returns>The identifier for the TilePixelSize dependency property.</returns>
    public static extern DependencyProperty TilePixelSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Visible dependency property.</summary>
    /// <returns>The identifier for the Visible dependency property.</returns>
    public static extern DependencyProperty VisibleProperty { [MethodImpl] get; }
  }
}
