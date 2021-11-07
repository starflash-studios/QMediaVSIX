// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.PackageCatalog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  /// <summary>Provides access to app packages on the device.</summary>
  [Static(typeof (IPackageCatalogStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class PackageCatalog : 
    IPackageCatalog,
    IPackageCatalog2,
    IPackageCatalog3,
    IPackageCatalog4
  {
    /// <summary>Indicates that an app package is staging.</summary>
    public extern event TypedEventHandler<PackageCatalog, PackageStagingEventArgs> PackageStaging;

    /// <summary>Indicates that an app package is installing.</summary>
    public extern event TypedEventHandler<PackageCatalog, PackageInstallingEventArgs> PackageInstalling;

    /// <summary>Indicates that an app package is being updated.</summary>
    public extern event TypedEventHandler<PackageCatalog, PackageUpdatingEventArgs> PackageUpdating;

    /// <summary>Indicates that an app package is uninstalling.</summary>
    public extern event TypedEventHandler<PackageCatalog, PackageUninstallingEventArgs> PackageUninstalling;

    /// <summary>Indicates that an app package has been removed or updated</summary>
    public extern event TypedEventHandler<PackageCatalog, PackageStatusChangedEventArgs> PackageStatusChanged;

    /// <summary>The event that is fired when a package content group starts staging.</summary>
    public extern event TypedEventHandler<PackageCatalog, PackageContentGroupStagingEventArgs> PackageContentGroupStaging;

    /// <summary>Adds an optional package to the package catalog.</summary>
    /// <param name="optionalPackageFamilyName">The package family of the optional package to add to the catalog.</param>
    /// <returns>The result of starting the asynchronous operation to add the package.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageCatalogAddOptionalPackageResult> AddOptionalPackageAsync(
      string optionalPackageFamilyName);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageCatalogRemoveOptionalPackagesResult> RemoveOptionalPackagesAsync(
      IIterable<string> optionalPackageFamilyNames);

    /// <summary>Adds a resource package to an existing app package.</summary>
    /// <param name="resourcePackageFamilyName">Package family name that uniquely identifies the app's package.</param>
    /// <param name="resourceID">The resource ID of the package.</param>
    /// <param name="options">Options to specify the behavior when adding a resource package to an app.</param>
    /// <returns>The progress report of adding a resource package.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<PackageCatalogAddResourcePackageResult, PackageInstallProgress> AddResourcePackageAsync(
      string resourcePackageFamilyName,
      string resourceID,
      AddResourcePackageOptions options);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageCatalogRemoveResourcePackagesResult> RemoveResourcePackagesAsync(
      IIterable<Package> resourcePackages);

    /// <summary>Opens the catalog of packages for the main package.</summary>
    /// <returns>The package catalog for the main package.</returns>
    [MethodImpl]
    public static extern PackageCatalog OpenForCurrentPackage();

    /// <summary>Opens the catalog of app packages on the device that are available to the current user.</summary>
    /// <returns>The catalog of packages for the current user.</returns>
    [MethodImpl]
    public static extern PackageCatalog OpenForCurrentUser();
  }
}
