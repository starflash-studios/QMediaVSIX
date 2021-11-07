// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceCatalogStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppServiceCatalog))]
  [Guid(4010616071, 53554, 19589, 131, 149, 60, 49, 213, 161, 233, 65)]
  internal interface IAppServiceCatalogStatics
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInfo>> FindAppServiceProvidersAsync(
      string appServiceName);
  }
}
