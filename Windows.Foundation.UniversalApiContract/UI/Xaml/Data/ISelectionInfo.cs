// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ISelectionInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Manages whether items and ranges of items in the data source are selected in the list control.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(772983430, 57837, 16965, 190, 73, 32, 126, 66, 174, 197, 36)]
  public interface ISelectionInfo
  {
    /// <summary>Marks the items in the data source specified by *itemIndexRange* as selected in the list control.</summary>
    /// <param name="itemIndexRange">A range of items in the data source.</param>
    void SelectRange(ItemIndexRange itemIndexRange);

    /// <summary>Marks the items in the data source specified by *itemIndexRange* as not selected in the list control.</summary>
    /// <param name="itemIndexRange">A range of items in the data source.</param>
    void DeselectRange(ItemIndexRange itemIndexRange);

    /// <summary>Provides info about whether the item in the data source at the specified *index* is selected in the list control.</summary>
    /// <param name="index">The index of an item in the data source.</param>
    /// <returns>**true** if the item in the data source at the specified *index* is selected in the list control; otherwise, **false**.</returns>
    bool IsSelected(int index);

    /// <summary>Returns the collection of ranges of items in the data source that are selected in the list control.</summary>
    /// <returns>A collection of ranges of items in the data source that are selected in the list control..</returns>
    IVectorView<ItemIndexRange> GetSelectedRanges();
  }
}
