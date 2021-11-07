// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionRectangleGeometry
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(215290920, 21334, 16966, 174, 207, 122, 11, 118, 151, 84, 0)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (CompositionRectangleGeometry))]
  [WebHostHidden]
  internal interface ICompositionRectangleGeometry
  {
    Vector2 Offset { get; set; }

    Vector2 Size { get; set; }
  }
}
