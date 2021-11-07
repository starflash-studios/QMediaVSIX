// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IReceiptOrSlipJob
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents actions common to jobs for receipt and slip printer stations.</summary>
  [Guid(1394710974, 51395, 19906, 137, 233, 92, 74, 55, 179, 77, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IReceiptOrSlipJob : IPosPrinterJob
  {
    /// <summary>Sets the rotation of the barcode on the page for the receipt or slip printer station.</summary>
    /// <param name="value">The rotation of the barcode on the page.</param>
    void SetBarcodeRotation(PosPrinterRotation value);

    /// <summary>Sets the rotation of the text or image on the page for the receipt or slip printer station.</summary>
    /// <param name="value">The rotation of the text or image on the page.</param>
    /// <param name="includeBitmaps">Whether bitmaps should be rotated as well. This setting takes effect only for subsequent calls to PrintBitmap, and may not apply to saved bitmaps that you print using PrintSavedBitmap.</param>
    void SetPrintRotation(PosPrinterRotation value, bool includeBitmaps);

    /// <summary>Sets the area of the page on which the receipt or slip printer station can print the job.</summary>
    /// <param name="value">The area of the page on which the receipt or slip printer station can print the job.</param>
    void SetPrintArea(Rect value);

    /// <summary>Saves information about a bitmap and a standard horizontal placement that you want to use to print that bitmap on the receipt or slip printer station, so that you can use the PrintSavedBitmap method to add that information to the print job later.</summary>
    /// <param name="bitmapNumber">The number that you want to assign to this bitmap. You can set two bitmaps, numbered 1 and 2. Use this number with the PrintSavedBitmap method later to add the print instructions to the print job.</param>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignment">An enumeration value that specifies a standard horizontal placement on the page for the bitmap, such as left-aligned, centered, or right-aligned.</param>
    [Overload("SetBitmap")]
    void SetBitmap(uint bitmapNumber, BitmapFrame bitmap, PosPrinterAlignment alignment);

    /// <summary>Saves information about a bitmap, along with the width and a standard horizontal placement that you want to use to print that bitmap on the receipt or slip printer station, so that you can use the PrintSavedBitmap method to add that information to the print job later.</summary>
    /// <param name="bitmapNumber">The number that you want to assign to this bitmap. You can set two bitmaps, numbered 1 and 2. Use this number with the PrintSavedBitmap method later to add the print instructions to the print job.</param>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignment">An enumeration value that specifies a standard horizontal placement on the page for the bitmap, such as left-aligned, centered, or right-aligned.</param>
    /// <param name="width">The width to use for printing the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    [Overload("SetBitmapCustomWidthStandardAlign")]
    void SetBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      PosPrinterAlignment alignment,
      uint width);

    /// <summary>Saves information about a bitmap and the distance from the leftmost print column at which you want to print that bitmap on the receipt or slip printer station, so that you can use the PrintSavedBitmap method to add that information to the print job later.</summary>
    /// <param name="bitmapNumber">The number that you want to assign to this bitmap. You can set two bitmaps, numbered 1 and 2. Use this number with the PrintSavedBitmap method later to add the print instructions to the print job.</param>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignmentDistance">The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    [Overload("SetCustomAlignedBitmap")]
    void SetCustomAlignedBitmap(uint bitmapNumber, BitmapFrame bitmap, uint alignmentDistance);

    /// <summary>Saves information about a bitmap, along with the width and the distance from the leftmost print column that you want to use to print that bitmap on the receipt or slip printer station, so that you can use the PrintSavedBitmap method to add that information to the print job later.</summary>
    /// <param name="bitmapNumber">The number that you want to assign to this bitmap. You can set two bitmaps, numbered 1 and 2. Use this number with the PrintSavedBitmap method later to add the print instructions to the print job.</param>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignmentDistance">The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    /// <param name="width">The width to use for printing the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    [Overload("SetBitmapCustomWidthCustomAlign")]
    void SetCustomAlignedBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      uint alignmentDistance,
      uint width);

    /// <summary>Adds an instruction to the print job to print a bitmap on the receipt or slip printer station by using the information that you saved about the bitmap and how to print it when you called the SetBitmap or SetCustomAlignedBitmap method.</summary>
    /// <param name="bitmapNumber">The number that you assigned to the bitmap that you want to print when you called SetBitmap or SetCustomAlignedBitmap.</param>
    void PrintSavedBitmap(uint bitmapNumber);

    /// <summary>Adds an instruction to the print job to print a drawn, ruled line on the paper of the receipt or slip printer station.</summary>
    /// <param name="positionList">The position parameters for the ruled line. The character string for *positionList* differs depending on whether *lineDirection* specifies a horizontal ruled line or a vertical ruled line.</param>
    /// <param name="lineDirection">The direction in which to print the ruled line.</param>
    /// <param name="lineWidth">The width of the ruled line that the printer station should print. The unit of width is dot. If an unsupported value is specified, the best fit value for the printer station is used.</param>
    /// <param name="lineStyle">The appearance of the ruled line, such as whether it is solid or broken, or single or double.</param>
    /// <param name="lineColor">The color of the ruled line, as an integer value that is equal to the value of the cartridge constant used in the ICommonClaimedPosPrinterStation.ColorCartridge property. If an unsupported value is specified, the printing results may be unpredictable.</param>
    void DrawRuledLine(
      string positionList,
      PosPrinterLineDirection lineDirection,
      uint lineWidth,
      PosPrinterLineStyle lineStyle,
      uint lineColor);

    /// <summary>Adds an instruction to the print job to print a barcode on the receipt or slip printer station with the specified data and symbology.</summary>
    /// <param name="data">The data to represent as a barcode.</param>
    /// <param name="symbology">The symbology (encoding) of the barcode.</param>
    /// <param name="height">The height of the barcode, in pixels.</param>
    /// <param name="width">The width of the barcode, in pixels.</param>
    /// <param name="textPosition">The vertical position of the barcode text relative to the barcode.</param>
    /// <param name="alignment">The horizontal alignment of the barcode on the page.</param>
    void PrintBarcode(
      string data,
      uint symbology,
      uint height,
      uint width,
      PosPrinterBarcodeTextPosition textPosition,
      PosPrinterAlignment alignment);

    /// <summary>Adds an instruction to the print job to print a barcode on a receipt or slip printer station with the specified data, symbology, and custom alignment.</summary>
    /// <param name="data">The data to represent as a barcode.</param>
    /// <param name="symbology">The symbology (encoding) of the barcode.</param>
    /// <param name="height">The height of the barcode, in pixels.</param>
    /// <param name="width">The width of the barcode, in pixels.</param>
    /// <param name="textPosition">The vertical position of the barcode text relative to the barcode.</param>
    /// <param name="alignmentDistance">The distance from the leftmost print column to the start of the barcode, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    void PrintBarcodeCustomAlign(
      string data,
      uint symbology,
      uint height,
      uint width,
      PosPrinterBarcodeTextPosition textPosition,
      uint alignmentDistance);

    /// <summary>Adds an instruction to the print job to print the specified bitmap with the specified standard horizontal placement on the receipt or slip printer station.</summary>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignment">An enumeration value that specifies a standard horizontal placement on the page for the bitmap, such as left-aligned, centered, or right-aligned.</param>
    [Overload("PrintBitmap")]
    void PrintBitmap(BitmapFrame bitmap, PosPrinterAlignment alignment);

    /// <summary>Adds an instruction to the print job to print the specified bitmap with the specified width and a standard horizontal placement on the receipt or slip printer station.</summary>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignment">An enumeration value that specifies a standard horizontal placement on the page for the bitmap, such as left-aligned, centered, or right-aligned.</param>
    /// <param name="width">The width to use for printing the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    [Overload("PrintBitmapCustomWidthStandardAlign")]
    void PrintBitmap(BitmapFrame bitmap, PosPrinterAlignment alignment, uint width);

    /// <summary>Adds an instruction to the print job to print the specified bitmap at the specified distance from the leftmost print column on the receipt or slip printer station.</summary>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignmentDistance">The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    [Overload("PrintCustomAlignedBitmap")]
    void PrintCustomAlignedBitmap(BitmapFrame bitmap, uint alignmentDistance);

    /// <summary>Adds an instruction to the print job to print the specified bitmap with the specified width and at the specified distance from the leftmost print column on the receipt or slip printer station.</summary>
    /// <param name="bitmap">Information about the bitmap that you want to print.</param>
    /// <param name="alignmentDistance">The distance from the leftmost print column to the start of the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    /// <param name="width">The width to use for printing the bitmap, expressed in the unit of measurement indicated by the ClaimedPosPrinter.MapMode property.</param>
    [Overload("PrintBitmapCustomWidthCustomAlign")]
    void PrintCustomAlignedBitmap(BitmapFrame bitmap, uint alignmentDistance, uint width);
  }
}
