// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControlsStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(388550620, 22047, 17286, 167, 248, 9, 13, 149, 246, 141, 150)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaTransportControls))]
  internal interface IMediaTransportControlsStatics2
  {
    DependencyProperty IsSkipForwardButtonVisibleProperty { get; }

    DependencyProperty IsSkipForwardEnabledProperty { get; }

    DependencyProperty IsSkipBackwardButtonVisibleProperty { get; }

    DependencyProperty IsSkipBackwardEnabledProperty { get; }

    DependencyProperty IsNextTrackButtonVisibleProperty { get; }

    DependencyProperty IsPreviousTrackButtonVisibleProperty { get; }

    DependencyProperty FastPlayFallbackBehaviourProperty { get; }
  }
}
