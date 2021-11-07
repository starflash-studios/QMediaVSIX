// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ApplicationData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Storage
{
  /// <summary>Provides access to the application data store. Application data consists of files and settings that are either local, roaming, or temporary.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IApplicationDataStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IApplicationDataStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationData : 
    IApplicationData,
    IApplicationData2,
    IApplicationData3,
    IClosable
  {
    /// <summary>Gets the version number of the application data in the app data store.</summary>
    /// <returns>The version number of the application data.</returns>
    public extern uint Version { [MethodImpl] get; }

    /// <summary>Sets the version number of the application data in the app data store.</summary>
    /// <param name="desiredVersion">The new version number.</param>
    /// <param name="handler">The set version event handler.</param>
    /// <returns>An object that is used to manage the asynchronous set version operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetVersionAsync(
      uint desiredVersion,
      ApplicationDataSetVersionHandler handler);

    /// <summary>Removes all application data from the local, roaming, and temporary app data stores.</summary>
    /// <returns>An object that is used to manage the asynchronous clear operation.</returns>
    [RemoteAsync]
    [Overload("ClearAllAsync")]
    [MethodImpl]
    public extern IAsyncAction ClearAsync();

    /// <summary>Removes all application data from the specified app data store.</summary>
    /// <param name="locality">One of the enumeration values.</param>
    /// <returns>An object that is used to manage the asynchronous clear operation.</returns>
    [Overload("ClearAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearAsync(ApplicationDataLocality locality);

    /// <summary>Gets the application settings container in the local app data store.</summary>
    /// <returns>The application settings container.</returns>
    public extern ApplicationDataContainer LocalSettings { [MethodImpl] get; }

    /// <summary>Gets the application settings container in the roaming app data store.</summary>
    /// <returns>The application settings container.</returns>
    public extern ApplicationDataContainer RoamingSettings { [MethodImpl] get; }

    /// <summary>Gets the root folder in the local app data store. This folder is backed up to the cloud.</summary>
    /// <returns>The file system folder that contains the files.</returns>
    public extern StorageFolder LocalFolder { [MethodImpl] get; }

    /// <summary>Gets the root folder in the roaming app data store.</summary>
    /// <returns>The file system folder that contains the files.</returns>
    public extern StorageFolder RoamingFolder { [MethodImpl] get; }

    /// <summary>Gets the root folder in the temporary app data store.</summary>
    /// <returns>The file system folder that contains the files.</returns>
    public extern StorageFolder TemporaryFolder { [MethodImpl] get; }

    /// <summary>Occurs when roaming application data is synchronized.</summary>
    public extern event TypedEventHandler<ApplicationData, object> DataChanged;

    /// <summary>Sends a DataChanged event to all registered event handlers.</summary>
    [MethodImpl]
    public extern void SignalDataChanged();

    /// <summary>Gets the maximum size of the data that can be synchronized to the cloud from the roaming app data store.</summary>
    /// <returns>The maximum size of the data, in KB.</returns>
    public extern ulong RoamingStorageQuota { [MethodImpl] get; }

    /// <summary>Gets the folder in the local app data store where you can save files that are not included in backup and restore.</summary>
    /// <returns>The folder in the local app data store where you can save files that are not included in backup and restore.</returns>
    public extern StorageFolder LocalCacheFolder { [MethodImpl] get; }

    /// <summary>Gets the specified subfolder of the shared storage folder for the publisher of the current app.</summary>
    /// <param name="folderName">The subfolder to get from the shared storage folder for the publisher of the current app.</param>
    /// <returns>The specified subfolder.</returns>
    [MethodImpl]
    public extern StorageFolder GetPublisherCacheFolder(string folderName);

    /// <summary>Clears the files and subfolders from the specified subfolder of the shared storage folder for the publisher of the current app.</summary>
    /// <param name="folderName">The subfolder of the shared storage folder for the publisher of the current app from which to clear the files and subfolders.</param>
    /// <returns>Represents an asynchronous action that does not return a result and does not have progress notifications. You can use this value to get the results of the operation, or to specify a method to run when the operation completes - for example, to repopulate the shared storage folder with new data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearPublisherCacheFolderAsync(string folderName);

    /// <summary>Gets the root folder in the shared app data store.</summary>
    /// <returns>The file system folder that contains files.</returns>
    public extern StorageFolder SharedLocalFolder { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Static method that returns the ApplicationData for a User.</summary>
    /// <param name="user">The User for which the ApplicationData is returned.</param>
    /// <returns>When this method completes, it returns the requested ApplicationData object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ApplicationData> GetForUserAsync(
      User user);

    /// <summary>Provides access to the app data store associated with the app's app package.</summary>
    /// <returns>The app data store.</returns>
    public static extern ApplicationData Current { [MethodImpl] get; }
  }
}
