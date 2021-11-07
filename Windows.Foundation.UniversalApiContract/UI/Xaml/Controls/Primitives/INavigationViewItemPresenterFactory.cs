// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.INavigationViewItemPresenterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3137743952, 18998, 21223, 148, 89, 232, 157, 2, 243, 252, 66)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [WebHostHidden]
  [ExclusiveTo(typeof (NavigationViewItemPresenter))]
  internal interface INavigationViewItemPresenterFactory
  {
    NavigationViewItemPresenter CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
