// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1494132999, 53999, 19482, 148, 41, 180, 177, 93, 100, 253, 86)]
  [ExclusiveTo(typeof (MediaTransportControls))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaTransportControlsStatics
  {
    DependencyProperty IsFullWindowButtonVisibleProperty { get; }

    DependencyProperty IsFullWindowEnabledProperty { get; }

    DependencyProperty IsZoomButtonVisibleProperty { get; }

    DependencyProperty IsZoomEnabledProperty { get; }

    DependencyProperty IsFastForwardButtonVisibleProperty { get; }

    DependencyProperty IsFastForwardEnabledProperty { get; }

    DependencyProperty IsFastRewindButtonVisibleProperty { get; }

    DependencyProperty IsFastRewindEnabledProperty { get; }

    DependencyProperty IsStopButtonVisibleProperty { get; }

    DependencyProperty IsStopEnabledProperty { get; }

    DependencyProperty IsVolumeButtonVisibleProperty { get; }

    DependencyProperty IsVolumeEnabledProperty { get; }

    DependencyProperty IsPlaybackRateButtonVisibleProperty { get; }

    DependencyProperty IsPlaybackRateEnabledProperty { get; }

    DependencyProperty IsSeekBarVisibleProperty { get; }

    DependencyProperty IsSeekEnabledProperty { get; }

    DependencyProperty IsCompactProperty { get; }
  }
}
