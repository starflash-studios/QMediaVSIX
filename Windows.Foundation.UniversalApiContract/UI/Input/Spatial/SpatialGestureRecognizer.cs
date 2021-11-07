// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialGestureRecognizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  /// <summary>Interprets user interactions from hands, motion controllers, and system voice commands to surface spatial gesture events, which users target using their gaze or a motion controller's pointing ray.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  [Activatable(typeof (ISpatialGestureRecognizerFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class SpatialGestureRecognizer : ISpatialGestureRecognizer
  {
    /// <summary>Initializes a new SpatialGestureRecognizer with the specified gesture settings.</summary>
    /// <param name="settings">The gesture settings for the new recognizer.</param>
    [MethodImpl]
    public extern SpatialGestureRecognizer(SpatialGestureSettings settings);

    /// <summary>Occurs when gesture recognition begins (this is the first event to fire).</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialRecognitionStartedEventArgs> RecognitionStarted;

    /// <summary>Occurs when gesture recognition ends, due to completion or cancellation of a gesture (this is the last event to fire).</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialRecognitionEndedEventArgs> RecognitionEnded;

    /// <summary>Occurs when a Tap or DoubleTap gesture is recognized.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialTappedEventArgs> Tapped;

    /// <summary>Occurs when an interaction becomes a Hold gesture.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldStartedEventArgs> HoldStarted;

    /// <summary>Occurs when a Hold gesture completes.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldCompletedEventArgs> HoldCompleted;

    /// <summary>Occurs when a Hold gesture is canceled.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialHoldCanceledEventArgs> HoldCanceled;

    /// <summary>Occurs when an interaction becomes a Manipulation gesture.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationStartedEventArgs> ManipulationStarted;

    /// <summary>Occurs when a Manipulation gesture is updated due to hand movement.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationUpdatedEventArgs> ManipulationUpdated;

    /// <summary>Occurs when a Manipulation gesture is completed.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationCompletedEventArgs> ManipulationCompleted;

    /// <summary>Occurs when a Manipulation gesture is canceled.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialManipulationCanceledEventArgs> ManipulationCanceled;

    /// <summary>Occurs when an interaction becomes a Navigation gesture.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationStartedEventArgs> NavigationStarted;

    /// <summary>Occurs when a Navigation gesture is updated due to hand or motion controller movement.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationUpdatedEventArgs> NavigationUpdated;

    /// <summary>Occurs when a Navigation gesture is completed.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationCompletedEventArgs> NavigationCompleted;

    /// <summary>Occurs when a Navigation gesture is canceled.</summary>
    public extern event TypedEventHandler<SpatialGestureRecognizer, SpatialNavigationCanceledEventArgs> NavigationCanceled;

    /// <summary>Track all input events that occur as part of the specified interaction.</summary>
    /// <param name="interaction">The interaction to capture from the InteractionDetected event.</param>
    [MethodImpl]
    public extern void CaptureInteraction(SpatialInteraction interaction);

    /// <summary>Cancels all in-progress gestures and abandons any captured interactions.</summary>
    [MethodImpl]
    public extern void CancelPendingGestures();

    /// <summary>Attempts to change the gesture settings for this recognizer.</summary>
    /// <param name="settings">The new SpatialGestureSettings to switch to.</param>
    /// <returns>True if the switch was successful; otherwise, false.</returns>
    [MethodImpl]
    public extern bool TrySetGestureSettings(SpatialGestureSettings settings);

    /// <summary>Gets the current SpatialGestureSettings for this recognizer.</summary>
    /// <returns>The gesture settings.</returns>
    public extern SpatialGestureSettings GestureSettings { [MethodImpl] get; }
  }
}
