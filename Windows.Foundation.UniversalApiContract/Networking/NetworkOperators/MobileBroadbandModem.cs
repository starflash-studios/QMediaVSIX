// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandModem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  /// <summary>Represents a mobile broadband modem.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMobileBroadbandModemStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class MobileBroadbandModem : 
    IMobileBroadbandModem,
    IMobileBroadbandModem2,
    IMobileBroadbandModem3
  {
    /// <summary>Gets the MobileBroadbandAccount associated currently with the mobile broadband modem.</summary>
    /// <returns>The account associated currently with the mobile broadband modem.</returns>
    public extern MobileBroadbandAccount CurrentAccount { [MethodImpl] get; }

    /// <summary>Gets the MobileBroadbandDeviceInformation for the mobile broadband modem.</summary>
    /// <returns>The device information for the mobile broadband modem.</returns>
    public extern MobileBroadbandDeviceInformation DeviceInformation { [MethodImpl] get; }

    /// <summary>Gets the maximum device service command size, in bytes, for the mobile broadband modem.</summary>
    /// <returns>The maximum device service command size, in bytes, for the mobile broadband modem.</returns>
    public extern uint MaxDeviceServiceCommandSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets the maximum device service data size, in bytes, for the mobile broadband modem.</summary>
    /// <returns>the maximum device service data size, in bytes, for the mobile broadband modem.</returns>
    public extern uint MaxDeviceServiceDataSizeInBytes { [MethodImpl] get; }

    /// <summary>Gets a list of the device services available for the mobile broadband modem.</summary>
    /// <returns>A list of the device services available for the mobile broadband modem.</returns>
    public extern IVectorView<MobileBroadbandDeviceServiceInformation> DeviceServices { [MethodImpl] get; }

    /// <summary>Gets a specific device service for the mobile broadband modem.</summary>
    /// <param name="deviceServiceId">The unique device service identifier for the device service to be retrieved.</param>
    /// <returns>The mobile broadband device service retrieved.</returns>
    [MethodImpl]
    public extern MobileBroadbandDeviceService GetDeviceService(
      Guid deviceServiceId);

    /// <summary>Gets a value indicating whether the mobile broadband modem allows a reset operation.</summary>
    /// <returns>When this value is true, the modem can be reset by calling ResetAsync. When this value is false, calling **ResetAsync** fails.</returns>
    public extern bool IsResetSupported { [MethodImpl] get; }

    /// <summary>Asynchronously performs a reset operation on the mobile broadband modem.</summary>
    /// <returns>An asynchronous reset operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ResetAsync();

    /// <summary>Asynchronously retrieves mobile broadband modem configuration information.</summary>
    /// <returns>An asynchronous retrieval operation. On successful completion, contains a MobileBroadbandModemConfiguration object representing the current configuration.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandModemConfiguration> GetCurrentConfigurationAsync();

    /// <summary>Gets an object that describes the mobile broadband network that this modem us currently attached to.</summary>
    /// <returns>Describes the current broadband network.</returns>
    public extern MobileBroadbandNetwork CurrentNetwork { [MethodImpl] get; }

    /// <summary>Gets a value indicating whether passthrough mode is enabled.</summary>
    /// <returns>An asynchronous operation that returns a boolean value on completion. The value is true if passthrough is enabled; otherwise, false.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> GetIsPassthroughEnabledAsync();

    /// <summary>Asynchronously enables or disables passthrough mode.</summary>
    /// <param name="value">True if passthrough should be enabled; otherwise, false.</param>
    /// <returns>An asynchronous operation that returns a MobileBroadbandModemStatus value on completion.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandModemStatus> SetIsPassthroughEnabledAsync(
      bool value);

    /// <summary>Asynchronously retrieves the Protocol Configuration Options (PCO) data for the modem.</summary>
    /// <returns>An asynchronous retrieval operation. On successful completion, contains a MobileBroadbandPco object representing Protocol Configuration Options (PCO) data.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPco> TryGetPcoAsync();

    /// <summary>Gets a value indicating whether the mobile broadband modem is in emergency call mode.</summary>
    /// <returns>`true` if the mobile broadband modem is in emergency call mode, otherwise `false`.</returns>
    public extern bool IsInEmergencyCallMode { [MethodImpl] get; }

    /// <summary>Occurs when the mobile broadband modem either enters or exits emergency call mode.</summary>
    public extern event TypedEventHandler<MobileBroadbandModem, object> IsInEmergencyCallModeChanged;

    /// <summary>Gets a device selector for the mobile broadband modem.</summary>
    /// <returns>A device selector for the mobile broadband modem.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Determine if a mobile broadband device is a Wireless WAN device.</summary>
    /// <param name="deviceId">The mobile broadband device ID</param>
    /// <returns>The mobile broadband modem.</returns>
    [MethodImpl]
    public static extern MobileBroadbandModem FromId(string deviceId);

    /// <summary>Determines the default mobile broadband modem.</summary>
    /// <returns>The mobile broadband modem.</returns>
    [MethodImpl]
    public static extern MobileBroadbandModem GetDefault();
  }
}
