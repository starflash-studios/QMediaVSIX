// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.BarcodeSymbologyAttributes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>The attributes of a barcode scanner symbology.</summary>
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeSymbologyAttributes : IBarcodeSymbologyAttributes
  {
    /// <summary>Gets whether barcode check digit will be validated.</summary>
    /// <returns>True if the barcode check digit will be validated; otherwise, false.</returns>
    public extern bool IsCheckDigitValidationEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets whether the barcode symbology supports check digit validation.</summary>
    /// <returns>True if the barcode symbology supports check digit validation; otherwise, false.</returns>
    public extern bool IsCheckDigitValidationSupported { [MethodImpl] get; }

    /// <summary>Gets or sets whether the check digit will be transmitted to the host as part of the raw data.</summary>
    /// <returns>True if the check digit will be tranmissted to the host as raw data; otherwise, false.</returns>
    public extern bool IsCheckDigitTransmissionEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets whether the barcode symbology supports transmitting the check digit to the host as part of the raw data.</summary>
    /// <returns>True if the barcode symbology supports transmitting the check digit as raw data; otherwise, false.</returns>
    public extern bool IsCheckDigitTransmissionSupported { [MethodImpl] get; }

    /// <summary>Gets or sets the first value used to determine the barcode symbology decode length.</summary>
    /// <returns>The first part of the decode length.</returns>
    public extern uint DecodeLength1 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the second value used to determine the barcode symbology decode length.</summary>
    /// <returns>The second part of the decode length.</returns>
    public extern uint DecodeLength2 { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the decode length kind used by the barcode symbology.</summary>
    /// <returns>The decode length kind used by the barcode symbology.</returns>
    public extern BarcodeSymbologyDecodeLengthKind DecodeLengthKind { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets whether the barcode symbology supports multiple decode lengths.</summary>
    /// <returns>True if the barcode symbology supports multiple decode lengths; otherwise, false.</returns>
    public extern bool IsDecodeLengthSupported { [MethodImpl] get; }
  }
}
