// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IScrollViewer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(1693040128, 19905, 18749, 171, 231, 203, 211, 197, 119, 73, 13)]
  [ExclusiveTo(typeof (ScrollViewer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScrollViewer
  {
    ScrollBarVisibility HorizontalScrollBarVisibility { get; set; }

    ScrollBarVisibility VerticalScrollBarVisibility { get; set; }

    bool IsHorizontalRailEnabled { get; set; }

    bool IsVerticalRailEnabled { get; set; }

    bool IsHorizontalScrollChainingEnabled { get; set; }

    bool IsVerticalScrollChainingEnabled { get; set; }

    bool IsZoomChainingEnabled { get; set; }

    bool IsScrollInertiaEnabled { get; set; }

    bool IsZoomInertiaEnabled { get; set; }

    ScrollMode HorizontalScrollMode { get; set; }

    ScrollMode VerticalScrollMode { get; set; }

    ZoomMode ZoomMode { get; set; }

    SnapPointsAlignment HorizontalSnapPointsAlignment { get; set; }

    SnapPointsAlignment VerticalSnapPointsAlignment { get; set; }

    SnapPointsType HorizontalSnapPointsType { get; set; }

    SnapPointsType VerticalSnapPointsType { get; set; }

    SnapPointsType ZoomSnapPointsType { get; set; }

    double HorizontalOffset { get; }

    double ViewportWidth { get; }

    double ScrollableWidth { get; }

    Visibility ComputedHorizontalScrollBarVisibility { get; }

    double ExtentWidth { get; }

    double VerticalOffset { get; }

    double ViewportHeight { get; }

    double ScrollableHeight { get; }

    Visibility ComputedVerticalScrollBarVisibility { get; }

    double ExtentHeight { get; }

    float MinZoomFactor { get; set; }

    float MaxZoomFactor { get; set; }

    float ZoomFactor { get; }

    IVector<float> ZoomSnapPoints { get; }

    event EventHandler<ScrollViewerViewChangedEventArgs> ViewChanged;

    [Deprecated("ScrollToHorizontalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ScrollToHorizontalOffset(double offset);

    [Deprecated("ScrollToVerticalOffset may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ScrollToVerticalOffset(double offset);

    [Deprecated("ZoomToFactor may be altered or unavailable for releases after Windows 8.1. Instead, use ChangeView.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    void ZoomToFactor(float factor);

    void InvalidateScrollInfo();

    bool IsDeferredScrollingEnabled { get; set; }

    bool BringIntoViewOnFocusChange { get; set; }
  }
}
