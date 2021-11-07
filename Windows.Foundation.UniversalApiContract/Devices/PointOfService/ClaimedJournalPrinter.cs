// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedJournalPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents a journal printer station that has been claimed for use.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ClaimedJournalPrinter : IClaimedJournalPrinter, ICommonClaimedPosPrinterStation
  {
    /// <summary>Creates a new print job for the journal printer station.</summary>
    /// <returns>The new print job for the journal printer station.</returns>
    [MethodImpl]
    public extern JournalPrintJob CreateJob();

    /// <summary>Gets or sets the number of characters per line for the journal printer station.</summary>
    /// <returns>The number of characters.</returns>
    public extern uint CharactersPerLine { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the current height of the printed line for the journal printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</summary>
    /// <returns>The current height of the printed line for the journal printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    public extern uint LineHeight { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the spacing of each single-high print line for the journal printer station, in the units that the ClaimedPosPrinter.MapMode property specifies. This spacing includes both the height of printed line and of the white space between each pair of lines.</summary>
    /// <returns>The spacing of each single-high print line for the journal printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    public extern uint LineSpacing { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the current width of the printed line for the journal printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</summary>
    /// <returns>The current width of the printed line for the journal printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    public extern uint LineWidth { [MethodImpl] get; }

    /// <summary>Gets or sets whether the journal printer station prints with high quality or high speed. Note, this may throw an exception if the corresponding sensor is not available on the printer.</summary>
    /// <returns>True if the journal printer station prints with high quality. False if the journal printer station prints with high speed.</returns>
    public extern bool IsLetterQuality { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets whether the printer paper is near the end for the journal printer station. Note, this may throw an exception if the corresponding sensor is not available on the printer. See JournalPrinterCapabilities to verify sensor availability.</summary>
    /// <returns>True if the paper is near the end; otherwise false.</returns>
    public extern bool IsPaperNearEnd { [MethodImpl] get; }

    /// <summary>Gets or sets the color cartridge that the journal printer station should use when it prints. This property must agree with what is available through ColorCartridgeCapabilities.</summary>
    /// <returns>An enumeration value that identifies the color cartridge that the journal printer station should use when it prints.</returns>
    public extern PosPrinterColorCartridge ColorCartridge { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets whether the printer cover for the journal printer station is open.</summary>
    /// <returns>True if the cover is open; otherwise false.</returns>
    public extern bool IsCoverOpen { [MethodImpl] get; }

    /// <summary>Gets whether the cartridge for journal printer station has been removed. Note, this may throw an exception if the corresponding sensor is not available on the printer. See JournalPrinterCapabilities to verify sensor availability.</summary>
    /// <returns>True if the cartridge is missing; otherwise false.</returns>
    public extern bool IsCartridgeRemoved { [MethodImpl] get; }

    /// <summary>Gets whether the printer cartridge for the journal printer station is empty. Note, this may throw an exception if the corresponding sensor is not available on the printer. See JournalPrinterCapabilities to verify sensor availability.</summary>
    /// <returns>True if the printer cartridge is empty; otherwise false.</returns>
    public extern bool IsCartridgeEmpty { [MethodImpl] get; }

    /// <summary>Gets whether the head for the journal printer station is currently cleaning.</summary>
    /// <returns>True if the head is currently cleaning; otherwise false.</returns>
    public extern bool IsHeadCleaning { [MethodImpl] get; }

    /// <summary>Gets whether the paper is empty for the journal printer station. Note, this may throw an exception if the corresponding sensor is not available on the printer. See JournalPrinterCapabilities to verify sensor availability.</summary>
    /// <returns>True if the printer is out of paper; otherwise false.</returns>
    public extern bool IsPaperEmpty { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station is ready to print. Note, this may throw an exception if the corresponding sensor is not available on the printer. See JournalPrinterCapabilities to verify sensor availability.</summary>
    /// <returns>True if the printer is ready to print; otherwise false.</returns>
    public extern bool IsReadyToPrint { [MethodImpl] get; }

    /// <summary>Determines if a JournalPrintJob can successfully execute a print instruction with the specified data.</summary>
    /// <param name="data">The data sequence that you want to validate before you use it with the JournalPrintJob.Print method. This sequence may include printable data and escape sequences.</param>
    /// <returns>True if the data passes validation; otherwise false.</returns>
    [MethodImpl]
    public extern bool ValidateData(string data);
  }
}
