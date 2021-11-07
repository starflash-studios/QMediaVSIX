// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalog2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [Guid(2527464502, 36855, 17220, 182, 191, 238, 100, 194, 32, 126, 210)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (PackageCatalog))]
  internal interface IPackageCatalog2
  {
    event TypedEventHandler<PackageCatalog, PackageContentGroupStagingEventArgs> PackageContentGroupStaging;

    [RemoteAsync]
    IAsyncOperation<PackageCatalogAddOptionalPackageResult> AddOptionalPackageAsync(
      string optionalPackageFamilyName);
  }
}
