// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICommonClaimedPosPrinterStation
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents properties and actions common to all type of claimed stations for a point-of-service printer.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3085657768, 65162, 19707, 139, 66, 227, 91, 40, 12, 178, 124)]
  public interface ICommonClaimedPosPrinterStation
  {
    /// <summary>Gets or sets the number of characters the station can print per line of text.</summary>
    /// <returns>The number of characters the device can print per line of text.</returns>
    uint CharactersPerLine { set; get; }

    /// <summary>Gets or sets the current height of the printed line for the printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</summary>
    /// <returns>The current height of the printed line for the printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    uint LineHeight { set; get; }

    /// <summary>Gets or sets the spacing of each single-high print line for the printer station, in the units that the ClaimedPosPrinter.MapMode property specifies. This spacing includes both the height of printed line and of the white space between each pair of lines.</summary>
    /// <returns>The spacing of each single-high print line for the slip printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    uint LineSpacing { set; get; }

    /// <summary>Gets the current width of the printed line for the printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</summary>
    /// <returns>The current width of the printed line for the printer station, in the units that the ClaimedPosPrinter.MapMode property specifies.</returns>
    uint LineWidth { get; }

    /// <summary>Gets or sets whether the printer station prints with high quality or high speed.</summary>
    /// <returns>True if the printer station prints with high quality. False if the point-of-service printer prints with high speed.</returns>
    bool IsLetterQuality { set; get; }

    /// <summary>Gets whether the printer station is almost out of paper.</summary>
    /// <returns>True if the printer station is almost out of paper; otherwise, false.</returns>
    bool IsPaperNearEnd { get; }

    /// <summary>Gets or sets the color cartridge that the printer station should use when it prints.</summary>
    /// <returns>An enumeration value that identifies the color cartridge that the printer station should use when it prints.</returns>
    PosPrinterColorCartridge ColorCartridge { set; get; }

    /// <summary>Gets whether the cover of the printer station is currently open.</summary>
    /// <returns>True if the cover of the printer station is currently open; otherwise, false.</returns>
    bool IsCoverOpen { get; }

    /// <summary>Gets whether the cartridge of the printer station is currently removed.</summary>
    /// <returns>True if the cartridge of the printer station is currently removed; otherwise, false.</returns>
    bool IsCartridgeRemoved { get; }

    /// <summary>Gets whether the cartridge of the printer station is currently out of ink or toner.</summary>
    /// <returns>True if the cartridge of the printer station is currently out of ink or toner; otherwise, false.</returns>
    bool IsCartridgeEmpty { get; }

    /// <summary>Gets whether the printer station is currently cleaning its print head.</summary>
    /// <returns>True if the printer station is currently cleaning its print head; otherwise, false.</returns>
    bool IsHeadCleaning { get; }

    /// <summary>Gets whether the printer station needs paper.</summary>
    /// <returns>True if the printer station needs paper; otherwise, false.</returns>
    bool IsPaperEmpty { get; }

    /// <summary>Gets whether the printer station is on and accepting print jobs.</summary>
    /// <returns>True if the printer station is on and accepting print jobs; otherwise, false.</returns>
    bool IsReadyToPrint { get; }

    /// <summary>Determines whether a data sequence, possibly including one or more escape sequences, is valid for the printer station, before you use that data sequence when you call the IPosPrinterJob.Print and IPosPrinterJob.ExecuteAsync methods.</summary>
    /// <param name="data">The data sequence that you want to validate before you use it with the IPosPrinterJob.Print method. This sequence may include printable data and escape sequences.</param>
    /// <returns>True if the data passes validation; otherwise false.</returns>
    bool ValidateData(string data);
  }
}
