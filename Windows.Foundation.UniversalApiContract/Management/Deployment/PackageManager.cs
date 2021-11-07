// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  /// <summary>Manages the software available to a user.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [DualApiPartition(version = 1)]
  public sealed class PackageManager : 
    IPackageManager,
    IPackageManager2,
    IPackageManager3,
    IPackageManager4,
    IPackageManager5,
    IPackageManager6,
    IPackageManager7,
    IPackageManager8,
    IPackageManager9,
    IPackageManager10
  {
    /// <summary>Creates and initializes a new instance of the object.</summary>
    [MethodImpl]
    public extern PackageManager();

    [Overload("AddPackageAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> UpdatePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    /// <summary>Removes a package for the current user asynchronously and receives progress and status messages on the removal operation. Dependency packages are also removed for the user if no other packages installed for the user depend on them.</summary>
    /// <param name="packageFullName">A string representation of the package identity to identify the package to be removed.</param>
    /// <returns>The status of the deployment request. The DeploymentResult contains the final returned value of the deployment operation, once it is completed. The DeploymentProgress can be used to obtain the percentage of completion over the entire course of the deployment operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync(
      string packageFullName);

    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris);

    [Overload("RegisterPackageAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    /// <summary>Retrieves information about a specified family of packages installed across all users.</summary>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location.</returns>
    [Overload("FindPackages")]
    [MethodImpl]
    public extern IIterable<Package> FindPackages();

    /// <summary>Finds all packages installed for the specified user.</summary>
    /// <param name="userSecurityId">The user security identifier (SID). If this parameter is **string.Empty**, the packages are retrieved for the current user.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location.</returns>
    [Overload("FindPackagesByUserSecurityId")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUser(string userSecurityId);

    /// <summary>Finds all installed packages with the specified name and publisher.</summary>
    /// <param name="packageName">The package name. This parameter cannot be **null**.</param>
    /// <param name="packagePublisher">The package publisher. This parameter cannot be **null**.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects with the same package name and publisher name is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified name and publisher are found, this method returns an empty list.</returns>
    [Overload("FindPackagesByNamePublisher")]
    [MethodImpl]
    public extern IIterable<Package> FindPackages(
      string packageName,
      string packagePublisher);

    /// <summary>Retrieves information about all packages with the specified package name and publisher name, installed for a specific user.</summary>
    /// <param name="userSecurityId">The user security identifier (SID). If this parameter is an empty string (""), the packages are retrieved for the current user.</param>
    /// <param name="packageName">The package name. This parameter cannot be **null**.</param>
    /// <param name="packagePublisher">The package publisher. This parameter cannot be **null**.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified name and publisher are found, this method returns an empty list.</returns>
    [Overload("FindPackagesByUserSecurityIdNamePublisher")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUser(
      string userSecurityId,
      string packageName,
      string packagePublisher);

    /// <summary>Finds the users who have installed the specified package.</summary>
    /// <param name="packageFullName">The full name of the package. This parameter cannot be **null**.</param>
    /// <returns>If the method succeeds, an enumerable collection of package user information objects is returned. Each PackageUserInformation object in this collection contains the user security identifier (user SID) of a user for whom the specified package is installed. If no packages with the specified package full name are found, this method returns an empty list.</returns>
    [MethodImpl]
    public extern IIterable<PackageUserInformation> FindUsers(
      string packageFullName);

    /// <summary>Sets the state of a package, for example, to usable, tampered with, and so on.</summary>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <param name="packageState">One of the enumeration values.</param>
    [MethodImpl]
    public extern void SetPackageState(string packageFullName, PackageState packageState);

    /// <summary>Retrieves information about the specified package installed for any user.</summary>
    /// <param name="packageFullName">The full name of the package. This parameter cannot be null.</param>
    /// <returns>If this method succeeds it returns a package object that contains information about the specified package, including but not limited to its name, publisher, version, and install location. If the specified package is not found, this method returns **null**.</returns>
    [Overload("FindPackageByPackageFullName")]
    [MethodImpl]
    public extern Package FindPackage(string packageFullName);

    /// <summary>Cleans up a specified package for a specified user. Used to cleanup packages installed for a user after their user profile is deleted.</summary>
    /// <param name="packageName">The package name.</param>
    /// <param name="userSecurityId">The user security identifier (SID).</param>
    /// <returns>The status of the deployment request. The DeploymentResult contains the final returned value of the deployment operation, once it is completed. The DeploymentProgress can be used to obtain the percentage of completion over the entire course of the deployment operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> CleanupPackageForUserAsync(
      string packageName,
      string userSecurityId);

    /// <summary>Retrieves information about a specified family of packages installed across all users.</summary>
    /// <param name="packageFamilyName">The package family name. This parameter cannot be **null**.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects with the same package family name will be returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package family name are found, this method returns an empty list.</returns>
    [Overload("FindPackagesByPackageFamilyName")]
    [MethodImpl]
    public extern IIterable<Package> FindPackages(string packageFamilyName);

    /// <summary>Retrieves information about a specified family of packages installed for a specific user.</summary>
    /// <param name="userSecurityId">The user security identifier (SID). If this parameter is String.Empty, the packages are retrieved for the current user.</param>
    /// <param name="packageFamilyName">The family name of packages to find. This parameter cannot be **null**.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package family name are found, this method returns an empty list.</returns>
    [Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUser(
      string userSecurityId,
      string packageFamilyName);

    /// <summary>Retrieves information about a specific package installed for a specific user or for all users.</summary>
    /// <param name="userSecurityId">The user security identifier (SID). If this parameter is string.Empty, the packages are retrieved for the current user.</param>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <returns>The package.</returns>
    [Overload("FindPackageByUserSecurityIdPackageFullName")]
    [MethodImpl]
    public extern Package FindPackageForUser(string userSecurityId, string packageFullName);

    /// <summary>Removes a package for the current user asynchronously and receives progress and status messages on the removal operation. Dependency packages are also removed for the user if no other packages installed for the user depend on them.</summary>
    /// <param name="packageFullName">A string representation of the package identity to identify the package to be removed.</param>
    /// <param name="removalOptions">A RemovalOptions -typed value that modifies the removal operation.</param>
    /// <returns>A pointer that receives the address of an object that implements the IAsyncOperationWithProgress interface.</returns>
    [Overload("RemovePackageWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync(
      string packageFullName,
      RemovalOptions removalOptions);

    [Overload("StagePackageWithOptionsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFullNameAsync(
      string mainPackageFullName,
      IIterable<string> dependencyPackageFullNames,
      DeploymentOptions deploymentOptions);

    /// <summary>Retrieves information about specific package types that are installed across all users.</summary>
    /// <param name="packageTypes">A combination of PackageTypes -typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. The *packageTypes* parameter determines the types of packages to return.</returns>
    [Overload("FindPackagesWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes);

    /// <summary>Finds packages of specific types that are installed for the specified user.</summary>
    /// <param name="userSecurityId">The user security identifier (SID). If this parameter is **null**, the packages are retrieved for the current user. Any user SID other than that of current user requires administrative privileges.</param>
    /// <param name="packageTypes">A combination of PackageTypes -typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. The *packageTypes* parameter determines the types of packages to return.</returns>
    [Overload("FindPackagesByUserSecurityIdWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes);

    /// <summary>Finds all installed packages of specific types with the specified name and publisher.</summary>
    /// <param name="packageName">The package name. This parameter can't be **null**.</param>
    /// <param name="packagePublisher">The package publisher. This parameter can't be **null**.</param>
    /// <param name="packageTypes">A combination of PackageTypes -typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects with the same package name and publisher name is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified name and publisher are found, this method returns an empty list. The *packageTypes* parameter determines the types of packages to return.</returns>
    [Overload("FindPackagesByNamePublisherWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesWithPackageTypes(
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    /// <summary>Retrieves information about packages of specific types with the specified package name and publisher name, installed for a specific user.</summary>
    /// <param name="userSecurityId">The user security identifier (SID). If this parameter is **null**, the packages are retrieved for the current user. Any user SID other than that of current user requires administrative privileges.</param>
    /// <param name="packageName">The package name. This parameter can't be **null**.</param>
    /// <param name="packagePublisher">The package publisher. This parameter can't be **null**.</param>
    /// <param name="packageTypes">A combination of PackageTypes -typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package publisher and family name are found, this method returns an empty list. The *packageTypes* parameter determines the types of packages to return.</returns>
    [Overload("FindPackagesByUserSecurityIdNamePublisherWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    /// <summary>Retrieves information about a specified family of packages and specific package types that are installed across all users.</summary>
    /// <param name="packageFamilyName">The package family name. This parameter can't be **null**.</param>
    /// <param name="packageTypes">A combination of PackageTypes -typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects with the same package family name is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package family name are found, this method returns an empty list. The *packageTypes* parameter determines the types of packages to return.</returns>
    [Overload("FindPackagesByPackageFamilyNameWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesWithPackageTypes(
      string packageFamilyName,
      PackageTypes packageTypes);

    /// <summary>Retrieves information about a specified family of packages and of specific types that are installed for the specified user.</summary>
    /// <param name="userSecurityId">The user security identifier (SID). If this parameter is **String.Empty**, the packages are retrieved for the current user. Any user SID other than that of current user requires administrative privileges.</param>
    /// <param name="packageFamilyName">The family name of packages to find. This parameter can't be **null**.</param>
    /// <param name="packageTypes">A combination of PackageTypes -typed values that are combined by using a bitwise OR operation. The resulting value specifies the types of packages to be included in the result set.</param>
    /// <returns>If the method succeeds, an enumerable collection of package objects is returned. Each package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location. If no packages with the specified package family name are found, this method returns an empty list. The *packageTypes* parameter determines the types of packages to return.</returns>
    [Overload("FindPackagesByUserSecurityIdPackageFamilyNameWithPackageTypes")]
    [MethodImpl]
    public extern IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageFamilyName,
      PackageTypes packageTypes);

    /// <summary>Stages a package's roaming data to the system without registering the package. Call this method after staging the package but before registering the package for a particular user.</summary>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <returns>An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.</returns>
    [RemoteAsync]
    [Overload("StageUserDataAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName);

    /// <summary>Creates a new volume. The caller must be a member of the administrators group.</summary>
    /// <param name="packageStorePath">The absolute path of the package store.</param>
    /// <returns>An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperation** interface and returns the newly added PackageVolume.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageVolume> AddPackageVolumeAsync(
      string packageStorePath);

    [Overload("AddPackageToVolumeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    /// <summary>Clears the status of a package.</summary>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <param name="status">One of the enumeration values that specifies the status to clear.</param>
    [MethodImpl]
    public extern void ClearPackageStatus(string packageFullName, PackageStatus status);

    [Overload("RegisterPackageWithAppDataVolumeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume);

    /// <summary>Gets the specified volume.</summary>
    /// <param name="volumeName">The volume media ID, which is a GUID value.</param>
    /// <returns>The requested volume.</returns>
    [Overload("FindPackageVolumeByName")]
    [MethodImpl]
    public extern PackageVolume FindPackageVolume(string volumeName);

    /// <summary>Gets all the known volumes, regardless of their current state.</summary>
    /// <returns>All the known volumes, regardless of their current state.</returns>
    [MethodImpl]
    public extern IIterable<PackageVolume> FindPackageVolumes();

    /// <summary>Gets the default package volume, which is the target of deployment operations such as the AddPackageAsync method.</summary>
    /// <returns>The default package volume, which is the target of deployment operations such as the AddPackageAsync method.</returns>
    [MethodImpl]
    public extern PackageVolume GetDefaultPackageVolume();

    /// <summary>Moves the specified package to the specified volume using the specified deployment options.</summary>
    /// <param name="packageFullName">The full name of the package to move.</param>
    /// <param name="deploymentOptions">One of the enumeration values that specifies a deployment option.</param>
    /// <param name="targetVolume">The target volume.</param>
    /// <returns>An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> MovePackageToVolumeAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    /// <summary>Removes the specified volume.</summary>
    /// <param name="volume">The volume to remove.</param>
    /// <returns>An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageVolumeAsync(
      PackageVolume volume);

    /// <summary>Sets the default package volume, which is the target of deployment operations such as the AddPackageAsync method.</summary>
    /// <param name="volume">The default package volume, which is the target of deployment operations such as the AddPackageAsync method.</param>
    [MethodImpl]
    public extern void SetDefaultPackageVolume(PackageVolume volume);

    /// <summary>Sets the status of the specified package.</summary>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <param name="status">One of the enumeration values that describes the status of the package.</param>
    [MethodImpl]
    public extern void SetPackageStatus(string packageFullName, PackageStatus status);

    /// <summary>Sets the specified volume to an offline state. The caller must be a member of the administrators group.</summary>
    /// <param name="packageVolume">The volume to take offline.</param>
    /// <returns>An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOfflineAsync(
      PackageVolume packageVolume);

    /// <summary>Sets the specified volume to an online state. The caller must be a member of the administrators group.</summary>
    /// <param name="packageVolume">The volume to bring online.</param>
    /// <returns>An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOnlineAsync(
      PackageVolume packageVolume);

    [RemoteAsync]
    [Overload("StagePackageToVolumeAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    /// <summary>Stages a package's roaming data to the system without registering the package. Call this method after staging the package but before registering the package for a particular user.</summary>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <param name="deploymentOptions">A bitwise combination of enumeration values from the DeploymentOptions enumeration that specify deployment options.</param>
    /// <returns>An object that the caller can observe to track progress and completion for the call. The object implements the **IAsyncOperationWithProgress** pattern.</returns>
    [RemoteAsync]
    [Overload("StageUserDataWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions);

    /// <summary>Gets the package volumes on the device.</summary>
    /// <returns>Returns an asynchronous operation that completes with the package volumes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<PackageVolume>> GetPackageVolumesAsync();

    [Overload("AddPackageToVolumeAndOptionalPackagesAsync")]
    [DefaultOverload]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [Overload("StagePackageToVolumeAndOptionalPackagesAsync")]
    [RemoteAsync]
    [DefaultOverload]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [RemoteAsync]
    [Overload("RegisterPackageByFamilyNameAndOptionalPackagesAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFamilyNameAsync(
      string mainPackageFamilyName,
      IIterable<string> dependencyPackageFamilyNames,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume,
      IIterable<string> optionalPackageFamilyNames);

    /// <summary>Get the debugging settings for package deployment.</summary>
    /// <returns>The debugging settings for package deployment.</returns>
    public extern PackageManagerDebugSettings DebugSettings { [MethodImpl] get; }

    /// <summary>Enables an app package to be installed for all users on a device.</summary>
    /// <param name="packageFamilyName">The FamilyName of the app package to be installed.</param>
    /// <returns>The progress and the result of the app package deployment.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> ProvisionPackageForAllUsersAsync(
      string packageFamilyName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageByAppInstallerFileAsync(
      Uri appInstallerFileUri,
      AddPackageByAppInstallerOptions options,
      PackageVolume targetVolume);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RequestAddPackageByAppInstallerFileAsync(
      Uri appInstallerFileUri,
      AddPackageByAppInstallerOptions options,
      PackageVolume targetVolume);

    [RemoteAsync]
    [Overload("AddPackageToVolumeAndRelatedSetAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions options,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> packageUrisToInstall,
      IIterable<Uri> relatedPackageUris);

    [Overload("StagePackageToVolumeAndRelatedSetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions options,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> packageUrisToInstall,
      IIterable<Uri> relatedPackageUris);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RequestAddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> relatedPackageUris);

    [Overload("RequestAddPackageAndRelatedSetAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RequestAddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> relatedPackageUris,
      IIterable<Uri> packageUrisToInstall);

    /// <summary>Deprovisions an app package so new users on the device will no longer have the app automatically installed.</summary>
    /// <param name="packageFamilyName">The package family name of the package to be deprovisioned.</param>
    /// <returns>An async operation with the current DeploymentProgress status.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> DeprovisionPackageForAllUsersAsync(
      string packageFamilyName);

    /// <summary>Gets the list of all installed packages on the device.</summary>
    /// <returns>The list of all installed packages on the device.</returns>
    [Overload("FindProvisionedPackages")]
    [MethodImpl]
    public extern IVector<Package> FindProvisionedPackages();

    [RemoteAsync]
    [Overload("AddPackageByUriAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageByUriAsync(
      Uri packageUri,
      AddPackageOptions options);

    [RemoteAsync]
    [Overload("StagePackageByUriAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageByUriAsync(
      Uri packageUri,
      StagePackageOptions options);

    [RemoteAsync]
    [Overload("RegisterPackageByUriAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByUriAsync(
      Uri manifestUri,
      RegisterPackageOptions options);

    [Overload("RegisterPackagesByFullNameAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackagesByFullNameAsync(
      IIterable<string> packageFullNames,
      RegisterPackageOptions options);

    /// <summary>Sets a value that indicates whether the specified app package currently prefers to run as a full app or a stub app.</summary>
    /// <param name="packageFamilyName">The family name of the app package to configure.</param>
    /// <param name="useStub">A value that indicates whether the specified app package currently prefers to run as a full app or a stub app.</param>
    [Overload("SetPackageStubPreference")]
    [MethodImpl]
    public extern void SetPackageStubPreference(
      string packageFamilyName,
      PackageStubPreference useStub);

    /// <summary>Gets a value that indicates whether the specified app package currently prefers to run as a full app or a stub app.</summary>
    /// <param name="packageFamilyName">The family name of the app package to query.</param>
    /// <returns>A value that indicates whether the specified app package currently prefers to run as a full app or a stub app.</returns>
    [Overload("GetPackageStubPreference")]
    [MethodImpl]
    public extern PackageStubPreference GetPackageStubPreference(
      string packageFamilyName);

    [RemoteAsync]
    [Overload("ProvisionPackageForAllUsersWithOptionsAsync")]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> ProvisionPackageForAllUsersAsync(
      string mainPackageFamilyName,
      PackageAllUserProvisioningOptions options);
  }
}
