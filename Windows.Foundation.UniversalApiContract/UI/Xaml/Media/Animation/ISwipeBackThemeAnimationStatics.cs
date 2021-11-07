// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISwipeBackThemeAnimationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (SwipeBackThemeAnimation))]
  [Guid(1765749183, 19878, 18058, 140, 224, 153, 108, 154, 173, 66, 224)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISwipeBackThemeAnimationStatics
  {
    DependencyProperty TargetNameProperty { get; }

    DependencyProperty FromHorizontalOffsetProperty { get; }

    DependencyProperty FromVerticalOffsetProperty { get; }
  }
}
