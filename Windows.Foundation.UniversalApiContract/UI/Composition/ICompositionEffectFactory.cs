// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (CompositionEffectFactory))]
  [Guid(3193316527, 47742, 17680, 152, 80, 65, 192, 180, 255, 116, 223)]
  internal interface ICompositionEffectFactory
  {
    CompositionEffectBrush CreateBrush();

    HResult ExtendedError { get; }

    CompositionEffectFactoryLoadStatus LoadStatus { get; }
  }
}
