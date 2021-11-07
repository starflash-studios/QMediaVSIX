// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(3212802398, 33740, 17599, 164, 71, 62, 60, 7, 23, 137, 236)]
  [ExclusiveTo(typeof (CompositionEffectBrush))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionEffectBrush
  {
    CompositionBrush GetSourceParameter(string name);

    void SetSourceParameter(string name, CompositionBrush source);
  }
}
