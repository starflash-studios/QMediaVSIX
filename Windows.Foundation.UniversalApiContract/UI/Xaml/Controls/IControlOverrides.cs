// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IControlOverrides
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Control))]
  [Guid(2694222303, 38948, 16894, 181, 48, 176, 216, 153, 14, 100, 193)]
  internal interface IControlOverrides
  {
    void OnPointerEntered(PointerRoutedEventArgs e);

    void OnPointerPressed(PointerRoutedEventArgs e);

    void OnPointerMoved(PointerRoutedEventArgs e);

    void OnPointerReleased(PointerRoutedEventArgs e);

    void OnPointerExited(PointerRoutedEventArgs e);

    void OnPointerCaptureLost(PointerRoutedEventArgs e);

    void OnPointerCanceled(PointerRoutedEventArgs e);

    void OnPointerWheelChanged(PointerRoutedEventArgs e);

    void OnTapped(TappedRoutedEventArgs e);

    void OnDoubleTapped(DoubleTappedRoutedEventArgs e);

    void OnHolding(HoldingRoutedEventArgs e);

    void OnRightTapped(RightTappedRoutedEventArgs e);

    void OnManipulationStarting(ManipulationStartingRoutedEventArgs e);

    void OnManipulationInertiaStarting(ManipulationInertiaStartingRoutedEventArgs e);

    void OnManipulationStarted(ManipulationStartedRoutedEventArgs e);

    void OnManipulationDelta(ManipulationDeltaRoutedEventArgs e);

    void OnManipulationCompleted(ManipulationCompletedRoutedEventArgs e);

    void OnKeyUp(KeyRoutedEventArgs e);

    void OnKeyDown(KeyRoutedEventArgs e);

    void OnGotFocus(RoutedEventArgs e);

    void OnLostFocus(RoutedEventArgs e);

    void OnDragEnter(DragEventArgs e);

    void OnDragLeave(DragEventArgs e);

    void OnDragOver(DragEventArgs e);

    void OnDrop(DragEventArgs e);
  }
}
