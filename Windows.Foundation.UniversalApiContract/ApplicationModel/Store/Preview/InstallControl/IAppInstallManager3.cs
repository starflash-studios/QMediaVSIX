// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Management.Deployment;
using Windows.System;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (AppInstallManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2511489815, 59754, 19726, 132, 225, 200, 203, 65, 122, 1, 120)]
  internal interface IAppInstallManager3
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallAsync(
      string productId,
      string catalogId,
      string flightId,
      string clientId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string correlationVector,
      PackageVolume targetVolume);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> StartProductInstallForUserAsync(
      User user,
      string productId,
      string catalogId,
      string flightId,
      string clientId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string correlationVector,
      PackageVolume targetVolume);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameForUserAsync(
      User user,
      string packageFamilyName,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> SearchForUpdatesForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesForUserAsync(
      User user,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsAppAllowedToInstallForUserAsync(
      User user,
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsApplicableForUserAsync(
      User user,
      string productId,
      string skuId);

    void MoveToFrontOfDownloadQueue(string productId, string correlationVector);
  }
}
