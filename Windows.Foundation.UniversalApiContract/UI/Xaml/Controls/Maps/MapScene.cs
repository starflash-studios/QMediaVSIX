// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapScene
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents a view of a map.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMapSceneStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapScene : DependencyObject, IMapScene
  {
    /// <summary>Gets the MapCamera settings that define the final position of the camera.</summary>
    /// <returns>The MapCamera settings that define the final position of the camera.</returns>
    public extern MapCamera TargetCamera { [MethodImpl] get; }

    /// <summary>Occurs when the final position of the map's camera has changed.</summary>
    public extern event TypedEventHandler<MapScene, MapTargetCameraChangedEventArgs> TargetCameraChanged;

    /// <summary>Creates a scene to appear in a map based on a four-sided geographic area.</summary>
    /// <param name="bounds">The four-sided geographic area to appear in the scene.</param>
    /// <returns>Represents a view of a map in the MapControl.</returns>
    [Overload("CreateFromBoundingBox")]
    [MethodImpl]
    public static extern MapScene CreateFromBoundingBox(GeoboundingBox bounds);

    /// <summary>Creates a scene to appear in a map based on a four-sided geographic area, heading, and pitch.</summary>
    /// <param name="bounds">The four-sided geographic area to appear in the scene.</param>
    /// <param name="headingInDegrees">The directional heading of the map's camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.</param>
    /// <param name="pitchInDegrees">The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.</param>
    /// <returns>Represents a view of a map in the MapControl.</returns>
    [Overload("CreateFromBoundingBoxWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromBoundingBox(
      GeoboundingBox bounds,
      double headingInDegrees,
      double pitchInDegrees);

    /// <summary>Creates a scene to appear in a map based on the position of the specified MapCamera.</summary>
    /// <param name="camera">The current position of the specified camera.</param>
    /// <returns>Represents a view of a map in the MapControl.</returns>
    [MethodImpl]
    public static extern MapScene CreateFromCamera(MapCamera camera);

    /// <summary>Creates a scene to appear in a map based on a single geographic location.</summary>
    /// <param name="location">The center of the scene.</param>
    /// <returns>Represents a view of a map in the MapControl.</returns>
    [Overload("CreateFromLocation")]
    [MethodImpl]
    public static extern MapScene CreateFromLocation(Geopoint location);

    /// <summary>Creates a scene to appear in a map based on a single geographic location, heading, and pitch.</summary>
    /// <param name="location">The center of the scene.</param>
    /// <param name="headingInDegrees">The directional heading of the map's camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.</param>
    /// <param name="pitchInDegrees">The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.</param>
    /// <returns>Represents a view of a map in the MapControl.</returns>
    [Overload("CreateFromLocationWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromLocation(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees);

    /// <summary>Creates a scene to appear in a map based on a single geographic location and radius.</summary>
    /// <param name="location">The center of the scene.</param>
    /// <param name="radiusInMeters">The radius around the center to appear in the scene, in meters.</param>
    /// <returns>Represents a view of a map in the MapControl.</returns>
    [Overload("CreateFromLocationAndRadius")]
    [MethodImpl]
    public static extern MapScene CreateFromLocationAndRadius(
      Geopoint location,
      double radiusInMeters);

    /// <summary>Creates a scene to appear in a map based on a single geographic location, radius, heading, and pitch.</summary>
    /// <param name="location">The center of the scene.</param>
    /// <param name="radiusInMeters">The radius around the center to appear in the scene, in meters.</param>
    /// <param name="headingInDegrees">The directional heading of the map's camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.</param>
    /// <param name="pitchInDegrees">The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.</param>
    /// <returns>Represents a view of a map in the MapControl.</returns>
    [Overload("CreateFromLocationAndRadiusWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromLocationAndRadius(
      Geopoint location,
      double radiusInMeters,
      double headingInDegrees,
      double pitchInDegrees);

    [Overload("CreateFromLocations")]
    [MethodImpl]
    public static extern MapScene CreateFromLocations(IIterable<Geopoint> locations);

    [Overload("CreateFromLocationsWithHeadingAndPitch")]
    [MethodImpl]
    public static extern MapScene CreateFromLocations(
      IIterable<Geopoint> locations,
      double headingInDegrees,
      double pitchInDegrees);
  }
}
