// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  /// <summary>Provides members for programmatically installing apps, including the ability to start an app install and get a list of app installs currently in progress.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppInstallManager : 
    IAppInstallManager,
    IAppInstallManager2,
    IAppInstallManager3,
    IAppInstallManager4,
    IAppInstallManager5,
    IAppInstallManager6,
    IAppInstallManager7
  {
    /// <summary>Creates and initializes a new instance of the AppInstallManager class.</summary>
    [MethodImpl]
    public extern AppInstallManager();

    /// <summary>Retrieves information about all apps that are currently in the installation queue.</summary>
    /// <returns>A collection of AppInstallItem objects that represent all apps that are currently in the installation queue.</returns>
    public extern IVectorView<AppInstallItem> AppInstallItems { [MethodImpl] get; }

    /// <summary>Cancels the installation of the specified app.</summary>
    /// <param name="productId">The product ID of the app whose installation should be canceled.</param>
    [MethodImpl]
    public extern void Cancel(string productId);

    /// <summary>Pauses the installation of the specified app.</summary>
    /// <param name="productId">The product ID of the app whose installation should be paused.</param>
    [MethodImpl]
    public extern void Pause(string productId);

    /// <summary>Restarts the installation of the specified app.</summary>
    /// <param name="productId">The product ID of the app whose installation should be restarted.</param>
    [MethodImpl]
    public extern void Restart(string productId);

    /// <summary>Occurs when an app has finished installing.</summary>
    public extern event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemCompleted;

    /// <summary>Occurs when the status of an app in the installation queue has changed.</summary>
    public extern event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemStatusChanged;

    /// <summary>Gets or sets the auto update setting for apps on the current computer or device.</summary>
    /// <returns>A value that specifies the auto update setting for apps on the current computer or device.</returns>
    public extern AutoUpdateSetting AutoUpdateSetting { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the user identity associated with the app installs.</summary>
    /// <returns>The user identity associated with the app installs.</returns>
    public extern string AcquisitionIdentity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Determines whether the specified app can be installed on the current computer or device.</summary>
    /// <param name="productId">The product ID of the app that this method will check to determine if it can be installed.</param>
    /// <param name="skuId">The SKU ID of the app that this method will check to determine if it can be installed.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns true if the app can be installed; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsApplicableAsync(
      string productId,
      string skuId);

    /// <summary>Starts the installation of the specified app.</summary>
    /// <param name="productId">The product ID of the app to install.</param>
    /// <param name="skuId">The SKU ID of the app to install.</param>
    /// <param name="repair">True to attempt to repair the installation of an app that is already installed; otherwise, false.</param>
    /// <param name="forceUseOfNonRemovableStorage">True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the app that was added to the installation queue.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage);

    /// <summary>Starts the update of an app specified by the package family name.</summary>
    /// <param name="packageFamilyName">The package family name of the app to update.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the app update that was added to the installation queue.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName);

    /// <summary>Searches for updates for the specified app.</summary>
    /// <param name="productId">The product ID of the app to be queried for updates.</param>
    /// <param name="skuId">The SKU to be queried for updates.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the available update.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId);

    /// <summary>Searches for all available updates to apps installed on the current computer or device.</summary>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync();

    /// <summary>Determines whether the specified app is blocked by policy on the current computer or device.</summary>
    /// <param name="storeClientName">The name of the app that this method will check to determine if is blocked by policy.</param>
    /// <param name="storeClientPublisher">The publisher name of the app that this method will check to determine if is blocked by policy.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns true if the app can be installed; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsStoreBlockedByPolicyAsync(
      string storeClientName,
      string storeClientPublisher);

    /// <summary>Determines whether the specified app has permission to install on the current computer or device.</summary>
    /// <param name="productId">The product ID of the app that this method will check to determine if it has permission to be installed.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns true if the app has permission to be installed; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(
      string productId);

    /// <summary>Starts the installation of the specified app, with the option to generate telemetry data.</summary>
    /// <param name="productId">The product ID of the app to install.</param>
    /// <param name="skuId">The SKU ID of the app to install.</param>
    /// <param name="repair">True to attempt to repair the installation of an app that is already installed; otherwise, false.</param>
    /// <param name="forceUseOfNonRemovableStorage">True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.</param>
    /// <param name="catalogId">The catalog ID of the app to install.</param>
    /// <param name="bundleId">The bundle ID of the app to install.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the app that was added to the installation queue.</returns>
    [RemoteAsync]
    [Overload("StartAppInstallWithTelemetryAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string catalogId,
      string bundleId,
      string correlationVector);

    /// <summary>Starts the update of an app specified by the package family name, with the option to generate telemetry data.</summary>
    /// <param name="packageFamilyName">The package family name of the app to update.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the app update that was added to the installation queue.</returns>
    [Overload("UpdateAppByPackageFamilyNameWithTelemetryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName,
      string correlationVector);

    /// <summary>Searches for updates for the specified app, with the option to generate telemetry data.</summary>
    /// <param name="productId">The product ID of the app to be queried for updates.</param>
    /// <param name="skuId">The SKU ID of the app to be queried for updates.</param>
    /// <param name="catalogId">The catalog ID of the app to be queried for updates.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the available update.</returns>
    [Overload("SearchForUpdatesWithTelemetryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    /// <summary>Searches for all available updates to apps installed on the current computer or device, with the option to generate telemetry data.</summary>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [Overload("SearchForAllUpdatesWithTelemetryAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync(
      string correlationVector);

    /// <summary>Determines whether the specified app has permission to install on the current computer or device, with the option to generate telemetry data.</summary>
    /// <param name="productId">The product ID of the app that this method will check to determine if it has permission to be installed.</param>
    /// <param name="skuId">The SKU ID of the app that this method will check to determine if it has permission to be installed.</param>
    /// <param name="catalogId">The catalog ID of the app that this method will check to determine if it has permission to be installed.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns true if the app has permission to be installed; otherwise false.</returns>
    [RemoteAsync]
    [Overload("GetIsAppAllowedToInstallWithTelemetryAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    /// <summary>Cancels the installation of the specified app, with the option to generate telemetry data.</summary>
    /// <param name="productId">The product ID of the app whose installation should be canceled.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    [Overload("CancelWithTelemetry")]
    [MethodImpl]
    public extern void Cancel(string productId, string correlationVector);

    /// <summary>Pauses the installation of the specified app, with the option to generate telemetry data.</summary>
    /// <param name="productId">The product ID of the app whose installation should be paused.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    [Overload("PauseWithTelemetry")]
    [MethodImpl]
    public extern void Pause(string productId, string correlationVector);

    /// <summary>Restarts the installation of the specified app, with the option to generate telemetry data.</summary>
    /// <param name="productId">The product ID of the app whose installation should be restarted.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    [Overload("RestartWithTelemetry")]
    [MethodImpl]
    public extern void Restart(string productId, string correlationVector);

    /// <summary>Starts the installation of the specified app or app bundle.</summary>
    /// <param name="productId">The product ID of the app to install.</param>
    /// <param name="catalogId">The catalog ID of the app to install.</param>
    /// <param name="flightId">The flight ID of the app to install.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="repair">True to attempt to repair the installation of an app that is already installed; otherwise, false.</param>
    /// <param name="forceUseOfNonRemovableStorage">True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="targetVolume">The package storage volume where the app or app bundle will be installed.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the app or set of apps (for an app bundle) that were added to the installation queue. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallAsync(
      string productId,
      string catalogId,
      string flightId,
      string clientId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string correlationVector,
      PackageVolume targetVolume);

    /// <summary>Starts the installation of the specified app or app bundle for the specified user.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="productId">The product ID of the app to install.</param>
    /// <param name="catalogId">The catalog ID of the app to install.</param>
    /// <param name="flightId">The flight ID of the app to install.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="repair">True to attempt to repair the installation of an app that is already installed; otherwise, false.</param>
    /// <param name="forceUseOfNonRemovableStorage">True to install the app to non-removable storage even if the user has configured apps to install to SD card; false to install the app to non-removable storage or SD card according to the user's settings.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="targetVolume">The package storage volume where the app or app bundle will be installed.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the app or set of apps (for an app bundle) that were added to the installation queue. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallForUserAsync(
      User user,
      string productId,
      string catalogId,
      string flightId,
      string clientId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string correlationVector,
      PackageVolume targetVolume);

    /// <summary>Starts the update of an app for a given user specified by the package family name, with the option to generate telemetry data.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="packageFamilyName">The package family name of the app to update.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the app update that was added to the installation queue.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameForUserAsync(
      User user,
      string packageFamilyName,
      string correlationVector);

    /// <summary>Searches for updates for the specified app and user, with the option to generate telemetry data.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="productId">The product ID of the app to be queried for updates.</param>
    /// <param name="skuId">The SKU ID of the app to be queried for updates.</param>
    /// <param name="catalogId">The catalog ID of the app to be queried for updates.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the available update.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    /// <summary>Searches for all available updates to apps installed on the current computer or device for the specified user, with the option to generate telemetry data.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesForUserAsync(
      User user,
      string correlationVector);

    /// <summary>Determines whether the specified app has permission to install on the current computer or device for the specified user, with the option to generate telemetry data.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="productId">The product ID of the app that this method will check to determine if it has permission to be installed.</param>
    /// <param name="skuId">The SKU ID of the app that this method will check to determine if it has permission to be installed.</param>
    /// <param name="catalogId">The catalog ID of the app that this method will check to determine if it has permission to be installed.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns true if the app has permission to be installed; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsAppAllowedToInstallForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    /// <summary>Determines whether the specified app can be installed on the current computer or device for the specified user.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="productId">The product ID of the app that this method will check to determine if it can be installed.</param>
    /// <param name="skuId">The SKU ID of the app that this method will check to determine if it can be installed.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns true if the app can be installed; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsApplicableForUserAsync(
      User user,
      string productId,
      string skuId);

    /// <summary>Moves the specified app to the front of the download queue.</summary>
    /// <param name="productId">The product ID of the app to move to the front of the download queue.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    [MethodImpl]
    public extern void MoveToFrontOfDownloadQueue(string productId, string correlationVector);

    /// <summary>Grants a free entitlement for the specified app to the current user.</summary>
    /// <param name="storeId">The Store ID of the app for which you want to grant the entitlement.</param>
    /// <param name="campaignId">The ID of the campaign that is associated with the entitlement.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns a GetEntitlementResult object that indicates the status of the entitlement grant.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);

    /// <summary>Grants a free entitlement for the specified app to the specified user.</summary>
    /// <param name="user">A Windows.System.User object that represents the user to which you want to grant the entitlement.</param>
    /// <param name="storeId">The Store ID of the app for which you want to grant the entitlement.</param>
    /// <param name="campaignId">The ID of the campaign that is associated with the entitlement.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns a GetEntitlementResult object that indicates the status of the entitlement grant.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementForUserAsync(
      User user,
      string storeId,
      string campaignId,
      string correlationVector);

    /// <summary>Grants a free entitlement for the specified app to all users on the current device.</summary>
    /// <param name="storeId">The Store ID of the app for which you want to grant the entitlement.</param>
    /// <param name="campaignId">The ID of the campaign that is associated with the entitlement.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns a GetEntitlementResult object that indicates the status of the entitlement grant.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GetEntitlementResult> GetFreeDeviceEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);

    /// <summary>Retrieves information about all the apps that are part of a single app bundle that is currently in the installation queue.</summary>
    /// <returns>A collection of AppInstallItem objects that represent all the apps that are part of a single app bundle that is currently in the installation queue.</returns>
    public extern IVectorView<AppInstallItem> AppInstallItemsWithGroupSupport { [MethodImpl] get; }

    /// <summary>Searches for all available updates to apps installed on the current computer or device, with the ability to allow forced app restarts and the option to generate telemetry data.</summary>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="updateOptions">Provides additional options for the operation, including the ability to allow forced app restarts.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [Overload("SearchForAllUpdatesWithUpdateOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync(
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    /// <summary>Searches for all available updates to apps installed on the current computer or device for the specified user, with the ability to allow forced app restarts and the option to generate telemetry data.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="updateOptions">Provides additional options for the operation, including the ability to allow forced app restarts.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [Overload("SearchForAllUpdatesWithUpdateOptionsForUserAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesForUserAsync(
      User user,
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    /// <summary>Searches for updates for the specified app, with the ability to allow a forced app restart and the option to generate telemetry data.</summary>
    /// <param name="productId">The product ID of the app to be queried for updates.</param>
    /// <param name="skuId">The SKU ID of the app to be queried for updates.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="updateOptions">Provides additional options for the operation, including the ability to allow a forced app restart.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the available update.</returns>
    [Overload("SearchForUpdatesWithUpdateOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId,
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    /// <summary>Searches for updates for the specified app and user, with the ability to allow a forced app restart and the option to generate telemetry data.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="productId">The product ID of the app to be queried for updates.</param>
    /// <param name="skuId">The SKU ID of the app to be queried for updates.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="updateOptions">Provides additional options for the operation, including the ability to allow a forced app restart.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns an AppInstallItem that represents the available update.</returns>
    [RemoteAsync]
    [Overload("SearchForUpdatesWithUpdateOptionsForUserAsync")]
    [MethodImpl]
    public extern IAsyncOperation<AppInstallItem> SearchForUpdatesForUserAsync(
      User user,
      string productId,
      string skuId,
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    /// <summary>Starts the installation of the specified app or app bundle, with the ability to specify additional install options such as whether to allow a forced app restart.</summary>
    /// <param name="productId">The product ID of the app to install.</param>
    /// <param name="flightId">The flight ID of the app to install.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="installOptions">Provides additional options for the operation, including the ability to allow a forced app restart.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the app or set of apps (for an app bundle) that were added to the installation queue. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [Overload("StartProductInstallWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallAsync(
      string productId,
      string flightId,
      string clientId,
      string correlationVector,
      AppInstallOptions installOptions);

    /// <summary>Starts the installation of the specified app or app bundle for the specified user, with the ability to specify additional install options such as whether to allow a forced app restart.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="productId">The product ID of the app to install.</param>
    /// <param name="flightId">The flight ID of the app to install.</param>
    /// <param name="clientId">The ID of the caller.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data.</param>
    /// <param name="installOptions">Provides additional options for the operation, including the ability to allow a forced app restart.</param>
    /// <returns>An asynchronous operation that, on successful completion, returns the app or set of apps (for an app bundle) that were added to the installation queue. If you use Asynchronous programming, the result type is a read-only list/vector of AppInstallItem items. (You can use APIs of IVectorView&lt;AppInstallItem&gt; for C++ or JavaScript, APIs of IReadOnlyList&lt;AppInstallItem&gt; for .NET.)</returns>
    [RemoteAsync]
    [Overload("StartProductInstallWithOptionsForUserAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallForUserAsync(
      User user,
      string productId,
      string flightId,
      string clientId,
      string correlationVector,
      AppInstallOptions installOptions);

    /// <summary>Returns a value that indicates whether the package with the specified identity info is allowed to be installed on the current device.</summary>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data for the operation.</param>
    /// <param name="packageIdentityName">The identity name of the package, as specified in the package manifest.</param>
    /// <param name="publisherCertificateName">The publisher name of the package, as specified in the package manifest.</param>
    /// <returns>True if the package with the specified identity info is allowed to be installed on the current device; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsPackageIdentityAllowedToInstallAsync(
      string correlationVector,
      string packageIdentityName,
      string publisherCertificateName);

    /// <summary>Returns a value that indicates whether the package with the specified identity info is allowed to be installed on the current device for the specified user.</summary>
    /// <param name="user">An object that identifies the user to specify for this operation.</param>
    /// <param name="correlationVector">A correlation vector string that can be used to generate telemetry data for the operation.</param>
    /// <param name="packageIdentityName">The identity name of the package, as specified in the package manifest.</param>
    /// <param name="publisherCertificateName">The publisher name of the package, as specified in the package manifest.</param>
    /// <returns>True if the package with the specified identity info is allowed to be installed on the current device for the specified user; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsPackageIdentityAllowedToInstallForUserAsync(
      User user,
      string correlationVector,
      string packageIdentityName,
      string publisherCertificateName);

    /// <summary>Gets or sets a value that indicates whether the calling app has elevated administrative privileges to ensure installing an app for all users will succeed.</summary>
    /// <returns>True indicates the calling app has elevated administrative privileges; otherwise, false.</returns>
    public extern bool CanInstallForAllUsers { [MethodImpl] get; }
  }
}
