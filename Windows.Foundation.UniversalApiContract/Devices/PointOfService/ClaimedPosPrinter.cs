// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedPosPrinter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  /// <summary>Represent a point-of-service printer that has been claimed for use.</summary>
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ClaimedPosPrinter : IClaimedPosPrinter, IClaimedPosPrinter2, IClosable
  {
    /// <summary>Gets the identifier string of the claimed point-of-service printer.</summary>
    /// <returns>The identifier of the claimed point-of-service printer.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets whether the printer is powered on for use.</summary>
    /// <returns>True if the printer is powered on for use; false otherwise.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>Gets or sets a numeric value that indicates the character set that the application wants to use for printing characters.</summary>
    /// <returns>The character set that the application wants to use for printing characters.</returns>
    public extern uint CharacterSet { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets whether the cover of the point-of-service printer is currently open.</summary>
    /// <returns>True if the cover of the printer is currently open; otherwise, false.</returns>
    public extern bool IsCoverOpen { [MethodImpl] get; }

    /// <summary>Gets or sets whether the driver or provider can map Unicode characters to characters that the point-of-service printer can print, or just sends the low byte of the Unicode character to the printer directly.</summary>
    /// <returns>True if the driver or provider maps Unicode characters to character that the point-of-service printer can print. False if the driver or provider sends the low byte of each Unicode character to the point-of-service printer directly.</returns>
    public extern bool IsCharacterSetMappingEnabled { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the mapping mode of the point-of-service printer that the app wants to use. The mapping mode defines the unit of measure used for other printer properties, such as line height and line spacing.</summary>
    /// <returns>An enumeration value that indicates the mapping mode of the point-of-service printer that the app wants to use.</returns>
    public extern PosPrinterMapMode MapMode { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets an object that represents the receipt station for a claimed point-of-service printer.</summary>
    /// <returns>An object that represents the receipt station for a claimed point-of-service printer. Null if a receipt station is not present.</returns>
    public extern ClaimedReceiptPrinter Receipt { [MethodImpl] get; }

    /// <summary>Gets an object that represents the slip station for a claimed point-of-service printer.</summary>
    /// <returns>An object that represents the slip station for a claimed point-of-service printer. Null if a slip station is not present.</returns>
    public extern ClaimedSlipPrinter Slip { [MethodImpl] get; }

    /// <summary>Gets an object that represents the journal station for a claimed point-of-service printer.</summary>
    /// <returns>An object that represents the journal station for a claimed point-of-service printer. Null if a journal station is not present.</returns>
    public extern ClaimedJournalPrinter Journal { [MethodImpl] get; }

    /// <summary>Notifies the underlying hardware asynchronously to power on for use.</summary>
    /// <returns>True if the attempt to turn on the printer succeeded; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> EnableAsync();

    /// <summary>Notifies the underlying hardware to turn off.</summary>
    /// <returns>True if the attempt turn off the printer succeeded; otherwise false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> DisableAsync();

    /// <summary>Retains the claim on the point-of-service printer asynchronously, usually in response to the ReleaseDeviceRequested event.</summary>
    /// <returns>True if the printer was successfully retained; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RetainDeviceAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ResetStatisticsAsync(
      IIterable<string> statisticsCategories);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    /// <summary>Occurs when a point-of-service printer gets a request to release its exclusive claim.</summary>
    public extern event TypedEventHandler<ClaimedPosPrinter, PosPrinterReleaseDeviceRequestedEventArgs> ReleaseDeviceRequested;

    /// <summary>Event that is raised when the **ClaimedPosPrinter** is closed.</summary>
    public extern event TypedEventHandler<ClaimedPosPrinter, ClaimedPosPrinterClosedEventArgs> Closed;

    [MethodImpl]
    public extern void Close();
  }
}
