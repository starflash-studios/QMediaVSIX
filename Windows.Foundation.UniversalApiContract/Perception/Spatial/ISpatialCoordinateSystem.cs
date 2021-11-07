// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialCoordinateSystem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [Guid(1777060427, 24739, 13702, 166, 83, 89, 167, 189, 103, 109, 7)]
  [ExclusiveTo(typeof (SpatialCoordinateSystem))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialCoordinateSystem
  {
    IReference<Matrix4x4> TryGetTransformTo(SpatialCoordinateSystem target);
  }
}
