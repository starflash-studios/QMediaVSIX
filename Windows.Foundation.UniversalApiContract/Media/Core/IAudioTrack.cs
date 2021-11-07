// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IAudioTrack
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.MediaProperties;
using Windows.Media.Playback;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4063981175, 16119, 16606, 185, 67, 6, 139, 19, 33, 112, 29)]
  [ExclusiveTo(typeof (AudioTrack))]
  internal interface IAudioTrack
  {
    event TypedEventHandler<AudioTrack, AudioTrackOpenFailedEventArgs> OpenFailed;

    AudioEncodingProperties GetEncodingProperties();

    MediaPlaybackItem PlaybackItem { get; }

    string Name { get; }

    AudioTrackSupportInfo SupportInfo { get; }
  }
}
