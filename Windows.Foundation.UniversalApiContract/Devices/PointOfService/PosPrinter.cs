// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a point-of-service printer.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPosPrinterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPosPrinterStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class PosPrinter : IPosPrinter, IPosPrinter2, IClosable
  {
    /// <summary>Gets the identifier of the point-of-service printer.</summary>
    /// <returns>The identifier of the point-of-service printer.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the point-of-service printer.</summary>
    /// <returns>The capabilities of the point-of-service printer.</returns>
    public extern PosPrinterCapabilities Capabilities { [MethodImpl] get; }

    /// <summary>Gets the list of character sets that the point-of-service printer supports.</summary>
    /// <returns>The list of numeric values for the character sets that the point-of-service-printer supports.</returns>
    public extern IVectorView<uint> SupportedCharacterSets { [MethodImpl] get; }

    /// <summary>Gets the fonts and typefaces that the point-of-service printer supports.</summary>
    /// <returns>The fonts and typefaces that the point-of-service printer supports.</returns>
    public extern IVectorView<string> SupportedTypeFaces { [MethodImpl] get; }

    /// <summary>Gets the current status of the power and availability of the point-of-service printer.</summary>
    /// <returns>The current status of the power and availability of the point-of-service printer.</returns>
    public extern PosPrinterStatus Status { [MethodImpl] get; }

    /// <summary>Claims the point-of-service printer for use, and gets an instance of the ClaimedPosPrinter class for the point-of-service printer.</summary>
    /// <returns>The claimed point-of-service printer.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedPosPrinter> ClaimPrinterAsync();

    /// <summary>Gets the health state of the point-of-service printer asynchronously.</summary>
    /// <param name="level">The type of health check that you want to perform for the point-of-service printer. Only level POSInternal(1) should be used, as any other UnifiedPosHealthCheckLevel levels will result in an error.</param>
    /// <returns>An asynchronous operation that returns the health state of the point-of-service printer. You should display this value in the app interface immediately so the user of the app can interpret the value. For example, the operation returns “OK” as the health state if the state of the point-of-service printer is good.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetStatisticsAsync(
      IIterable<string> statisticsCategories);

    /// <summary>Occurs when the status of the power or availability of the point-of-service printer changes.</summary>
    public extern event TypedEventHandler<PosPrinter, PosPrinterStatusUpdatedEventArgs> StatusUpdated;

    /// <summary>Gets the barcode symbologies that the point-of-service printer supports.</summary>
    /// <returns>The barcode symbologies that the point-of-service printer supports.</returns>
    public extern IVectorView<uint> SupportedBarcodeSymbologies { [MethodImpl] get; }

    /// <summary>Gets the specified font property from the point-of-service printers.</summary>
    /// <param name="typeface">The typeface of the font property to retrieve.</param>
    /// <returns>The requested font property.</returns>
    [MethodImpl]
    public extern PosPrinterFontProperty GetFontProperty(string typeface);

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the point-of-service printers available over the specified connection types</summary>
    /// <param name="connectionTypes">A list of the connection types to check for available point-of-service printers.</param>
    /// <returns>An Advanced Query Syntax (AQS) string that is used to enumerate the point-of-service printers available over the specified connection types</returns>
    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    /// <summary>Gets the default paired or locally-connected printer.</summary>
    /// <returns>The default locally-connected printer.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PosPrinter> GetDefaultAsync();

    /// <summary>Creates a PosPrinter object for point-of-service printer with the specified DeviceInformation.Id.</summary>
    /// <param name="deviceId">The DeviceInformation.Id that identifies a specific point-of-service printer.</param>
    /// <returns>The point-of-service printer that the unique device identifier identifies. Returns a null object in the following cases:</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PosPrinter> FromIdAsync(
      string deviceId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string that you can use to list the available point-of-service printers.</summary>
    /// <returns>An Advanced Query Syntax (AQS) string that you can use to list the available point-of-service printers.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
