// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialStageFrameOfReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  /// <summary>Represents a spatial stage, defined by the user to establish the physical space in which they intend to use a Mixed Reality headset.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISpatialStageFrameOfReferenceStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialStageFrameOfReference : ISpatialStageFrameOfReference
  {
    /// <summary>Gets a floor-level coordinate system located at the stage origin defined by the user.</summary>
    /// <returns>The coordinate system.</returns>
    public extern SpatialCoordinateSystem CoordinateSystem { [MethodImpl] get; }

    /// <summary>Gets the extent to which the user can move while wearing their headset.</summary>
    /// <returns>The movement range.</returns>
    public extern SpatialMovementRange MovementRange { [MethodImpl] get; }

    /// <summary>Gets the extent to which the user can look around with their headset.</summary>
    /// <returns>The look direction range.</returns>
    public extern SpatialLookDirectionRange LookDirectionRange { [MethodImpl] get; }

    /// <summary>Gets a floor-level coordinate system at the user's current position and orientation.</summary>
    /// <param name="locator">The spatial locator with the position and orientation to use as the origin for the returned coordinate system.</param>
    /// <returns>The coordinate system.</returns>
    [MethodImpl]
    public extern SpatialCoordinateSystem GetCoordinateSystemAtCurrentLocation(
      SpatialLocator locator);

    /// <summary>Gets the boundary vertices of the open area defined by the user where they intend to move while using their headset.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the boundary vertices.</param>
    /// <returns>The boundary vertices.</returns>
    [MethodImpl]
    public extern Vector3[] TryGetMovementBounds(SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets the current spatial stage, if one has been defined by the user.</summary>
    /// <returns>The current spatial stage.</returns>
    public static extern SpatialStageFrameOfReference Current { [MethodImpl] get; }

    /// <summary>Occurs when the user changes or redefines the current spatial stage.</summary>
    public static extern event EventHandler<object> CurrentChanged;

    /// <summary>Shows system UI to guide the user in defining a new stage to replace the current stage.</summary>
    /// <returns>An app may call RequestNewStageAsync if there is no stage defined or if the current stage is insufficient to meet the app's needs, such as not defining movement bounds.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SpatialStageFrameOfReference> RequestNewStageAsync();
  }
}
