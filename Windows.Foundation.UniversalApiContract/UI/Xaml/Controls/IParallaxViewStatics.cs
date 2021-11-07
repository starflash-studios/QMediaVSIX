// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IParallaxViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ParallaxView))]
  [WebHostHidden]
  [Guid(2285298844, 3598, 22488, 147, 149, 240, 169, 160, 209, 187, 40)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IParallaxViewStatics
  {
    DependencyProperty ChildProperty { get; }

    DependencyProperty HorizontalSourceEndOffsetProperty { get; }

    DependencyProperty HorizontalSourceOffsetKindProperty { get; }

    DependencyProperty HorizontalSourceStartOffsetProperty { get; }

    DependencyProperty MaxHorizontalShiftRatioProperty { get; }

    DependencyProperty HorizontalShiftProperty { get; }

    DependencyProperty IsHorizontalShiftClampedProperty { get; }

    DependencyProperty IsVerticalShiftClampedProperty { get; }

    DependencyProperty SourceProperty { get; }

    DependencyProperty VerticalSourceEndOffsetProperty { get; }

    DependencyProperty VerticalSourceOffsetKindProperty { get; }

    DependencyProperty VerticalSourceStartOffsetProperty { get; }

    DependencyProperty MaxVerticalShiftRatioProperty { get; }

    DependencyProperty VerticalShiftProperty { get; }
  }
}
