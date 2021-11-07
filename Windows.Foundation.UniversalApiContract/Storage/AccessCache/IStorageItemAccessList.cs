// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.IStorageItemAccessList
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  /// <summary>Represents a list of storage items that the app has stored for efficient future access.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(749729453, 56976, 18421, 178, 195, 221, 54, 201, 253, 212, 83)]
  public interface IStorageItemAccessList
  {
    /// <summary>Adds a new storage item to the access list.</summary>
    /// <param name="file">The storage item to add.</param>
    /// <returns>A token that the app can use later to retrieve the storage item.</returns>
    [Overload("AddOverloadDefaultMetadata")]
    string Add(IStorageItem file);

    /// <summary>Adds a new storage item and accompanying metadata to the access list.</summary>
    /// <param name="file">The storage item to add.</param>
    /// <param name="metadata">Optional metadata to associate with the storage item.</param>
    /// <returns>A token that the app can use later to retrieve the storage item.</returns>
    [Overload("Add")]
    string Add(IStorageItem file, string metadata);

    /// <summary>Adds a new storage item to the access list, or replaces the specified item if it already exists in the list.</summary>
    /// <param name="token">The token associated with the new storage item. If the access list already contains a storage item that has this token, the new item replaces the existing one.</param>
    /// <param name="file">The storage item to add or replace.</param>
    [Overload("AddOrReplaceOverloadDefaultMetadata")]
    void AddOrReplace(string token, IStorageItem file);

    /// <summary>Adds a new storage item and accompanying metadata to the access list, or replaces the specified item if it already exists in the list.</summary>
    /// <param name="token">The token associated with the new storage item. If the access list already contains a storage item that has this token, the new item replaces the existing one.</param>
    /// <param name="file">The storage item to add or replace.</param>
    /// <param name="metadata">Optional metadata to associate with the storage item.</param>
    [Overload("AddOrReplace")]
    void AddOrReplace(string token, IStorageItem file, string metadata);

    /// <summary>Retrieves the specified item (like a file or folder) from the list.</summary>
    /// <param name="token">The token of the item to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the item (type IStorageItem ) that is associated with the specified *token*.</returns>
    [Overload("GetItemAsync")]
    IAsyncOperation<IStorageItem> GetItemAsync(string token);

    /// <summary>Retrieves the specified StorageFile from the list.</summary>
    /// <param name="token">The token of the StorageFile to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the StorageFile that is associated with the specified *token*.</returns>
    [Overload("GetFileAsync")]
    IAsyncOperation<StorageFile> GetFileAsync(string token);

    /// <summary>Retrieves the specified StorageFolder from the list.</summary>
    /// <param name="token">The token of the StorageFolder to retrieve.</param>
    /// <returns>When this method completes successfully, it returns the StorageFolder that is associated with the specified *token*.</returns>
    [Overload("GetFolderAsync")]
    IAsyncOperation<StorageFolder> GetFolderAsync(string token);

    /// <summary>Retrieves the specified item (like a file or folder) from the list using the specified options.</summary>
    /// <param name="token">The token of the item to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the item (type IStorageItem ) that is associated with the specified *token*.</returns>
    [Overload("GetItemWithOptionsAsync")]
    IAsyncOperation<IStorageItem> GetItemAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Retrieves the specified StorageFile from the list using the specified options.</summary>
    /// <param name="token">The token of the StorageFile to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the StorageFile that is associated with the specified *token*.</returns>
    [Overload("GetFileWithOptionsAsync")]
    IAsyncOperation<StorageFile> GetFileAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Retrieves the specified StorageFolder from the list using the specified options.</summary>
    /// <param name="token">The token of the StorageFolder to retrieve.</param>
    /// <param name="options">The enum value that describes the behavior to use when the app accesses the item.</param>
    /// <returns>When this method completes successfully, it returns the StorageFolder that is associated with the specified *token*.</returns>
    [Overload("GetFolderWithOptionsAsync")]
    IAsyncOperation<StorageFolder> GetFolderAsync(
      string token,
      AccessCacheOptions options);

    /// <summary>Removes the specified storage item from the access list.</summary>
    /// <param name="token">The token of the storage item to remove.</param>
    void Remove(string token);

    /// <summary>Determines whether the access list contains the specified storage item.</summary>
    /// <param name="token">The token of the storage item to look for.</param>
    /// <returns>True if the access list contains the specified storage item; false otherwise.</returns>
    bool ContainsItem(string token);

    /// <summary>Removes all storage items from the access list.</summary>
    void Clear();

    /// <summary>Determines whether the app has access to the specified storage item in the access list.</summary>
    /// <param name="file">The storage item to check for access.</param>
    /// <returns>True if the app can access the storage item; otherwise false.</returns>
    bool CheckAccess(IStorageItem file);

    /// <summary>Gets an object for retrieving storage items from the access list.</summary>
    /// <returns>The object for retrieving storage items.</returns>
    AccessListEntryView Entries { get; }

    /// <summary>Gets the maximum number of storage items that the access list can contain.</summary>
    /// <returns>The maximum number of storage items.</returns>
    uint MaximumItemsAllowed { get; }
  }
}
