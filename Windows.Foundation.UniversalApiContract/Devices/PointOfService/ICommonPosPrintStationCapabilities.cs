// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICommonPosPrintStationCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the capabilities common to all types of stations for point-of-service printers.</summary>
  [Guid(3730526922, 57390, 16617, 158, 94, 27, 72, 142, 106, 172, 252)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICommonPosPrintStationCapabilities
  {
    /// <summary>Gets whether a printer station is present.</summary>
    /// <returns>True if a printer station is present; otherwise false.</returns>
    bool IsPrinterPresent { get; }

    /// <summary>Gets whether the printer station can print a dark color plus an alternate color.</summary>
    /// <returns>True if the printer station can print a dark color plus an alternate color; otherwise false.</returns>
    bool IsDualColorSupported { get; }

    /// <summary>Gets the color cartridges that the printer station can use to print in color.</summary>
    /// <returns>A combination of enumeration values that indicates which color cartridges the printer station can use to print in color.</returns>
    PosPrinterColorCapabilities ColorCartridgeCapabilities { get; }

    /// <summary>Gets information about the sensors that the printer station has available to report the status of the printer station.</summary>
    /// <returns>A combination of enumeration values that indicate the sensors that the printer station has available to report the status of the printer station.</returns>
    PosPrinterCartridgeSensors CartridgeSensors { get; }

    /// <summary>Gets whether the printer station can print bold characters.</summary>
    /// <returns>True if the printer station can print bold characters; otherwise false.</returns>
    bool IsBoldSupported { get; }

    /// <summary>Gets whether the printer station can print italic characters.</summary>
    /// <returns>True if the printer station can print italic characters; otherwise false.</returns>
    bool IsItalicSupported { get; }

    /// <summary>Gets whether the printer station can underline characters.</summary>
    /// <returns>True if the printer station can underline characters; otherwise false.</returns>
    bool IsUnderlineSupported { get; }

    /// <summary>Gets whether the printer station can print double-high characters.</summary>
    /// <returns>True if the printer station can print double-high characters; otherwise false.</returns>
    bool IsDoubleHighPrintSupported { get; }

    /// <summary>Gets whether the printer station can print double-wide characters.</summary>
    /// <returns>True if the printer station can print double-wide characters; otherwise false.</returns>
    bool IsDoubleWidePrintSupported { get; }

    /// <summary>Gets whether the printer station can print characters that are both double-high and double-wide.</summary>
    /// <returns>True if the printer station can print characters that are both double-high and double-wide; otherwise false.</returns>
    bool IsDoubleHighDoubleWidePrintSupported { get; }

    /// <summary>Gets whether the printer station has an out-of-paper sensor.</summary>
    /// <returns>True if the printer station has an out-of-paper sensor; otherwise false.</returns>
    bool IsPaperEmptySensorSupported { get; }

    /// <summary>Gets whether the printer station has a low-paper sensor.</summary>
    /// <returns>True if the printer station has a low-paper sensor; otherwise false.</returns>
    bool IsPaperNearEndSensorSupported { get; }

    /// <summary>Gets a collection of the line widths in characters per line that the printer station supports.</summary>
    /// <returns>A collection of the line widths in characters per line that the printer station supports.</returns>
    IVectorView<uint> SupportedCharactersPerLine { get; }
  }
}
