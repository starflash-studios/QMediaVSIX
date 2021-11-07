// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.Provider.BarcodeSymbologyAttributesBuilder
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService.Provider
{
  /// <summary>Represents the builder of barcode symbology attributes.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Activatable(393216, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BarcodeSymbologyAttributesBuilder : IBarcodeSymbologyAttributesBuilder
  {
    /// <summary>Creates an instance for BarcodeSymbologyAttributesBuilder.</summary>
    [MethodImpl]
    public extern BarcodeSymbologyAttributesBuilder();

    /// <summary>Gets or sets whether the barcode symbology supports check digit validation.</summary>
    /// <returns>True if the barcode symbology supports check digit validation; otherwise, false.</returns>
    public extern bool IsCheckDigitValidationSupported { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the barcode symbology supports transmitting the check digit to the client as part of the raw data.</summary>
    /// <returns>True if the barcode symbology supports transmitting the check digit as raw data; otherwise, false.</returns>
    public extern bool IsCheckDigitTransmissionSupported { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the barcode symbology supports multiple decode lengths.</summary>
    /// <returns>True if the barcode symbology supports multiple decode lengths; otherwise, false.</returns>
    public extern bool IsDecodeLengthSupported { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a BarcodeSymbologyAttributes object from the properties of this class.</summary>
    /// <returns>The symbology attributes.</returns>
    [MethodImpl]
    public extern BarcodeSymbologyAttributes CreateAttributes();
  }
}
