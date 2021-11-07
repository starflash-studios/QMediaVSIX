// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ICompositeTransformStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (CompositeTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(790170632, 33382, 18799, 150, 83, 161, 139, 212, 248, 54, 170)]
  internal interface ICompositeTransformStatics
  {
    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty SkewXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty SkewYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty RotationProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
