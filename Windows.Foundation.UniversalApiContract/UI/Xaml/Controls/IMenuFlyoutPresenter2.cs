// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutPresenter2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2304283871, 23199, 18975, 133, 236, 111, 60, 27, 109, 203, 137)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MenuFlyoutPresenter))]
  internal interface IMenuFlyoutPresenter2
  {
    MenuFlyoutPresenterTemplateSettings TemplateSettings { get; }
  }
}
