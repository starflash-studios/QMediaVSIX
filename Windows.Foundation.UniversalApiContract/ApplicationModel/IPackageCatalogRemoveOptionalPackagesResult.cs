// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalogRemoveOptionalPackagesResult
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageCatalogRemoveOptionalPackagesResult))]
  [Guid(701692283, 55668, 20068, 147, 89, 34, 202, 223, 215, 152, 40)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPackageCatalogRemoveOptionalPackagesResult
  {
    IVectorView<Package> PackagesRemoved { get; }

    HResult ExtendedError { get; }
  }
}
