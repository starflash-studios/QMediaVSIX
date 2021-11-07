// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeScannerProviderConnection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Represents a connection to a barcode scanner provider client.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  public sealed class BarcodeScannerProviderConnection : 
    IBarcodeScannerProviderConnection,
    IBarcodeScannerProviderConnection2,
    IClosable
  {
    /// <summary>Gets the ID of the barcode scanner provider connection.</summary>
    /// <returns>The connection ID.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Gets the video device ID that represents the camera lens associated with the barcode scanner.</summary>
    /// <returns>The video device ID.</returns>
    public extern string VideoDeviceId { [MethodImpl] get; }

    /// <summary>Gets the supported symbologies of the barcode scanner provider.</summary>
    /// <returns>The supported symbologies.</returns>
    public extern IVector<uint> SupportedSymbologies { [MethodImpl] get; }

    /// <summary>Gets or sets the company name of the barcode scanner provider.</summary>
    /// <returns>The company name.</returns>
    public extern string CompanyName { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the name of the barcode scanner provider.</summary>
    /// <returns>The provider name.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the version of the barcode scanner provider.</summary>
    /// <returns>The provider version.</returns>
    public extern string Version { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Starts the connection for data transfer.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Sends a barcode scanner data report to the client app.</summary>
    /// <param name="report">The barcode scanner data.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportScannedDataAsync(BarcodeScannerReport report);

    /// <summary>Sends a barcode scanner trigger state update to the client app during a scanning operation.</summary>
    /// <param name="state">The barcode scanner trigger state. Possible values are defined in BarcodeScannerTriggerState.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportTriggerStateAsync(BarcodeScannerTriggerState state);

    /// <summary>Sends an error report to the client app.</summary>
    /// <param name="errorData">The error information.</param>
    /// <returns>An asynchronous operation.</returns>
    [RemoteAsync]
    [Overload("ReportErrorAsync")]
    [MethodImpl]
    public extern IAsyncAction ReportErrorAsync(UnifiedPosErrorData errorData);

    /// <summary>Sends an error report to the client app.</summary>
    /// <param name="errorData">The error information.</param>
    /// <param name="isRetriable">Indicates whether the operation can be retried.</param>
    /// <param name="scanReport">The scan data that was successfully read.</param>
    /// <returns>
    /// </returns>
    [RemoteAsync]
    [Overload("ReportErrorAsyncWithScanReport")]
    [MethodImpl]
    public extern IAsyncAction ReportErrorAsync(
      UnifiedPosErrorData errorData,
      bool isRetriable,
      BarcodeScannerReport scanReport);

    /// <summary>Raised when the client app attempts to enable the barcode scanner.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerEnableScannerRequestEventArgs> EnableScannerRequested;

    /// <summary>Raised when the client app attempts to disable the barcode scanner.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerDisableScannerRequestEventArgs> DisableScannerRequested;

    /// <summary>Raised when the client app attempts to set the barcode symbologies for the device to use.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerSetActiveSymbologiesRequestEventArgs> SetActiveSymbologiesRequested;

    /// <summary>Raised when the client app attempts to signal the barcode scanner to start scanning.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerStartSoftwareTriggerRequestEventArgs> StartSoftwareTriggerRequested;

    /// <summary>Raised when the client app attempts to signal the barcode scanner to stop scanning.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerStopSoftwareTriggerRequestEventArgs> StopSoftwareTriggerRequested;

    /// <summary>Raised when the client app attempts to get the attributes of a barcode symbology.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerGetSymbologyAttributesRequestEventArgs> GetBarcodeSymbologyAttributesRequested;

    /// <summary>Raised when the client app attempts to set the attributes of a barcode symbology.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerSetSymbologyAttributesRequestEventArgs> SetBarcodeSymbologyAttributesRequested;

    /// <summary>Raised when the client app attempts to hide a video preview window.</summary>
    public extern event TypedEventHandler<BarcodeScannerProviderConnection, BarcodeScannerHideVideoPreviewRequestEventArgs> HideVideoPreviewRequested;

    /// <summary>Creates a new BarcodeScannerFrameReader instance.</summary>
    /// <returns>A new **BarcodeScannerFrameReader** instance that reads frames from this **BarcodeScannerProviderConnection**.</returns>
    [RemoteAsync]
    [Overload("CreateFrameReaderAsync")]
    [MethodImpl]
    public extern IAsyncOperation<BarcodeScannerFrameReader> CreateFrameReaderAsync();

    /// <summary>Creates a new BarcodeScannerFrameReader instance that returns frames in the preferred format when possible.</summary>
    /// <param name="preferredFormat">The preferred image format as a BitmapPixelFormat.</param>
    /// <returns>A new **BarcodeScannerFrameReader** instance that reads frames from this **BarcodeScannerProviderConnection**.</returns>
    [RemoteAsync]
    [Overload("CreateFrameReaderWithFormatAsync")]
    [MethodImpl]
    public extern IAsyncOperation<BarcodeScannerFrameReader> CreateFrameReaderAsync(
      BitmapPixelFormat preferredFormat);

    /// <summary>Creates a new BarcodeScannerFrameReader instance that returns frames in the preferred format and size when possible.</summary>
    /// <param name="preferredFormat">The preferred image format as a BitmapPixelFormat.</param>
    /// <param name="preferredSize">The preferred frame size as a BitmapSize in pixels.</param>
    /// <returns>A new **BarcodeScannerFrameReader** instance that reads frames from this **BarcodeScannerProviderConnection**.</returns>
    [Overload("CreateFrameReaderWithFormatAndSizeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<BarcodeScannerFrameReader> CreateFrameReaderAsync(
      BitmapPixelFormat preferredFormat,
      BitmapSize preferredSize);

    [MethodImpl]
    public extern void Close();
  }
}
