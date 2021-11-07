// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>Represents your app's most recently used list (MRU) (obtained from the static StorageApplicationPermissions.MostRecentlyUsedList property). You use your MRU to track items (files and/or folders) that the user has accessed most recently. Items are stored in the MRU as StorageFile and StorageFolder objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemMostRecentlyUsedList : 
    IStorageItemMostRecentlyUsedList,
    IStorageItemAccessList,
    IStorageItemMostRecentlyUsedList2
  {
    /// <summary>Fires when a storage item is removed from the most recently used (MRU) list.</summary>
    public extern event TypedEventHandler<StorageItemMostRecentlyUsedList, ItemRemovedEventArgs> ItemRemoved;

    /// <summary>Adds a new storage item to the most recently used (MRU) list.</summary>
    /// <param name="file">The storage item to add.</param>
    /// <returns>A token that the app can use later to retrieve the storage item.</returns>
    [Overload("AddOverloadDefaultMetadata")]
    [MethodImpl]
    public extern string Add(IStorageItem file);

    /// <summary>Adds a new storage item and accompanying metadata to the most recently used (MRU) list.</summary>
    /// <param name="file">The storage item to add.</param>
    /// <param name="metadata">Optional metadata to associate with the storage item.</param>
    /// <returns>A token that the app can use later to retrieve the storage item.</returns>
    [Overload("Add")]
    [MethodImpl]
    public extern string Add(IStorageItem file, string metadata);

    /// <summary>Adds a new storage item to the most recently used (MRU) list, or replaces the specified item if it already exists in the list.</summary>
    /// <param name="token">The token associated with the new storage item. If the access list already contains a storage item that has this token, the new item replaces the existing one.</param>
    /// <param name="file">The storage item to add or replace.</param>
    [Overload("AddOrReplaceOverloadDefaultMetadata")]
    [MethodImpl]
    public extern void AddOrReplace(string token, IStorageItem file);

    /// <summary>Adds a new storage item and accompanying metadata to the most recently used (MRU) list, or replaces the specified item if it already exists in the list.</summary>
    /// <param name="token">The token associated with the new storage item. If the access list already contains a storage item that has this token, the new item replaces the existing one.</param>
    /// <param name="file">The storage item to add or replace.</param>
    /// <param name="metadata">Optional metadata to associate with the storage item.</param>
    [Overload("AddOrReplace")]
    [MethodImpl]
    public extern void AddOrReplace(string token, IStorageItem file, string metadata);

    /// <summary>Retrieves the specified item (like a file or folder) from the most recently used (MRU) list.</summary>
    /// <param name="token">The token of the item to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the item (type IStorageItem ) that is associated with the specified *token*.</returns>
    [Overload("GetItemAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(string token);

    /// <summary>Retrieves the specified storageFile from the most recently used (MRU) list.</summary>
    /// <param name="token">The token of the storageFile to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the storageFile that is associated with the specified *token*.</returns>
    [Overload("GetFileAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(string token);

    /// <summary>Retrieves the specified StorageFolder from the most recently used (MRU) list.</summary>
    /// <param name="token">The token of the StorageFolder to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the StorageFolder that is associated with the specified *token*.</returns>
    [Overload("GetFolderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string token);

    /// <summary>Retrieves the specified item (like a file or folder) from the most recently used (MRU) list using the specified options.</summary>
    /// <param name="token">The token of the item to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the item (type IStorageItem ) that is associated with the specified *token*.</returns>
    [Overload("GetItemWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Retrieves the specified storageFile from the most recently used (MRU) list using the specified options.</summary>
    /// <param name="token">The token of the storageFile to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the storageFile that is associated with the specified *token*.</returns>
    [Overload("GetFileWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Retrieves the specified StorageFolder from the most recently used (MRU) list using the specified options.</summary>
    /// <param name="token">The token of the StorageFolder to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the StorageFolder that is associated with the specified *token*.</returns>
    [Overload("GetFolderWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Removes the specified storage item from the most recently used (MRU) list.</summary>
    /// <param name="token">The token of the storage item to remove.</param>
    [MethodImpl]
    public extern void Remove(string token);

    /// <summary>Determines whether the most recently used (MRU) list contains the specified storage item.</summary>
    /// <param name="token">The token of the storage item to look for.</param>
    /// <returns>True if the most recently used (MRU) list contains the specified storage item; false otherwise.</returns>
    [MethodImpl]
    public extern bool ContainsItem(string token);

    /// <summary>Removes all storage items from the most recently used (MRU) list.</summary>
    [MethodImpl]
    public extern void Clear();

    /// <summary>Determines whether the app has access to the specified storage item in the most recently used (MRU) list.</summary>
    /// <param name="file">The storage item to check for access.</param>
    /// <returns>True if the app can access the storage item; otherwise false.</returns>
    [MethodImpl]
    public extern bool CheckAccess(IStorageItem file);

    /// <summary>Gets an object for retrieving storage items from the most recently used (MRU) list.</summary>
    /// <returns>The object for retrieving storage items.</returns>
    public extern AccessListEntryView Entries { [MethodImpl] get; }

    /// <summary>Gets the maximum number of storage items that the most recently used (MRU) list can contain.</summary>
    /// <returns>The maximum number of storage items.</returns>
    public extern uint MaximumItemsAllowed { [MethodImpl] get; }

    /// <summary>Adds a new storage item and accompanying metadata to the most recently used (MRU) list, specifying the extent of its visibility in the list.</summary>
    /// <param name="file">The storage item to add.</param>
    /// <param name="metadata">Optional metadata to associate with the storage item.</param>
    /// <param name="visibility">The extent of the visibility of the storage item in the list.</param>
    /// <returns>A token that the app can use later to retrieve the storage item.</returns>
    [Overload("AddWithMetadataAndVisibility")]
    [MethodImpl]
    public extern string Add(
      IStorageItem file,
      string metadata,
      RecentStorageItemVisibility visibility);

    /// <summary>Adds a new storage item and accompanying metadata to the most recently used (MRU) list, or replaces the specified item if it already exists in the list. Also specifies the extent of its visibility in the list.</summary>
    /// <param name="token">The token associated with the new storage item. If the access list already contains a storage item that has this token, the new item replaces the existing one.</param>
    /// <param name="file">The storage item to add or replace.</param>
    /// <param name="metadata">Optional metadata to associate with the storage item.</param>
    /// <param name="visibility">The extent of the visibility of the storage item in the list.</param>
    [Overload("AddOrReplaceWithMetadataAndVisibility")]
    [MethodImpl]
    public extern void AddOrReplace(
      string token,
      IStorageItem file,
      string metadata,
      RecentStorageItemVisibility visibility);
  }
}
