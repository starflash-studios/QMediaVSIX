// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.INavigationThemeTransition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (NavigationThemeTransition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2285077644, 20151, 16882, 135, 153, 158, 239, 10, 33, 59, 115)]
  [WebHostHidden]
  internal interface INavigationThemeTransition
  {
    NavigationTransitionInfo DefaultNavigationTransitionInfo { get; set; }
  }
}
