// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedCashDrawer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3393165743, 43960, 17089, 138, 132, 92, 102, 81, 47, 90, 117)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ClaimedCashDrawer))]
  internal interface IClaimedCashDrawer
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    bool IsDrawerOpen { get; }

    CashDrawerCloseAlarm CloseAlarm { get; }

    [RemoteAsync]
    IAsyncOperation<bool> OpenDrawerAsync();

    [RemoteAsync]
    IAsyncOperation<bool> EnableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> DisableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> RetainDeviceAsync();

    [RemoteAsync]
    IAsyncOperation<bool> ResetStatisticsAsync(IIterable<string> statisticsCategories);

    [RemoteAsync]
    IAsyncOperation<bool> UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    event TypedEventHandler<ClaimedCashDrawer, object> ReleaseDeviceRequested;
  }
}
