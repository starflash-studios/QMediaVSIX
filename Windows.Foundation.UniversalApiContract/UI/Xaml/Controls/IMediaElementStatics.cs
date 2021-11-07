// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElementStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3704433849, 30056, 18050, 167, 42, 141, 223, 42, 38, 101, 202)]
  [ExclusiveTo(typeof (MediaElement))]
  internal interface IMediaElementStatics
  {
    DependencyProperty PosterSourceProperty { get; }

    DependencyProperty SourceProperty { get; }

    DependencyProperty IsMutedProperty { get; }

    DependencyProperty IsAudioOnlyProperty { get; }

    DependencyProperty AutoPlayProperty { get; }

    DependencyProperty VolumeProperty { get; }

    DependencyProperty BalanceProperty { get; }

    DependencyProperty NaturalVideoHeightProperty { get; }

    DependencyProperty NaturalVideoWidthProperty { get; }

    DependencyProperty NaturalDurationProperty { get; }

    DependencyProperty PositionProperty { get; }

    DependencyProperty DownloadProgressProperty { get; }

    DependencyProperty BufferingProgressProperty { get; }

    DependencyProperty DownloadProgressOffsetProperty { get; }

    DependencyProperty CurrentStateProperty { get; }

    DependencyProperty CanSeekProperty { get; }

    DependencyProperty CanPauseProperty { get; }

    DependencyProperty AudioStreamCountProperty { get; }

    DependencyProperty AudioStreamIndexProperty { get; }

    DependencyProperty PlaybackRateProperty { get; }

    DependencyProperty IsLoopingProperty { get; }

    DependencyProperty PlayToSourceProperty { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    DependencyProperty DefaultPlaybackRateProperty { get; }

    DependencyProperty AspectRatioWidthProperty { get; }

    DependencyProperty AspectRatioHeightProperty { get; }

    DependencyProperty RealTimePlaybackProperty { get; }

    DependencyProperty AudioCategoryProperty { get; }

    DependencyProperty AudioDeviceTypeProperty { get; }

    DependencyProperty ProtectionManagerProperty { get; }

    DependencyProperty Stereo3DVideoPackingModeProperty { get; }

    DependencyProperty Stereo3DVideoRenderModeProperty { get; }

    DependencyProperty IsStereo3DVideoProperty { get; }

    DependencyProperty ActualStereo3DVideoPackingModeProperty { get; }
  }
}
