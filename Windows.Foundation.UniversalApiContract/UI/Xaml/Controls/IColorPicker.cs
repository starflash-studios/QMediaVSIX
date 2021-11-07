// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IColorPicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (ColorPicker))]
  [WebHostHidden]
  [Guid(1647502193, 23652, 17355, 139, 53, 127, 130, 221, 227, 103, 64)]
  internal interface IColorPicker
  {
    Color Color { get; set; }

    IReference<Color> PreviousColor { get; set; }

    bool IsAlphaEnabled { get; set; }

    bool IsColorSpectrumVisible { get; set; }

    bool IsColorPreviewVisible { get; set; }

    bool IsColorSliderVisible { get; set; }

    bool IsAlphaSliderVisible { get; set; }

    bool IsMoreButtonVisible { get; set; }

    bool IsColorChannelTextInputVisible { get; set; }

    bool IsAlphaTextInputVisible { get; set; }

    bool IsHexInputVisible { get; set; }

    int MinHue { get; set; }

    int MaxHue { get; set; }

    int MinSaturation { get; set; }

    int MaxSaturation { get; set; }

    int MinValue { get; set; }

    int MaxValue { get; set; }

    ColorSpectrumShape ColorSpectrumShape { get; set; }

    ColorSpectrumComponents ColorSpectrumComponents { get; set; }

    event TypedEventHandler<ColorPicker, ColorChangedEventArgs> ColorChanged;
  }
}
