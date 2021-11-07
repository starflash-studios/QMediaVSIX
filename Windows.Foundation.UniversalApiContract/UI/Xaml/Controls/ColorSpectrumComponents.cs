// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ColorSpectrumComponents
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Defines constants that specify how the Hue-Saturation-Value (HSV) color components are mapped onto the ColorSpectrum.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public enum ColorSpectrumComponents
  {
    /// <summary>Hue is mapped to the X axis. Value is mapped to the Y axis.</summary>
    HueValue,
    /// <summary>Value is mapped to the X axis. Hue is mapped to the Y axis.</summary>
    ValueHue,
    /// <summary>Hue is mapped to the X axis. Saturation is mapped to the Y axis.</summary>
    HueSaturation,
    /// <summary>Saturation is mapped to the X axis. Hue is mapped to the Y axis.</summary>
    SaturationHue,
    /// <summary>Saturation is mapped to the X axis. Value is mapped to the Y axis.</summary>
    SaturationValue,
    /// <summary>Value is mapped to the X axis. Saturation is mapped to the Y axis.</summary>
    ValueSaturation,
  }
}
