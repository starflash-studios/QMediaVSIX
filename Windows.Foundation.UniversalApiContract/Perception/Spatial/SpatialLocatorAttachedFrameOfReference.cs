// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialLocatorAttachedFrameOfReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a frame of reference that is positionally attached to the device.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialLocatorAttachedFrameOfReference : 
    ISpatialLocatorAttachedFrameOfReference
  {
    /// <summary>Gets or sets the position of this frame of reference's origin relative to the SpatialLocator that it is tracking.</summary>
    /// <returns>The offset.</returns>
    public extern Vector3 RelativePosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the orientation of this frame of reference's origin relative to the direction of the heading.</summary>
    /// <returns>The orientation.</returns>
    public extern Quaternion RelativeOrientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Adjusts the fixed heading of this frame of reference relative to its current heading.</summary>
    /// <param name="headingOffsetInRadians">The amount to change the heading, in radians.</param>
    [MethodImpl]
    public extern void AdjustHeading(double headingOffsetInRadians);

    /// <summary>Gets a coordinate system whose origin is the position of the device at the specified timestamp, oriented at this frame of reference's fixed heading. This coordinate system stays stationary and does not track any further movement of the device.</summary>
    /// <param name="timestamp">The timestamp to compute the coordinate system for.</param>
    /// <returns>The coordinate system that corresponds with the timestamp.</returns>
    [MethodImpl]
    public extern SpatialCoordinateSystem GetStationaryCoordinateSystemAtTimestamp(
      PerceptionTimestamp timestamp);

    /// <summary>Computes the device's heading in radians for the specified timestamp, relative to this frame's fixed heading.</summary>
    /// <param name="timestamp">The timestamp to compute the relative heading for.</param>
    /// <returns>The relative heading in radians that corresponds with the timestamp, or null if it is not available for the specified time.</returns>
    [MethodImpl]
    public extern IReference<double> TryGetRelativeHeadingAtTimestamp(
      PerceptionTimestamp timestamp);
  }
}
