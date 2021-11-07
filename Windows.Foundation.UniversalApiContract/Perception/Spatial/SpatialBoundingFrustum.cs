// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialBoundingFrustum
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>A bounding frustum in the user's surroundings defined as a set of 6 planes, with coordinates expressed in meters.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public struct SpatialBoundingFrustum
  {
    /// <summary>The near Plane defines the boundary for the closest content within the frustum.</summary>
    public Plane Near;
    /// <summary>The far Plane defines the boundary for the farthest content within the frustum.</summary>
    public Plane Far;
    /// <summary>The right Plane defines the boundary for the rightmost content within the frustum.</summary>
    public Plane Right;
    /// <summary>The left Plane defines the boundary for the leftmost content within the frustum.</summary>
    public Plane Left;
    /// <summary>The top Plane defines the boundary for the topmost content within the frustum.</summary>
    public Plane Top;
    /// <summary>The bottom Plane defines the boundary for the bottommost content within the frustum.</summary>
    public Plane Bottom;
  }
}
