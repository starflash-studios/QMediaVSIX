// Decompiled with JetBrains decompiler
// Type: Windows.Media.Playback.IMediaPlayer2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Playback
{
  [ExclusiveTo(typeof (MediaPlayer))]
  [Guid(1015288344, 8483, 20421, 144, 130, 47, 136, 63, 119, 189, 245)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaPlayer2
  {
    SystemMediaTransportControls SystemMediaTransportControls { get; }

    MediaPlayerAudioCategory AudioCategory { get; set; }

    MediaPlayerAudioDeviceType AudioDeviceType { get; set; }
  }
}
