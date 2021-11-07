// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IRepositionThemeAnimation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RepositionThemeAnimation))]
  [WebHostHidden]
  [Guid(3973719272, 35141, 18761, 161, 191, 98, 16, 153, 101, 167, 233)]
  internal interface IRepositionThemeAnimation
  {
    string TargetName { get; set; }

    double FromHorizontalOffset { get; set; }

    double FromVerticalOffset { get; set; }
  }
}
