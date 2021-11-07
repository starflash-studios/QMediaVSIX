// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialStationaryFrameOfReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a frame of reference that remains stationary relative to the user's surroundings at a point in time.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialStationaryFrameOfReference : ISpatialStationaryFrameOfReference
  {
    /// <summary>Gets a stationary coordinate system with an origin at the position and orientation of the device at the time this frame was created.</summary>
    /// <returns>The coordinate system.</returns>
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }
  }
}
