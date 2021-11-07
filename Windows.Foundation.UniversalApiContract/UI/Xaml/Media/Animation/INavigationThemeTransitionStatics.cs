// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.INavigationThemeTransitionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (NavigationThemeTransition))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3928950496, 24160, 20366, 188, 175, 67, 20, 135, 162, 148, 171)]
  internal interface INavigationThemeTransitionStatics
  {
    DependencyProperty DefaultNavigationTransitionInfoProperty { get; }
  }
}
