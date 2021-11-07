// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a coordinate system that is strongly anchored to a point in the user's surroundings.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISpatialAnchorStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialAnchor : ISpatialAnchor, ISpatialAnchor2
  {
    /// <summary>Gets the coordinate system of the anchor, with easing adjustments applied.</summary>
    /// <returns>The eased coordinate system.</returns>
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    /// <summary>Gets the coordinate system of the anchor, without easing applied.</summary>
    /// <returns>The raw coordinate system.</returns>
    public extern SpatialCoordinateSystem RawCoordinateSystem { [MethodImpl] get; }

    /// <summary>Occurs when the device adjusts the anchor's precise location, which updates the RawCoordinateSystem.</summary>
    public extern event TypedEventHandler<SpatialAnchor, SpatialAnchorRawCoordinateSystemAdjustedEventArgs> RawCoordinateSystemAdjusted;

    /// <summary>Gets a value indicating whether the persisted anchor was removed by the user.</summary>
    /// <returns>**True**, if the anchor was removed; otherwise, **false**.</returns>
    public extern bool RemovedByUser { [MethodImpl] get; }

    /// <summary>Creates an anchor at the origin of the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The reference SpatialCoordinateSystem object.</param>
    /// <returns>The new anchor, if the creation attempt is successful; otherwise, null.</returns>
    [Overload("TryCreateRelativeTo")]
    [MethodImpl]
    public static extern SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem);

    [Overload("TryCreateWithPositionRelativeTo")]
    [MethodImpl]
    public static extern SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position);

    [Overload("TryCreateWithPositionAndOrientationRelativeTo")]
    [MethodImpl]
    public static extern SpatialAnchor TryCreateRelativeTo(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Quaternion orientation);
  }
}
