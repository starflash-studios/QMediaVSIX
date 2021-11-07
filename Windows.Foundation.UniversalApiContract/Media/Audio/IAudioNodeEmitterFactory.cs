// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(4257761434, 27350, 19684, 183, 247, 169, 147, 112, 223, 126, 233)]
  [ExclusiveTo(typeof (AudioNodeEmitter))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioNodeEmitterFactory
  {
    AudioNodeEmitter CreateAudioNodeEmitter(
      AudioNodeEmitterShape shape,
      AudioNodeEmitterDecayModel decayModel,
      AudioNodeEmitterSettings settings);
  }
}
