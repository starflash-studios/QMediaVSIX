// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IColorSpectrum
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3460756081, 62729, 20376, 130, 136, 228, 148, 47, 179, 133, 223)]
  [ExclusiveTo(typeof (ColorSpectrum))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  internal interface IColorSpectrum
  {
    Color Color { get; set; }

    Vector4 HsvColor { get; set; }

    int MinHue { get; set; }

    int MaxHue { get; set; }

    int MinSaturation { get; set; }

    int MaxSaturation { get; set; }

    int MinValue { get; set; }

    int MaxValue { get; set; }

    ColorSpectrumShape Shape { get; set; }

    ColorSpectrumComponents Components { get; set; }

    event TypedEventHandler<ColorSpectrum, ColorChangedEventArgs> ColorChanged;
  }
}
