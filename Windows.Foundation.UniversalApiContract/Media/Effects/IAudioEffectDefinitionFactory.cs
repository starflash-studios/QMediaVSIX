// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffectDefinitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (AudioEffectDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2384307782, 59141, 17901, 138, 43, 252, 78, 79, 64, 90, 151)]
  internal interface IAudioEffectDefinitionFactory
  {
    AudioEffectDefinition Create(string activatableClassId);

    AudioEffectDefinition CreateWithProperties(
      string activatableClassId,
      IPropertySet props);
  }
}
