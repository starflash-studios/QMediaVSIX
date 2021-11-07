// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterDecayModelStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioNodeEmitterDecayModel))]
  [Guid(3346562216, 61816, 17967, 188, 129, 141, 213, 203, 229, 218, 232)]
  internal interface IAudioNodeEmitterDecayModelStatics
  {
    AudioNodeEmitterDecayModel CreateNatural(
      double minGain,
      double maxGain,
      double unityGainDistance,
      double cutoffDistance);

    AudioNodeEmitterDecayModel CreateCustom(
      double minGain,
      double maxGain);
  }
}
