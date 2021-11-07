// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScanner
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the barcode scanner device.</summary>
  [Static(typeof (IBarcodeScannerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBarcodeScannerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class BarcodeScanner : IBarcodeScanner, IBarcodeScanner2, IClosable
  {
    /// <summary>Gets the DeviceInformation.Id of the barcode scanner.</summary>
    /// <returns>The DeviceInformation.Id of the barcode scanner.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the specified barcode scanner.</summary>
    /// <returns>The capabilities of the barcode scanner.</returns>
    public extern BarcodeScannerCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Attempts to get an exclusive access to the barcode scanner.</summary>
    /// <returns>When the method completes, it returns a ClaimedBarcodeScanner.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedBarcodeScanner> ClaimScannerAsync();

    /// <summary>Tests the state of the barcode scanner.</summary>
    /// <param name="level">The specified health check level.</param>
    /// <returns>A text description of the test result. Returns an error if the specified check level is not supported by the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    /// <summary>Gets the symbologies supported by the claimed barcode scanner.</summary>
    /// <returns>When the method completes successfully, it returns a list of values that represent the symbologies supported by the device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<uint>> GetSupportedSymbologiesAsync();

    /// <summary>Determines whether the specified symbology is supported by the barcode scanner.</summary>
    /// <param name="barcodeSymbology">The specific barcode symbology.</param>
    /// <returns>True if the device supports the specified symbology; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> IsSymbologySupportedAsync(
      uint barcodeSymbology);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    /// <summary>Gets the list of profiles supported by the barcode scanner.</summary>
    /// <returns>As array of strings representing the supported profiles. Returns an empty list if the scanner does not support profiles.</returns>
    [MethodImpl]
    public extern IVectorView<string> GetSupportedProfiles();

    /// <summary>Determines whether the profile is supported.</summary>
    /// <param name="profile">Barcode scanner profile.</param>
    /// <returns>True if the barcode scanner supports the profile; otherwise false.</returns>
    [MethodImpl]
    public extern bool IsProfileSupported(string profile);

    /// <summary>Occurs when the barcode scanner detects an operation status change.</summary>
    public extern event TypedEventHandler<BarcodeScanner, BarcodeScannerStatusUpdatedEventArgs> StatusUpdated;

    /// <summary>Retrieves the video device ID which represents the camera lens associated with the claimed barcode scanner. (Not supported on mobile platforms)</summary>
    /// <returns>The video device ID.</returns>
    public extern string VideoDeviceId { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the barcode scanners available over the specified connection types</summary>
    /// <param name="connectionTypes">A list of the connection types to test for available barcode scanners.</param>
    /// <returns>An Advanced Query Syntax (AQS) string that is used to enumerate the barcode scanners available over the specified connection types</returns>
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    /// <summary>Returns the first available barcode scanner.</summary>
    /// <returns>The first available barcode scanner. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BarcodeScanner> GetDefaultAsync();

    /// <summary>Creates BarcodeScanner object from the DeviceInformation.Id.</summary>
    /// <param name="deviceId">The DeviceInformation.Id that identifies a specific barcode scanner, which can be retrieved from the DeviceId property.</param>
    /// <returns>The barcode scanner specified by the unique device identifier. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BarcodeScanner> FromIdAsync(
      string deviceId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the available barcode scanners.</summary>
    /// <returns>An Advanced Query Syntax (AQS) string that is used to enumerate available barcode scanners.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
