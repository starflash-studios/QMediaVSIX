// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager6
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (AppInstallManager))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3387413512, 62074, 17521, 178, 244, 231, 110, 252, 190, 188, 202)]
  internal interface IAppInstallManager6
  {
    [RemoteAsync]
    [Overload("SearchForAllUpdatesWithUpdateOptionsAsync")]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync(
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    [Overload("SearchForAllUpdatesWithUpdateOptionsForUserAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesForUserAsync(
      User user,
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    [Overload("SearchForUpdatesWithUpdateOptionsAsync")]
    [RemoteAsync]
    IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId,
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    [RemoteAsync]
    [Overload("SearchForUpdatesWithUpdateOptionsForUserAsync")]
    IAsyncOperation<AppInstallItem> SearchForUpdatesForUserAsync(
      User user,
      string productId,
      string skuId,
      string correlationVector,
      string clientId,
      AppUpdateOptions updateOptions);

    [RemoteAsync]
    [Overload("StartProductInstallWithOptionsAsync")]
    IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallAsync(
      string productId,
      string flightId,
      string clientId,
      string correlationVector,
      AppInstallOptions installOptions);

    [RemoteAsync]
    [Overload("StartProductInstallWithOptionsForUserAsync")]
    IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallForUserAsync(
      User user,
      string productId,
      string flightId,
      string clientId,
      string correlationVector,
      AppInstallOptions installOptions);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsPackageIdentityAllowedToInstallAsync(
      string correlationVector,
      string packageIdentityName,
      string publisherCertificateName);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsPackageIdentityAllowedToInstallForUserAsync(
      User user,
      string correlationVector,
      string packageIdentityName,
      string publisherCertificateName);
  }
}
