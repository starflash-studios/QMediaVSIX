// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IColorAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ColorAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1441461986, 34787, 20296, 149, 143, 133, 91, 47, 158, 169, 236)]
  internal interface IColorAnimationStatics
  {
    DependencyProperty FromProperty { get; }

    DependencyProperty ToProperty { get; }

    DependencyProperty ByProperty { get; }

    DependencyProperty EasingFunctionProperty { get; }

    DependencyProperty EnableDependentAnimationProperty { get; }
  }
}
