// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSourceState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.People;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents a snapshot of the state of a spatial interaction source (hand, motion controller, or speech) at a given time.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialInteractionSourceState : 
    ISpatialInteractionSourceState,
    ISpatialInteractionSourceState2,
    ISpatialInteractionSourceState3
  {
    /// <summary>Gets the interaction source that this state describes.</summary>
    /// <returns>The source.</returns>
    public extern SpatialInteractionSource Source { [MethodImpl] get; }

    /// <summary>Gets advanced state of the interaction source.</summary>
    /// <returns>The properties.</returns>
    public extern SpatialInteractionSourceProperties Properties { [MethodImpl] get; }

    /// <summary>Gets whether a hand or motion controller is experiencing any press.</summary>
    /// <returns>Whether the source is experiencing any press.</returns>
    public extern bool IsPressed { [MethodImpl] get; }

    /// <summary>Gets the timestamp at which this state snapshot was taken.</summary>
    /// <returns>The timestamp.</returns>
    public extern PerceptionTimestamp Timestamp { [MethodImpl] get; }

    /// <summary>Gets the available pointer poses, such as the user's head gaze, eye gaze and each motion controller's pointer pose, for the timestamp when this state snapshot was taken.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the pointer poses.</param>
    /// <returns>The pointer poses.</returns>
    [MethodImpl]
    public extern SpatialPointerPose TryGetPointerPose(
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets whether a hand or motion controller is experiencing a primary Select press.</summary>
    /// <returns>Whether the source is experiencing a Select press.</returns>
    public extern bool IsSelectPressed { [MethodImpl] get; }

    /// <summary>Gets whether a motion controller is experiencing a Menu press.</summary>
    /// <returns>Whether the source is experiencing a Menu press.</returns>
    public extern bool IsMenuPressed { [MethodImpl] get; }

    /// <summary>Gets whether an input device detects a grasp/grab action (how users take direct action on objects in order to manipulate them).</summary>
    /// <returns>True, if the source detects a grasp/grab action. Otherwise, false.</returns>
    public extern bool IsGrasped { [MethodImpl] get; }

    /// <summary>Gets the amount to which a hand or motion controller is experiencing a primary Select press, as a value between 0.0 and 1.0.</summary>
    /// <returns>The amount to which the source is experiencing a Select press.</returns>
    public extern double SelectPressedValue { [MethodImpl] get; }

    /// <summary>Gets state specific to motion controllers.</summary>
    /// <returns>The motion controller properties.</returns>
    public extern SpatialInteractionControllerProperties ControllerProperties { [MethodImpl] get; }

    /// <summary>Gets the poses of the user's joints for this hand.</summary>
    /// <returns>The poses of the user's hand joints if supported for this source; otherwise null.</returns>
    [MethodImpl]
    public extern HandPose TryGetHandPose();
  }
}
