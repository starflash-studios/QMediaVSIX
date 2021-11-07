// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeScannerReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  /// <summary>Contains the barcode scanner data.</summary>
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IBarcodeScannerReportFactory), 393216, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeScannerReport : IBarcodeScannerReport
  {
    /// <summary>Creates an instance of BarcodeScannerReport.</summary>
    /// <param name="scanDataType">The decoded barcode label type.</param>
    /// <param name="scanData">The full raw scan data.</param>
    /// <param name="scanDataLabel">The decoded barcode label.</param>
    [MethodImpl]
    public extern BarcodeScannerReport(uint scanDataType, IBuffer scanData, IBuffer scanDataLabel);

    /// <summary>Gets the decoded barcode label type. Possible values are defined in the BarcodeSymbologies class.</summary>
    /// <returns>The specific barcode symbology.</returns>
    public extern uint ScanDataType { [MethodImpl] get; }

    /// <summary>Gets the full raw data from the DataReceived event.</summary>
    /// <returns>The raw data stream from the scanning event.</returns>
    public extern IBuffer ScanData { [MethodImpl] get; }

    /// <summary>Gets the decoded barcode label, which does not include the header, checksum, and other miscellaneous information.</summary>
    /// <returns>The data stream containing the decoded barcode label.</returns>
    public extern IBuffer ScanDataLabel { [MethodImpl] get; }
  }
}
