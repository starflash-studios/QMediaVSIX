// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Arguments for the IInteractionTrackerOwner.InertiaStateEntered callback.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class InteractionTrackerInertiaStateEnteredArgs : 
    IInteractionTrackerInertiaStateEnteredArgs,
    IInteractionTrackerInertiaStateEnteredArgs2,
    IInteractionTrackerInertiaStateEnteredArgs3
  {
    /// <summary>The InteractionTracker 's resting position when inertia completes after InteractionTrackerInertiaModifier s and boundaries have been applied.</summary>
    /// <returns>The InteractionTracker 's resting position when inertia completes after InteractionTrackerInertiaModifier s and boundaries have been applied.</returns>
    public extern IReference<Vector3> ModifiedRestingPosition { [MethodImpl] get; }

    /// <summary>The InteractionTracker 's resting scale when inertia completes, after InteractionTrackerInertiaModifiers and boundaries have been applied.</summary>
    /// <returns>The InteractionTracker 's resting scale when inertia completes, after InteractionTrackerInertiaModifiers and boundaries have been applied.</returns>
    public extern IReference<float> ModifiedRestingScale { [MethodImpl] get; }

    /// <summary>The InteractionTracker 's resting position when inertia completes, without any modifiers or boundaries applied.</summary>
    /// <returns>The InteractionTracker 's resting position when inertia completes, without any modifiers or boundaries applied.</returns>
    public extern Vector3 NaturalRestingPosition { [MethodImpl] get; }

    /// <summary>The InteractionTracker 's resting scale when inertia completes, without accounting for InteractionTrackerInertiaModifier s or boundaries.</summary>
    /// <returns>The InteractionTracker 's resting scale when inertia completes, without accounting for InteractionTrackerInertiaModifier s or boundaries.</returns>
    public extern float NaturalRestingScale { [MethodImpl] get; }

    /// <summary>The velocity of InteractionTracker 's position.</summary>
    /// <returns>The velocity of InteractionTracker 's position.</returns>
    public extern Vector3 PositionVelocityInPixelsPerSecond { [MethodImpl] get; }

    /// <summary>The ID of the request that triggered the callback. Represents the ID of the request that caused InteractionTracker to enter the Inertia State (the InertiaStateEntered callback was triggered). Note that the RequestID property will be incremented each time a request tries to change the state of InteractionTracker.</summary>
    /// <returns>The ID of the request that triggered the callback.</returns>
    public extern int RequestId { [MethodImpl] get; }

    /// <summary>The velocity of InteractionTracker 's scale.</summary>
    /// <returns>The velocity of InteractionTracker 's scale.</returns>
    public extern float ScaleVelocityInPercentPerSecond { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether the inertia is the result of an impulse.</summary>
    /// <returns>**true** if the inertia is the result of an impulse; otherwise, **false**.</returns>
    public extern bool IsInertiaFromImpulse { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether this state was entered through interaction with a tracker that this one is bound to.</summary>
    /// <returns>**true** if this state was entered through interaction with a tracker that this one is bound to; **false** if the state was entered through interaction directly with this tracker.</returns>
    public extern bool IsFromBinding { [MethodImpl] get; }
  }
}
