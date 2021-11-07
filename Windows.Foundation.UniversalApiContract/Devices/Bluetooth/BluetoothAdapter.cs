// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Radios;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Represents a Bluetooth adapter.</summary>
  [Static(typeof (IBluetoothAdapterStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 1)]
  public sealed class BluetoothAdapter : IBluetoothAdapter, IBluetoothAdapter2, IBluetoothAdapter3
  {
    /// <summary>Gets the device ID.</summary>
    /// <returns>The ID of the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the device address.</summary>
    /// <returns>The device address.</returns>
    public extern ulong BluetoothAddress { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating if the adapter supports the Bluetooth Classic transport type.</summary>
    /// <returns>Gets a boolean indicating if the adapter supports the Bluetooth Classic transport type.</returns>
    public extern bool IsClassicSupported { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating if the adapater supports LowEnergy Bluetooth Transport type.</summary>
    /// <returns>Gets a boolean indicating if the adapater supports LowEnergy Bluetooth Transport type.</returns>
    public extern bool IsLowEnergySupported { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating if the adapater supports LowEnergy peripheral role.</summary>
    /// <returns>Gets a boolean indicating if the adapater supports LowEnergy peripheral role.</returns>
    public extern bool IsPeripheralRoleSupported { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating if the adapater supports LowEnergy central role.</summary>
    /// <returns>Gets a boolean indicating if the adapater supports LowEnergy central role.</returns>
    public extern bool IsCentralRoleSupported { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating if the adapter supports advertisement offload.</summary>
    /// <returns>Gets a boolean indicating if the adapter supports advertisement offload.</returns>
    public extern bool IsAdvertisementOffloadSupported { [MethodImpl] get; }

    /// <summary>Gets the radio represented by this Bluetooth adapter.</summary>
    /// <returns>Returns an asynchronous operation that completes with the Radio.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Radio> GetRadioAsync();

    /// <summary>Gets or sets a value indicating whether Secure Connections are supported for classic paired Bluetooth devices.</summary>
    /// <returns>Indicates whether Secure Connections are supported for classic paired Bluetooth devices.</returns>
    public extern bool AreClassicSecureConnectionsSupported { [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating whether Secure Connections are supported for paired Bluetooth LE devices.</summary>
    /// <returns>Indicates whether Secure Connections are supported for classic paired Bluetooth devices.</returns>
    public extern bool AreLowEnergySecureConnectionsSupported { [MethodImpl] get; }

    /// <summary>Indicates whether the adapter supports the 5.0 Extended Advertising format.</summary>
    /// <returns>Indicates whether extended advertisements are supported on this adapter.</returns>
    public extern bool IsExtendedAdvertisingSupported { [MethodImpl] get; }

    /// <summary>Indicates the maximum length of an advertisement that can be published by this adapter.</summary>
    /// <returns>The maximum advertisement length of this adapter.</returns>
    public extern uint MaxAdvertisementDataLength { [MethodImpl] get; }

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying instances of this adapter. This string is passed to the FindAllAsync or CreateWatcher method.</summary>
    /// <returns>Returns an AQS string.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();

    /// <summary>Gets a BluetoothAdapter object identified by the given DeviceId.</summary>
    /// <param name="deviceId">The DeviceId value that identifies the BluetoothAdapter instance. This is a composite string combining registry information that includes the MatchingDeviceId, the MAC address, and a GUID representing a device class. This is different than Windows.Devices.Enumeration.DeviceInformation.Id. However, both contain the MAC address of the Bluetooth radio device embedded within the identifier string.</param>
    /// <returns>After the asynchronous operation completes, returns the BluetoothAdapter object identified by the given DeviceId.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothAdapter> FromIdAsync(
      string deviceId);

    /// <summary>Gets the default BluetoothAdapter.</summary>
    /// <returns>An asynchronous operation that completes with a BluetoothAdapter.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothAdapter> GetDefaultAsync();
  }
}
