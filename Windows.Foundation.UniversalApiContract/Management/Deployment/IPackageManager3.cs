// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(3668810056, 14065, 16807, 145, 136, 188, 38, 62, 13, 203, 114)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PackageManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPackageManager3
  {
    [RemoteAsync]
    IAsyncOperation<PackageVolume> AddPackageVolumeAsync(
      string packageStorePath);

    [RemoteAsync]
    [Overload("AddPackageToVolumeAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    void ClearPackageStatus(string packageFullName, PackageStatus status);

    [RemoteAsync]
    [Overload("RegisterPackageWithAppDataVolumeAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageAsync(
      Uri manifestUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume);

    [Overload("FindPackageVolumeByName")]
    PackageVolume FindPackageVolume(string volumeName);

    IIterable<PackageVolume> FindPackageVolumes();

    PackageVolume GetDefaultPackageVolume();

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> MovePackageToVolumeAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RemovePackageVolumeAsync(
      PackageVolume volume);

    void SetDefaultPackageVolume(PackageVolume volume);

    void SetPackageStatus(string packageFullName, PackageStatus status);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOfflineAsync(
      PackageVolume packageVolume);

    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> SetPackageVolumeOnlineAsync(
      PackageVolume packageVolume);

    [Overload("StagePackageToVolumeAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume);

    [RemoteAsync]
    [Overload("StageUserDataWithOptionsAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StageUserDataAsync(
      string packageFullName,
      DeploymentOptions deploymentOptions);
  }
}
