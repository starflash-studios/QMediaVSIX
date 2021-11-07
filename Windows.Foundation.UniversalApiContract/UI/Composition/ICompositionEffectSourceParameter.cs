// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectSourceParameter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2240459066, 12946, 20046, 179, 187, 43, 108, 101, 68, 166, 238)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionEffectSourceParameter))]
  internal interface ICompositionEffectSourceParameter
  {
    string Name { get; }
  }
}
