// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.LicenseManagement.ILicenseManagerStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.LicenseManagement
{
  [Guid(2871968891, 8057, 17536, 184, 126, 44, 73, 158, 96, 27, 163)]
  [ExclusiveTo(typeof (LicenseManager))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ILicenseManagerStatics2
  {
    [RemoteAsync]
    IAsyncAction RefreshLicensesAsync(LicenseRefreshOption refreshOption);
  }
}
