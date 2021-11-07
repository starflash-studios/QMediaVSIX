// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.StorageItemAccessList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>Represents your app's future-access list (obtained from the static StorageApplicationPermissions.FutureAccessList property). By picking files and folders, your user grants your app permission to access items that might not be accessible otherwise. If you add these items to your future-access list then you'll retain that permission when your app wants to access those items again later. Items are stored in the future-access list as StorageFile and StorageFolder objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class StorageItemAccessList : IStorageItemAccessList
  {
    /// <summary>Adds a new storage item to the access list.</summary>
    /// <param name="file">The storage item to add.</param>
    /// <returns>A token that the app can use later to retrieve the storage item.</returns>
    [Overload("AddOverloadDefaultMetadata")]
    [MethodImpl]
    public extern string Add(IStorageItem file);

    /// <summary>Adds a new storage item and accompanying metadata to the access list.</summary>
    /// <param name="file">The storage item to add.</param>
    /// <param name="metadata">Optional metadata to associate with the storage item.</param>
    /// <returns>A token that the app can use later to retrieve the storage item.</returns>
    [Overload("Add")]
    [MethodImpl]
    public extern string Add(IStorageItem file, string metadata);

    /// <summary>Adds a new storage item to the access list, or replaces the specified item if it already exists in the list.</summary>
    /// <param name="token">The token associated with the new storage item. If the access list already contains a storage item that has this token, the new item replaces the existing one.</param>
    /// <param name="file">The storage item to add or replace.</param>
    [Overload("AddOrReplaceOverloadDefaultMetadata")]
    [MethodImpl]
    public extern void AddOrReplace(string token, IStorageItem file);

    /// <summary>Adds a new storage item and accompanying metadata to the access list, or replaces the specified item if it already exists in the list.</summary>
    /// <param name="token">A token that the app can use later to retrieve this storage item.</param>
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

    /// <summary>Retrieves the specified StorageFile from the list.</summary>
    /// <param name="token">The token of the StorageFile to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the StorageFile that is associated with the specified *token*.</returns>
    [Overload("GetFileAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(string token);

    /// <summary>Retrieves the specified StorageFolder from the list.</summary>
    /// <param name="token">The token of the StorageFolder to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the StorageFolder that is associated with the specified *token*.</returns>
    [Overload("GetFolderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string token);

    /// <summary>Retrieves the specified item (like a file or folder) from the list using the specified options.</summary>
    /// <param name="token">The token of the item to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the item (type IStorageItem ) that is associated with the specified *token*.</returns>
    [Overload("GetItemWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IStorageItem> GetItemAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Retrieves the StorageFile from the list using the specified options.</summary>
    /// <param name="token">The token of the StorageFile to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the StorageFile that is associated with the specified *token*.</returns>
    [Overload("GetFileWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFile> GetFileAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Retrieves the specified StorageFolder from the list using the specified options.</summary>
    /// <param name="token">The token of the StorageFolder to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the StorageFolder that is associated with the specified *token*.</returns>
    [Overload("GetFolderWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> GetFolderAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Removes the specified storage item from the access list.</summary>
    /// <param name="token">The token of the storage item to remove.</param>
    [MethodImpl]
    public extern void Remove(string token);

    /// <summary>Determines whether the access list contains the specified storage item.</summary>
    /// <param name="token">The token of the storage item to look for.</param>
    /// <returns>True if the access list contains the specified storage item; false otherwise.</returns>
    [MethodImpl]
    public extern bool ContainsItem(string token);

    /// <summary>Removes all storage items from the access list.</summary>
    [MethodImpl]
    public extern void Clear();

    /// <summary>Determines whether the app has access to the specified storage item in the access list.</summary>
    /// <param name="file">The storage item to check for access.</param>
    /// <returns>True if the app can access the storage item; otherwise false.</returns>
    [MethodImpl]
    public extern bool CheckAccess(IStorageItem file);

    /// <summary>Gets an object for retrieving storage items from the access list.</summary>
    /// <returns>The object for retrieving storage items.</returns>
    public extern AccessListEntryView Entries { [MethodImpl] get; }

    /// <summary>Gets the maximum number of storage items that the access list can contain.</summary>
    /// <returns>The maximum number of storage items.</returns>
    public extern uint MaximumItemsAllowed { [MethodImpl] get; }
  }
}
