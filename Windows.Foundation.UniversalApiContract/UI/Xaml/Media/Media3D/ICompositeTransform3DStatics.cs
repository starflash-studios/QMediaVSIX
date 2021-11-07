// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.ICompositeTransform3DStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ExclusiveTo(typeof (CompositeTransform3D))]
  [WebHostHidden]
  [Guid(3720301927, 10789, 18675, 152, 8, 197, 30, 195, 213, 91, 236)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompositeTransform3DStatics
  {
    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterZProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty ScaleZProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty TranslateZProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
