// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialLocator))]
  [Guid(4131883301, 40460, 15286, 153, 126, 182, 78, 204, 162, 76, 244)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialLocator
  {
    SpatialLocatability Locatability { get; }

    event TypedEventHandler<SpatialLocator, object> LocatabilityChanged;

    event TypedEventHandler<SpatialLocator, SpatialLocatorPositionalTrackingDeactivatingEventArgs> PositionalTrackingDeactivating;

    SpatialLocation TryLocateAtTimestamp(
      PerceptionTimestamp timestamp,
      SpatialCoordinateSystem coordinateSystem);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeading")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading();

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPosition")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientation")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateAttachedFrameOfReferenceAtCurrentHeadingWithPositionAndOrientationAndRelativeHeading")]
    SpatialLocatorAttachedFrameOfReference CreateAttachedFrameOfReferenceAtCurrentHeading(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocation")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation();

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPosition")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientation")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    [Overload("CreateStationaryFrameOfReferenceAtCurrentLocationWithPositionAndOrientationAndRelativeHeading")]
    SpatialStationaryFrameOfReference CreateStationaryFrameOfReferenceAtCurrentLocation(
      Vector3 relativePosition,
      Quaternion relativeOrientation,
      double relativeHeadingInRadians);
  }
}
