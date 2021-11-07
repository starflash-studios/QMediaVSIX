// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Package
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel
{
  /// <summary>Provides information about a package.</summary>
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPackageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Package : 
    IPackage,
    IPackage2,
    IPackage3,
    IPackageWithMetadata,
    IPackage4,
    IPackage5,
    IPackage6,
    IPackage7,
    IPackage8
  {
    /// <summary>Gets the package identity of the current package.</summary>
    /// <returns>The package identity.</returns>
    public extern PackageId Id { [MethodImpl] get; }

    /// <summary>Gets the current package's path in the original install folder for the current package.</summary>
    /// <returns>The current package's path in the original install folder for the current package.</returns>
    public extern StorageFolder InstalledLocation { [MethodImpl] get; }

    /// <summary>Indicates whether other packages can declare a dependency on this package.</summary>
    /// <returns>True if other packages can declare a dependency on this package; otherwise false.</returns>
    public extern bool IsFramework { [MethodImpl] get; }

    /// <summary>Gets the packages on which the current package depends.</summary>
    /// <returns>The packages on which the current package depends.</returns>
    public extern IVectorView<Package> Dependencies { [MethodImpl] get; }

    /// <summary>Gets the display name of the package.</summary>
    /// <returns>The display name.</returns>
    public extern string DisplayName { [MethodImpl] get; }

    /// <summary>Gets the publisher display name of the package.</summary>
    /// <returns>The publisher display name.</returns>
    public extern string PublisherDisplayName { [MethodImpl] get; }

    /// <summary>Gets the description of the package.</summary>
    /// <returns>The description of the package.</returns>
    public extern string Description { [MethodImpl] get; }

    /// <summary>Gets the logo of the package.</summary>
    /// <returns>The logo of the package.</returns>
    public extern Uri Logo { [MethodImpl] get; }

    /// <summary>Indicates whether the package is a resource package.</summary>
    /// <returns>A Boolean value that indicates whether the package is a resource package. **TRUE** indicates that the package is a resource package; otherwise **FALSE**.</returns>
    public extern bool IsResourcePackage { [MethodImpl] get; }

    /// <summary>Indicates whether the package is a bundle package.</summary>
    /// <returns>A Boolean value that indicates whether the package is a bundle package. **TRUE** indicates that the package is a bundle package; otherwise **FALSE**.</returns>
    public extern bool IsBundle { [MethodImpl] get; }

    /// <summary>Indicates whether the package is installed in development mode.</summary>
    /// <returns>A Boolean value that indicates whether the package is installed in development mode. **TRUE** indicates that the package is installed in development mode; otherwise **FALSE**.</returns>
    public extern bool IsDevelopmentMode { [MethodImpl] get; }

    /// <summary>Get the current status of the package for the user.</summary>
    /// <returns>The current status of the package for the user.</returns>
    public extern PackageStatus Status { [MethodImpl] get; }

    /// <summary>Gets the date on which the application package was installed or last updated.</summary>
    /// <returns>The date on which the application package was installed or last updated.</returns>
    public extern DateTime InstalledDate { [MethodImpl] get; }

    /// <summary>Enumerates the packaged apps on the device and returns the list asynchronously. Only apps included in the current package are returned.</summary>
    /// <returns>A list of AppListEntry objects that specify the packaged apps along with their display name, description, and logo.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<AppListEntry>> GetAppListEntriesAsync();

    /// <summary>Windows Phone only. Gets the date the application package was installed on the user's phone.</summary>
    /// <returns>The date the application package was installed on the user's phone.</returns>
    public extern DateTime InstallDate { [MethodImpl] get; }

    /// <summary>Windows Phone only. Returns a token that can be used to retrieve the thumbnail image associated with this application package.</summary>
    /// <returns>A token that can be used to retrieve the thumbnail image associated with this application package.</returns>
    [MethodImpl]
    public extern string GetThumbnailToken();

    /// <summary>Windows Phone only. Launches the specified application.</summary>
    /// <deprecated type="deprecate">Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync</deprecated>
    /// <param name="parameters">The navigation URI that specifies the page to launch and optional parameters. Use an empty string to specify the default page for the app.</param>
    [Deprecated("Launch may be altered or unavailable for releases after Windows 8.1. Instead, for SmartCardTrigger scenarios use SmartCardTriggerDetails.TryLaunchSelfAsync", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern void Launch(string parameters);

    /// <summary>How the app package is signed.</summary>
    /// <returns>The signature kind.</returns>
    public extern PackageSignatureKind SignatureKind { [MethodImpl] get; }

    /// <summary>Indicates whether the package is optional.</summary>
    /// <returns>Returns **true** if the package is optional; **false** otherwise.</returns>
    public extern bool IsOptional { [MethodImpl] get; }

    /// <summary>Ensures that the package has not been modified or tampered with before being loaded.</summary>
    /// <returns>**true** - the package has not been modified; **false** otherwise.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> VerifyContentIntegrityAsync();

    /// <summary>Provides information about all of the package content groups in the app and their state, name, whether they are required, and so on.</summary>
    /// <returns>A list of package content group objects.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVector<PackageContentGroup>> GetContentGroupsAsync();

    /// <summary>Provides information about the package content group such as its state, name, whether it is required, and so on.</summary>
    /// <param name="name">The name of the content group to get.</param>
    /// <returns>A PackageContentGroup that contains information such as whether the content group is required, its state, the package associated with the content group, and so on.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageContentGroup> GetContentGroupAsync(
      string name);

    [RemoteAsync]
    [Overload("StageContentGroupsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names);

    [RemoteAsync]
    [Overload("StageContentGroupsWithPriorityAsync")]
    [MethodImpl]
    public extern IAsyncOperation<IVector<PackageContentGroup>> StageContentGroupsAsync(
      IIterable<string> names,
      bool moveToHeadOfQueue);

    /// <summary>Sets whether the package is in use or not.</summary>
    /// <param name="inUse">**True** to specify that the package is in use; **false** otherwise.</param>
    /// <returns>**True** indicates that the operation to set whether the package is in use or not was successful; **false** otherwise.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SetInUseAsync(bool inUse);

    /// <summary>Returns the .appinstaller XML file location. Use this method when you need to retrieve the .appinstaller XML file location for your app. For example, this is useful if your app needs to share a URI to its associated .appinstaller file. You can optionally add arguments to the URI.</summary>
    /// <returns>The .appinstaller XML file location.</returns>
    [MethodImpl]
    public extern AppInstallerInfo GetAppInstallerInfo();

    /// <summary>The **CheckUpdateAvailabilityAsync** method allows developers to check for updates to the main app package listed in the .appinstaller file. It allows the developer to determine if the updates are required due to .appinstaller policy. This method currently only works for applications installed via .appinstaller files.</summary>
    /// <returns>A PackageUpdateAvailabilityResult that indicates if an application has an update, and if the update is required.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PackageUpdateAvailabilityResult> CheckUpdateAvailabilityAsync();

    /// <summary>Gets the current package's path in the mutable folder for the installed package, if the app is declared to be mutable in its package manifest.</summary>
    /// <returns>The location of the mutable folder for the installed package.</returns>
    public extern StorageFolder MutableLocation { [MethodImpl] get; }

    /// <summary>Gets either the location of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.</summary>
    /// <returns>The location of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.</returns>
    public extern StorageFolder EffectiveLocation { [MethodImpl] get; }

    /// <summary>Gets the location of the machine-wide or per-user external folder specified in the package manifest for the current package, depending on how the app is installed.</summary>
    /// <returns>The location of the machine-wide or per-user machine-wide external folder specified in the package manifest for the current package, depending on how the app is installed.</returns>
    public extern StorageFolder EffectiveExternalLocation { [MethodImpl] get; }

    /// <summary>Gets the location of the machine-wide external folder specified in the package manifest for the current package.</summary>
    /// <returns>The location of the machine-wide external folder specified in the package manifest for the current package.</returns>
    public extern StorageFolder MachineExternalLocation { [MethodImpl] get; }

    /// <summary>Gets the location of the per-user external folder specified in the package manifest for the current package.</summary>
    /// <returns>The location of the per-user external folder specified in the package manifest for the current package.</returns>
    public extern StorageFolder UserExternalLocation { [MethodImpl] get; }

    /// <summary>Gets the current package's path in the original install folder for the current package.</summary>
    /// <returns>The current package's path in the original install folder for the current package.</returns>
    public extern string InstalledPath { [MethodImpl] get; }

    /// <summary>Gets the current package's path in the mutable folder for the installed package, if the app is declared to be mutable in its package manifest.</summary>
    /// <returns>The location of the mutable folder for the installed package.</returns>
    public extern string MutablePath { [MethodImpl] get; }

    /// <summary>Gets either the path of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.</summary>
    /// <returns>The path of the installed folder or the mutable folder for the installed package, depending on whether the app is declared to be mutable in its package manifest.</returns>
    public extern string EffectivePath { [MethodImpl] get; }

    /// <summary>Gets the location of the machine-wide or per-user external folder specified in the package manifest for the current package, depending on how the app is installed.</summary>
    /// <returns>The location of the machine-wide or per-user machine-wide external folder specified in the package manifest for the current package, depending on how the app is installed.</returns>
    public extern string EffectiveExternalPath { [MethodImpl] get; }

    /// <summary>Gets the location of the machine-wide external folder specified in the package manifest for the current package.</summary>
    /// <returns>The location of the machine-wide external folder specified in the package manifest for the current package.</returns>
    public extern string MachineExternalPath { [MethodImpl] get; }

    /// <summary>Gets the path of the per-user external folder specified in the package manifest for the current package.</summary>
    /// <returns>The path of the per-user external folder specified in the package manifest for the current package.</returns>
    public extern string UserExternalPath { [MethodImpl] get; }

    /// <summary>Gets the application logo of the package as a random access stream.</summary>
    /// <param name="size">The size of the application logo to get.</param>
    /// <returns>A random access stream that contains the logo.</returns>
    [MethodImpl]
    public extern RandomAccessStreamReference GetLogoAsRandomAccessStreamReference(
      Size size);

    /// <summary>Enumerates the packaged apps on the device and returns the list synchronously. Only apps included in the current package are returned.</summary>
    /// <returns>A list of AppListEntry objects that specify the packaged apps along with their display name, description, and logo.</returns>
    [MethodImpl]
    public extern IVectorView<AppListEntry> GetAppListEntries();

    /// <summary>Gets a value that indicates whether the application in the current package is a stub application.</summary>
    /// <returns>**TRUE** indicates that the application is a stub application; otherwise, **FALSE**.</returns>
    public extern bool IsStub { [MethodImpl] get; }

    /// <summary>Gets the package for the current app.</summary>
    /// <returns>The package.</returns>
    public static extern Package Current { [MethodImpl] get; }
  }
}
