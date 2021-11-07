// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutPresenter3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MenuFlyoutPresenter))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [Guid(1794985494, 44768, 22602, 152, 73, 237, 170, 50, 58, 72, 79)]
  internal interface IMenuFlyoutPresenter3
  {
    bool IsDefaultShadowEnabled { get; set; }
  }
}
