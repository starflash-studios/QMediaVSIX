﻿// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [Guid(2471747952, 33857, 19269, 189, 114, 124, 47, 169, 37, 190, 238)]
  [ExclusiveTo(typeof (AppInstallManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppInstallManager
  {
    IVectorView<AppInstallItem> AppInstallItems { get; }

    void Cancel(string productId);

    void Pause(string productId);

    void Restart(string productId);

    event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemCompleted;

    event TypedEventHandler<AppInstallManager, AppInstallManagerItemEventArgs> ItemStatusChanged;

    AutoUpdateSetting AutoUpdateSetting { get; set; }

    string AcquisitionIdentity { get; set; }

    [RemoteAsync]
    IAsyncOperation<bool> GetIsApplicableAsync(string productId, string skuId);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName);

    [RemoteAsync]
    IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId);

    [RemoteAsync]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync();

    [RemoteAsync]
    IAsyncOperation<bool> IsStoreBlockedByPolicyAsync(
      string storeClientName,
      string storeClientPublisher);

    [RemoteAsync]
    IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(string productId);
  }
}