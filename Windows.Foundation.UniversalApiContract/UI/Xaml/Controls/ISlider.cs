// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISlider
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2304188455, 19528, 18176, 128, 118, 73, 123, 167, 61, 156, 24)]
  [ExclusiveTo(typeof (Slider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISlider
  {
    double IntermediateValue { get; set; }

    double StepFrequency { get; set; }

    SliderSnapsTo SnapsTo { get; set; }

    double TickFrequency { get; set; }

    TickPlacement TickPlacement { get; set; }

    Orientation Orientation { get; set; }

    bool IsDirectionReversed { get; set; }

    bool IsThumbToolTipEnabled { get; set; }

    IValueConverter ThumbToolTipValueConverter { get; set; }
  }
}
