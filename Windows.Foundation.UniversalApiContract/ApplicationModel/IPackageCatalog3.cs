// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.IPackageCatalog3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel
{
  [ExclusiveTo(typeof (PackageCatalog))]
  [Guid(2531089544, 34871, 17401, 144, 21, 3, 52, 52, 186, 20, 243)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IPackageCatalog3
  {
    [RemoteAsync]
    IAsyncOperation<PackageCatalogRemoveOptionalPackagesResult> RemoveOptionalPackagesAsync(
      IIterable<string> optionalPackageFamilyNames);
  }
}
