// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ColorPickerSlider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  /// <summary>Represents a slider in a ColorPicker control.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IColorPickerSliderFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IColorPickerSliderStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  public class ColorPickerSlider : Slider, IColorPickerSlider
  {
    /// <summary>Initializes a new instance of the ColorPickerSlider class.</summary>
    [MethodImpl]
    public extern ColorPickerSlider();

    /// <summary>Gets or sets a value that indicates which color channel the slider modifies.</summary>
    /// <returns>A value of the enumeration that indicates which color channel the slider modifies.</returns>
    public extern ColorPickerHsvChannel ColorChannel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the ColorChannel dependency property.</summary>
    /// <returns>The identifier for the ColorChannel dependency property.</returns>
    public static extern DependencyProperty ColorChannelProperty { [MethodImpl] get; }
  }
}
