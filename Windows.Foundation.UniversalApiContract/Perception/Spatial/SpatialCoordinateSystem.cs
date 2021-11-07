// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialCoordinateSystem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a coordinate system used to reason about the user's surroundings.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialCoordinateSystem : ISpatialCoordinateSystem
  {
    /// <summary>Provides a transform matrix that you can use to convert geometry expressed in one coordinate system to another coordinate system.</summary>
    /// <param name="target">The target coordinate system that you want to transform geometry to.</param>
    /// <returns>If the transformation is successful, this parameter returns the Matrix4x4 structure that you can use to transform geometry from being represented in the source SpatialCoordinateSystem to the specified target coordinate system.</returns>
    [MethodImpl]
    public extern IReference<Matrix4x4> TryGetTransformTo(
      SpatialCoordinateSystem target);
  }
}
