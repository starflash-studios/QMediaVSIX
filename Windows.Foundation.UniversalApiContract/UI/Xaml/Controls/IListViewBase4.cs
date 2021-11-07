// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(414677291, 4572, 20150, 167, 188, 116, 26, 219, 62, 235, 121)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewBase))]
  internal interface IListViewBase4
  {
    IVectorView<ItemIndexRange> SelectedRanges { get; }

    bool IsMultiSelectCheckBoxEnabled { get; set; }

    event TypedEventHandler<ListViewBase, DragItemsCompletedEventArgs> DragItemsCompleted;

    event TypedEventHandler<ListViewBase, ChoosingItemContainerEventArgs> ChoosingItemContainer;

    event TypedEventHandler<ListViewBase, ChoosingGroupHeaderContainerEventArgs> ChoosingGroupHeaderContainer;

    void SelectRange(ItemIndexRange itemIndexRange);

    void DeselectRange(ItemIndexRange itemIndexRange);
  }
}
