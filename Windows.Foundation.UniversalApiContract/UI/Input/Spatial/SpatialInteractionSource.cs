// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSource
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;
using Windows.Perception.People;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Represents one detected instance of a hand, motion controller, or speech source that can cause interactions and gestures.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialInteractionSource : 
    ISpatialInteractionSource,
    ISpatialInteractionSource2,
    ISpatialInteractionSource3,
    ISpatialInteractionSource4
  {
    /// <summary>Gets the identifier for the hand, motion controller, or speech source.</summary>
    /// <returns>The ID.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Gets the interaction source type.</summary>
    /// <returns>The interaction source type.</returns>
    public extern SpatialInteractionSourceKind Kind { [MethodImpl] get; }

    /// <summary>Gets whether the source can provide pointer poses.</summary>
    /// <returns>Returns true for motion controllers that support positional tracking and false for other interaction sources.</returns>
    public extern bool IsPointingSupported { [MethodImpl] get; }

    /// <summary>Gets whether the source supports Menu presses.</summary>
    /// <returns>Whether the source supports Menu presses.</returns>
    public extern bool IsMenuSupported { [MethodImpl] get; }

    /// <summary>Gets whether the source supports grasps.</summary>
    /// <returns>True for some motion controllers, and false for other interaction sources.</returns>
    public extern bool IsGraspSupported { [MethodImpl] get; }

    /// <summary>Represents the specifics of a detected motion controller.</summary>
    /// <returns>The motion controller, or null if the source is not a motion controller.</returns>
    public extern SpatialInteractionController Controller { [MethodImpl] get; }

    /// <summary>Get the state of this source as of the specified timestamp.</summary>
    /// <param name="timestamp">The time to query for the state of this interaction source.</param>
    /// <returns>The state.</returns>
    [MethodImpl]
    public extern SpatialInteractionSourceState TryGetStateAtTimestamp(
      PerceptionTimestamp timestamp);

    /// <summary>Gets whether the interaction source represents the user's left hand or right hand.</summary>
    /// <returns>The handedness.</returns>
    public extern SpatialInteractionSourceHandedness Handedness { [MethodImpl] get; }

    /// <summary>Synchronously requests a HandMeshObserver to provide mesh updates for each frame that tracks the detected shape of a hand.</summary>
    /// <returns>A hand mesh observer if this source supports hand meshes; otherwise, null.</returns>
    [MethodImpl]
    public extern HandMeshObserver TryCreateHandMeshObserver();

    /// <summary>Requests a HandMeshObserver to provide mesh updates for each frame that tracks the detected shape of a hand.</summary>
    /// <returns>An operation that triggers with a hand mesh observer (if this source supports hand meshes); otherwise, an operation that returns null.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<HandMeshObserver> TryCreateHandMeshObserverAsync();
  }
}
