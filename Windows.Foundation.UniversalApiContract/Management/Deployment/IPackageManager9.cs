// Decompiled with JetBrains decompiler
// Type: Windows.Management.Deployment.IPackageManager9
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management.Deployment
{
  [Guid(447189045, 52337, 19246, 128, 166, 199, 4, 29, 133, 121, 167)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [ExclusiveTo(typeof (PackageManager))]
  internal interface IPackageManager9
  {
    [Overload("FindProvisionedPackages")]
    IVector<Package> FindProvisionedPackages();

    [RemoteAsync]
    [Overload("AddPackageByUriAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> AddPackageByUriAsync(
      Uri packageUri,
      AddPackageOptions options);

    [Overload("StagePackageByUriAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> StagePackageByUriAsync(
      Uri packageUri,
      StagePackageOptions options);

    [RemoteAsync]
    [Overload("RegisterPackageByUriAsync")]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackageByUriAsync(
      Uri manifestUri,
      RegisterPackageOptions options);

    [Overload("RegisterPackagesByFullNameAsync")]
    [RemoteAsync]
    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> RegisterPackagesByFullNameAsync(
      IIterable<string> packageFullNames,
      RegisterPackageOptions options);

    [Overload("SetPackageStubPreference")]
    void SetPackageStubPreference(string packageFamilyName, PackageStubPreference useStub);

    [Overload("GetPackageStubPreference")]
    PackageStubPreference GetPackageStubPreference(string packageFamilyName);
  }
}
