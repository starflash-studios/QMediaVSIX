// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteManeuver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  /// <summary>Represents actions to be taken along the path of a route leg.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapRouteManeuver : IMapRouteManeuver, IMapRouteManeuver2, IMapRouteManeuver3
  {
    /// <summary>Gets the location where the maneuver starts.</summary>
    /// <returns>The location where the maneuver starts.</returns>
    public extern Geopoint StartingPoint { [MethodImpl] get; }

    /// <summary>Gets the distance in meters to the start of the next maneuver.</summary>
    /// <returns>The distance in meters to the start of the next maneuver.</returns>
    public extern double LengthInMeters { [MethodImpl] get; }

    /// <summary>Gets the instruction text associated with the maneuver.</summary>
    /// <returns>The instruction text associated with the maneuver.</returns>
    public extern string InstructionText { [MethodImpl] get; }

    /// <summary>Gets the type of the maneuver.</summary>
    /// <returns>The type of the maneuver.</returns>
    public extern MapRouteManeuverKind Kind { [MethodImpl] get; }

    /// <summary>Gets the exit number of route maneuver.</summary>
    /// <returns>The exit number of route maneuver.</returns>
    public extern string ExitNumber { [MethodImpl] get; }

    /// <summary>Gets additional information associated with the maneuver.</summary>
    /// <returns>Additional information associated with the maneuver.</returns>
    public extern MapManeuverNotices ManeuverNotices { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the heading at the start of the maneuver in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</summary>
    /// <returns>The heading at the start of the maneuver in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</returns>
    public extern double StartHeading { [MethodImpl] get; }

    /// <summary>Gets a value that indicates the heading at the end of the maneuver in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</summary>
    /// <returns>The heading at the end of the maneuver in degrees, where 0 or 360 = North, 90 = East, 180 = South, and 270 = West.</returns>
    public extern double EndHeading { [MethodImpl] get; }

    /// <summary>Gets the street name specified in InstructionText, if available.</summary>
    /// <returns>The street name specified in InstructionText, if available.</returns>
    public extern string StreetName { [MethodImpl] get; }

    /// <summary>Gets a list of potential issues along a route leg.</summary>
    /// <returns>A list of potential issues along a route leg.</returns>
    public extern IVectorView<ManeuverWarning> Warnings { [MethodImpl] get; }
  }
}
