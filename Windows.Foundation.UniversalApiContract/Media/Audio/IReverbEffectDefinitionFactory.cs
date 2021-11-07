// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IReverbEffectDefinitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ExclusiveTo(typeof (ReverbEffectDefinition))]
  [Guid(2815806462, 4107, 20464, 157, 166, 220, 78, 5, 167, 89, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IReverbEffectDefinitionFactory
  {
    ReverbEffectDefinition Create(AudioGraph audioGraph);
  }
}
