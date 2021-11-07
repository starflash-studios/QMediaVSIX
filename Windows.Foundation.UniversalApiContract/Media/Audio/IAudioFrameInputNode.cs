// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFrameInputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(28468935, 64918, 20469, 163, 197, 210, 122, 155, 244, 66, 55)]
  [ExclusiveTo(typeof (AudioFrameInputNode))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAudioFrameInputNode : IAudioInputNode, IAudioNode, IClosable
  {
    double PlaybackSpeedFactor { set; get; }

    void AddFrame(AudioFrame frame);

    void DiscardQueuedFrames();

    ulong QueuedSampleCount { get; }

    event TypedEventHandler<AudioFrameInputNode, AudioFrameCompletedEventArgs> AudioFrameCompleted;

    event TypedEventHandler<AudioFrameInputNode, FrameInputNodeQuantumStartedEventArgs> QuantumStarted;
  }
}
