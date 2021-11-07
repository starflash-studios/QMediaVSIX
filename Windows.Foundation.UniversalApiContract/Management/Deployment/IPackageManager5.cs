// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [WebHostHidden]
  [Guid(1897869591, 6909, 17171, 151, 140, 155, 182, 225, 184, 100, 167)]
  [ExclusiveTo(typeof (PackageManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IPackageManager5
  {
    [RemoteAsync]
    [Overload("AddPackageToVolumeAndOptionalPackagesAsync")]
    [DefaultOverload]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [Overload("StagePackageToVolumeAndOptionalPackagesAsync")]
    [DefaultOverload]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageAsync(
      Uri packageUri,
      IIterable<Uri> dependencyPackageUris,
      DeploymentOptions deploymentOptions,
      PackageVolume targetVolume,
      IIterable<string> optionalPackageFamilyNames,
      IIterable<Uri> externalPackageUris);

    [RemoteAsync]
    [Overload("RegisterPackageByFamilyNameAndOptionalPackagesAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByFamilyNameAsync(
      string mainPackageFamilyName,
      IIterable<string> dependencyPackageFamilyNames,
      DeploymentOptions deploymentOptions,
      PackageVolume appDataVolume,
      IIterable<string> optionalPackageFamilyNames);

    PackageManagerDebugSettings DebugSettings { get; }
  }
}
