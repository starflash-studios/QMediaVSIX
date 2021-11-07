// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IItemsRangeInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Provides info about a range of items in the data source.</summary>
  [WebHostHidden]
  [Guid(4032779877, 29181, 17826, 190, 19, 160, 129, 210, 148, 166, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IItemsRangeInfo : IClosable
  {
    void RangesChanged(ItemIndexRange visibleRange, IVectorView<ItemIndexRange> trackedItems);
  }
}
