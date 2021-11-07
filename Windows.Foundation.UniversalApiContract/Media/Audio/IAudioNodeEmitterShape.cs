// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioNodeEmitterShape
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3926069701, 59197, 17596, 133, 156, 69, 85, 59, 188, 72, 40)]
  [ExclusiveTo(typeof (AudioNodeEmitterShape))]
  internal interface IAudioNodeEmitterShape
  {
    AudioNodeEmitterShapeKind Kind { get; }

    AudioNodeEmitterConeProperties ConeProperties { get; }
  }
}
