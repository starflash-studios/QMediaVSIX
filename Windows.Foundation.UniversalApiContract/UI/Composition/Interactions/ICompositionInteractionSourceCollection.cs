// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.ICompositionInteractionSourceCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Guid(457608779, 42431, 18392, 165, 71, 56, 148, 21, 90, 21, 140)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CompositionInteractionSourceCollection))]
  internal interface ICompositionInteractionSourceCollection
  {
    int Count { get; }

    void Add(ICompositionInteractionSource value);

    void Remove(ICompositionInteractionSource value);

    void RemoveAll();
  }
}
