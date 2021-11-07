// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialStageFrameOfReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [Guid(2055877732, 44301, 17808, 171, 134, 51, 6, 43, 103, 73, 38)]
  [ExclusiveTo(typeof (SpatialStageFrameOfReference))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ISpatialStageFrameOfReference
  {
    SpatialCoordinateSystem CoordinateSystem { get; }

    SpatialMovementRange MovementRange { get; }

    SpatialLookDirectionRange LookDirectionRange { get; }

    SpatialCoordinateSystem GetCoordinateSystemAtCurrentLocation(
      SpatialLocator locator);

    Vector3[] TryGetMovementBounds(SpatialCoordinateSystem coordinateSystem);
  }
}
