// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioFileInputNode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2421909448, 28517, 19668, 136, 144, 70, 148, 132, 60, 39, 109)]
  [ExclusiveTo(typeof (AudioFileInputNode))]
  internal interface IAudioFileInputNode : IAudioInputNode, IAudioNode, IClosable
  {
    double PlaybackSpeedFactor { set; get; }

    TimeSpan Position { get; }

    void Seek(TimeSpan position);

    IReference<TimeSpan> StartTime { get; set; }

    IReference<TimeSpan> EndTime { get; set; }

    IReference<int> LoopCount { get; set; }

    TimeSpan Duration { get; }

    StorageFile SourceFile { get; }

    event TypedEventHandler<AudioFileInputNode, object> FileCompleted;
  }
}
