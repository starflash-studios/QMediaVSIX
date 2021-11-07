// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IMediaSourceAudioInputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Audio
{
  [Guid(2581108795, 43146, 16449, 142, 79, 221, 186, 192, 201, 31, 211)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (MediaSourceAudioInputNode))]
  internal interface IMediaSourceAudioInputNode : 
    IAudioInputNode,
    IAudioNode,
    IClosable,
    IAudioInputNode2
  {
    double PlaybackSpeedFactor { set; get; }

    TimeSpan Position { get; }

    void Seek(TimeSpan position);

    IReference<TimeSpan> StartTime { get; set; }

    IReference<TimeSpan> EndTime { get; set; }

    IReference<int> LoopCount { get; set; }

    TimeSpan Duration { get; }

    MediaSource MediaSource { get; }

    event TypedEventHandler<MediaSourceAudioInputNode, object> MediaSourceCompleted;
  }
}
