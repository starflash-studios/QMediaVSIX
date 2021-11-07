// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(2676553160, 56916, 19182, 168, 144, 146, 11, 203, 254, 48, 252)]
  [ExclusiveTo(typeof (CashDrawer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICashDrawer
  {
    string DeviceId { get; }

    CashDrawerCapabilities Capabilities { get; }

    CashDrawerStatus Status { get; }

    bool IsDrawerOpen { get; }

    CashDrawerEventSource DrawerEventSource { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedCashDrawer> ClaimDrawerAsync();

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<string> GetStatisticsAsync(IIterable<string> statisticsCategories);

    event TypedEventHandler<CashDrawer, CashDrawerStatusUpdatedEventArgs> StatusUpdated;
  }
}
