// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(638200342, 23198, 20157, 185, 68, 242, 186, 117, 195, 17, 89)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AppInstallManager))]
  internal interface IAppInstallManager4
  {
    [RemoteAsync]
    IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<GetEntitlementResult> GetFreeUserEntitlementForUserAsync(
      User user,
      string storeId,
      string campaignId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<GetEntitlementResult> GetFreeDeviceEntitlementAsync(
      string storeId,
      string campaignId,
      string correlationVector);
  }
}
