// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IPopupThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(1199846738, 17027, 21598, 199, 145, 38, 141, 202, 34, 206, 75)]
  [ExclusiveTo(typeof (PopupThemeTransition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPopupThemeTransition
  {
    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }
  }
}
