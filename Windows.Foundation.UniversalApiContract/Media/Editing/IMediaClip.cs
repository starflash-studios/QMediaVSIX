// Decompiled with JetBrains decompiler
// Type: Windows.Media.Editing.IMediaClip
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;
using Windows.Media.MediaProperties;

namespace Windows.Media.Editing
{
  [Guid(1408389990, 24506, 16036, 134, 147, 36, 118, 24, 17, 20, 10)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaClip))]
  internal interface IMediaClip
  {
    TimeSpan TrimTimeFromStart { get; set; }

    TimeSpan TrimTimeFromEnd { get; set; }

    TimeSpan OriginalDuration { get; }

    TimeSpan TrimmedDuration { get; }

    IMap<string, string> UserData { get; }

    MediaClip Clone();

    TimeSpan StartTimeInComposition { get; }

    TimeSpan EndTimeInComposition { get; }

    IVectorView<EmbeddedAudioTrack> EmbeddedAudioTracks { get; }

    uint SelectedEmbeddedAudioTrackIndex { get; set; }

    double Volume { set; get; }

    VideoEncodingProperties GetVideoEncodingProperties();

    IVector<IAudioEffectDefinition> AudioEffectDefinitions { get; }

    IVector<IVideoEffectDefinition> VideoEffectDefinitions { get; }
  }
}
