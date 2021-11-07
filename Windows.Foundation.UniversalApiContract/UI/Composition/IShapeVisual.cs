// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IShapeVisual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ShapeVisual))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(4072477635, 47742, 19215, 145, 38, 255, 183, 83, 107, 129, 118)]
  internal interface IShapeVisual
  {
    CompositionShapeCollection Shapes { get; }

    CompositionViewBox ViewBox { get; set; }
  }
}
