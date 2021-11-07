// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaPlayerElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaPlayerElement))]
  [WebHostHidden]
  [Guid(994878758, 11813, 17816, 188, 113, 212, 145, 248, 232, 222, 57)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlayerElement
  {
    IMediaPlaybackSource Source { get; set; }

    MediaTransportControls TransportControls { get; set; }

    bool AreTransportControlsEnabled { get; set; }

    ImageSource PosterSource { get; set; }

    Stretch Stretch { get; set; }

    bool AutoPlay { get; set; }

    bool IsFullWindow { get; set; }

    MediaPlayer MediaPlayer { get; }

    void SetMediaPlayer(MediaPlayer mediaPlayer);
  }
}
