// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.INavigationViewItemPresenter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ExclusiveTo(typeof (NavigationViewItemPresenter))]
  [Guid(2572604412, 18067, 22987, 182, 191, 55, 36, 144, 88, 190, 150)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  internal interface INavigationViewItemPresenter
  {
    IconElement Icon { get; set; }
  }
}
