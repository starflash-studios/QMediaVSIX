// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISwipeHintThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (SwipeHintThemeAnimation))]
  [Guid(3452987328, 22542, 20032, 190, 152, 242, 2, 211, 216, 67, 101)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISwipeHintThemeAnimation
  {
    string TargetName { get; set; }

    double ToHorizontalOffset { get; set; }

    double ToVerticalOffset { get; set; }
  }
}
