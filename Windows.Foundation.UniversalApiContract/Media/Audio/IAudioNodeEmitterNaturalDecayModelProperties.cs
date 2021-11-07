// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterNaturalDecayModelProperties
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(1217612751, 53036, 20220, 147, 49, 117, 189, 34, 223, 31, 12)]
  [ExclusiveTo(typeof (AudioNodeEmitterNaturalDecayModelProperties))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAudioNodeEmitterNaturalDecayModelProperties
  {
    double UnityGainDistance { get; }

    double CutoffDistance { get; }
  }
}
