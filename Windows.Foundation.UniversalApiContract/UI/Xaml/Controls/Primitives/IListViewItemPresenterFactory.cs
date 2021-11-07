// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IListViewItemPresenterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Guid(3765927165, 63460, 19047, 154, 192, 169, 148, 252, 172, 208, 32)]
  [ExclusiveTo(typeof (ListViewItemPresenter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IListViewItemPresenterFactory
  {
    ListViewItemPresenter CreateInstance(
      object baseInterface,
      out object innerInterface);
  }
}
