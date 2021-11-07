// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Store.Preview.InstallControl.IAppInstallManager2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Store.Preview.InstallControl
{
  [ExclusiveTo(typeof (AppInstallManager))]
  [Guid(378763345, 60727, 18445, 131, 20, 82, 226, 124, 3, 240, 74)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IAppInstallManager2
  {
    [Overload("StartAppInstallWithTelemetryAsync")]
    [RemoteAsync]
    IAsyncOperation<AppInstallItem> StartAppInstallAsync(
      string productId,
      string skuId,
      bool repair,
      bool forceUseOfNonRemovableStorage,
      string catalogId,
      string bundleId,
      string correlationVector);

    [RemoteAsync]
    [Overload("UpdateAppByPackageFamilyNameWithTelemetryAsync")]
    IAsyncOperation<AppInstallItem> UpdateAppByPackageFamilyNameAsync(
      string packageFamilyName,
      string correlationVector);

    [Overload("SearchForUpdatesWithTelemetryAsync")]
    [RemoteAsync]
    IAsyncOperation<AppInstallItem> SearchForUpdatesAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [RemoteAsync]
    [Overload("SearchForAllUpdatesWithTelemetryAsync")]
    IAsyncOperation<IVectorView<AppInstallItem>> SearchForAllUpdatesAsync(
      string correlationVector);

    [RemoteAsync]
    [Overload("GetIsAppAllowedToInstallWithTelemetryAsync")]
    IAsyncOperation<bool> GetIsAppAllowedToInstallAsync(
      string productId,
      string skuId,
      string catalogId,
      string correlationVector);

    [Overload("CancelWithTelemetry")]
    void Cancel(string productId, string correlationVector);

    [Overload("PauseWithTelemetry")]
    void Pause(string productId, string correlationVector);

    [Overload("RestartWithTelemetry")]
    void Restart(string productId, string correlationVector);
  }
}
