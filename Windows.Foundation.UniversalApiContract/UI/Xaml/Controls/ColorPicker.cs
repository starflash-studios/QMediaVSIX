// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ColorPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that lets a user pick a color using a color spectrum, sliders, and text input.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IColorPickerFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IColorPickerStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class ColorPicker : Control, IColorPicker
  {
    /// <summary>Initializes a new instance of the ColorPicker class.</summary>
    [MethodImpl]
    public extern ColorPicker();

    /// <summary>Gets or sets the current color value.</summary>
    /// <returns>The current color value.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the previous color.</summary>
    /// <returns>The previous color. The default is **null**.</returns>
    public extern IReference<Color> PreviousColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the alpha channel can be modified.</summary>
    /// <returns>**true** if the alpha channel is enabled; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsAlphaEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the color spectrum control is shown.</summary>
    /// <returns>**true** if the color spectrum is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorSpectrumVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the color preview bar is shown.</summary>
    /// <returns>**true** if the color preview bar is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorPreviewVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the slider control for the color value is shown.</summary>
    /// <returns>**true** if the color slider is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorSliderVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the slider control for the alpha channel is shown.</summary>
    /// <returns>**true** if the alpha channel slider is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsAlphaSliderVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the 'more' button is shown.</summary>
    /// <returns>**true** if the 'more' button is shown; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsMoreButtonVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the text input boxes for the color channels are shown.</summary>
    /// <returns>**true** if the color channel text input boxes are shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorChannelTextInputVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the text input box for the alpha channel is shown.</summary>
    /// <returns>**true** if the alpha channel text input box is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsAlphaTextInputVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the text input box for a HEX color value is shown.</summary>
    /// <returns>**true** if the HEX color text input box is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsHexInputVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum Hue value in the range 0-359.</summary>
    /// <returns>The minimum Hue value in the range 0-359. The default is 0.</returns>
    public extern int MinHue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum Hue value in the range 0-359.</summary>
    /// <returns>The maximum Hue value in the range 0-359. The default is 359.</returns>
    public extern int MaxHue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum Saturation value in the range 0-100.</summary>
    /// <returns>The minimum Saturation value in the range 0-100. The default is 100.</returns>
    public extern int MinSaturation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum Saturation value in the range 0-100.</summary>
    /// <returns>The maximum Saturation value in the range 0-100. The default is 100.</returns>
    public extern int MaxSaturation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum Value value in the range 0-100.</summary>
    /// <returns>The minimum Value value in the range 0-100. The default is 100.</returns>
    public extern int MinValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum Value value in the range 0-100.</summary>
    /// <returns>The maximum Value value in the range 0-100. The default is 100.</returns>
    public extern int MaxValue { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the ColorSpectrum is shown as a square or a circle.</summary>
    /// <returns>A value of the enumeration. The default is **Box**, which shows the spectrum as a square.</returns>
    public extern ColorSpectrumShape ColorSpectrumShape { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the Hue-Saturation-Value (HSV) color components are mapped onto the ColorSpectrum.</summary>
    /// <returns>A value of the enumeration. The default is **HueSaturation**.</returns>
    public extern ColorSpectrumComponents ColorSpectrumComponents { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Color property has changed.</summary>
    public extern event TypedEventHandler<ColorPicker, ColorChangedEventArgs> ColorChanged;

    /// <summary>Identifies the Color dependency property.</summary>
    /// <returns>The identifier for the Color dependency property.</returns>
    public static extern DependencyProperty ColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the PreviousColor dependency property.</summary>
    /// <returns>The identifier for the PreviousColor dependency property.</returns>
    public static extern DependencyProperty PreviousColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsAlphaEnabled dependency property.</summary>
    /// <returns>The identifier for the IsAlphaEnabled dependency property.</returns>
    public static extern DependencyProperty IsAlphaEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsColorSpectrumVisible dependency property.</summary>
    /// <returns>The identifier for the IsColorSpectrumVisible dependency property.</returns>
    public static extern DependencyProperty IsColorSpectrumVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsColorPreviewVisible dependency property.</summary>
    /// <returns>The identifier for the IsColorPreviewVisible dependency property.</returns>
    public static extern DependencyProperty IsColorPreviewVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsColorSliderVisible dependency property.</summary>
    /// <returns>The identifier for the IsColorSliderVisible dependency property.</returns>
    public static extern DependencyProperty IsColorSliderVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsAlphaSliderVisible dependency property.</summary>
    /// <returns>The identifier for the IsAlphaSliderVisible dependency property.</returns>
    public static extern DependencyProperty IsAlphaSliderVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsMoreButtonVisible dependency property.</summary>
    /// <returns>The identifier for the IsMoreButtonVisible dependency property.</returns>
    public static extern DependencyProperty IsMoreButtonVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsColorChannelTextInputVisible dependency property.</summary>
    /// <returns>The identifier for the IsColorChannelTextInputVisible dependency property.</returns>
    public static extern DependencyProperty IsColorChannelTextInputVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsAlphaTextInputVisible dependency property.</summary>
    /// <returns>The identifier for the IsAlphaTextInputVisible dependency property.</returns>
    public static extern DependencyProperty IsAlphaTextInputVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsHexInputVisible dependency property.</summary>
    /// <returns>The identifier for the IsHexInputVisible dependency property.</returns>
    public static extern DependencyProperty IsHexInputVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinHue dependency property.</summary>
    /// <returns>The identifier for the MinHue dependency property.</returns>
    public static extern DependencyProperty MinHueProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxHue dependency property.</summary>
    /// <returns>The identifier for the MaxHue dependency property.</returns>
    public static extern DependencyProperty MaxHueProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinSaturation dependency property.</summary>
    /// <returns>The identifier for the MinSaturation dependency property.</returns>
    public static extern DependencyProperty MinSaturationProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxSaturation dependency property.</summary>
    /// <returns>The identifier for the MaxSaturation dependency property.</returns>
    public static extern DependencyProperty MaxSaturationProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinValue dependency property.</summary>
    /// <returns>The identifier for the MinValue dependency property.</returns>
    public static extern DependencyProperty MinValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxValue dependency property.</summary>
    /// <returns>The identifier for the MaxValue dependency property.</returns>
    public static extern DependencyProperty MaxValueProperty { [MethodImpl] get; }

    /// <summary>Identifies the ColorSpectrumShape dependency property.</summary>
    /// <returns>The identifier for the ColorSpectrumShape dependency property.</returns>
    public static extern DependencyProperty ColorSpectrumShapeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ColorSpectrumComponents dependency property.</summary>
    /// <returns>The identifier for the ColorSpectrumComponents dependency property.</returns>
    public static extern DependencyProperty ColorSpectrumComponentsProperty { [MethodImpl] get; }
  }
}
