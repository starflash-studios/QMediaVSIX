// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraph2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;

namespace Windows.Media.Audio
{
  [Guid(1313618901, 20417, 17910, 169, 71, 60, 211, 143, 79, 216, 57)]
  [ExclusiveTo(typeof (AudioGraph))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioGraph2 : IClosable, IAudioGraph
  {
    [Overload("CreateFrameInputNodeWithFormatAndEmitter")]
    AudioFrameInputNode CreateFrameInputNode(
      AudioEncodingProperties encodingProperties,
      AudioNodeEmitter emitter);

    [RemoteAsync]
    [Overload("CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync")]
    IAsyncOperation<CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(
      MediaCategory category,
      AudioEncodingProperties encodingProperties,
      DeviceInformation device,
      AudioNodeEmitter emitter);

    [Overload("CreateFileInputNodeWithEmitterAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateAudioFileInputNodeResult> CreateFileInputNodeAsync(
      IStorageFile file,
      AudioNodeEmitter emitter);

    [Overload("CreateSubmixNodeWithFormatAndEmitter")]
    AudioSubmixNode CreateSubmixNode(
      AudioEncodingProperties encodingProperties,
      AudioNodeEmitter emitter);

    AudioGraphBatchUpdater CreateBatchUpdater();
  }
}
