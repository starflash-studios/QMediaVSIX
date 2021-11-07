// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISliderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2319672279, 32735, 19760, 152, 254, 206, 120, 192, 91, 49, 207)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Slider))]
  internal interface ISliderStatics
  {
    DependencyProperty IntermediateValueProperty { get; }

    DependencyProperty StepFrequencyProperty { get; }

    DependencyProperty SnapsToProperty { get; }

    DependencyProperty TickFrequencyProperty { get; }

    DependencyProperty TickPlacementProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty IsDirectionReversedProperty { get; }

    DependencyProperty IsThumbToolTipEnabledProperty { get; }

    DependencyProperty ThumbToolTipValueConverterProperty { get; }
  }
}
