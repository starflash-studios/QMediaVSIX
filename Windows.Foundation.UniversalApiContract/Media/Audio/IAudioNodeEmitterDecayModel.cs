// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterDecayModel
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (AudioNodeEmitterDecayModel))]
  [Guid(488463095, 3411, 20393, 189, 132, 213, 129, 106, 134, 243, 255)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioNodeEmitterDecayModel
  {
    AudioNodeEmitterDecayKind Kind { get; }

    double MinGain { get; }

    double MaxGain { get; }

    AudioNodeEmitterNaturalDecayModelProperties NaturalProperties { get; }
  }
}
