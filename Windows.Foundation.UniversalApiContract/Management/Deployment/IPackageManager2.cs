// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [ExclusiveTo(typeof (PackageManager))]
  [Guid(4155166861, 2112, 18162, 181, 216, 202, 212, 118, 147, 160, 149)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageManager2
  {
    [Overload("RemovePackageWithOptionsAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageAsync(
      string packageFullName,
      RemovalOptions removalOptions);

    [RemoteAsync]
    [Overload("StagePackageWithOptionsAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFullNameAsync(
      string mainPackageFullName,
      IIterable<string> dependencyPackageFullNames,
      DeploymentOptions deploymentOptions);

    [Overload("FindPackagesWithPackageTypes")]
    IIterable<Package> FindPackagesWithPackageTypes(PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdWithPackageTypes")]
    IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      PackageTypes packageTypes);

    [Overload("FindPackagesByNamePublisherWithPackageTypes")]
    IIterable<Package> FindPackagesWithPackageTypes(
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdNamePublisherWithPackageTypes")]
    IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageName,
      string packagePublisher,
      PackageTypes packageTypes);

    [Overload("FindPackagesByPackageFamilyNameWithPackageTypes")]
    IIterable<Package> FindPackagesWithPackageTypes(
      string packageFamilyName,
      PackageTypes packageTypes);

    [Overload("FindPackagesByUserSecurityIdPackageFamilyNameWithPackageTypes")]
    IIterable<Package> FindPackagesForUserWithPackageTypes(
      string userSecurityId,
      string packageFamilyName,
      PackageTypes packageTypes);

    [RemoteAsync]
    [Overload("StageUserDataAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName);
  }
}
