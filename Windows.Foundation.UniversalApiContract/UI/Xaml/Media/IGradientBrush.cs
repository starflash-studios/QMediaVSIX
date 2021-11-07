// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (GradientBrush))]
  [Guid(560391839, 37722, 16785, 142, 60, 28, 141, 253, 252, 220, 120)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGradientBrush
  {
    GradientSpreadMethod SpreadMethod { get; set; }

    BrushMappingMode MappingMode { get; set; }

    ColorInterpolationMode ColorInterpolationMode { get; set; }

    GradientStopCollection GradientStops { get; set; }
  }
}
