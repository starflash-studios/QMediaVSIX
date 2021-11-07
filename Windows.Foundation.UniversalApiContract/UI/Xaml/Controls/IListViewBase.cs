// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1023939514, 26768, 17719, 191, 229, 121, 109, 148, 88, 237, 214)]
  [ExclusiveTo(typeof (ListViewBase))]
  [WebHostHidden]
  internal interface IListViewBase
  {
    IVector<object> SelectedItems { get; }

    ListViewSelectionMode SelectionMode { get; set; }

    bool IsSwipeEnabled { get; set; }

    bool CanDragItems { get; set; }

    bool CanReorderItems { get; set; }

    bool IsItemClickEnabled { get; set; }

    double DataFetchSize { get; set; }

    double IncrementalLoadingThreshold { get; set; }

    IncrementalLoadingTrigger IncrementalLoadingTrigger { get; set; }

    event ItemClickEventHandler ItemClick;

    event DragItemsStartingEventHandler DragItemsStarting;

    [Overload("ScrollIntoView")]
    void ScrollIntoView(object item);

    void SelectAll();

    [RemoteAsync]
    IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync();

    [Overload("ScrollIntoViewWithAlignment")]
    void ScrollIntoView(object item, ScrollIntoViewAlignment alignment);

    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    TransitionCollection HeaderTransitions { get; set; }
  }
}
