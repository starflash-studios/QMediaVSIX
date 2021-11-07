// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [Guid(2905739505, 39003, 16753, 187, 186, 103, 188, 199, 41, 100, 155)]
  [ExclusiveTo(typeof (MenuFlyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMenuFlyout
  {
    IVector<MenuFlyoutItemBase> Items { get; }

    Style MenuFlyoutPresenterStyle { get; set; }
  }
}
