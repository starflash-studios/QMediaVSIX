// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.SlipPrinterCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the capabilities of slip station of a point-of-service printer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SlipPrinterCapabilities : 
    ISlipPrinterCapabilities,
    ISlipPrinterCapabilities2,
    ICommonReceiptSlipCapabilities,
    ICommonPosPrintStationCapabilities
  {
    /// <summary>Gets whether the slip printer station can print full-length forms.</summary>
    /// <returns>True if the slip printer station can print full-length forms. False if the slip printer station is a validation-type station. Validation-type stations usually limit the number of print lines and turn off access to the receipt and journal stations while the validation slip is used.</returns>
    public extern bool IsFullLengthSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station supports printing on both sides of the document.</summary>
    /// <returns>True if the slip printer station supports printing on both sides of the document; otherwise, false.</returns>
    public extern bool IsBothSidesPrintingSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print characters in reverse-video style.</summary>
    /// <returns>True if the slip printer station can print characters in reverse-video style; otherwise false.</returns>
    public extern bool IsReverseVideoSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print characters in strikethrough style.</summary>
    /// <returns>True if the slip printer station can print characters in strikethrough style; otherwise false.</returns>
    public extern bool IsStrikethroughSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print characters in superscript style.</summary>
    /// <returns>True if the slip printer station can print characters in superscript style; otherwise false.</returns>
    public extern bool IsSuperscriptSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print characters in subscript style.</summary>
    /// <returns>True if the slip printer station can print characters in subscript style; otherwise false.</returns>
    public extern bool IsSubscriptSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can reverse paper feed by line.</summary>
    /// <returns>True if the slip printer station can reverse paper feed by line; otherwise false.</returns>
    public extern bool IsReversePaperFeedByLineSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can reverse paper feed by map mode unit.</summary>
    /// <returns>True if the slip printer station can reverse paper feed by map mode unit; otherwise false.</returns>
    public extern bool IsReversePaperFeedByMapModeUnitSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print barcodes.</summary>
    /// <returns>True if the slip printer station can print barcodes; otherwise false.</returns>
    public extern bool IsBarcodeSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print bitmaps.</summary>
    /// <returns>True if the slip printer station can print bitmaps; otherwise false.</returns>
    public extern bool IsBitmapSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print information rotated 90 degrees to the left.</summary>
    /// <returns>True if the slip printer station can print information rotated 90 degrees to the left; otherwise false.</returns>
    public extern bool IsLeft90RotationSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print information rotated 90 degrees to the right.</summary>
    /// <returns>True if the slip printer station can print information rotated 90 degrees to the right; otherwise false.</returns>
    public extern bool IsRight90RotationSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print in a rotated upside-down mode.</summary>
    /// <returns>True if the slip printer station can print in a rotated upside-down mode; otherwise false.</returns>
    public extern bool Is180RotationSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station supports setting a custom size for the area of the page on which the printer station should print.</summary>
    /// <returns>True if the slip printer station supports setting a custom size for the area of the page on which the printer station should print; otherwise false.</returns>
    public extern bool IsPrintAreaSupported { [MethodImpl] get; }

    /// <summary>Gets information about the capabilities of the slip printer station to draw ruled lines.</summary>
    /// <returns>Information about the capabilities of the slip printer station to draw ruled lines.</returns>
    public extern PosPrinterRuledLineCapabilities RuledLineCapabilities { [MethodImpl] get; }

    /// <summary>Gets a list of the directions in which the slip printer station can rotate a barcode when printing.</summary>
    /// <returns>A list of the directions in which the slip printer station can rotate a barcode when printing.</returns>
    public extern IVectorView<PosPrinterRotation> SupportedBarcodeRotations { [MethodImpl] get; }

    /// <summary>Gets a list of the directions in which the slip printer station can rotate a bitmap when printing.</summary>
    /// <returns>A list of the directions in which the slip printer station can rotate a bitmap when printing.</returns>
    public extern IVectorView<PosPrinterRotation> SupportedBitmapRotations { [MethodImpl] get; }

    /// <summary>Gets whether a point-of-service printer with a station that prints forms such as checks or credit card slips is present.</summary>
    /// <returns>True if a point-of-service printer with a station that prints forms such as checks or credit card slips is present; otherwise false.</returns>
    public extern bool IsPrinterPresent { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print a dark color plus an alternate color.</summary>
    /// <returns>True if the slip printer station can print a dark color plus an alternate color; otherwise false.</returns>
    public extern bool IsDualColorSupported { [MethodImpl] get; }

    /// <summary>Gets the color cartridges that the slip printer station can use to print in color.</summary>
    /// <returns>A combination of enumeration values that indicates which color cartridges the slip printer station can use to print in color.</returns>
    public extern PosPrinterColorCapabilities ColorCartridgeCapabilities { [MethodImpl] get; }

    /// <summary>Gets information about the sensors that the slip printer station has available to report the status of the printer station.</summary>
    /// <returns>A combination of enumeration values that indicate the sensors that the slip printer station has available to report the status of the printer station.</returns>
    public extern PosPrinterCartridgeSensors CartridgeSensors { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print bold characters.</summary>
    /// <returns>True if the slip printer station can print bold characters; otherwise false.</returns>
    public extern bool IsBoldSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print italic characters.</summary>
    /// <returns>True if the slip printer station can print italic characters; otherwise false.</returns>
    public extern bool IsItalicSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can underline characters.</summary>
    /// <returns>True if the slip printer station can underline characters; otherwise false.</returns>
    public extern bool IsUnderlineSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print double-high characters.</summary>
    /// <returns>True if the slip printer station can print double-high characters; otherwise false.</returns>
    public extern bool IsDoubleHighPrintSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print double-wide characters.</summary>
    /// <returns>True if the slip printer station can print double-wide characters; otherwise false.</returns>
    public extern bool IsDoubleWidePrintSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station can print characters that are both double-high and double-wide.</summary>
    /// <returns>True if the slip printer station can print characters that are both double-high and double-wide; otherwise false.</returns>
    public extern bool IsDoubleHighDoubleWidePrintSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station has an out-of-paper sensor.</summary>
    /// <returns>True if the slip printer station has an out-of-paper sensor; otherwise false.</returns>
    public extern bool IsPaperEmptySensorSupported { [MethodImpl] get; }

    /// <summary>Gets whether the slip printer station has a low-paper sensor.</summary>
    /// <returns>True if the slip printer station has a low-paper sensor; otherwise false.</returns>
    public extern bool IsPaperNearEndSensorSupported { [MethodImpl] get; }

    /// <summary>Gets a collection of the line widths in characters per line that the slip printer station supports.</summary>
    /// <returns>A collection of the line widths in characters per line that the slip printer station supports.</returns>
    public extern IVectorView<uint> SupportedCharactersPerLine { [MethodImpl] get; }
  }
}
