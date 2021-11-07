// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.ICompositionConditionalValueStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Guid(151800690, 33895, 19722, 144, 101, 172, 70, 184, 10, 85, 34)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionConditionalValue))]
  internal interface ICompositionConditionalValueStatics
  {
    CompositionConditionalValue Create(Compositor compositor);
  }
}
