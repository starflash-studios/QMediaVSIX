// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IColorSpectrumStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(2422992508, 11502, 20112, 150, 139, 240, 165, 189, 105, 27, 74)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ColorSpectrum))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IColorSpectrumStatics
  {
    DependencyProperty ColorProperty { get; }

    DependencyProperty HsvColorProperty { get; }

    DependencyProperty MinHueProperty { get; }

    DependencyProperty MaxHueProperty { get; }

    DependencyProperty MinSaturationProperty { get; }

    DependencyProperty MaxSaturationProperty { get; }

    DependencyProperty MinValueProperty { get; }

    DependencyProperty MaxValueProperty { get; }

    DependencyProperty ShapeProperty { get; }

    DependencyProperty ComponentsProperty { get; }
  }
}
