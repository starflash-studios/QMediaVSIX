// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPlaneProjectionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [Guid(2912001127, 15324, 18517, 137, 105, 209, 249, 163, 173, 194, 125)]
  [ExclusiveTo(typeof (PlaneProjection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlaneProjectionStatics
  {
    [ConditionallyIndependentlyAnimatable]
    DependencyProperty LocalOffsetXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty LocalOffsetYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty LocalOffsetZProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterOfRotationXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterOfRotationYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterOfRotationZProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty GlobalOffsetXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty GlobalOffsetYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty GlobalOffsetZProperty { [ConditionallyIndependentlyAnimatable] get; }

    DependencyProperty ProjectionMatrixProperty { get; }
  }
}
