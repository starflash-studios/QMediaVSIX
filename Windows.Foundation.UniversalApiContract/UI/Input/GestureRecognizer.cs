// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.GestureRecognizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  /// <summary>Provides gesture and manipulation recognition, event listeners, and settings.</summary>
  [MarshalingBehavior(MarshalingType.None)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class GestureRecognizer : IGestureRecognizer, IGestureRecognizer2
  {
    /// <summary>Initializes a new instance of a GestureRecognizer object.</summary>
    [MethodImpl]
    public extern GestureRecognizer();

    /// <summary>Gets or sets a value that indicates the gesture and manipulation settings supported by an application.</summary>
    /// <returns>The gesture settings supported by an application. The value of this property is a bitwise OR of members of GestureSettings enumeration.</returns>
    public extern GestureSettings GestureSettings { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a value that indicates whether a manipulation is still being processed during inertia (no input points are active).</summary>
    /// <returns>True if the manipulation is still being processed during inertia; otherwise false. The default value is false.</returns>
    public extern bool IsInertial { [MethodImpl] get; }

    /// <summary>Gets a value that indicates whether an interaction is being processed.</summary>
    /// <returns>True if the interaction (including inertia) is still being processed; otherwise false. The default value is false.</returns>
    public extern bool IsActive { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates whether visual feedback is displayed during an interaction.</summary>
    /// <returns>True if feedback is displayed; otherwise false. The default is true.</returns>
    public extern bool ShowGestureFeedback { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the center point for a rotation interaction when single pointer input is detected.</summary>
    /// <returns>The screen location for the center of rotation, in device-independent pixel (DIP).</returns>
    public extern Point PivotCenter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius, from the PivotCenter to the pointer input, for a rotation interaction when single pointer input is detected.</summary>
    /// <returns>The offset between the PivotCenter point and the single pointer input, in device-independent pixel (DIP).</returns>
    public extern float PivotRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the rate of deceleration from the start of inertia to the end of inertia (when the translation manipulation is complete).</summary>
    /// <returns>The rate of deceleration, in device-independent pixel (DIP)/ms&lt;sup&gt;2&lt;/sup&gt;.</returns>
    public extern float InertiaTranslationDeceleration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the rate of deceleration from the start of inertia to the end of inertia (when the rotation manipulation is complete).</summary>
    /// <returns>The rate of deceleration, in degrees/ms&lt;sup&gt;2&lt;/sup&gt;.</returns>
    public extern float InertiaRotationDeceleration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the rate of deceleration from the start of inertia to the end of inertia (when the resizing, or expansion, manipulation is complete).</summary>
    /// <returns>The rate of deceleration, in device-independent pixel (DIP)/ms&lt;sup&gt;2&lt;/sup&gt;.</returns>
    public extern float InertiaExpansionDeceleration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the relative change in the screen location of an object from the start of inertia to the end of inertia (when the translation manipulation is complete).</summary>
    /// <returns>The relative change in screen location, in device-independent pixel (DIP).</returns>
    public extern float InertiaTranslationDisplacement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the final angle of rotation of an object at the end of inertia (when the rotation manipulation is complete).</summary>
    /// <returns>The relative change in angle of rotation, in degrees.</returns>
    public extern float InertiaRotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the relative change in size of an object from the start of inertia to the end of inertia (when resizing, or scaling, is complete).</summary>
    /// <returns>The relative change in size, in device-independent pixel (DIP).</returns>
    public extern float InertiaExpansion { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the exact distance from initial contact to end of the interaction is reported.By default, a small distance threshold is subtracted from the first delta reported by the system. This distance threshold is intended to account for slight movements of the contact when processing a tap gesture. If this flag is set, the distance threshold is not subtracted from the first delta.</summary>
    /// <returns>True if the distance threshold is subtracted; otherwise false. The default value is false.</returns>
    public extern bool ManipulationExact { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets values that indicate the distance thresholds for a CrossSliding interaction.</summary>
    /// <returns>By default, every value in CrossSlideThresholds is set to 0.0 (CrossSliding functionality is disabled).</returns>
    public extern CrossSlideThresholds CrossSlideThresholds { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the cross-slide axis is horizontal.</summary>
    /// <returns>True if the cross-slide axis is horizontal; otherwise false. The default value is false.</returns>
    public extern bool CrossSlideHorizontally { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the exact distance from initial contact to end of the cross-slide interaction is reported.By default, a small distance threshold is subtracted from the first position reported by the system for cross-slide interactions. If this flag is set, the distance threshold is not subtracted from the initial position.</summary>
    /// <returns>True if the distance threshold is not subtracted; otherwise false. The default value is false.</returns>
    public extern bool CrossSlideExact { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether manipulations during inertia are generated automatically.</summary>
    /// <returns>True if manipulations are generated automatically; otherwise false. The default value is true.</returns>
    public extern bool AutoProcessInertia { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a set of properties that are associated with the wheel button of a mouse device.</summary>
    /// <returns>The collection of wheel button properties. The system defaults should be checked to ensure the best user experience for your app.</returns>
    public extern MouseWheelParameters MouseWheelParameters { [MethodImpl] get; }

    /// <summary>Identifies whether a tap can still be interpreted as the second tap of a double tap gesture.</summary>
    /// <param name="value">The last input pointer.</param>
    /// <returns>True if a UI element supports the double tap gesture and the time threshold to complete the gesture has not been crossed; otherwise false.</returns>
    [MethodImpl]
    public extern bool CanBeDoubleTap(PointerPoint value);

    /// <summary>Processes pointer input and raises the GestureRecognizer events appropriate to a pointer down action for the gestures and manipulations specified by the GestureSettings property.</summary>
    /// <param name="value">The input point.</param>
    [MethodImpl]
    public extern void ProcessDownEvent(PointerPoint value);

    [MethodImpl]
    public extern void ProcessMoveEvents(IVector<PointerPoint> value);

    /// <summary>Processes pointer input and raises the GestureRecognizer events appropriate to a pointer up action for the gestures and manipulations specified by the GestureSettings property.</summary>
    /// <param name="value">The input point.</param>
    [MethodImpl]
    public extern void ProcessUpEvent(PointerPoint value);

    /// <summary>Processes pointer input and raises the GestureRecognizer events appropriate to a mouse wheel action for the gestures and manipulations specified by the GestureSettings property.</summary>
    /// <param name="value">The input point.</param>
    /// <param name="isShiftKeyDown">True if the Shift key is pressed; otherwise false.</param>
    /// <param name="isControlKeyDown">True if the Ctrl key is pressed.</param>
    [MethodImpl]
    public extern void ProcessMouseWheelEvent(
      PointerPoint value,
      bool isShiftKeyDown,
      bool isControlKeyDown);

    /// <summary>Performs inertia calculations and raises the various inertia events.</summary>
    [MethodImpl]
    public extern void ProcessInertia();

    /// <summary>Causes the gesture recognizer to finalize an interaction.</summary>
    [MethodImpl]
    public extern void CompleteGesture();

    /// <summary>Occurs when the pointer input is interpreted as a tap gesture.</summary>
    public extern event TypedEventHandler<GestureRecognizer, TappedEventArgs> Tapped;

    /// <summary>Occurs when the pointer input is interpreted as a right-tap gesture, regardless of input device.</summary>
    public extern event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> RightTapped;

    /// <summary>Occurs when a user performs a press and hold gesture (with a single touch, mouse, or pen/stylus contact).</summary>
    public extern event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Holding;

    /// <summary>Occurs when a user performs a slide or swipe gesture with a mouse or pen/stylus (single contact).</summary>
    public extern event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Dragging;

    /// <summary>Occurs when one or more input points have been initiated and subsequent motion (translation, expansion, or rotation) has begun.</summary>
    public extern event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> ManipulationStarted;

    /// <summary>Occurs after one or more input points have been initiated and subsequent motion (translation, expansion, or rotation) is under way.</summary>
    public extern event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> ManipulationUpdated;

    /// <summary>Occurs when all contact points are lifted during a manipulation and the velocity of the manipulation is significant enough to initiate inertia behavior (translation, expansion, or rotation continue after the input pointers are lifted).</summary>
    public extern event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;

    /// <summary>Occurs when the input points are lifted and all subsequent motion (translation, expansion, or rotation) through inertia has ended.</summary>
    public extern event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> ManipulationCompleted;

    /// <summary>Occurs when a user performs a slide or swipe gesture (through a single touch contact) within a content area that supports panning along a single axis only. The gesture must occur in a direction that is perpendicular to this panning axis.</summary>
    public extern event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> CrossSliding;

    /// <summary>Gets or sets the minimum number of contact points needed to recognize a Windows.UI.Input.GestureRecognizer.Tapped event.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint TapMinContactCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of contact points needed to recognize a Windows.UI.Input.GestureRecognizer.Tapped event.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint TapMaxContactCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum number of contact points needed to recognize a Windows.UI.Input.GestureRecognizer.Holding event.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint HoldMinContactCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of contact points needed to recognize a Windows.UI.Input.GestureRecognizer.Holding event.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint HoldMaxContactCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the radius of the contact points recognized for the Windows.UI.Input.GestureRecognizer.Holding event.</summary>
    /// <returns>The radius of the contact points, in device-independent pixels (DIP).</returns>
    public extern float HoldRadius { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the time threshold at which the contacts are recognized for the Windows.UI.Input.GestureRecognizer.Holding event.</summary>
    /// <returns>The TimeSpan.</returns>
    public extern TimeSpan HoldStartDelay { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum number of contact points needed to recognize a translation (or panning) event.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint TranslationMinContactCount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum number of contact points needed to recognize a translation (or panning) event.</summary>
    /// <returns>The number of contact points.</returns>
    public extern uint TranslationMaxContactCount { [MethodImpl] get; [MethodImpl] set; }
  }
}
