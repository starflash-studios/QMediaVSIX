// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSurfaceBrush3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (CompositionSurfaceBrush))]
  [Guid(1426829961, 8160, 17125, 129, 149, 30, 239, 168, 127, 240, 142)]
  internal interface ICompositionSurfaceBrush3
  {
    bool SnapToPixels { get; set; }
  }
}
