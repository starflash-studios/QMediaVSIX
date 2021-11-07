// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectSourceParameterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionEffectSourceParameter))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3017405046, 43939, 18212, 172, 243, 208, 57, 116, 100, 219, 28)]
  [WebHostHidden]
  internal interface ICompositionEffectSourceParameterFactory
  {
    CompositionEffectSourceParameter Create(string name);
  }
}
