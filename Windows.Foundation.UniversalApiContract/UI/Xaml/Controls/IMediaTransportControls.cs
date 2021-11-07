// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControls
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(3606486653, 2085, 18857, 159, 206, 85, 134, 216, 105, 79, 12)]
  [ExclusiveTo(typeof (MediaTransportControls))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaTransportControls
  {
    bool IsFullWindowButtonVisible { get; set; }

    bool IsFullWindowEnabled { get; set; }

    bool IsZoomButtonVisible { get; set; }

    bool IsZoomEnabled { get; set; }

    bool IsFastForwardButtonVisible { get; set; }

    bool IsFastForwardEnabled { get; set; }

    bool IsFastRewindButtonVisible { get; set; }

    bool IsFastRewindEnabled { get; set; }

    bool IsStopButtonVisible { get; set; }

    bool IsStopEnabled { get; set; }

    bool IsVolumeButtonVisible { get; set; }

    bool IsVolumeEnabled { get; set; }

    bool IsPlaybackRateButtonVisible { get; set; }

    bool IsPlaybackRateEnabled { get; set; }

    bool IsSeekBarVisible { get; set; }

    bool IsSeekEnabled { get; set; }

    bool IsCompact { get; set; }
  }
}
