// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandSarManager
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Contains the SAR configuration properties and the control method to change them on the device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MobileBroadbandSarManager : IMobileBroadbandSarManager
  {
    /// <summary>Gets a value indicating whether SAR backoff functionality is enabled on the device.</summary>
    /// <returns>True if SAR backoff functionality is enabled; otherwise, false.</returns>
    public extern bool IsBackoffEnabled { [MethodImpl] get; }

    /// <summary>Gets a value indicating if WiFi and cellular SAR are integrated in the device.</summary>
    /// <returns>True if WiFi and cellular SAR are integrated in the device; otherwise, false.</returns>
    public extern bool IsWiFiHardwareIntegrated { [MethodImpl] get; }

    /// <summary>Gets a value indicating if SAR configuration is controlled by device hardware.</summary>
    /// <returns>True if SAR configuration is controlled by device hardware; otherwise, false.</returns>
    public extern bool IsSarControlledByHardware { [MethodImpl] get; }

    /// <summary>Gets the collection of current SAR configuration models for each antenna on the device. </summary>
    /// <returns>The collection of current SAR configuration models for each antenna on the device.</returns>
    public extern IVectorView<MobileBroadbandAntennaSar> Antennas { [MethodImpl] get; }

    /// <summary>Gets the time window of the hysteresis timer that is used to determine antenna's transmission state.</summary>
    /// <returns>The time window of the hysteresis timer.</returns>
    public extern TimeSpan HysteresisTimerPeriod { [MethodImpl] get; }

    /// <summary>Occurs when there is notification received from device that indicate a change in the current transmission state.</summary>
    public extern event TypedEventHandler<MobileBroadbandSarManager, MobileBroadbandTransmissionStateChangedEventArgs> TransmissionStateChanged;

    /// <summary>Enables SAR backoff functionality on the device.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction EnableBackoffAsync();

    /// <summary>Disables SAR backoff functionality on the device.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction DisableBackoffAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetConfigurationAsync(
      IIterable<MobileBroadbandAntennaSar> antennas);

    /// <summary>Sets the device back to hardware control mode. The relevant SAR configuration values are reset to the hardware default settings.</summary>
    /// <returns>An asynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RevertSarToHardwareControlAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetTransmissionStateChangedHysteresisAsync(
      TimeSpan timerPeriod);

    /// <summary>Gets a value that indicates whether the modem is transmitting or idle.</summary>
    /// <returns>True if the modem is transmitting; otherwise, it is idle.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsTransmittingAsync();

    /// <summary>Starts monitoring the transmission state change on the device.</summary>
    [MethodImpl]
    public extern void StartTransmissionStateMonitoring();

    /// <summary>Stops monitoring the transmission state change on the device.</summary>
    [MethodImpl]
    public extern void StopTransmissionStateMonitoring();
  }
}
