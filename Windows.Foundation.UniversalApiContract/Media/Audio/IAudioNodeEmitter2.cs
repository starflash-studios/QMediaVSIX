// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [Guid(1253502667, 60457, 18424, 129, 140, 182, 182, 96, 165, 174, 177)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AudioNodeEmitter))]
  internal interface IAudioNodeEmitter2
  {
    SpatialAudioModel SpatialAudioModel { get; set; }
  }
}
