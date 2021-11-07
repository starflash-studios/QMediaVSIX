// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IScaleTransformStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(2643736308, 16551, 18141, 151, 90, 7, 211, 55, 205, 133, 46)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ScaleTransform))]
  internal interface IScaleTransformStatics
  {
    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
