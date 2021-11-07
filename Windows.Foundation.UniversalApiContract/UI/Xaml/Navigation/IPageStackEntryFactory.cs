// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.IPageStackEntryFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [WebHostHidden]
  [Guid(1146356874, 43193, 20344, 155, 132, 31, 81, 245, 136, 81, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PageStackEntry))]
  internal interface IPageStackEntryFactory
  {
    PageStackEntry CreateInstance(
      TypeName sourcePageType,
      object parameter,
      NavigationTransitionInfo navigationTransitionInfo);
  }
}
