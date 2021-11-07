// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IColorPickerSliderFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(114850210, 35847, 19230, 169, 64, 159, 188, 232, 244, 150, 57)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (ColorPickerSlider))]
  internal interface IColorPickerSliderFactory
  {
    ColorPickerSlider CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
