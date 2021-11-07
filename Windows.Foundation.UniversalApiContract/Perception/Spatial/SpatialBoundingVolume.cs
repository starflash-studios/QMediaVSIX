// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialBoundingVolume
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a bounding volume of some kind in the user's surroundings, for example, a box, oriented box, sphere or frustum.</summary>
  [Static(typeof (ISpatialBoundingVolumeStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class SpatialBoundingVolume : ISpatialBoundingVolume
  {
    /// <summary>Creates a bounding volume from the specified box, with its coordinates interpreted within the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system within which to interpret the bounding box's coordinates.</param>
    /// <param name="box">The bounding box.</param>
    /// <returns>The new bounding volume.</returns>
    [MethodImpl]
    public static extern SpatialBoundingVolume FromBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingBox box);

    /// <summary>Creates a bounding volume from the specified oriented box, with its coordinates interpreted within the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system within which to interpret the bounding box's coordinates.</param>
    /// <param name="box">The oriented bounding box.</param>
    /// <returns>The new bounding volume.</returns>
    [MethodImpl]
    public static extern SpatialBoundingVolume FromOrientedBox(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingOrientedBox box);

    /// <summary>Creates a bounding volume from the specified sphere, with its coordinates interpreted within the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system within which to interpret the bounding sphere's coordinates.</param>
    /// <param name="sphere">The bounding sphere.</param>
    /// <returns>The new bounding volume.</returns>
    [MethodImpl]
    public static extern SpatialBoundingVolume FromSphere(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingSphere sphere);

    /// <summary>Creates a bounding volume from the specified frustum, with its coordinates interpreted within the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system within which to interpret the bounding frustum's coordinates.</param>
    /// <param name="frustum">The bounding frustum.</param>
    /// <returns>The new bounding volume.</returns>
    [MethodImpl]
    public static extern SpatialBoundingVolume FromFrustum(
      SpatialCoordinateSystem coordinateSystem,
      SpatialBoundingFrustum frustum);
  }
}
