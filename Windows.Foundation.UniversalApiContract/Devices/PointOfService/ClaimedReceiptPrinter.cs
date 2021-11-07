// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedReceiptPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a receipt printer station that has been claimed for use.</summary>
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ClaimedReceiptPrinter : IClaimedReceiptPrinter, ICommonClaimedPosPrinterStation
  {
    /// <summary>Gets the maximum number of lines that the receipt printer station can print in sideways mode.</summary>
    /// <returns>The maximum number of lines that the receipt printer station can print in sideways mode.</returns>
    public extern uint SidewaysMaxLines { [MethodImpl] get; }

    /// <summary>Gets the maximum number of characters that the receipt printer station can print on each line in sideways mode.</summary>
    /// <returns>The maximum number of characters that the receipt printer station can print on each line in sideways mode.</returns>
    public extern uint SidewaysMaxChars { [MethodImpl] get; }

    /// <summary>Gets the number of lines that must be advanced before cutting the receipt paper.</summary>
    /// <returns>The number of lines that must be advanced before cutting the receipt paper.</returns>
    public extern uint LinesToPaperCut { [MethodImpl] get; }

    /// <summary>Gets the size of paper that the claimed receipt printer station currently uses.</summary>
    /// <returns>The size of paper that the claimed receipt printer station currently uses.</returns>
    public extern Size PageSize { [MethodImpl] get; }

    /// <summary>Gets the print area for the receipt printer station, expressed in the unit of measurement that the ClaimedPosPrinter.MapMode property specifies.</summary>
    /// <returns>The print area for the receipt printer station, expressed in the unit of measurement that the ClaimedPosPrinter.MapMode property specifies.</returns>
    public extern Rect PrintArea { [MethodImpl] get; }

    /// <summary>Creates a new print job for the receipt printer station.</summary>
    /// <returns>The new print job for the receipt printer station.</returns>
    [MethodImpl]
    public extern ReceiptPrintJob CreateJob();

    /// <summary>Gets or sets the number of characters the receipt printer station can print per line of text.</summary>
    /// <returns>The number of characters the receipt printer station can print per line of text.</returns>
    public extern uint CharactersPerLine { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the current height of the printed line for the receipt printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</summary>
    /// <returns>The current height of the printed line for the receipt printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    public extern uint LineHeight { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the spacing of each single-high print line for the receipt printer station, in the units that the ClaimedPosPrinter.MapMode property specifies. This spacing includes both the height of printed line and of the white space between each pair of lines.</summary>
    /// <returns>The spacing of each single-high print line for the receipt printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    public extern uint LineSpacing { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the current width of the printed line for the receipt printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</summary>
    /// <returns>The current width of the printed line for the receipt printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    public extern uint LineWidth { [MethodImpl] get; }

    /// <summary>Gets or sets whether the receipt printer station prints with high quality or high speed.</summary>
    /// <returns>True if the receipt printer station prints with high quality. False if the receipt printer station prints with high speed.</returns>
    public extern bool IsLetterQuality { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets whether the receipt printer station is almost out of paper.</summary>
    /// <returns>True if the receipt printer station is almost out of paper; otherwise, false.</returns>
    public extern bool IsPaperNearEnd { [MethodImpl] get; }

    /// <summary>Gets or sets the color cartridge that the receipt printer station should use when it prints.</summary>
    /// <returns>An enumeration value that identifies the color cartridge that the receipt printer station should use when it prints.</returns>
    public extern PosPrinterColorCartridge ColorCartridge { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets whether the cover of the receipt printer station is currently open.</summary>
    /// <returns>True if the cover of the receipt printer station is currently open; otherwise, false.</returns>
    public extern bool IsCoverOpen { [MethodImpl] get; }

    /// <summary>Gets whether the cartridge of the receipt printer station is currently removed.</summary>
    /// <returns>True if the cartridge of the receipt printer station is currently removed; otherwise, false.</returns>
    public extern bool IsCartridgeRemoved { [MethodImpl] get; }

    /// <summary>Gets whether the cartridge of the receipt printer station is currently out of ink or toner.</summary>
    /// <returns>True if the cartridge of the receipt printer station is currently out of ink or toner; otherwise, false.</returns>
    public extern bool IsCartridgeEmpty { [MethodImpl] get; }

    /// <summary>Gets whether the receipt printer station is currently cleaning its print head.</summary>
    /// <returns>True if the receipt printer station is currently cleaning its print head; otherwise, false.</returns>
    public extern bool IsHeadCleaning { [MethodImpl] get; }

    /// <summary>Gets whether the receipt printer station needs paper.</summary>
    /// <returns>True if the receipt printer station needs paper; otherwise, false.</returns>
    public extern bool IsPaperEmpty { [MethodImpl] get; }

    /// <summary>Gets whether the receipt printer station is on and accepting print jobs.</summary>
    /// <returns>True if the receipt printer station is on and accepting print jobs; otherwise, false.</returns>
    public extern bool IsReadyToPrint { [MethodImpl] get; }

    /// <summary>Determines whether a data sequence, possibly including one or more escape sequences, is valid for the receipt printer station, before you use that data sequence when you call the ReceiptPrintJob.Print and ReceiptPrintJob.ExecuteAsync methods.</summary>
    /// <param name="data">The data sequence that you want to validate before you use it with the ReceiptPrintJob.Print method. This sequence may include printable data and escape sequences.</param>
    /// <returns>True if the data passes validation; otherwise false.</returns>
    [MethodImpl]
    public extern bool ValidateData(string data);
  }
}
