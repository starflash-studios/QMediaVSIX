// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IColorPickerStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ColorPicker))]
  [Guid(1741331431, 5492, 17690, 182, 223, 254, 87, 217, 208, 123, 70)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IColorPickerStatics
  {
    DependencyProperty ColorProperty { get; }

    DependencyProperty PreviousColorProperty { get; }

    DependencyProperty IsAlphaEnabledProperty { get; }

    DependencyProperty IsColorSpectrumVisibleProperty { get; }

    DependencyProperty IsColorPreviewVisibleProperty { get; }

    DependencyProperty IsColorSliderVisibleProperty { get; }

    DependencyProperty IsAlphaSliderVisibleProperty { get; }

    DependencyProperty IsMoreButtonVisibleProperty { get; }

    DependencyProperty IsColorChannelTextInputVisibleProperty { get; }

    DependencyProperty IsAlphaTextInputVisibleProperty { get; }

    DependencyProperty IsHexInputVisibleProperty { get; }

    DependencyProperty MinHueProperty { get; }

    DependencyProperty MaxHueProperty { get; }

    DependencyProperty MinSaturationProperty { get; }

    DependencyProperty MaxSaturationProperty { get; }

    DependencyProperty MinValueProperty { get; }

    DependencyProperty MaxValueProperty { get; }

    DependencyProperty ColorSpectrumShapeProperty { get; }

    DependencyProperty ColorSpectrumComponentsProperty { get; }
  }
}
