// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionSourceProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialInteractionSourceProperties))]
  [Guid(90195266, 16119, 12834, 159, 83, 99, 201, 203, 126, 59, 199)]
  internal interface ISpatialInteractionSourceProperties
  {
    IReference<Vector3> TryGetSourceLossMitigationDirection(
      SpatialCoordinateSystem coordinateSystem);

    double SourceLossRisk { get; }

    SpatialInteractionSourceLocation TryGetLocation(
      SpatialCoordinateSystem coordinateSystem);
  }
}
