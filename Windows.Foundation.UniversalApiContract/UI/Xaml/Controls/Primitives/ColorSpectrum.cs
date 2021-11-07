// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ColorSpectrum
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a control that lets a user choose a color from a visual spectrum.</summary>
  [WebHostHidden]
  [Composable(typeof (IColorSpectrumFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IColorSpectrumStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public class ColorSpectrum : Control, IColorSpectrum
  {
    /// <summary>Initializes a new instance of the ColorSpectrum class.</summary>
    [MethodImpl]
    public extern ColorSpectrum();

    /// <summary>Gets or sets the current color value.</summary>
    /// <returns>The current color value.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current color value as a Vector4.</summary>
    /// <returns>The current HSV color value.</returns>
    public extern Vector4 HsvColor { [MethodImpl] get; [MethodImpl] set; }

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
    public extern ColorSpectrumShape Shape { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the Hue-Saturation-Value (HSV) color components are mapped onto the ColorSpectrum.</summary>
    /// <returns>A value of the enumeration. The default is **HueSaturation**.</returns>
    public extern ColorSpectrumComponents Components { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the Color property has changed.</summary>
    public extern event TypedEventHandler<ColorSpectrum, ColorChangedEventArgs> ColorChanged;

    /// <summary>Identifies the Color dependency property.</summary>
    /// <returns>The identifier for the Color dependency property.</returns>
    public static extern DependencyProperty ColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the HsvColor dependency property.</summary>
    /// <returns>The identifier for the HsvColor dependency property.</returns>
    public static extern DependencyProperty HsvColorProperty { [MethodImpl] get; }

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

    /// <summary>Identifies the Shape dependency property.</summary>
    /// <returns>The identifier for the Shape dependency property.</returns>
    public static extern DependencyProperty ShapeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Components dependency property.</summary>
    /// <returns>The identifier for the Components dependency property.</returns>
    public static extern DependencyProperty ComponentsProperty { [MethodImpl] get; }
  }
}
