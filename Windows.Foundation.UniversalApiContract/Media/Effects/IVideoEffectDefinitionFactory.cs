// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoEffectDefinitionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (VideoEffectDefinition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2168691534, 28211, 17039, 157, 33, 181, 170, 254, 247, 97, 124)]
  internal interface IVideoEffectDefinitionFactory
  {
    VideoEffectDefinition Create(string activatableClassId);

    VideoEffectDefinition CreateWithProperties(
      string activatableClassId,
      IPropertySet props);
  }
}
