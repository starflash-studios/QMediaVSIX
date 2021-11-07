// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IStorageItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.FileProperties;

namespace Windows.Storage
{
  /// <summary>Manipulates storage items (files and folders) and their contents, and provides information about them.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1107798422, 51759, 17143, 189, 232, 139, 16, 69, 122, 127, 48)]
  public interface IStorageItem
  {
    /// <summary>Renames the current item.</summary>
    /// <param name="desiredName">The desired, new name of the item.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("RenameAsyncOverloadDefaultOptions")]
    [RemoteAsync]
    IAsyncAction RenameAsync(string desiredName);

    /// <summary>Renames the current item. This method also specifies what to do if an existing item in the current item's location has the same name.</summary>
    /// <param name="desiredName">The desired, new name of the current item.</param>
    /// <param name="option">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing item in the current item's location.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [Overload("RenameAsync")]
    [RemoteAsync]
    IAsyncAction RenameAsync(string desiredName, NameCollisionOption option);

    /// <summary>Deletes the current item.</summary>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [RemoteAsync]
    [Overload("DeleteAsyncOverloadDefaultOptions")]
    IAsyncAction DeleteAsync();

    /// <summary>Deletes the current item, optionally deleting it permanently.</summary>
    /// <param name="option">A value that indicates whether to delete the item permanently.</param>
    /// <returns>No object or value is returned by this method when it completes.</returns>
    [RemoteAsync]
    [Overload("DeleteAsync")]
    IAsyncAction DeleteAsync(StorageDeleteOption option);

    /// <summary>Gets the basic properties of the current item (like a file or folder).</summary>
    /// <returns>When this method completes successfully, it returns the basic properties of the current item as a BasicProperties object.</returns>
    [RemoteAsync]
    IAsyncOperation<BasicProperties> GetBasicPropertiesAsync();

    /// <summary>Gets the name of the item including the file name extension if there is one.</summary>
    /// <returns>The name of the item including the file name extension if there is one.</returns>
    string Name { get; }

    /// <summary>Gets the full file-system path of the item, if the item has a path.</summary>
    /// <returns>The full path of the item, if the item has a path in the user's file-system.</returns>
    string Path { get; }

    /// <summary>Gets the attributes of a storage item.</summary>
    /// <returns>The file or folder attributes.</returns>
    FileAttributes Attributes { get; }

    /// <summary>Gets the date and time when the current item was created.</summary>
    /// <returns>The date and time when the current item was created.</returns>
    DateTime DateCreated { get; }

    /// <summary>Determines whether the current IStorageItem matches the specified StorageItemTypes value.</summary>
    /// <param name="type">The value to match against.</param>
    /// <returns>True if the IStorageItem matches the specified value; otherwise false.</returns>
    bool IsOfType(StorageItemTypes type);
  }
}
