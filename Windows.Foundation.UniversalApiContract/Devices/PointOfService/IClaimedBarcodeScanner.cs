// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedBarcodeScanner
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ClaimedBarcodeScanner))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1248048284, 36772, 17202, 187, 38, 148, 93, 17, 216, 30, 15)]
  internal interface IClaimedBarcodeScanner
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    bool IsDisabledOnDataReceived { set; get; }

    bool IsDecodeDataEnabled { set; get; }

    [RemoteAsync]
    IAsyncAction EnableAsync();

    [RemoteAsync]
    IAsyncAction DisableAsync();

    void RetainDevice();

    [RemoteAsync]
    IAsyncAction SetActiveSymbologiesAsync(IIterable<uint> symbologies);

    [RemoteAsync]
    IAsyncAction ResetStatisticsAsync(IIterable<string> statisticsCategories);

    [RemoteAsync]
    IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    [RemoteAsync]
    IAsyncAction SetActiveProfileAsync(string profile);

    event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerDataReceivedEventArgs> DataReceived;

    event EventHandler<ClaimedBarcodeScanner> TriggerPressed;

    event EventHandler<ClaimedBarcodeScanner> TriggerReleased;

    event EventHandler<ClaimedBarcodeScanner> ReleaseDeviceRequested;

    event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerImagePreviewReceivedEventArgs> ImagePreviewReceived;

    event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerErrorOccurredEventArgs> ErrorOccurred;
  }
}
