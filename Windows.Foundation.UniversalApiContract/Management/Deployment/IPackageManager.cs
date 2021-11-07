// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [WebHostHidden]
  [Guid(2591902565, 24207, 20423, 162, 229, 127, 105, 37, 203, 139, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PackageManager))]
  internal interface IPackageManager
  {
    [Overload("AddPackageAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> UpdatePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync(
      string packageFullName);

    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris);

    [Overload("RegisterPackageAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [Overload("FindPackages")]
    IIterable<Package> FindPackages();

    [Overload("FindPackagesByUserSecurityId")]
    IIterable<Package> FindPackagesForUser(string userSecurityId);

    [Overload("FindPackagesByNamePublisher")]
    IIterable<Package> FindPackages(string packageName, string packagePublisher);

    [Overload("FindPackagesByUserSecurityIdNamePublisher")]
    IIterable<Package> FindPackagesForUser(
      string userSecurityId,
      string packageName,
      string packagePublisher);

    IIterable<PackageUserInformation> FindUsers(
      string packageFullName);

    void SetPackageState(string packageFullName, PackageState packageState);

    [Overload("FindPackageByPackageFullName")]
    Package FindPackage(string packageFullName);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> CleanupPackageForUserAsync(
      string packageName,
      string userSecurityId);

    [Overload("FindPackagesByPackageFamilyName")]
    IIterable<Package> FindPackages(string packageFamilyName);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyName")]
    IIterable<Package> FindPackagesForUser(
      string userSecurityId,
      string packageFamilyName);

    [Overload("FindPackageByUserSecurityIdPackageFullName")]
    Package FindPackageForUser(string userSecurityId, string packageFullName);
  }
}
