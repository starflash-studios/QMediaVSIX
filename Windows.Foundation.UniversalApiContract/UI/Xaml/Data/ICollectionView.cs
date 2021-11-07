// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  /// <summary>Enables collections to support current record management, grouping, and incremental loading (data virtualization).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2347286500, 56303, 17631, 129, 38, 163, 26, 137, 18, 29, 220)]
  [WebHostHidden]
  public interface ICollectionView : IObservableVector<object>, IVector<object>, IIterable<object>
  {
    /// <summary>Gets the current item in the view.</summary>
    /// <returns>The current item in the view or null if there is no current item.</returns>
    object CurrentItem { get; }

    /// <summary>Gets the ordinal position of the CurrentItem within the view.</summary>
    /// <returns>The ordinal position of the CurrentItem within the view.</returns>
    int CurrentPosition { get; }

    /// <summary>Gets a value that indicates whether the CurrentItem of the view is beyond the end of the collection.</summary>
    /// <returns>**true** if the CurrentItem of the view is beyond the end of the collection; otherwise, **false**.</returns>
    bool IsCurrentAfterLast { get; }

    /// <summary>Gets a value that indicates whether the CurrentItem of the view is beyond the beginning of the collection.</summary>
    /// <returns>**true** if the CurrentItem of the view is beyond the beginning of the collection; otherwise, **false**.</returns>
    bool IsCurrentBeforeFirst { get; }

    /// <summary>Returns any collection groups that are associated with the view.</summary>
    /// <returns>A vector collection of possible views.</returns>
    IObservableVector<object> CollectionGroups { get; }

    /// <summary>Gets a sentinel value that supports incremental loading implementations. See also LoadMoreItemsAsync.</summary>
    /// <returns>**true** if additional unloaded items remain in the view; otherwise, **false**.</returns>
    bool HasMoreItems { get; }

    /// <summary>When implementing this interface, fire this event after the current item has been changed.</summary>
    event EventHandler<object> CurrentChanged;

    /// <summary>When implementing this interface, fire this event before changing the current item. The event handler can cancel this event.</summary>
    event CurrentChangingEventHandler CurrentChanging;

    /// <summary>Sets the specified item to be the CurrentItem in the view.</summary>
    /// <param name="item">The item to set as the CurrentItem.</param>
    /// <returns>**true** if the resulting CurrentItem is within the view; otherwise, **false**.</returns>
    bool MoveCurrentTo(object item);

    /// <summary>Sets the item at the specified index to be the CurrentItem in the view.</summary>
    /// <param name="index">The index of the item to move to.</param>
    /// <returns>**true** if the resulting CurrentItem is an item within the view; otherwise, **false**.</returns>
    bool MoveCurrentToPosition(int index);

    /// <summary>Sets the first item in the view as the CurrentItem.</summary>
    /// <returns>**true** if the resulting CurrentItem is an item within the view; otherwise, **false**.</returns>
    bool MoveCurrentToFirst();

    /// <summary>Sets the last item in the view as the CurrentItem.</summary>
    /// <returns>**true** if the resulting CurrentItem is an item within the view; otherwise, **false**.</returns>
    bool MoveCurrentToLast();

    /// <summary>Sets the item after the CurrentItem in the view as the CurrentItem.</summary>
    /// <returns>**true** if the resulting CurrentItem is an item within the view; otherwise, **false**.</returns>
    bool MoveCurrentToNext();

    /// <summary>Sets the item before the CurrentItem in the view as the CurrentItem.</summary>
    /// <returns>**true** if the resulting CurrentItem is an item within the view; otherwise, **false**.</returns>
    bool MoveCurrentToPrevious();

    /// <summary>Initializes incremental loading from the view.</summary>
    /// <param name="count">The number of items to load.</param>
    /// <returns>The wrapped results of the load operation.</returns>
    [RemoteAsync]
    IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(
      uint count);
  }
}
