// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [WebHostHidden]
  [ExclusiveTo(typeof (PackageManager))]
  [Guid(138930441, 21453, 20047, 131, 46, 87, 209, 128, 246, 228, 71)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPackageManager6
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> ProvisionPackageForAllUsersAsync(
      string packageFamilyName);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageByAppInstallerFileAsync(
      Uri appInstallerFileUri,
      AddPackageByAppInstallerOptions options,
      PackageVolume targetVolume);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RequestAddPackageByAppInstallerFileAsync(
      Uri appInstallerFileUri,
      AddPackageByAppInstallerOptions options,
      PackageVolume targetVolume);

    [Overload("AddPackageToVolumeAndRelatedSetAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions options,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> packageUrisToInstall,
      IIterable<Uri> relatedPackageUris);

    [RemoteAsync]
    [Overload("StagePackageToVolumeAndRelatedSetAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions options,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> packageUrisToInstall,
      IIterable<Uri> relatedPackageUris);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RequestAddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> relatedPackageUris);
  }
}
