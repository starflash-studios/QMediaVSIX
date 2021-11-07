// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewSelectionChangedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (NavigationViewSelectionChangedEventArgs))]
  [Guid(4250597382, 53514, 24203, 151, 63, 59, 143, 218, 148, 70, 37)]
  [WebHostHidden]
  internal interface INavigationViewSelectionChangedEventArgs2
  {
    NavigationViewItemBase SelectedItemContainer { get; }

    NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
  }
}
