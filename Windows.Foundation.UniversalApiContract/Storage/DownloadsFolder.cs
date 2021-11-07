// Decompiled with JetBrains decompiler
// Type: Windows.Storage.DownloadsFolder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>Creates files and folders inside the Downloads folder.</summary>
  [Static(typeof (IDownloadsFolderStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IDownloadsFolderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class DownloadsFolder
  {
    /// <summary>Creates a new file inside the Downloads folder of a specific User.</summary>
    /// <param name="user">The User for which the file is created.</param>
    /// <param name="desiredName">The desired name of the file to create.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile object.</returns>
    [Overload("CreateFileForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName);

    /// <summary>Creates a new subfolder inside the Downloads folder of a specific User.</summary>
    /// <param name="user">The User for which the folder is created.</param>
    /// <param name="desiredName">The desired name of the subfolder to create.</param>
    /// <returns>When this method completes, it returns the new subfolder as a StorageFolder.</returns>
    [Overload("CreateFolderForUserAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName);

    /// <summary>Creates a new file in the Downloads folder of a specific User, and specifies what to do if a file with the same name already exists in the Downloads folder.</summary>
    /// <param name="user">The User for which the file is created.</param>
    /// <param name="desiredName">The desired name of the file to create.</param>
    /// <param name="option">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing file in the current folder.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile object.</returns>
    [Overload("CreateFileForUserWithCollisionOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);

    /// <summary>Creates a new subfolder in the Downloads folder of a specific User, and specifies what to do if a subfolder with the same name already exists in the Downloads folder.</summary>
    /// <param name="user">The User for which the folder is created.</param>
    /// <param name="desiredName">The desired name of the subfolder to create.</param>
    /// <param name="option">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing subfolder in the Downloads folder.</param>
    /// <returns>When this method completes, it returns the new subfolder as a StorageFolder.</returns>
    [RemoteAsync]
    [Overload("CreateFolderForUserWithCollisionOptionAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderForUserAsync(
      User user,
      string desiredName,
      CreationCollisionOption option);

    /// <summary>Creates a new file inside the Downloads folder.</summary>
    /// <param name="desiredName">The desired name of the file to create.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile object.</returns>
    [RemoteAsync]
    [Overload("CreateFileAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName);

    /// <summary>Creates a new subfolder in the Downloads folder.</summary>
    /// <param name="desiredName">The desired name of the subfolder to create.</param>
    /// <returns>When this method completes, it returns the new subfolder as a StorageFolder.</returns>
    [RemoteAsync]
    [Overload("CreateFolderAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName);

    /// <summary>Creates a new file in the Downloads folder, and specifies what to do if a file with the same name already exists in the Downloads folder.</summary>
    /// <param name="desiredName">The desired name of the file to create.</param>
    /// <param name="option">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing file in the current folder.</param>
    /// <returns>When this method completes, it returns the new file as a StorageFile object.</returns>
    [Overload("CreateFileWithCollisionOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFile> CreateFileAsync(
      string desiredName,
      CreationCollisionOption option);

    /// <summary>Creates a new subfolder in the Downloads folder, and specifies what to do if a subfolder with the same name already exists in the Downloads folder.</summary>
    /// <param name="desiredName">The desired name of the subfolder to create.</param>
    /// <param name="option">The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing subfolder in the Downloads folder.</param>
    /// <returns>When this method completes, it returns the new subfolder as a StorageFolder.</returns>
    [Overload("CreateFolderWithCollisionOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<StorageFolder> CreateFolderAsync(
      string desiredName,
      CreationCollisionOption option);
  }
}
