// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedBarcodeScanner
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the claimed barcode scanner.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ClaimedBarcodeScanner : 
    IClaimedBarcodeScanner,
    IClaimedBarcodeScanner1,
    IClaimedBarcodeScanner2,
    IClaimedBarcodeScanner3,
    IClaimedBarcodeScanner4,
    IClosable
  {
    /// <summary>Gets the DeviceInformation.Id of the claimed barcode scanner.</summary>
    /// <returns>The DeviceInformation.Id of the claimed barcode scanner.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Indicates whether the barcode scanner can receive DataReceived events.</summary>
    /// <returns>True if the device can receive DataReceived events; otherwise, false.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value that indicates whether the barcode scanner is disabled after receiving the data.</summary>
    /// <returns>Set to true if the application wants to receive and process only one input or only one input at a time.</returns>
    public extern bool IsDisabledOnDataReceived { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a Boolean value that indicates whether to provide the decoded data to the service object.</summary>
    /// <returns>Set to true if decoded data is provided to the application; otherwise, false.</returns>
    public extern bool IsDecodeDataEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the barcode scanner into a ready state for DataReceived events.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction EnableAsync();

    /// <summary>Puts the barcode scanner into a state where it cannot receive DataReceived events.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DisableAsync();

    /// <summary>Retains exclusive claim to the barcode scanner.</summary>
    [MethodImpl]
    public extern void RetainDevice();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetActiveSymbologiesAsync(IIterable<uint> symbologies);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResetStatisticsAsync(
      IIterable<string> statisticsCategories);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    /// <summary>Sets the active profile on the barcode scanner.</summary>
    /// <param name="profile">The name of the profile to set on the device.</param>
    /// <returns>No object or value is returned when the method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetActiveProfileAsync(string profile);

    /// <summary>Occurs when the device scans a barcode.</summary>
    public extern event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerDataReceivedEventArgs> DataReceived;

    /// <summary>Occurs when the barcode scanner trigger or button is pressed during a scanning operation.</summary>
    public extern event EventHandler<ClaimedBarcodeScanner> TriggerPressed;

    /// <summary>Occurs when the barcode scanner trigger or button is released during a scanning operation.</summary>
    public extern event EventHandler<ClaimedBarcodeScanner> TriggerReleased;

    /// <summary>Occurs when the device gets a request to release its exclusive claim.</summary>
    public extern event EventHandler<ClaimedBarcodeScanner> ReleaseDeviceRequested;

    /// <summary>Occurs when the device receives the bitmap image of the scan.</summary>
    public extern event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerImagePreviewReceivedEventArgs> ImagePreviewReceived;

    /// <summary>Occurs when there is a problem in reading a barcode.</summary>
    public extern event TypedEventHandler<ClaimedBarcodeScanner, BarcodeScannerErrorOccurredEventArgs> ErrorOccurred;

    /// <summary>Used to signal the barcode scanner to start scanning. A session is active until StopSoftwareTriggerAsync is invoked, or until the scanner ends the session on its own.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartSoftwareTriggerAsync();

    /// <summary>Used to stop a session that was started with StartSoftwareTriggerAsync. No error is raised if this is called when no session is active.</summary>
    /// <returns>No object or value is returned when this method completes.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StopSoftwareTriggerAsync();

    /// <summary>Gets the attributes of the specified barcode symbology.</summary>
    /// <param name="barcodeSymbology">The barcode symbology.</param>
    /// <returns>A BarcodeSymbologyAttributes object, containing the attributes of the specified barcode symbology.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BarcodeSymbologyAttributes> GetSymbologyAttributesAsync(
      uint barcodeSymbology);

    /// <summary>Sets the attributes of the barcode symbology used by the claimed barcode scanner.</summary>
    /// <param name="barcodeSymbology">The barcode symbology.</param>
    /// <param name="attributes">The barcode symbology attributes.</param>
    /// <returns>True if the barcode symbology attributes were successfully set; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> SetSymbologyAttributesAsync(
      uint barcodeSymbology,
      BarcodeSymbologyAttributes attributes);

    /// <summary>Shows the video preview window.</summary>
    /// <returns>True if the video preview is shown; false if the video preview is not shown or not supported.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ShowVideoPreviewAsync();

    /// <summary>Hides the video preview window.</summary>
    [MethodImpl]
    public extern void HideVideoPreview();

    /// <summary>Gets or sets whether to show the video preview window when the barcode scanner is enabled.</summary>
    /// <returns>True if the video preview window will be shown; otherwise false.</returns>
    public extern bool IsVideoPreviewShownOnEnable { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Event that is raised when the **ClaimedBarcodeScanner** is closed.</summary>
    public extern event TypedEventHandler<ClaimedBarcodeScanner, ClaimedBarcodeScannerClosedEventArgs> Closed;

    [MethodImpl]
    public extern void Close();
  }
}
