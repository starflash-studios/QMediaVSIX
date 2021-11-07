// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterCapabilities
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represents the capabilities of the point-of-service printer.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PosPrinterCapabilities : IPosPrinterCapabilities
  {
    /// <summary>Gets the power reporting capabilities of the point-of-service printer.</summary>
    /// <returns>The power reporting capabilities of the point-of-service printer, such as whether the printer can determine and report two or three different power states.</returns>
    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    /// <summary>Gets whether the point-of-service printer supports reporting statistics.</summary>
    /// <returns>True if the point-of-service printer supports reporting statistics; otherwise, false.</returns>
    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    /// <summary>Gets whether the point-of-service printer supports updating statistics.</summary>
    /// <returns>True if the point-of-service printer supports updating statistics; otherwise, false.</returns>
    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    /// <summary>Gets the character set that the point-of-service printer uses by default.</summary>
    /// <returns>The character set that the point-of-service printer uses by default.</returns>
    public extern uint DefaultCharacterSet { [MethodImpl] get; }

    /// <summary>Gets whether the point-of-service printer has a sensor that detects if the printer cover is open.</summary>
    /// <returns>True if the point-of-service printer has a sensor that detects if the printer cover is open; otherwise false.</returns>
    public extern bool HasCoverSensor { [MethodImpl] get; }

    /// <summary>Gets whether the point-of-service printer can map the characters that the application sends (in the character set that the ClaimedPosPrinter.CharacterSet property defines) to the character sets that the PosPrinter.SupportedCharacterSets property defines.</summary>
    /// <returns>True if the point-of-service printer can map the characters that the application sends to the code page used by the printer. If false, the user must make sure that the Unicode characters have the low byte as the value that will be used to send to the printer.</returns>
    public extern bool CanMapCharacterSet { [MethodImpl] get; }

    /// <summary>Gets whether the point-of-service printer supports printer transactions.</summary>
    /// <returns>True if the point-of-service printer supports printer transactions; otherwise false.</returns>
    public extern bool IsTransactionSupported { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the receipt station for the point-of-service printer.</summary>
    /// <returns>The capabilities of the receipt station for the point-of-service printer.</returns>
    public extern ReceiptPrinterCapabilities Receipt { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the slip station for the point-of-service printer.</summary>
    /// <returns>The capabilities of the slip station for the point-of-service printer.</returns>
    public extern SlipPrinterCapabilities Slip { [MethodImpl] get; }

    /// <summary>Gets the capabilities of the journal station for the point-of-service printer.</summary>
    /// <returns>The capabilities of the journal station for the point-of-service printer.</returns>
    public extern JournalPrinterCapabilities Journal { [MethodImpl] get; }
  }
}
