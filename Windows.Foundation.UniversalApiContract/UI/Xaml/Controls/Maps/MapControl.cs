// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapControl
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a symbolic or photorealistic map of the Earth.</summary>
  [Static(typeof (IMapControlStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics8), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics7), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics6), 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapControlStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Children")]
  [WebHostHidden]
  public sealed class MapControl : 
    Control,
    IMapControl,
    IMapControl2,
    IMapControl3,
    IMapControl4,
    IMapControl5,
    IMapControl6,
    IMapControl7,
    IMapControl8
  {
    /// <summary>Initializes a new instance of the MapControl class.</summary>
    [MethodImpl]
    public extern MapControl();

    /// <summary>Gets or sets the center of the map.</summary>
    /// <returns>The center of the map.</returns>
    public extern Geopoint Center { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of objects that are children of the MapControl.</summary>
    /// <returns>The collection of objects that are children of the MapControl.</returns>
    public extern IVector<DependencyObject> Children { [MethodImpl] get; }

    /// <summary>Gets or sets the color scheme of the map – for example, light or dark.</summary>
    /// <returns>The color scheme of the map – for example, light or dark.</returns>
    public extern MapColorScheme ColorScheme { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates by how many degrees you want the map to be tilted. Sometimes the desired pitch cannot be set.</summary>
    /// <returns>A value that indicates by how many degrees you want the map to be tilted. Sometimes the desired pitch cannot be set.</returns>
    public extern double DesiredPitch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the directional heading of the map in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</summary>
    /// <returns>The directional heading of the map in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</returns>
    public extern double Heading { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether 3D buildings are displayed on the map.</summary>
    /// <returns>**true** if 3D buildings are displayed on the map; otherwise, **false**.</returns>
    public extern bool LandmarksVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the loading status of the map to be displayed in the MapControl.</summary>
    /// <returns>The loading status of the map to be displayed in the MapControl.</returns>
    public extern MapLoadingStatus LoadingStatus { [MethodImpl] get; }

    /// <summary>Gets or sets the authentication key required for using the MapControl and online mapping services.</summary>
    /// <returns>The authentication key required for using the MapControl and online mapping services.</returns>
    public extern string MapServiceToken { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the maximum zoom level for the map.</summary>
    /// <returns>The maximum zoom level for the map.</returns>
    public extern double MaxZoomLevel { [MethodImpl] get; }

    /// <summary>Gets the minimum zoom level for the map.</summary>
    /// <returns>The minimum zoom level for the map.</returns>
    public extern double MinZoomLevel { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether pedestrian features such as public stairs are displayed on the map.</summary>
    /// <returns>**true** if pedestrian features such as public stairs are displayed on the map; otherwise, **false**.</returns>
    public extern bool PedestrianFeaturesVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the actual pitch of the map. Sometimes the pitch requested by setting the DesiredPitch property cannot be set.</summary>
    /// <returns>The actual pitch of the map. Sometimes the pitch requested by setting the property cannot be set.</returns>
    public extern double Pitch { [MethodImpl] get; }

    /// <summary>Specifies the style of the map - for example, a road map or an aerial map.</summary>
    /// <returns>The style of the map - for example, a road map or an aerial map.</returns>
    public extern MapStyle Style { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether traffic conditions are displayed on the map.</summary>
    /// <returns>**true** if traffic conditions are displayed on the map; otherwise, **false**.</returns>
    public extern bool TrafficFlowVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a point to which the logical center of the map is transformed.</summary>
    /// <returns>A point to which the logical center of the map is transformed. Use a value between 0 and 1 (but not 0 or 1) for the X and Y properties of the Point.</returns>
    public extern Point TransformOrigin { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines when the watermark of the map is displayed.</summary>
    /// <returns>A value that determines when the watermark of the map is displayed.</returns>
    public extern MapWatermarkMode WatermarkMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the zoom level of the map, which is a value between 1 and 20 in 2D views.</summary>
    /// <returns>The zoom level of the map, which is a value between 1 and 20 in 2D views.</returns>
    public extern double ZoomLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the collection of MapElement objects that are children of the MapControl.</summary>
    /// <returns>The collection of MapElement objects that are children of the MapControl.</returns>
    public extern IVector<MapElement> MapElements { [MethodImpl] get; }

    /// <summary>Gets the collection of MapRouteView objects displayed on the map.</summary>
    /// <returns>The collection of MapRouteView objects displayed on the map.</returns>
    public extern IVector<MapRouteView> Routes { [MethodImpl] get; }

    /// <summary>Gets or sets the collection of MapTileSource objects that are children of the MapControl.</summary>
    /// <returns>The collection of MapTileSource objects that are children of the MapControl.</returns>
    public extern IVector<MapTileSource> TileSources { [MethodImpl] get; }

    /// <summary>Occurs when the value of the Center property of the MapControl changes.</summary>
    public extern event TypedEventHandler<MapControl, object> CenterChanged;

    /// <summary>Occurs when the value of the Heading property of the MapControl changes.</summary>
    public extern event TypedEventHandler<MapControl, object> HeadingChanged;

    /// <summary>Occurs when the value of the LoadingStatus property of the MapControl changes.</summary>
    public extern event TypedEventHandler<MapControl, object> LoadingStatusChanged;

    /// <summary>Occurs when the user double-taps the MapControl. An instance of MapInputEventArgs provides data for this event.</summary>
    public extern event TypedEventHandler<MapControl, MapInputEventArgs> MapDoubleTapped;

    /// <summary>Occurs when the user taps and holds on the MapControl. An instance of MapInputEventArgs provides data for this event.</summary>
    public extern event TypedEventHandler<MapControl, MapInputEventArgs> MapHolding;

    /// <summary>Occurs when the user taps the MapControl or clicks on it with the left mouse button. An instance of MapInputEventArgs provides data for this event.</summary>
    public extern event TypedEventHandler<MapControl, MapInputEventArgs> MapTapped;

    /// <summary>Occurs when the value of the Pitch property of the MapControl changes.</summary>
    public extern event TypedEventHandler<MapControl, object> PitchChanged;

    /// <summary>Occurs when the value of the TransformOrigin property of the MapControl changes.</summary>
    public extern event TypedEventHandler<MapControl, object> TransformOriginChanged;

    /// <summary>Occurs when the value of the ZoomLevel property of the MapControl changes.</summary>
    public extern event TypedEventHandler<MapControl, object> ZoomLevelChanged;

    /// <summary>Retrieves the collection of MapElement objects at the specified point on the map.</summary>
    /// <param name="offset">The point on the map from which to retrieve the collection of MapElement objects.</param>
    /// <returns>The collection of MapElement objects at the specified point on the map.</returns>
    [Overload("FindMapElementsAtOffset")]
    [MethodImpl]
    public extern IVectorView<MapElement> FindMapElementsAtOffset(Point offset);

    /// <summary>Converts a point on the map to a geographic location.</summary>
    /// <param name="offset">A point on the map to convert to a geographic location.</param>
    /// <param name="location">When this method returns, contains the corresponding geographic location.</param>
    [Overload("GetLocationFromOffset")]
    [MethodImpl]
    public extern void GetLocationFromOffset(Point offset, out Geopoint location);

    /// <summary>Converts a geographic location to a point on the map.</summary>
    /// <param name="location">A geographic location to convert to a point on the map.</param>
    /// <param name="offset">When this method returns, contains the corresponding point on the map.</param>
    [MethodImpl]
    public extern void GetOffsetFromLocation(Geopoint location, out Point offset);

    /// <summary>Determines whether the specified geographic location is located in the portion of the map currently visible in the MapControl.</summary>
    /// <param name="location">A geographic location.</param>
    /// <param name="isInView">When this method returns, contains **true** if the specified geographic location is located in the portion of the map currently visible in the MapControl; otherwise, contains **false**.</param>
    [MethodImpl]
    public extern void IsLocationInView(Geopoint location, out bool isInView);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewBoundsAsync(
      GeoboundingBox bounds,
      IReference<Thickness> margin,
      MapAnimationKind animation);

    /// <summary>Sets the view of the map displayed in the MapControl using the specified center.</summary>
    /// <param name="center">The center to use in the view. For more info, see the Center property.</param>
    /// <returns>**true** if the asynchronous operation succeeded; otherwise, **false**.</returns>
    [Overload("TrySetViewWithCenterAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(Geopoint center);

    [Overload("TrySetViewWithCenterAndZoomAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel);

    [RemoteAsync]
    [Overload("TrySetViewWithCenterZoomHeadingAndPitchAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel,
      IReference<double> heading,
      IReference<double> desiredPitch);

    [RemoteAsync]
    [Overload("TrySetViewWithCenterZoomHeadingPitchAndAnimationAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetViewAsync(
      Geopoint center,
      IReference<double> zoomLevel,
      IReference<double> heading,
      IReference<double> desiredPitch,
      MapAnimationKind animation);

    /// <summary>Gets or sets a value that indicates whether businesses are displayed on the map.</summary>
    /// <returns>**true** if businesses are displayed on the map; otherwise, **false**.</returns>
    public extern bool BusinessLandmarksVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if transit features are displayed on the map.</summary>
    /// <returns>**true** if transit features are displayed on the map; otherwise, **false**.</returns>
    public extern bool TransitFeaturesVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the pan gesture is recognized on the map.</summary>
    /// <returns>A value that indicates if the pan gesture is recognized on the map.</returns>
    public extern MapPanInteractionMode PanInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the map responds to the rotate gesture and if the corresponding UI control appears on the map.</summary>
    /// <returns>A value that specifies if the map responds to the rotate gesture and if the corresponding UI control appears on the map.</returns>
    public extern MapInteractionMode RotateInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the map responds to the tilt gesture and if the corresponding UI control appears on the map.</summary>
    /// <returns>A value that specifies if the map responds to the tilt gesture and if the corresponding UI control appears on the map.</returns>
    public extern MapInteractionMode TiltInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates if the map responds to the zoom gesture and if the corresponding UI control appears on the map.</summary>
    /// <returns>A value that specifies if the map responds to the zoom gesture and if the corresponding UI control appears on the map.</returns>
    public extern MapInteractionMode ZoomInteractionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates if 3D is supported within the map.</summary>
    /// <returns>**true** if 3D is supported within the map; otherwise, **false**.</returns>
    public extern bool Is3DSupported { [MethodImpl] get; }

    /// <summary>Gets a value that indicates if Streetside is supported within the map.</summary>
    /// <returns>**true** if Streetside is supported within the map; otherwise, **false**.</returns>
    public extern bool IsStreetsideSupported { [MethodImpl] get; }

    /// <summary>Gets or sets the MapScene associated with this MapControl.</summary>
    /// <returns>The MapScene associated with this MapControl.</returns>
    public extern MapScene Scene { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the MapCamera settings that define the current position of the camera.</summary>
    /// <returns>The MapCamera settings that define the current position of the camera.</returns>
    public extern MapCamera ActualCamera { [MethodImpl] get; }

    /// <summary>Gets the MapCamera settings that define the final position of the camera.</summary>
    /// <returns>The MapCamera settings that define the final position of the camera.</returns>
    public extern MapCamera TargetCamera { [MethodImpl] get; }

    /// <summary>Gets or sets a custom experience for the MapControl.</summary>
    /// <returns>A custom experience for the MapControl.</returns>
    public extern MapCustomExperience CustomExperience { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user taps or clicks a MapElement on the MapControl.</summary>
    public extern event TypedEventHandler<MapControl, MapElementClickEventArgs> MapElementClick;

    /// <summary>Occurs when a pointer moves into the bounding area of a MapElement on a MapControl.</summary>
    public extern event TypedEventHandler<MapControl, MapElementPointerEnteredEventArgs> MapElementPointerEntered;

    /// <summary>Occurs when a pointer moves out of the bounding area of a MapElement on a MapControl.</summary>
    public extern event TypedEventHandler<MapControl, MapElementPointerExitedEventArgs> MapElementPointerExited;

    /// <summary>Occurs when the current position of the map's camera has changed.</summary>
    public extern event TypedEventHandler<MapControl, MapActualCameraChangedEventArgs> ActualCameraChanged;

    /// <summary>Occurs when the current position of the map's camera changes.</summary>
    public extern event TypedEventHandler<MapControl, MapActualCameraChangingEventArgs> ActualCameraChanging;

    /// <summary>Occurs when the final position of the map's camera has changed.</summary>
    public extern event TypedEventHandler<MapControl, MapTargetCameraChangedEventArgs> TargetCameraChanged;

    /// <summary>Occurs when the custom experience of the MapControl changes.</summary>
    public extern event TypedEventHandler<MapControl, MapCustomExperienceChangedEventArgs> CustomExperienceChanged;

    /// <summary>Starts an asynchronous operation to rotate the map's camera continuously from its current position.</summary>
    /// <param name="rateInDegreesPerSecond">The degrees that the map's camera rotates per second in a horizontal clockwise direction.</param>
    [MethodImpl]
    public extern void StartContinuousRotate(double rateInDegreesPerSecond);

    /// <summary>Stops an asynchronous operation to rotate the map's camera continuously from its current position.</summary>
    [MethodImpl]
    public extern void StopContinuousRotate();

    /// <summary>Starts an asynchronous operation to tilt the map's camera continuously from its current position.</summary>
    /// <param name="rateInDegreesPerSecond">The degrees of Pitch that the map's camera tilts down to the ground per second.</param>
    [MethodImpl]
    public extern void StartContinuousTilt(double rateInDegreesPerSecond);

    /// <summary>Stops an asynchronous operation to tilt the map's camera continuously from its current position.</summary>
    [MethodImpl]
    public extern void StopContinuousTilt();

    /// <summary>Starts an asynchronous operation to zoom in continuously until the map's maximum ZoomLevel is reached.</summary>
    /// <param name="rateOfChangePerSecond">The change in ZoomLevel per second.</param>
    [MethodImpl]
    public extern void StartContinuousZoom(double rateOfChangePerSecond);

    /// <summary>Stops an asynchronous operation to zoom in continuously until the map's maximum ZoomLevel is reached.</summary>
    [MethodImpl]
    public extern void StopContinuousZoom();

    /// <summary>Starts an asynchronous operation to rotate the map's camera from its current position.</summary>
    /// <param name="degrees">The degrees that the map's camera rotates in a horizontal clockwise direction.</param>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRotateAsync(double degrees);

    /// <summary>Starts an asynchronous operation to rotate the map's camera to a specific orientation.</summary>
    /// <param name="angleInDegrees">The final Heading of the map's camera, in degrees.</param>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRotateToAsync(double angleInDegrees);

    /// <summary>Starts an asynchronous operation to tilt the map's camera from its current position.</summary>
    /// <param name="degrees">The degrees of Pitch that the map's camera tilts down to the ground.</param>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryTiltAsync(double degrees);

    /// <summary>Starts an asynchronous operation to tilt the map's camera to a specific orientation.</summary>
    /// <param name="angleInDegrees">The final Pitch of the map's camera in degrees.</param>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryTiltToAsync(double angleInDegrees);

    /// <summary>Starts an asynchronous operation to zoom in, increasing the map's ZoomLevel by one.</summary>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryZoomInAsync();

    /// <summary>Starts an asynchronous operation to zoom out, decreasing the map's ZoomLevel by one.</summary>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryZoomOutAsync();

    /// <summary>Starts an asynchronous operation to zoom the map to a specific ZoomLevel.</summary>
    /// <param name="zoomLevel">The final zoom level of the map, between 1 and 20.</param>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryZoomToAsync(double zoomLevel);

    /// <summary>Sets the scene of the map displayed in the MapControl using the specified scene.</summary>
    /// <param name="scene">Defines the item or area to appear in the map.</param>
    /// <returns>**true** if the asynchronous operation succeeded; otherwise, **false**.</returns>
    [Overload("TrySetSceneAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetSceneAsync(MapScene scene);

    /// <summary>Sets the scene of the map displayed in the MapControl using the specified scene and animation.</summary>
    /// <param name="scene">Defines the item or area to appear in the map.</param>
    /// <param name="animationKind">Specifies the animation to use when you change the scene of the map.</param>
    /// <returns>**true** if the asynchronous operation succeeded; otherwise, **false**.</returns>
    [Overload("TrySetSceneWithAnimationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TrySetSceneAsync(
      MapScene scene,
      MapAnimationKind animationKind);

    /// <summary>Occurs when the user presses-and-holds the MapControl or clicks on it using the right mouse button. An instance of MapRightTappedEventArgs provides data for this event.</summary>
    public extern event TypedEventHandler<MapControl, MapRightTappedEventArgs> MapRightTapped;

    /// <summary>This property is not implemented.</summary>
    /// <returns>This property is not implemented.</returns>
    public extern bool BusinessLandmarksEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>This property is not implemented.</summary>
    /// <returns>This property is not implemented.</returns>
    public extern bool TransitFeaturesEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the visible region of the map control.</summary>
    /// <param name="region">The visible region kind.</param>
    /// <returns>The geopath indicating the visible region of the map control. The returned value can be null when a valid visible region cannot be calculated.</returns>
    [MethodImpl]
    public extern Geopath GetVisibleRegion(MapVisibleRegionKind region);

    /// <summary>Gets or sets a MapProjection that specifies how to transform the latitudes and longitudes of the map.</summary>
    /// <returns>An MapProjection that specifies how to transform the latitudes and longitudes of the map.</returns>
    public extern MapProjection MapProjection { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets an object that defines the style of the map control.</summary>
    /// <returns>An object that defines the style of the map control.</returns>
    public extern MapStyleSheet StyleSheet { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the padding inside a map control.</summary>
    /// <returns>The amount of space between the content of a MapControl and its Margin or Border. The default is a Thickness with values of 0 on all four sides.</returns>
    public extern Thickness ViewPadding { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the user has completed a context input gesture on a map, such as a right-click.</summary>
    public extern event TypedEventHandler<MapControl, MapContextRequestedEventArgs> MapContextRequested;

    /// <summary>Retrieves the collection of MapElement objects within the specified radius.</summary>
    /// <param name="offset">The point on the map that marks the center of a radius from which to retrieve the collection of MapElement objects.</param>
    /// <param name="radius">A number that's added to the offset to mark the edge of the radius.</param>
    /// <returns>The collection of MapElement objects within the specified radius.</returns>
    [Overload("FindMapElementsAtOffsetWithRadius")]
    [MethodImpl]
    public extern IVectorView<MapElement> FindMapElementsAtOffset(
      Point offset,
      double radius);

    /// <summary>Converts a point on the map to a geographic location by using the specified altitude reference system.</summary>
    /// <param name="offset">A point on the map to convert to a geographic location.</param>
    /// <param name="desiredReferenceSystem">The altitude reference system of the geographic point. A value of **Unspecified** for the altitude reference system has the same effect as using the default GetLocationFromOffset(Windows.Foundation.Point offset, Windows.Devices.Geolocation.Geopoint location) overload.</param>
    /// <param name="location">When this method returns, contains the corresponding geographic location.</param>
    [Overload("GetLocationFromOffsetWithReferenceSystem")]
    [MethodImpl]
    public extern void GetLocationFromOffset(
      Point offset,
      AltitudeReferenceSystem desiredReferenceSystem,
      out Geopoint location);

    /// <summary>Starts an asynchronous operation to pan the map continuously from its current position.</summary>
    /// <param name="horizontalPixelsPerSecond">The pixels per second to pan horizontally.</param>
    /// <param name="verticalPixelsPerSecond">The pixels per second to pan vertically.</param>
    [MethodImpl]
    public extern void StartContinuousPan(
      double horizontalPixelsPerSecond,
      double verticalPixelsPerSecond);

    /// <summary>Stops an asynchronous operation to pan the map continuously from its current position.</summary>
    [MethodImpl]
    public extern void StopContinuousPan();

    /// <summary>Starts an asynchronous operation to pan the map from its current position.</summary>
    /// <param name="horizontalPixels">The pixels to pan horizontally.</param>
    /// <param name="verticalPixels">The pixels to pan vertically.</param>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPanAsync(
      double horizontalPixels,
      double verticalPixels);

    /// <summary>Starts an asynchronous operation to pan the map to a specific location.</summary>
    /// <param name="location">The coordinates of a geographic location to which you want to pan the map.</param>
    /// <returns>Contains the results of the operation: **true** if the operation completed successfully; otherwise, **false**.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryPanToAsync(Geopoint location);

    /// <summary>Gets the collection of MapLayer objects that are children of the MapControl.</summary>
    /// <returns>The collection of MapLayer objects that are children of the MapControl.</returns>
    public extern IVector<MapLayer> Layers { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Converts a point on the map to a geographic location.</summary>
    /// <param name="offset">A point on the map to convert to a geographic location.</param>
    /// <param name="location">When this method returns, contains the corresponding geographic location.</param>
    /// <returns>Returns **true** if the location is invalid; otherwise, **false**.</returns>
    [Overload("TryGetLocationFromOffset")]
    [MethodImpl]
    public extern bool TryGetLocationFromOffset(Point offset, out Geopoint location);

    /// <summary>Converts a point on the map to a geographic location by using the specified altitude reference system.</summary>
    /// <param name="offset">A point on the map to convert to a geographic location.</param>
    /// <param name="desiredReferenceSystem">The altitude reference system of the geographic point. A value of **Unspecified** for the altitude reference system has the same effect as using the default TryGetLocationFromOffset(Windows.Foundation.Point offset, Windows.Devices.Geolocation.Geopoint location) overload.</param>
    /// <param name="location">When this method returns, contains the corresponding geographic location.</param>
    /// <returns>Returns **true** if the location is invalid; otherwise, **false**.</returns>
    [Overload("TryGetLocationFromOffsetWithReferenceSystem")]
    [MethodImpl]
    public extern bool TryGetLocationFromOffset(
      Point offset,
      AltitudeReferenceSystem desiredReferenceSystem,
      out Geopoint location);

    /// <summary>Gets or sets the region (for example, the state or province) of an address.</summary>
    /// <returns>The region (for example, the state or province) of an address.</returns>
    public extern string Region { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value indicating if the map can be tilted down</summary>
    /// <returns>
    /// </returns>
    public extern bool CanTiltDown { [MethodImpl] get; }

    /// <summary>Gets a value indicating if the map can be tilted up</summary>
    /// <returns>
    /// </returns>
    public extern bool CanTiltUp { [MethodImpl] get; }

    /// <summary>Gets a value indicating if the map can be zoomed in</summary>
    /// <returns>
    /// </returns>
    public extern bool CanZoomIn { [MethodImpl] get; }

    /// <summary>Gets a value indicating if the map can be zoomed out</summary>
    /// <returns>
    /// </returns>
    public extern bool CanZoomOut { [MethodImpl] get; }

    /// <summary>Identifies the CanTiltDown dependency property.</summary>
    /// <returns>The identifier for the CanTiltDown dependency property.</returns>
    public static extern DependencyProperty CanTiltDownProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanTiltUp dependency property.</summary>
    /// <returns>The identifier for the CanTiltUp dependency property.</returns>
    public static extern DependencyProperty CanTiltUpProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanZoomIn dependency property.</summary>
    /// <returns>The identifier for the CanZoomIn dependency property.</returns>
    public static extern DependencyProperty CanZoomInProperty { [MethodImpl] get; }

    /// <summary>Identifies the CanZoomOut dependency property.</summary>
    /// <returns>The identifier for the CanZoomOut dependency property.</returns>
    public static extern DependencyProperty CanZoomOutProperty { [MethodImpl] get; }

    /// <summary>Identifies the Region dependency property.</summary>
    /// <returns>Identifier for the Region dependency property.</returns>
    public static extern DependencyProperty RegionProperty { [MethodImpl] get; }

    /// <summary>Identifies the Layers dependency property.</summary>
    /// <returns>The Layers dependency property.</returns>
    public static extern DependencyProperty LayersProperty { [MethodImpl] get; }

    /// <summary>Identifies the MapProjection dependency property.</summary>
    /// <returns>The identifier for the MapProjection dependency property.</returns>
    public static extern DependencyProperty MapProjectionProperty { [MethodImpl] get; }

    /// <summary>Identifies the StyleSheet dependency property.</summary>
    /// <returns>The identifier for the StyleSheet dependency property.</returns>
    public static extern DependencyProperty StyleSheetProperty { [MethodImpl] get; }

    /// <summary>Identifies the ViewPadding dependency property.</summary>
    /// <returns>The identifier for the ViewPadding dependency property.</returns>
    public static extern DependencyProperty ViewPaddingProperty { [MethodImpl] get; }

    /// <summary>This property is not implemented.</summary>
    /// <returns>This property is not implemented.</returns>
    public static extern DependencyProperty BusinessLandmarksEnabledProperty { [MethodImpl] get; }

    /// <summary>This property is not implemented.</summary>
    /// <returns>This property is not implemented.</returns>
    public static extern DependencyProperty TransitFeaturesEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the BusinessLandmarksVisible dependency property.</summary>
    /// <returns>The identifier for the BusinessLandmarksVisible dependency property.</returns>
    public static extern DependencyProperty BusinessLandmarksVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the TransitFeaturesVisible dependency property.</summary>
    /// <returns>The identifier for the TransitFeaturesVisible dependency property.</returns>
    public static extern DependencyProperty TransitFeaturesVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the PanInteractionMode dependency property.</summary>
    /// <returns>Identifier for the PanInteractionMode dependency property.</returns>
    public static extern DependencyProperty PanInteractionModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the RotateInteractionMode dependency property.</summary>
    /// <returns>Identifier for the RotateInteractionMode dependency property.</returns>
    public static extern DependencyProperty RotateInteractionModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the TiltInteractionMode dependency property.</summary>
    /// <returns>Identifier for the TiltInteractionMode dependency property.</returns>
    public static extern DependencyProperty TiltInteractionModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomInteractionMode dependency property.</summary>
    /// <returns>Identifier for the ZoomInteractionMode dependency property.</returns>
    public static extern DependencyProperty ZoomInteractionModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Is3DSupported dependency property.</summary>
    /// <returns>Is the identifier for the Is3DSupported dependency property.</returns>
    public static extern DependencyProperty Is3DSupportedProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsStreetsideSupported dependency property.</summary>
    /// <returns>Is the identifier for the IsStreetsideSupported dependency property.</returns>
    public static extern DependencyProperty IsStreetsideSupportedProperty { [MethodImpl] get; }

    /// <summary>Identifies the Scene dependency property.</summary>
    /// <returns>The identifier for the Scene dependency property.</returns>
    public static extern DependencyProperty SceneProperty { [MethodImpl] get; }

    /// <summary>Identifies the Center dependency property.</summary>
    /// <returns>The identifier for the Center dependency property.</returns>
    public static extern DependencyProperty CenterProperty { [MethodImpl] get; }

    /// <summary>Identifies the Children dependency property.</summary>
    /// <returns>The identifier for the Children dependency property.</returns>
    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }

    /// <summary>Identifies the ColorScheme dependency property.</summary>
    /// <returns>The identifier for the ColorScheme dependency property.</returns>
    public static extern DependencyProperty ColorSchemeProperty { [MethodImpl] get; }

    /// <summary>Identifies the DesiredPitch dependency property.</summary>
    /// <returns>The identifier for the DesiredPitch dependency property.</returns>
    public static extern DependencyProperty DesiredPitchProperty { [MethodImpl] get; }

    /// <summary>Identifies the Heading dependency property.</summary>
    /// <returns>The identifier for the Heading dependency property.</returns>
    public static extern DependencyProperty HeadingProperty { [MethodImpl] get; }

    /// <summary>Identifies the LandmarksVisible dependency property.</summary>
    /// <returns>The identifier for the LandmarksVisible dependency property.</returns>
    public static extern DependencyProperty LandmarksVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the LoadingStatus dependency property.</summary>
    /// <returns>The identifier for the LoadingStatus dependency property.</returns>
    public static extern DependencyProperty LoadingStatusProperty { [MethodImpl] get; }

    /// <summary>Identifies the MapServiceToken dependency property.</summary>
    /// <returns>The identifier for the MapServiceToken dependency property.</returns>
    public static extern DependencyProperty MapServiceTokenProperty { [MethodImpl] get; }

    /// <summary>Identifies the PedestrianFeaturesVisible dependency property.</summary>
    /// <returns>The identifier for the PedestrianFeaturesVisible dependency property.</returns>
    public static extern DependencyProperty PedestrianFeaturesVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the Pitch dependency property.</summary>
    /// <returns>The identifier for the Pitch dependency property.</returns>
    public static extern DependencyProperty PitchProperty { [MethodImpl] get; }

    /// <summary>Identifies the Style dependency property.</summary>
    /// <returns>The identifier for the Style dependency property.</returns>
    public new static extern DependencyProperty StyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the TrafficFlowVisible dependency property.</summary>
    /// <returns>The identifier for the TrafficFlowVisible dependency property.</returns>
    public static extern DependencyProperty TrafficFlowVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the TransformOrigin dependency property.</summary>
    /// <returns>The identifier for the TransformOrigin dependency property.</returns>
    public static extern DependencyProperty TransformOriginProperty { [MethodImpl] get; }

    /// <summary>Identifies the WatermarkMode dependency property.</summary>
    /// <returns>The identifier for the WatermarkMode dependency property.</returns>
    public static extern DependencyProperty WatermarkModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ZoomLevel dependency property.</summary>
    /// <returns>The identifier for the ZoomLevel dependency property.</returns>
    public static extern DependencyProperty ZoomLevelProperty { [MethodImpl] get; }

    /// <summary>Identifies the MapElements dependency property.</summary>
    /// <returns>The identifier for the MapElements dependency property.</returns>
    public static extern DependencyProperty MapElementsProperty { [MethodImpl] get; }

    /// <summary>Identifies the Routes dependency property.</summary>
    /// <returns>The identifier for the Routes dependency property.</returns>
    public static extern DependencyProperty RoutesProperty { [MethodImpl] get; }

    /// <summary>Identifies the TileSources dependency property.</summary>
    /// <returns>The identifier for the TileSources dependency property.</returns>
    public static extern DependencyProperty TileSourcesProperty { [MethodImpl] get; }

    /// <summary>Identifies the MapControl.Location XAML attached property.</summary>
    /// <returns>The identifier for the MapControl.Location XAML attached property.</returns>
    public static extern DependencyProperty LocationProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the MapControl.Location XAML attached property from the specified child element of a MapControl. The location is the geographic location on the MapControl at which the MapControl.NormalizedAnchorPoint of the child element is positioned.</summary>
    /// <param name="element">The element from which to read the property value.</param>
    /// <returns>The value of the MapControl.Location XAML attached property on the specified child element of a MapControl.</returns>
    [MethodImpl]
    public static extern Geopoint GetLocation(DependencyObject element);

    /// <summary>Sets the value of the MapControl.Location XAML attached property on the specified child element of a MapControl. The location is the geographic location on the MapControl at which the MapControl.NormalizedAnchorPoint of the child element is positioned.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="value">The value of the MapControl.Location XAML attached property to set on the specified child element of a MapControl.</param>
    [MethodImpl]
    public static extern void SetLocation(DependencyObject element, Geopoint value);

    /// <summary>Identifies the MapControl.NormalizedAnchorPoint XAML attached property.</summary>
    /// <returns>The identifier for the MapControl.NormalizedAnchorPoint XAML attached property.</returns>
    public static extern DependencyProperty NormalizedAnchorPointProperty { [MethodImpl] get; }

    /// <summary>Gets the value of the MapControl.NormalizedAnchorPoint XAML attached property from the specified child element of a MapControl. The anchor point is the point on the child element that is positioned at the point on the MapControl specified by the MapControl.Location attached property.</summary>
    /// <param name="element">The element from which to read the property value.</param>
    /// <returns>The value of the MapControl.NormalizedAnchorPoint XAML attached property on the specified child element of a MapControl.</returns>
    [MethodImpl]
    public static extern Point GetNormalizedAnchorPoint(DependencyObject element);

    /// <summary>Sets the value of the MapControl.NormalizedAnchorPoint XAML attached property on the specified child element of a MapControl. The anchor point is the point on the child element that is positioned at the point on the MapControl specified by the MapControl.Location attached property.</summary>
    /// <param name="element">The element on which to set the property value.</param>
    /// <param name="value">The value of the MapControl.NormalizedAnchorPoint XAML attached property to set on the specified child element of a MapControl.</param>
    [MethodImpl]
    public static extern void SetNormalizedAnchorPoint(DependencyObject element, Point value);
  }
}
