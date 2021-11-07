// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.IBarcodeScannerProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  [ExclusiveTo(typeof (BarcodeScannerProviderConnection))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(3024800749, 2874, 20387, 134, 197, 73, 30, 163, 7, 128, 235)]
  internal interface IBarcodeScannerProviderConnection
  {
    string Id { get; }

    string VideoDeviceId { get; }

    IVector<uint> SupportedSymbologies { get; }

    string CompanyName { get; set; }

    string Name { get; set; }

    string Version { get; set; }

    void Start();

    [RemoteAsync]
    IAsyncAction ReportScannedDataAsync(BarcodeScannerReport report);

    [RemoteAsync]
    IAsyncAction ReportTriggerStateAsync(BarcodeScannerTriggerState state);

    [Overload("ReportErrorAsync")]
    [RemoteAsync]
    IAsyncAction ReportErrorAsync(UnifiedPosErrorData errorData);

    [Overload("ReportErrorAsyncWithScanReport")]
    [RemoteAsync]
    IAsyncAction ReportErrorAsync(
      UnifiedPosErrorData errorData,
      bool isRetriable,
      BarcodeScannerReport scanReport);

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerEnableScannerRequestEventArgs> EnableScannerRequested;

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerDisableScannerRequestEventArgs> DisableScannerRequested;

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerSetActiveSymbologiesRequestEventArgs> SetActiveSymbologiesRequested;

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerStartSoftwareTriggerRequestEventArgs> StartSoftwareTriggerRequested;

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerStopSoftwareTriggerRequestEventArgs> StopSoftwareTriggerRequested;

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerGetSymbologyAttributesRequestEventArgs> GetBarcodeSymbologyAttributesRequested;

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerSetSymbologyAttributesRequestEventArgs> SetBarcodeSymbologyAttributesRequested;

    event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerHideVideoPreviewRequestEventArgs> HideVideoPreviewRequested;
  }
}
