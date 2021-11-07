// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.JournalPrinterCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the capabilities of journal station of a point-of-service printer.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class JournalPrinterCapabilities : 
    IJournalPrinterCapabilities,
    IJournalPrinterCapabilities2,
    ICommonPosPrintStationCapabilities
  {
    /// <summary>Gets whether the journal printer station can print characters in reverse-video style.</summary>
    /// <returns>True if the journal printer station can print characters in reverse-video style; otherwise false.</returns>
    public extern bool IsReverseVideoSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print characters in strikethrough style.</summary>
    /// <returns>True if the journal printer station can print characters in strikethrough style; otherwise false.</returns>
    public extern bool IsStrikethroughSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print characters in superscript style.</summary>
    /// <returns>True if the journal printer station can print characters in superscript style; otherwise false.</returns>
    public extern bool IsSuperscriptSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print characters in subscript style.</summary>
    /// <returns>True if the journal printer station can print characters in subscript style; otherwise false.</returns>
    public extern bool IsSubscriptSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can reverse paper feed by line.</summary>
    /// <returns>True if the journal printer station can reverse paper feed by line; otherwise false.</returns>
    public extern bool IsReversePaperFeedByLineSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can reverse paper feed by map mode unit.</summary>
    /// <returns>True if the journal printer station can reverse paper feed by map mode unit; otherwise false.</returns>
    public extern bool IsReversePaperFeedByMapModeUnitSupported { [MethodImpl] get; }

    /// <summary>Gets whether a point-of-service printer with a station that functions as a journal printer station is present.</summary>
    /// <returns>True if a point-of-service printer with a station that functions as a journal printer station is present; otherwise false.</returns>
    public extern bool IsPrinterPresent { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print a dark color plus an alternate color.</summary>
    /// <returns>True if the journal printer station can print a dark color plus an alternate color; otherwise false.</returns>
    public extern bool IsDualColorSupported { [MethodImpl] get; }

    /// <summary>Gets the color cartridges that the journal printer station can use to print in color.</summary>
    /// <returns>A combination of enumeration values that indicates which color cartridges the journal printer station can use to print in color.</returns>
    public extern PosPrinterColorCapabilities ColorCartridgeCapabilities { [MethodImpl] get; }

    /// <summary>Gets information about the sensors that the journal printer station has available to report the status of the printer cartridge.</summary>
    /// <returns>A combination of enumeration values that indicate the set of sensors that can provide state information for the journal printer ink cartridges.</returns>
    public extern PosPrinterCartridgeSensors CartridgeSensors { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print bold characters.</summary>
    /// <returns>True if the journal printer station can print bold characters; otherwise false.</returns>
    public extern bool IsBoldSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print italic characters.</summary>
    /// <returns>True if the journal printer station can print italic characters; otherwise false.</returns>
    public extern bool IsItalicSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can underline characters.</summary>
    /// <returns>True if the journal printer station can underline characters; otherwise false.</returns>
    public extern bool IsUnderlineSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print double-high characters.</summary>
    /// <returns>True if the journal printer station can print double-high characters; otherwise false.</returns>
    public extern bool IsDoubleHighPrintSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print double-wide characters.</summary>
    /// <returns>True if the journal printer station can print double-wide characters; otherwise false.</returns>
    public extern bool IsDoubleWidePrintSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station can print characters that are both double-high and double-wide.</summary>
    /// <returns>True if the journal printer station can print characters that are both double-high and double-wide; otherwise false.</returns>
    public extern bool IsDoubleHighDoubleWidePrintSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station has an out-of-paper sensor.</summary>
    /// <returns>True if the journal printer station has an out-of-paper sensor; otherwise false.</returns>
    public extern bool IsPaperEmptySensorSupported { [MethodImpl] get; }

    /// <summary>Gets whether the journal printer station has a low-paper sensor.</summary>
    /// <returns>True if the journal printer station has a low-paper sensor; otherwise false.</returns>
    public extern bool IsPaperNearEndSensorSupported { [MethodImpl] get; }

    /// <summary>Gets a collection of the line widths in characters per line that the journal printer station supports.</summary>
    /// <returns>A collection of the line widths in characters per line that the journal printer station supports.</returns>
    public extern IVectorView<uint> SupportedCharactersPerLine { [MethodImpl] get; }
  }
}
