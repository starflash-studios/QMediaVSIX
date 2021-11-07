// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFontIconSourceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2349744687, 33385, 17329, 185, 90, 239, 7, 14, 134, 119, 13)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (FontIconSource))]
  internal interface IFontIconSourceStatics
  {
    DependencyProperty GlyphProperty { get; }

    DependencyProperty FontSizeProperty { get; }

    DependencyProperty FontFamilyProperty { get; }

    DependencyProperty FontWeightProperty { get; }

    DependencyProperty FontStyleProperty { get; }

    DependencyProperty IsTextScaleFactorEnabledProperty { get; }

    DependencyProperty MirroredWhenRightToLeftProperty { get; }
  }
}
