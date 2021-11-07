// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialBoundingVolumeStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialBoundingVolume))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(92836119, 46049, 14040, 176, 23, 86, 97, 129, 165, 177, 150)]
  internal interface ISpatialBoundingVolumeStatics
  {
    SpatialBoundingVolume FromBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingBox box);

    SpatialBoundingVolume FromOrientedBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingOrientedBox box);

    SpatialBoundingVolume FromSphere(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingSphere sphere);

    SpatialBoundingVolume FromFrustum(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingFrustum frustum);
  }
}
