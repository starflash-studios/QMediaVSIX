// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Effects.ISceneLightingEffect2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Effects
{
  [Guid(2653359745, 29424, 19548, 149, 248, 138, 110, 0, 36, 244, 9)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (SceneLightingEffect))]
  internal interface ISceneLightingEffect2
  {
    SceneLightingEffectReflectanceModel ReflectanceModel { get; set; }
  }
}
