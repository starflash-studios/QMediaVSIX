// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IBarcodeScanner
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Guid(3198369286, 45668, 20227, 169, 193, 69, 178, 15, 1, 19, 79)]
  [ExclusiveTo(typeof (BarcodeScanner))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBarcodeScanner
  {
    string DeviceId { get; }

    BarcodeScannerCapabilities Capabilities { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedBarcodeScanner> ClaimScannerAsync();

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<IVectorView<uint>> GetSupportedSymbologiesAsync();

    [RemoteAsync]
    IAsyncOperation<bool> IsSymbologySupportedAsync(uint barcodeSymbology);

    [RemoteAsync]
    IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    IVectorView<string> GetSupportedProfiles();

    bool IsProfileSupported(string profile);

    event TypedEventHandler<BarcodeScanner, BarcodeScannerStatusUpdatedEventArgs> StatusUpdated;
  }
}
