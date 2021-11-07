// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedPosPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1835322892, 57406, 19220, 163, 142, 194, 140, 52, 184, 99, 83)]
  [ExclusiveTo(typeof (ClaimedPosPrinter))]
  internal interface IClaimedPosPrinter
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    uint CharacterSet { set; get; }

    bool IsCoverOpen { get; }

    bool IsCharacterSetMappingEnabled { set; get; }

    PosPrinterMapMode MapMode { set; get; }

    ClaimedReceiptPrinter Receipt { get; }

    ClaimedSlipPrinter Slip { get; }

    ClaimedJournalPrinter Journal { get; }

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

    event TypedEventHandler<ClaimedPosPrinter, PosPrinterReleaseDeviceRequestedEventArgs> ReleaseDeviceRequested;
  }
}
