// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.PackageVolume
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
  /// <summary>Represents a package storage volume.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  public sealed class PackageVolume : IPackageVolume, IPackageVolume2
  {
    /// <summary>Describes whether a volume is in an offline state.</summary>
    /// <returns>true if the volume is in an offline state; otherwise, false.</returns>
    public extern bool IsOffline { [MethodImpl] get; }

    /// <summary>Describes whether a volume is an internal system volume mapped to the %SYSTEMDRIVER% environment variable.</summary>
    /// <returns>true if the volume is an internal system volume mapped to the %SYSTEMDRIVER% environment variable; otherwise, false.</returns>
    public extern bool IsSystemVolume { [MethodImpl] get; }

    /// <summary>Gets the path of the last known volume mount point.</summary>
    /// <returns>The path of the last known volume mount point.</returns>
    public extern string MountPoint { [MethodImpl] get; }

    /// <summary>Gets the media ID of the volume.</summary>
    /// <returns>The media ID of the volume.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the absolute path for the package store on the volume.</summary>
    /// <returns>The absolute path for the package store on the volume.</returns>
    public extern string PackageStorePath { [MethodImpl] get; }

    /// <summary>Gets a value that specifies whether the volume supports the creation of hard links in its file system.</summary>
    /// <returns>true if the volume supports the creation of hard links in its file system; otherwise, false.</returns>
    public extern bool SupportsHardLinks { [MethodImpl] get; }

    /// <summary>Gets a collection of info about all installed instances of all packages for all registered users.</summary>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackages")]
    [MethodImpl]
    public extern IVector<Package> FindPackages();

    /// <summary>Gets a collection of info about all installed instances of the specified package from the specified publisher for all registered users.</summary>
    /// <param name="packageName">The full name of the package.</param>
    /// <param name="packagePublisher">The publisher of the package.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByNamePublisher")]
    [MethodImpl]
    public extern IVector<Package> FindPackages(
      string packageName,
      string packagePublisher);

    /// <summary>Gets a collection of info about all installed instances of the specified package for all registered users.</summary>
    /// <param name="packageFamilyName">The package family name of the package.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByPackageFamilyName")]
    [MethodImpl]
    public extern IVector<Package> FindPackages(string packageFamilyName);

    /// <summary>Gets a collection of info about all installed instances of all packages with the specified package types for all registered users.</summary>
    /// <param name="packageTypes">A bitwise combination of the enumeration values that specifies the types of packages to return.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes);

    /// <summary>Gets a collection of info about all installed instances of the specified package from the specified publisher with the specified package types for all registered users.</summary>
    /// <param name="packageTypes">A bitwise combination of the enumeration values that specifies the types of packages to return.</param>
    /// <param name="packageName">The full name of the package.</param>
    /// <param name="packagePublisher">The publisher of the package.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByNamePublisherWithPackagesTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes,
      string packageName,
      string packagePublisher);

    /// <summary>Gets a collection of info about all installed instances of the specified package with the specified package types for all registered users.</summary>
    /// <param name="packageTypes">A bitwise combination of the enumeration values that specifies the types of packages to return.</param>
    /// <param name="packageFamilyName">The package family name.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByPackageFamilyNameWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesWithPackageTypes(
      PackageTypes packageTypes,
      string packageFamilyName);

    /// <summary>Gets a collection of info about all installed instances of the specified package for all registered users.</summary>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <returns>A collection of info about all installed instances of the specified package for all registered users.</returns>
    [Overload("FindPackageByPackageFullName")]
    [MethodImpl]
    public extern IVector<Package> FindPackage(string packageFullName);

    /// <summary>Gets a collection of info about all installed instances of all packages for the specified user or users.</summary>
    /// <param name="userSecurityId">The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByUserSecurityId")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUser(string userSecurityId);

    /// <summary>Gets a collection of info about all installed instances of the specified package from the specified publisher for the specified user or users.</summary>
    /// <param name="userSecurityId">The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.</param>
    /// <param name="packageName">The full name of the package.</param>
    /// <param name="packagePublisher">The publisher of the package.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByUserSecurityIdNamePublisher")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUser(
      string userSecurityId,
      string packageName,
      string packagePublisher);

    /// <summary>Gets a collection of info about all installed instances of the specified package for the specified user or users.</summary>
    /// <param name="userSecurityId">The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.</param>
    /// <param name="packageFamilyName">The package family name.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUser(
      string userSecurityId,
      string packageFamilyName);

    /// <summary>Gets a collection of info about all installed instances of all packages for the specified user or users and with the specified package types.</summary>
    /// <param name="userSecurityId">The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.</param>
    /// <param name="packageTypes">A bitwise combination of the enumeration values that specifies the types of packages to return.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByUserSecurityIdWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes);

    /// <summary>Gets a collection of info about all installed instances of the specified package for the specified user or users and with the specified package types.</summary>
    /// <param name="userSecurityId">The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.</param>
    /// <param name="packageTypes">A bitwise combination of the enumeration values that specifies the types of packages to return.</param>
    /// <param name="packageName">The full name of the package.</param>
    /// <param name="packagePublisher">The publisher of the package.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByUserSecurityIdNamePublisherWithPackageTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes,
      string packageName,
      string packagePublisher);

    /// <summary>Gets a collection of info about all installed instances of the specified package for the specified user or users and with the specified package types.</summary>
    /// <param name="userSecurityId">The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.</param>
    /// <param name="packageTypes">A bitwise combination of the enumeration values that specifies the types of packages to return.</param>
    /// <param name="packageFamilyName">The package family name.</param>
    /// <returns>A collection of info about the specified packages.</returns>
    [Overload("FindPackagesByUserSecurityIdPackageFamilyNameWithPackagesTypes")]
    [MethodImpl]
    public extern IVector<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes,
      string packageFamilyName);

    /// <summary>Gets a collection of info about the installed instances of the specified package for the specified user or users.</summary>
    /// <param name="userSecurityId">The security identifier (SID) of the user or users. An empty string denotes the current user. The Everyone SID (S-1-1-0) denotes all users. Any SID other than that of the current user requires administrative privileges.</param>
    /// <param name="packageFullName">The full name of the package.</param>
    /// <returns>A collection of info about all installed instances of the specified package for the specified user or users.</returns>
    [Overload("FindPackageByUserSecurityIdPackageFullName")]
    [MethodImpl]
    public extern IVector<Package> FindPackageForUser(
      string userSecurityId,
      string packageFullName);

    /// <summary>Gets a boolean that indicates if full-trust packages are supported.</summary>
    /// <returns>A boolean that indicates if full-trust packages are supported.</returns>
    public extern bool IsFullTrustPackageSupported { [MethodImpl] get; }

    /// <summary>Gets a boolean that indicates if APPX installing is supported.</summary>
    /// <returns>The boolean that indicates that APPX installing is supported.</returns>
    public extern bool IsAppxInstallSupported { [MethodImpl] get; }

    /// <summary>Gets the available space.</summary>
    /// <returns>Returns an asynchronous operation that will complete with the available space.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ulong> GetAvailableSpaceAsync();
  }
}
