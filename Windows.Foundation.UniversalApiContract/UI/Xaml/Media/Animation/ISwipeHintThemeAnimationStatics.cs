// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISwipeHintThemeAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (SwipeHintThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(601234007, 37141, 19811, 176, 74, 184, 159, 28, 116, 77, 192)]
  internal interface ISwipeHintThemeAnimationStatics
  {
    DependencyProperty TargetNameProperty { get; }

    DependencyProperty ToHorizontalOffsetProperty { get; }

    DependencyProperty ToVerticalOffsetProperty { get; }
  }
}
