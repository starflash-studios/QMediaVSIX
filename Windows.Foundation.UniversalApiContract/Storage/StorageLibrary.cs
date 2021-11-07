// Decompiled with JetBrains decompiler
// Type: Windows.Storage.StorageLibrary
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>Lets you add and remove folders from a library like Music or Videos and lets you get a list of folders included in the library.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IStorageLibraryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStorageLibraryStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class StorageLibrary : IStorageLibrary, IStorageLibrary2, IStorageLibrary3
  {
    /// <summary>Prompts the user to select a folder, and then adds the folder to the library.</summary>
    /// <returns>When this method completes, it returns the folder that the user picked and added as a StorageFolder. If the user cancels the operation and doesn't pick a folder, the method returns **null**.</returns>
    [MethodImpl]
    public extern IAsyncOperation<StorageFolder> RequestAddFolderAsync();

    /// <summary>Prompts the user to confirm removal of the specified folder from the current library, and then removes the folder.</summary>
    /// <param name="folder">The folder to remove.</param>
    /// <returns>Returns true if the folder was removed; otherwise false.</returns>
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestRemoveFolderAsync(StorageFolder folder);

    /// <summary>Gets the folders in the current library.</summary>
    /// <returns>The folders in the current storage library.</returns>
    public extern IObservableVector<StorageFolder> Folders { [MethodImpl] get; }

    /// <summary>Get the default save folder for the current library.</summary>
    /// <returns>The default save folder for the current library.</returns>
    public extern StorageFolder SaveFolder { [MethodImpl] get; }

    /// <summary>Occurs when the list of folders in the current library changes.</summary>
    public extern event TypedEventHandler<StorageLibrary, object> DefinitionChanged;

    /// <summary>Returns the StorageLibraryChangeTracker associated with the storage library.</summary>
    /// <returns>The StorageLibraryChangeTracker associated with the storage library.</returns>
    public extern StorageLibraryChangeTracker ChangeTracker { [MethodImpl] get; }

    /// <summary>Determines if there are suggestions for adding existing folders with content to the StorageLibrary.</summary>
    /// <returns>**True** if there are folder suggestions; **False** otherwise</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> AreFolderSuggestionsAvailableAsync();

    /// <summary>Gets the specified library for a User.</summary>
    /// <param name="user">The User for which the library is retrieved.</param>
    /// <param name="libraryId">A KnownLibraryId value that identifies the library to retrieve, like Music or Videos.</param>
    /// <returns>When this method completes successfully, it returns the library (type StorageLibrary ).</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageLibrary> GetLibraryForUserAsync(
      User user,
      KnownLibraryId libraryId);

    /// <summary>Gets the specified library.</summary>
    /// <param name="libraryId">A KnownLibraryId value that identifies the library to retrieve, like Music or Videos.</param>
    /// <returns>When this method completes successfully, it returns the library (type StorageLibrary ).</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageLibrary> GetLibraryAsync(
      KnownLibraryId libraryId);
  }
}
