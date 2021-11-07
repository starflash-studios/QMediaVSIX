// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerOwner
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  /// <summary>Contains callbacks that will be triggered by InteractionTracker events.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3677260531, 19947, 20051, 178, 156, 176, 108, 159, 150, 214, 81)]
  [WebHostHidden]
  public interface IInteractionTrackerOwner
  {
    /// <summary>Callback triggered when an InteractionTracker enters the custom animation state.</summary>
    /// <param name="sender">The InteractionTracker that triggered the callback.</param>
    /// <param name="args">Arguments for the callback.</param>
    void CustomAnimationStateEntered(
      InteractionTracker sender,
      InteractionTrackerCustomAnimationStateEnteredArgs args);

    /// <summary>Callback triggered when an InteractionTracker enters the idle state.</summary>
    /// <param name="sender">The InteractionTracker that triggered the callback.</param>
    /// <param name="args">Arguments for the callback.</param>
    void IdleStateEntered(InteractionTracker sender, InteractionTrackerIdleStateEnteredArgs args);

    /// <summary>Callback triggered when an InteractionTracker enters the inertia state.</summary>
    /// <param name="sender">The InteractionTracker that triggered the callback.</param>
    /// <param name="args">Arguments for the callback.</param>
    void InertiaStateEntered(
      InteractionTracker sender,
      InteractionTrackerInertiaStateEnteredArgs args);

    /// <summary>Callback that is triggered when an InteractionTracker enters the interaction state.</summary>
    /// <param name="sender">The InteractionTracker that triggered the callback.</param>
    /// <param name="args">Arguments for the callback.</param>
    void InteractingStateEntered(
      InteractionTracker sender,
      InteractionTrackerInteractingStateEnteredArgs args);

    /// <summary>Callback that is triggered when the InteractionTracker has ignored a request.</summary>
    /// <param name="sender">The InteractionTracker that triggered the callback.</param>
    /// <param name="args">The arguments for the callback.</param>
    void RequestIgnored(InteractionTracker sender, InteractionTrackerRequestIgnoredArgs args);

    /// <summary>Callback that is triggered when the InteractionTracker 's output values have changed.</summary>
    /// <param name="sender">The InteractionTracker that triggered the callback.</param>
    /// <param name="args">The new values for the InteractionTracker.</param>
    void ValuesChanged(InteractionTracker sender, InteractionTrackerValuesChangedArgs args);
  }
}
