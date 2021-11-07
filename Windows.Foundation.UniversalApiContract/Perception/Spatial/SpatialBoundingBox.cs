// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialBoundingBox
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>An axis-aligned bounding box in the user's surroundings, with coordinates expressed in meters.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public struct SpatialBoundingBox
  {
    /// <summary>The position of the center of the bounding box.</summary>
    public Vector3 Center;
    /// <summary>The distance from the center of the bounding box to its edges, along each axis.</summary>
    public Vector3 Extents;
  }
}
