// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionProjectedShadowCasterCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [Guid(3528612876, 57471, 22691, 172, 145, 55, 247, 62, 233, 23, 64)]
  [ExclusiveTo(typeof (CompositionProjectedShadowCasterCollection))]
  internal interface ICompositionProjectedShadowCasterCollection
  {
    int Count { get; }

    void InsertAbove(
      CompositionProjectedShadowCaster newCaster,
      CompositionProjectedShadowCaster reference);

    void InsertAtBottom(CompositionProjectedShadowCaster newCaster);

    void InsertAtTop(CompositionProjectedShadowCaster newCaster);

    void InsertBelow(
      CompositionProjectedShadowCaster newCaster,
      CompositionProjectedShadowCaster reference);

    void Remove(CompositionProjectedShadowCaster caster);

    void RemoveAll();
  }
}
