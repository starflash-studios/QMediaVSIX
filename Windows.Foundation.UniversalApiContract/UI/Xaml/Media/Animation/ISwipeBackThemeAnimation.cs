// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISwipeBackThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (SwipeBackThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2743747092, 3018, 19757, 149, 247, 206, 186, 87, 251, 175, 96)]
  [WebHostHidden]
  internal interface ISwipeBackThemeAnimation
  {
    string TargetName { get; set; }

    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }
  }
}
