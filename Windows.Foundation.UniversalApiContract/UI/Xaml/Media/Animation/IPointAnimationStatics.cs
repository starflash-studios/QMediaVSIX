// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPointAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(798602070, 59191, 16523, 160, 253, 50, 120, 38, 211, 34, 85)]
  [ExclusiveTo(typeof (PointAnimation))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointAnimationStatics
  {
    DependencyProperty FromProperty { get; }

    DependencyProperty ToProperty { get; }

    DependencyProperty ByProperty { get; }

    DependencyProperty EasingFunctionProperty { get; }

    DependencyProperty EnableDependentAnimationProperty { get; }
  }
}
