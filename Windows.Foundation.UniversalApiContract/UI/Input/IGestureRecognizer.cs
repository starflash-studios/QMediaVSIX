// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IGestureRecognizer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GestureRecognizer))]
  [Guid(3027908543, 15723, 20360, 131, 232, 109, 203, 64, 18, 255, 176)]
  internal interface IGestureRecognizer
  {
    GestureSettings GestureSettings { get; set; }

    bool IsInertial { get; }

    bool IsActive { get; }

    bool ShowGestureFeedback { get; set; }

    Point PivotCenter { get; set; }

    float PivotRadius { get; set; }

    float InertiaTranslationDeceleration { get; set; }

    float InertiaRotationDeceleration { get; set; }

    float InertiaExpansionDeceleration { get; set; }

    float InertiaTranslationDisplacement { get; set; }

    float InertiaRotationAngle { get; set; }

    float InertiaExpansion { get; set; }

    bool ManipulationExact { get; set; }

    CrossSlideThresholds CrossSlideThresholds { get; set; }

    bool CrossSlideHorizontally { get; set; }

    bool CrossSlideExact { get; set; }

    bool AutoProcessInertia { get; set; }

    MouseWheelParameters MouseWheelParameters { get; }

    bool CanBeDoubleTap(PointerPoint value);

    void ProcessDownEvent(PointerPoint value);

    void ProcessMoveEvents(IVector<PointerPoint> value);

    void ProcessUpEvent(PointerPoint value);

    void ProcessMouseWheelEvent(PointerPoint value, bool isShiftKeyDown, bool isControlKeyDown);

    void ProcessInertia();

    void CompleteGesture();

    event TypedEventHandler<GestureRecognizer, TappedEventArgs> Tapped;

    event TypedEventHandler<GestureRecognizer, RightTappedEventArgs> RightTapped;

    event TypedEventHandler<GestureRecognizer, HoldingEventArgs> Holding;

    event TypedEventHandler<GestureRecognizer, DraggingEventArgs> Dragging;

    event TypedEventHandler<GestureRecognizer, ManipulationStartedEventArgs> ManipulationStarted;

    event TypedEventHandler<GestureRecognizer, ManipulationUpdatedEventArgs> ManipulationUpdated;

    event TypedEventHandler<GestureRecognizer, ManipulationInertiaStartingEventArgs> ManipulationInertiaStarting;

    event TypedEventHandler<GestureRecognizer, ManipulationCompletedEventArgs> ManipulationCompleted;

    event TypedEventHandler<GestureRecognizer, CrossSlidingEventArgs> CrossSliding;
  }
}
