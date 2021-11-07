// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionLineGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(3715503524, 3226, 19303, 141, 206, 68, 10, 91, 249, 205, 236)]
  [ExclusiveTo(typeof (CompositionLineGeometry))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  internal interface ICompositionLineGeometry
  {
    Vector2 Start { get; set; }

    Vector2 End { get; set; }
  }
}
