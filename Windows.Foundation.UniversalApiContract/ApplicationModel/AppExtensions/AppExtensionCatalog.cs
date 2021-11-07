// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppExtensions.AppExtensionCatalog
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppExtensions
{
  /// <summary>Provides information about available extensions within an extension group.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IAppExtensionCatalogStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class AppExtensionCatalog : IAppExtensionCatalog
  {
    /// <summary>Provides the list of extensions in the catalog.</summary>
    /// <returns>The list of extensions in the catalog. Note that this method returns a list of AppExtensions, not Packages. You can get the **Package** for each **AppExtension** with AppExtension.Package.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppExtension>> FindAllAsync();

    /// <summary>Attempts to remove the specified extension package from the machine.</summary>
    /// <param name="packageFullName">The name of the package to remove, which you can get from AppExtension.Package.Id.FullName.</param>
    /// <returns>Returns **true** if the request to the user to remove the package was made; otherwise, **false**.  </returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RequestRemovePackageAsync(
      string packageFullName);

    /// <summary>Event that is fired when an extension package is installed.</summary>
    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageInstalledEventArgs> PackageInstalled;

    /// <summary>Event that is fired when an extension package is being updated.</summary>
    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatingEventArgs> PackageUpdating;

    /// <summary>Event that is fired when an extension package in the catalog is updated.</summary>
    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUpdatedEventArgs> PackageUpdated;

    /// <summary>Event that is fired when an extension package is being uninstalled.</summary>
    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageUninstallingEventArgs> PackageUninstalling;

    /// <summary>Event that is fired when an extension package in the catalog removed, updated, or installed.</summary>
    public extern event TypedEventHandler<AppExtensionCatalog, AppExtensionPackageStatusChangedEventArgs> PackageStatusChanged;

    /// <summary>Opens a catalog of extensions.</summary>
    /// <param name="appExtensionName">The extension namespace name.</param>
    /// <returns>A catalog containing the extensions declared with the specified extension namespace name.</returns>
    [MethodImpl]
    public static extern AppExtensionCatalog Open(string appExtensionName);
  }
}
