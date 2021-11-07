// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElementStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml
{
  [Guid(1490245435, 62764, 17854, 152, 139, 165, 134, 149, 100, 135, 60)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UIElement))]
  [WebHostHidden]
  internal interface IUIElementStatics
  {
    RoutedEvent KeyDownEvent { get; }

    RoutedEvent KeyUpEvent { get; }

    RoutedEvent PointerEnteredEvent { get; }

    RoutedEvent PointerPressedEvent { get; }

    RoutedEvent PointerMovedEvent { get; }

    RoutedEvent PointerReleasedEvent { get; }

    RoutedEvent PointerExitedEvent { get; }

    RoutedEvent PointerCaptureLostEvent { get; }

    RoutedEvent PointerCanceledEvent { get; }

    RoutedEvent PointerWheelChangedEvent { get; }

    RoutedEvent TappedEvent { get; }

    RoutedEvent DoubleTappedEvent { get; }

    RoutedEvent HoldingEvent { get; }

    RoutedEvent RightTappedEvent { get; }

    RoutedEvent ManipulationStartingEvent { get; }

    RoutedEvent ManipulationInertiaStartingEvent { get; }

    RoutedEvent ManipulationStartedEvent { get; }

    RoutedEvent ManipulationDeltaEvent { get; }

    RoutedEvent ManipulationCompletedEvent { get; }

    RoutedEvent DragEnterEvent { get; }

    RoutedEvent DragLeaveEvent { get; }

    RoutedEvent DragOverEvent { get; }

    RoutedEvent DropEvent { get; }

    DependencyProperty AllowDropProperty { get; }

    [IndependentlyAnimatable]
    DependencyProperty OpacityProperty { [IndependentlyAnimatable] get; }

    [IndependentlyAnimatable]
    DependencyProperty ClipProperty { [IndependentlyAnimatable] get; }

    [IndependentlyAnimatable]
    DependencyProperty RenderTransformProperty { [IndependentlyAnimatable] get; }

    [IndependentlyAnimatable]
    DependencyProperty ProjectionProperty { [IndependentlyAnimatable] get; }

    DependencyProperty RenderTransformOriginProperty { get; }

    DependencyProperty IsHitTestVisibleProperty { get; }

    DependencyProperty VisibilityProperty { get; }

    DependencyProperty UseLayoutRoundingProperty { get; }

    DependencyProperty TransitionsProperty { get; }

    DependencyProperty CacheModeProperty { get; }

    DependencyProperty IsTapEnabledProperty { get; }

    DependencyProperty IsDoubleTapEnabledProperty { get; }

    DependencyProperty IsRightTapEnabledProperty { get; }

    DependencyProperty IsHoldingEnabledProperty { get; }

    DependencyProperty ManipulationModeProperty { get; }

    DependencyProperty PointerCapturesProperty { get; }
  }
}
