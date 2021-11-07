// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioGraph3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Core;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioGraph))]
  [Guid(3721209262, 4485, 17063, 131, 29, 106, 155, 15, 200, 104, 32)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface IAudioGraph3
  {
    [Overload("CreateMediaSourceAudioInputNodeAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateMediaSourceAudioInputNodeResult> CreateMediaSourceAudioInputNodeAsync(
      MediaSource mediaSource);

    [Overload("CreateMediaSourceAudioInputNodeWithEmitterAsync")]
    [RemoteAsync]
    IAsyncOperation<CreateMediaSourceAudioInputNodeResult> CreateMediaSourceAudioInputNodeAsync(
      MediaSource mediaSource,
      AudioNodeEmitter emitter);
  }
}
