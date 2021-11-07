// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVisualCollection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2339656965, 64830, 19096, 132, 168, 233, 73, 70, 140, 107, 203)]
  [ExclusiveTo(typeof (VisualCollection))]
  internal interface IVisualCollection
  {
    int Count { get; }

    void InsertAbove(Visual newChild, Visual sibling);

    void InsertAtBottom(Visual newChild);

    void InsertAtTop(Visual newChild);

    void InsertBelow(Visual newChild, Visual sibling);

    void Remove(Visual child);

    void RemoveAll();
  }
}
