// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Effects.ISceneLightingEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition.Effects
{
  [Guid(2444975698, 38353, 20363, 154, 90, 100, 8, 178, 75, 140, 106)]
  [ExclusiveTo(typeof (SceneLightingEffect))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface ISceneLightingEffect
  {
    float AmbientAmount { get; set; }

    float DiffuseAmount { get; set; }

    IGraphicsEffectSource NormalMapSource { get; set; }

    float SpecularAmount { get; set; }

    float SpecularShine { get; set; }
  }
}
