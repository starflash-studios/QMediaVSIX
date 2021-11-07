// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMediaElement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.PlayTo;
using Windows.Media.Protection;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MediaElement))]
  [Guid(2744046287, 5086, 17049, 173, 226, 174, 24, 247, 78, 211, 83)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaElement
  {
    ImageSource PosterSource { get; set; }

    Uri Source { get; set; }

    bool IsMuted { get; set; }

    bool IsAudioOnly { get; }

    bool AutoPlay { get; set; }

    double Volume { get; set; }

    double Balance { get; set; }

    int NaturalVideoHeight { get; }

    int NaturalVideoWidth { get; }

    Duration NaturalDuration { get; }

    TimeSpan Position { get; set; }

    double DownloadProgress { get; }

    double BufferingProgress { get; }

    double DownloadProgressOffset { get; }

    MediaElementState CurrentState { get; }

    TimelineMarkerCollection Markers { get; }

    bool CanSeek { get; }

    bool CanPause { get; }

    int AudioStreamCount { get; }

    IReference<int> AudioStreamIndex { get; set; }

    double PlaybackRate { get; set; }

    bool IsLooping { get; set; }

    PlayToSource PlayToSource { [Deprecated("PlayToSource may be altered or unavailable for releases after Windows 10.0. Instead, use GetAsCastingSource.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    double DefaultPlaybackRate { get; set; }

    int AspectRatioWidth { get; }

    int AspectRatioHeight { get; }

    bool RealTimePlayback { get; set; }

    AudioCategory AudioCategory { get; set; }

    AudioDeviceType AudioDeviceType { get; set; }

    MediaProtectionManager ProtectionManager { get; set; }

    Stereo3DVideoPackingMode Stereo3DVideoPackingMode { get; set; }

    Stereo3DVideoRenderMode Stereo3DVideoRenderMode { get; set; }

    bool IsStereo3DVideo { get; }

    event RoutedEventHandler MediaOpened;

    event RoutedEventHandler MediaEnded;

    event ExceptionRoutedEventHandler MediaFailed;

    event RoutedEventHandler DownloadProgressChanged;

    event RoutedEventHandler BufferingProgressChanged;

    event RoutedEventHandler CurrentStateChanged;

    event TimelineMarkerRoutedEventHandler MarkerReached;

    event RateChangedRoutedEventHandler RateChanged;

    event RoutedEventHandler VolumeChanged;

    event RoutedEventHandler SeekCompleted;

    void Stop();

    void Play();

    void Pause();

    MediaCanPlayResponse CanPlayType(string type);

    void SetSource(IRandomAccessStream stream, string mimeType);

    string GetAudioStreamLanguage(IReference<int> index);

    void AddAudioEffect(string effectID, bool effectOptional, IPropertySet effectConfiguration);

    void AddVideoEffect(string effectID, bool effectOptional, IPropertySet effectConfiguration);

    void RemoveAllEffects();

    Stereo3DVideoPackingMode ActualStereo3DVideoPackingMode { get; }
  }
}
