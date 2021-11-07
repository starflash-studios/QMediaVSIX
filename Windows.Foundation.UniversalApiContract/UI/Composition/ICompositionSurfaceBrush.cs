// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionSurfaceBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionSurfaceBrush))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2902551929, 7756, 19469, 156, 41, 131, 51, 140, 135, 193, 98)]
  [WebHostHidden]
  internal interface ICompositionSurfaceBrush
  {
    CompositionBitmapInterpolationMode BitmapInterpolationMode { get; set; }

    float HorizontalAlignmentRatio { get; set; }

    CompositionStretch Stretch { get; set; }

    ICompositionSurface Surface { get; set; }

    float VerticalAlignmentRatio { get; set; }
  }
}
