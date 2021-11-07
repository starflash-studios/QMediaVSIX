// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalog4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageCatalog))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3279698331, 17612, 19323, 139, 175, 121, 108, 4, 234, 211, 185)]
  internal interface IPackageCatalog4
  {
    [RemoteAsync]
    IAsyncOperationWithProgress<PackageCatalogAddResourcePackageResult, PackageInstallProgress> AddResourcePackageAsync(
      string resourcePackageFamilyName,
      string resourceID,
      AddResourcePackageOptions options);

    [RemoteAsync]
    IAsyncOperation<PackageCatalogRemoveResourcePackagesResult> RemoveResourcePackagesAsync(
      IIterable<Package> resourcePackages);
  }
}
