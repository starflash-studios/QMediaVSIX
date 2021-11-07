// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutSubItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (MenuFlyoutSubItem))]
  [WebHostHidden]
  [Guid(3845678416, 65068, 17378, 167, 63, 98, 22, 143, 97, 153, 115)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMenuFlyoutSubItem
  {
    IVector<MenuFlyoutItemBase> Items { get; }

    string Text { get; set; }
  }
}
