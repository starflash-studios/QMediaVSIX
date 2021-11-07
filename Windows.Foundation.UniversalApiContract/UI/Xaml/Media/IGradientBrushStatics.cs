// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGradientBrushStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2518049273, 35764, 20076, 185, 35, 181, 215, 135, 224, 241, 169)]
  [ExclusiveTo(typeof (GradientBrush))]
  [WebHostHidden]
  internal interface IGradientBrushStatics
  {
    DependencyProperty SpreadMethodProperty { get; }

    DependencyProperty MappingModeProperty { get; }

    DependencyProperty ColorInterpolationModeProperty { get; }

    DependencyProperty GradientStopsProperty { get; }
  }
}
