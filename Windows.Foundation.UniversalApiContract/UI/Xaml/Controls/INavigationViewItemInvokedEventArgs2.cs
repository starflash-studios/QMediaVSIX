// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.INavigationViewItemInvokedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (NavigationViewItemInvokedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [Guid(3043554013, 20830, 22384, 164, 102, 189, 95, 67, 251, 100, 66)]
  [WebHostHidden]
  internal interface INavigationViewItemInvokedEventArgs2
  {
    NavigationViewItemBase InvokedItemContainer { get; }

    NavigationTransitionInfo RecommendedNavigationTransitionInfo { get; }
  }
}
