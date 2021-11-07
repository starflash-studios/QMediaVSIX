// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaTransportControls2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(730460140, 7146, 17694, 139, 205, 207, 226, 217, 66, 50, 98)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (MediaTransportControls))]
  internal interface IMediaTransportControls2
  {
    bool IsSkipForwardButtonVisible { get; set; }

    bool IsSkipForwardEnabled { get; set; }

    bool IsSkipBackwardButtonVisible { get; set; }

    bool IsSkipBackwardEnabled { get; set; }

    bool IsNextTrackButtonVisible { get; set; }

    bool IsPreviousTrackButtonVisible { get; set; }

    FastPlayFallbackBehaviour FastPlayFallbackBehaviour { get; set; }

    event TypedEventHandler<MediaTransportControls, MediaTransportControlsThumbnailRequestedEventArgs> ThumbnailRequested;
  }
}
