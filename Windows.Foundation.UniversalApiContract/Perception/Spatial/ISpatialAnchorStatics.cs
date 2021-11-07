// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2844952130, 372, 12572, 174, 121, 14, 81, 7, 102, 159, 22)]
  [ExclusiveTo(typeof (SpatialAnchor))]
  internal interface ISpatialAnchorStatics
  {
    [Overload("TryCreateRelativeTo")]
    SpatialAnchor TryCreateRelativeTo(SpatialCoordinateSystem coordinateSystem);

    [Overload("TryCreateWithPositionRelativeTo")]
    SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position);

    [Overload("TryCreateWithPositionAndOrientationRelativeTo")]
    SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Quaternion orientation);
  }
}
