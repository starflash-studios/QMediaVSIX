// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListPickerFlyout
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ListPickerFlyout))]
  [Guid(252492247, 58867, 17894, 144, 99, 255, 123, 187, 25, 60, 71)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListPickerFlyout
  {
    object ItemsSource { get; set; }

    DataTemplate ItemTemplate { get; set; }

    string DisplayMemberPath { get; set; }

    ListPickerFlyoutSelectionMode SelectionMode { get; set; }

    int SelectedIndex { get; set; }

    object SelectedItem { get; set; }

    object SelectedValue { get; set; }

    string SelectedValuePath { get; set; }

    IVector<object> SelectedItems { get; }

    event TypedEventHandler<ListPickerFlyout, ItemsPickedEventArgs> ItemsPicked;

    [RemoteAsync]
    IAsyncOperation<IVectorView<object>> ShowAtAsync(
      FrameworkElement target);
  }
}
