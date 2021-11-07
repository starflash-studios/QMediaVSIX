// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>Provides access to the location of a device that's tracked relative to the user's surroundings, such as a HoloLens or other Mixed Reality headset.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISpatialLocatorStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialLocator : ISpatialLocator
  {
    /// <summary>Gets the current state of the device's spatial location system.</summary>
    /// <returns>The locatability.</returns>
    public extern SpatialLocatability Locatability { [MethodImpl] get; }

    /// <summary>Occurs when the state of the spatial location system changes.</summary>
    public extern event TypedEventHandler<SpatialLocator, object> LocatabilityChanged;

    /// <summary>Occurs when the device's spatial location system is deactivating due to inactivity.</summary>
    public extern event TypedEventHandler<SpatialLocator, SpatialLocatorPositionalTrackingDeactivatingEventArgs> PositionalTrackingDeactivating;

    /// <summary>Returns a SpatialLocation representing the device's location at the specified timestamp. The coordinates within are expressed relative to the supplied coordinate system. If the device cannot be located in that coordinate system at the specified timestamp, the return value will be null. This can happen when the device has lost tracking, for example.</summary>
    /// <param name="timestamp">The timestamp at which to locate the device.</param>
    /// <param name="coordinateSystem">The coordinate system in which to express the location's coordinates.</param>
    /// <returns>The location.</returns>
    [MethodImpl]
    public extern SpatialLocation TryLocateAtTimestamp(
      PerceptionTimestamp timestamp,
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Creates a frame of reference that's positionally attached to this SpatialLocator with the current orientation as its fixed heading.</summary>
    /// <returns>The locator-attached frame of reference.</returns>
    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeading")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading();

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading")]
    [MethodImpl]
    public extern SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);

    /// <summary>Creates a frame of reference that remains stationary relative to the user's surroundings, with its initial origin at the SpatialLocator's current location.</summary>
    /// <returns>The stationary frame of reference.</returns>
    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocation")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation();

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading")]
    [MethodImpl]
    public extern SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);

    /// <summary>Gets the SpatialLocator instance that tracks the location of the current device, such as a HoloLens, relative to the user's surroundings.</summary>
    /// <returns>The spatial locator.</returns>
    [MethodImpl]
    public static extern SpatialLocator GetDefault();
  }
}
