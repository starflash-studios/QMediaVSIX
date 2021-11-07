// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTracker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Handles the logic of input that can be used as targets in ExpressionAnimations—typically to drive the motion of visuals based on input.</summary>
  [Static(typeof (IInteractionTrackerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Static(typeof (IInteractionTrackerStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class InteractionTracker : 
    CompositionObject,
    IInteractionTracker,
    IInteractionTracker2,
    IInteractionTracker3,
    IInteractionTracker4,
    IInteractionTracker5
  {
    /// <summary>A collection of objects that generate interactions.</summary>
    /// <returns>A collection of objects that generate interactions.</returns>
    public extern CompositionInteractionSourceCollection InteractionSources { [MethodImpl] get; }

    /// <summary>Boolean value indicating whether position rounding is currently suggested.</summary>
    /// <returns>Boolean value indicating whether position rounding is currently suggested.</returns>
    public extern bool IsPositionRoundingSuggested { [MethodImpl] get; }

    /// <summary>The maximum position allowed for the InteractionTracker.</summary>
    /// <returns>The maximum position allowed for the InteractionTracker.</returns>
    public extern Vector3 MaxPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The maximum scale for the InteractionTracker.</summary>
    /// <returns>The maximum scale for the InteractionTracker.</returns>
    public extern float MaxScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The minimum position allowed for the InteractionTracker.</summary>
    /// <returns>The minimum position allowed for the InteractionTracker.</returns>
    public extern Vector3 MinPosition { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The minimum scale for the InteractionTracker.</summary>
    /// <returns>The minimum scale for the InteractionTracker.</returns>
    public extern float MinScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Natural resting position for the InteractionTracker.</summary>
    /// <returns>Natural resting position for the InteractionTracker.</returns>
    public extern Vector3 NaturalRestingPosition { [MethodImpl] get; }

    /// <summary>Natural resting scale for the InteractionTracker.</summary>
    /// <returns>Natural resting scale for the InteractionTracker.</returns>
    public extern float NaturalRestingScale { [MethodImpl] get; }

    /// <summary>The IInteractionTrackerOwner associated with the InteractionTracker.</summary>
    /// <returns>The IInteractionTrackerOwner associated with the InteractionTracker.</returns>
    public extern IInteractionTrackerOwner Owner { [MethodImpl] get; }

    /// <summary>The output position calculated by the InteractionTracker. The current position is a relative value. During the Idle and CustomAnimation states, it will always be between the values specified in the MinPosition and MaxPosition properties. The InteractionTracker’s position property can go outside this range during the Interacting and Inertia states in order to show a bounce or resistance at the boundary.</summary>
    /// <returns>The output position calculated by the InteractionTracker.</returns>
    public extern Vector3 Position { [MethodImpl] get; }

    /// <summary>Inertia decay rate for position. Range is from 0 to 1.</summary>
    /// <returns>Inertia decay rate for position. Range is from 0 to 1.</returns>
    public extern IReference<Vector3> PositionInertiaDecayRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The velocity currently applied to position.</summary>
    /// <returns>The velocity currently applied to position.</returns>
    public extern Vector3 PositionVelocityInPixelsPerSecond { [MethodImpl] get; }

    /// <summary>The output scale calculated by the InteractionTracker. The current scale is a relative value that depends on the values specified in the MinScale and MaxScale properties.</summary>
    /// <returns>The output scale calculated by the InteractionTracker.</returns>
    public extern float Scale { [MethodImpl] get; }

    /// <summary>Inertia decay rate, for scale. Range is from 0 to 1.</summary>
    /// <returns>Inertia decay rate for scale. Range is from 0 to 1.</returns>
    public extern IReference<float> ScaleInertiaDecayRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The rate of change for scale.</summary>
    /// <returns>The rate of change for scale.</returns>
    public extern float ScaleVelocityInPercentPerSecond { [MethodImpl] get; }

    /// <summary>Adjusts the position x coordinate if it is greater than the specified threshold.</summary>
    /// <param name="adjustment">The amount to adjust the position x coordinate.</param>
    /// <param name="positionThreshold">The threshold for ajusting the position x coordinate.</param>
    [MethodImpl]
    public extern void AdjustPositionXIfGreaterThanThreshold(
      float adjustment,
      float positionThreshold);

    /// <summary>Adjusts the position y coordinate if it is greater than the specified threshold.</summary>
    /// <param name="adjustment">The amount to adjust the position y coordinate.</param>
    /// <param name="positionThreshold">The threshold for ajusting the position y coordinate.</param>
    [MethodImpl]
    public extern void AdjustPositionYIfGreaterThanThreshold(
      float adjustment,
      float positionThreshold);

    [MethodImpl]
    public extern void ConfigurePositionXInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    [MethodImpl]
    public extern void ConfigurePositionYInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    [MethodImpl]
    public extern void ConfigureScaleInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    [MethodImpl]
    public extern int TryUpdatePosition(Vector3 value);

    [MethodImpl]
    public extern int TryUpdatePositionBy(Vector3 amount);

    /// <summary>Tries to update the InteractionTracker 's position by applying an animation.</summary>
    /// <param name="animation">The animation to apply to the InteractionTracker.</param>
    /// <returns>Returns the request ID. On state transitions, the request which caused the change in state will be included in the args. These IDs will start at 1 and increase with each try call during the lifetime of the application.</returns>
    [MethodImpl]
    public extern int TryUpdatePositionWithAnimation(CompositionAnimation animation);

    [MethodImpl]
    public extern int TryUpdatePositionWithAdditionalVelocity(Vector3 velocityInPixelsPerSecond);

    [MethodImpl]
    public extern int TryUpdateScale(float value, Vector3 centerPoint);

    [MethodImpl]
    public extern int TryUpdateScaleWithAnimation(
      CompositionAnimation animation,
      Vector3 centerPoint);

    [MethodImpl]
    public extern int TryUpdateScaleWithAdditionalVelocity(
      float velocityInPercentPerSecond,
      Vector3 centerPoint);

    [MethodImpl]
    public extern void ConfigureCenterPointXInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureCenterPointYInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureVector2PositionInertiaModifiers(
      IIterable<InteractionTrackerVector2InertiaModifier> modifiers);

    [Overload("TryUpdatePositionWithOption")]
    [MethodImpl]
    public extern int TryUpdatePosition(Vector3 value, InteractionTrackerClampingOption option);

    [Overload("TryUpdatePositionByWithOption")]
    [MethodImpl]
    public extern int TryUpdatePositionBy(Vector3 amount, InteractionTrackerClampingOption option);

    /// <summary>Gets a value that indicates whether the inertia is the result of an impulse.</summary>
    /// <returns>**true** if the inertia is the result of an impulse; otherwise, **false**.</returns>
    public extern bool IsInertiaFromImpulse { [MethodImpl] get; }

    [Overload("TryUpdatePositionWithOption")]
    [MethodImpl]
    public extern int TryUpdatePosition(
      Vector3 value,
      InteractionTrackerClampingOption option,
      InteractionTrackerPositionUpdateOption posUpdateOption);

    /// <summary>Sets the binding axis mode between two interaction trackers.</summary>
    /// <param name="boundTracker1">The first interaction tracker in the binding.</param>
    /// <param name="boundTracker2">The second interaction tracker in the binding.</param>
    /// <param name="axisMode">The axis that is being bound.</param>
    [MethodImpl]
    public static extern void SetBindingMode(
      InteractionTracker boundTracker1,
      InteractionTracker boundTracker2,
      InteractionBindingAxisModes axisMode);

    /// <summary>Retrieves the binding axis mode between two interaction trackers.</summary>
    /// <param name="boundTracker1">The first interaction tracker in the binding.</param>
    /// <param name="boundTracker2">The second interaction tracker in the binding.</param>
    /// <returns>
    /// </returns>
    [MethodImpl]
    public static extern InteractionBindingAxisModes GetBindingMode(
      InteractionTracker boundTracker1,
      InteractionTracker boundTracker2);

    /// <summary>Creates an instance of InteractionTracker.</summary>
    /// <param name="compositor">The compositor to use when creating the InteractionTracker.</param>
    /// <returns>Returns the created InteractionTracker object.</returns>
    [MethodImpl]
    public static extern InteractionTracker Create(Compositor compositor);

    /// <summary>Creates an instance of InteractionTracker with the specified owner.</summary>
    /// <param name="compositor">The compositor to use to create the instance of InteractionTracker.</param>
    /// <param name="owner">The InteractionTracker owner to associate with the created InteractionTracker.</param>
    /// <returns>Returns the created InteractionTracker object.</returns>
    [MethodImpl]
    public static extern InteractionTracker CreateWithOwner(
      Compositor compositor,
      IInteractionTrackerOwner owner);
  }
}
