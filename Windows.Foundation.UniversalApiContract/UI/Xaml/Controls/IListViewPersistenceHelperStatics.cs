// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewPersistenceHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewPersistenceHelper))]
  [Guid(1829513992, 48027, 17657, 128, 99, 92, 63, 156, 33, 136, 75)]
  internal interface IListViewPersistenceHelperStatics
  {
    string GetRelativeScrollPosition(
      ListViewBase listViewBase,
      ListViewItemToKeyHandler itemToKeyHandler);

    [RemoteAsync]
    IAsyncAction SetRelativeScrollPositionAsync(
      ListViewBase listViewBase,
      string relativeScrollPosition,
      ListViewKeyToItemHandler keyToItemHandler);
  }
}
