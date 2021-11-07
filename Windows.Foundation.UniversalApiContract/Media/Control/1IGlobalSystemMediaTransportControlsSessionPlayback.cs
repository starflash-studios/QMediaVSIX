// Decompiled with JetBrains decompiler
// Type: Windows.Media.Control.IGlobalSystemMediaTransportControlsSessionPlaybackInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Control
{
  [ExclusiveTo(typeof (GlobalSystemMediaTransportControlsSessionPlaybackInfo))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(2494871247, 59578, 20909, 135, 167, 193, 10, 222, 16, 97, 39)]
  internal interface IGlobalSystemMediaTransportControlsSessionPlaybackInfo
  {
    GlobalSystemMediaTransportControlsSessionPlaybackControls Controls { get; }

    GlobalSystemMediaTransportControlsSessionPlaybackStatus PlaybackStatus { get; }

    IReference<MediaPlaybackType> PlaybackType { get; }

    IReference<MediaPlaybackAutoRepeatMode> AutoRepeatMode { get; }

    IReference<double> PlaybackRate { get; }

    IReference<bool> IsShuffleActive { get; }
  }
}
