// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRotateTransformStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RotateTransform))]
  [Guid(2704403338, 20899, 16822, 185, 211, 161, 14, 66, 144, 84, 171)]
  internal interface IRotateTransformStatics
  {
    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable] get; }

    [ConditionallyIndependentlyAnimatable]
    DependencyProperty AngleProperty { [ConditionallyIndependentlyAnimatable] get; }
  }
}
