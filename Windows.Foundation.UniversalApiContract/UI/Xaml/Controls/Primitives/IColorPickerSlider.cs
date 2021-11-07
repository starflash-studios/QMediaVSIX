// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IColorPickerSlider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ColorPickerSlider))]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2486783363, 57567, 19551, 187, 205, 129, 85, 244, 2, 4, 64)]
  internal interface IColorPickerSlider
  {
    ColorPickerHsvChannel ColorChannel { get; set; }
  }
}
