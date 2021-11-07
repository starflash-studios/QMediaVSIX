// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapCamera
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  /// <summary>Represents the position of a camera to define the view of a map.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMapCameraFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class MapCamera : DependencyObject, IMapCamera
  {
    /// <summary>Creates a map camera, to define the view of a map based on location.</summary>
    /// <param name="location">The location of the camera in the map.</param>
    [MethodImpl]
    public extern MapCamera(Geopoint location);

    /// <summary>Creates a map camera, to define the view of a map based on location and heading.</summary>
    /// <param name="location">The location of the camera in the map.</param>
    /// <param name="headingInDegrees">The directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.</param>
    [MethodImpl]
    public extern MapCamera(Geopoint location, double headingInDegrees);

    /// <summary>Creates a map camera, to define the view of a map based on location, heading, and pitch.</summary>
    /// <param name="location">The location of the camera in the map.</param>
    /// <param name="headingInDegrees">The directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.</param>
    /// <param name="pitchInDegrees">The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.</param>
    [MethodImpl]
    public extern MapCamera(Geopoint location, double headingInDegrees, double pitchInDegrees);

    /// <summary>Creates a map camera, to define the view of a map based on location, heading, pitch, roll, and field of view.</summary>
    /// <param name="location">The location of the camera in the map.</param>
    /// <param name="headingInDegrees">The directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West. The default *headingInDegrees* value is 0.</param>
    /// <param name="pitchInDegrees">The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum). The default *pitchInDegrees* value is 0.</param>
    /// <param name="rollInDegrees">The roll of the camera in degrees, where -90 is tilting to the left and +90 is tilting to the right. The default *rollInDegrees* value is 0.</param>
    /// <param name="fieldOfViewInDegrees">The horizontal angle of view that appears in the camera, in degrees. The default *fieldOfViewInDegrees* value is 45.0.</param>
    [MethodImpl]
    public extern MapCamera(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees,
      double rollInDegrees,
      double fieldOfViewInDegrees);

    /// <summary>Gets or sets the location of the camera in the map.</summary>
    /// <returns>The location of the camera in the map.</returns>
    public extern Geopoint Location { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</summary>
    /// <returns>The directional heading of the camera in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</returns>
    public extern double Heading { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum).</summary>
    /// <returns>The pitch of the map's camera in degrees, where 90 is looking out at the horizon (maximum) and 0 is looking straight down (minimum).</returns>
    public extern double Pitch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the roll of the camera in degrees, where -90 is tilting to the left and +90 is tilting to the right.</summary>
    /// <returns>The roll of the camera in degrees, where -90 is tilting to the left and +90 is tilting to the right.</returns>
    public extern double Roll { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical angle of view that appears in the camera, in degrees.</summary>
    /// <returns>The vertical angle of view that appears in the camera, in degrees.</returns>
    public extern double FieldOfView { [MethodImpl] get; [MethodImpl] set; }
  }
}
