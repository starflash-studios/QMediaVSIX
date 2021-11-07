// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IAcrylicBrushStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AcrylicBrush))]
  [Guid(663223673, 41946, 16959, 184, 26, 89, 145, 71, 151, 21, 35)]
  internal interface IAcrylicBrushStatics
  {
    DependencyProperty BackgroundSourceProperty { get; }

    DependencyProperty TintColorProperty { get; }

    DependencyProperty TintOpacityProperty { get; }

    DependencyProperty TintTransitionDurationProperty { get; }

    DependencyProperty AlwaysUseFallbackProperty { get; }
  }
}
