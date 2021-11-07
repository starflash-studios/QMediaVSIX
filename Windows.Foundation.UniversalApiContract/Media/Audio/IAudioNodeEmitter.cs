// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Audio
{
  [Guid(913741597, 34826, 18360, 173, 247, 19, 35, 169, 217, 101, 190)]
  [ExclusiveTo(typeof (AudioNodeEmitter))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioNodeEmitter
  {
    Vector3 Position { get; set; }

    Vector3 Direction { get; set; }

    AudioNodeEmitterShape Shape { get; }

    AudioNodeEmitterDecayModel DecayModel { get; }

    double Gain { get; set; }

    double DistanceScale { get; set; }

    double DopplerScale { get; set; }

    Vector3 DopplerVelocity { get; set; }

    bool IsDopplerDisabled { get; }
  }
}
