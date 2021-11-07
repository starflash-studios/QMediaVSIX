// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionAnimationGroup
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionAnimationGroup))]
  [Guid(1585236236, 52500, 19975, 138, 85, 199, 37, 39, 170, 189, 172)]
  [WebHostHidden]
  internal interface ICompositionAnimationGroup
  {
    int Count { get; }

    void Add(CompositionAnimation value);

    void Remove(CompositionAnimation value);

    void RemoveAll();
  }
}
