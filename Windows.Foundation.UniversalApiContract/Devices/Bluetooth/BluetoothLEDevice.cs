// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothLEDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Represents a Bluetooth LE device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IBluetoothLEDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IBluetoothLEDeviceStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BluetoothLEDevice : 
    IBluetoothLEDevice,
    IBluetoothLEDevice2,
    IBluetoothLEDevice3,
    IBluetoothLEDevice4,
    IBluetoothLEDevice5,
    IBluetoothLEDevice6,
    IClosable
  {
    /// <summary>Gets the device Id.</summary>
    /// <returns>The Id of the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the name of the Bluetooth LE device.</summary>
    /// <returns>The name of the Bluetooth LE device.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the read-only list of GATT services supported by the device.</summary>
    /// <returns>The read-only list of GATT services supported by this Bluetooth LE device.</returns>
    public extern IVectorView<GattDeviceService> GattServices { [Deprecated("Use GetGattServicesAsync instead of GattServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the connection status of the device.</summary>
    /// <returns>One of the BluetoothConnectionStatus enumeration values that specifies the connection status of the device.</returns>
    public extern BluetoothConnectionStatus ConnectionStatus { [MethodImpl] get; }

    /// <summary>Gets the device address.</summary>
    /// <returns>The address of the device.</returns>
    public extern ulong BluetoothAddress { [MethodImpl] get; }

    /// <summary>Returns the GATT service with the given service Id.</summary>
    /// <deprecated type="deprecate">Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.</deprecated>
    /// <param name="serviceUuid">The service Id of the GATT service.</param>
    /// <returns>The GATT service represented by the given service Id.</returns>
    [Deprecated("Use GetGattServicesForUuidAsync instead of GetGattService.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern GattDeviceService GetGattService(Guid serviceUuid);

    /// <summary>Occurs when the name of the device has changed.</summary>
    public extern event TypedEventHandler<BluetoothLEDevice, object> NameChanged;

    /// <summary>Occurs when the list of GATT services supported by the device has changed.</summary>
    public extern event TypedEventHandler<BluetoothLEDevice, object> GattServicesChanged;

    /// <summary>Occurs when the connection status for the device has changed.</summary>
    public extern event TypedEventHandler<BluetoothLEDevice, object> ConnectionStatusChanged;

    /// <summary>Gets the device information for the Bluetooth LE device.</summary>
    /// <returns>A DeviceInformation object representing the device information.</returns>
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    /// <summary>Gets the BluetoothLEAppearance object for the Bluetooth LE device.</summary>
    /// <returns>The appearance for the Bluetooth LE device.</returns>
    public extern BluetoothLEAppearance Appearance { [MethodImpl] get; }

    /// <summary>Gets the address type for the Bluetooth LE device.</summary>
    /// <returns>The address type.</returns>
    public extern BluetoothAddressType BluetoothAddressType { [MethodImpl] get; }

    /// <summary>Gets the DeviceAccessInformation.</summary>
    /// <returns>Gets the DeviceAccessInformation.</returns>
    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    /// <summary>Requests access to the Bluetooth LowEnergy device.</summary>
    /// <returns>Returns an asynchronous operation that completes with a DeviceAccessStatus.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    /// <summary>Gets the GattDeviceServices for this Bluetooth LowEnergy device.</summary>
    /// <returns>Returns an asynchronous operation that completes with a GattDeviceServicesResult.</returns>
    [RemoteAsync]
    [Overload("GetGattServicesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync();

    /// <summary>Returns the GattDeviceServices for this Bluetooth LowEnergy device with the specified cache mode.</summary>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>Returns an asynchronous operation that completes with a GattDeviceServicesResult.</returns>
    [Overload("GetGattServicesWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Returns the GattDeviceServices for the Bluetooth LowEnergy device with the specified UUID.</summary>
    /// <param name="serviceUuid">The service UUID.</param>
    /// <returns>
    /// </returns>
    [Overload("GetGattServicesForUuidAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid);

    /// <summary>Returns the GattDeviceServices for the Bluetooth LowEnergy device with the specified UUID.</summary>
    /// <param name="serviceUuid">The service UUID.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>Returns an asynchronous operation that completes with a GattDeviceServicesResult.</returns>
    [Overload("GetGattServicesForUuidWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetGattServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);

    /// <summary>Gets the bluetooth device ID.</summary>
    /// <returns>The bluetooth device ID.</returns>
    public extern BluetoothDeviceId BluetoothDeviceId { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating whether the BluetoothLEDevice was paired using a Secure Connection.</summary>
    /// <returns>A boolean indicating whether the BluetoothLEDevice was paired using a Secure Connection.</returns>
    public extern bool WasSecureConnectionUsedForPairing { [MethodImpl] get; }

    [MethodImpl]
    public extern BluetoothLEConnectionParameters GetConnectionParameters();

    [MethodImpl]
    public extern BluetoothLEConnectionPhy GetConnectionPhy();

    [MethodImpl]
    public extern BluetoothLEPreferredConnectionParametersRequest RequestPreferredConnectionParameters(
      BluetoothLEPreferredConnectionParameters preferredConnectionParameters);

    public extern event TypedEventHandler<BluetoothLEDevice, object> ConnectionParametersChanged;

    public extern event TypedEventHandler<BluetoothLEDevice, object> ConnectionPhyChanged;

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string that contains a query for Bluetooth LE devices that are either paired or unpaired. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects.</summary>
    /// <param name="pairingState">The current pairing state for Bluetooth LE devices used for constructing the AQS string. Bluetooth LE devices can be either paired (true) or unpaired (false). The AQS Filter string will request scanning to be performed when the pairingState is false.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromPairingState(bool pairingState);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string that contains a query for Bluetooth LE devices with the indicated BluetoothConnectionStatus. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects with the indicated Bluetooth connection status.</summary>
    /// <param name="connectionStatus">The connection status used for constructing the AQS string.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromConnectionStatus(
      BluetoothConnectionStatus connectionStatus);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string that contains a query for the Bluetooth LE device name. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects containing the specified Bluetooth LE device name.</summary>
    /// <param name="deviceName">The Bluetooth LE device name used for constructing the AQS string.</param>
    /// <returns>An AQS string that is passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromDeviceName(string deviceName);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string from a 64-bit address that represents a Bluetooth LE device. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects.</summary>
    /// <param name="bluetoothAddress">A 64-bit Bluetooth LE device address used for constructing the AQS string.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [Overload("GetDeviceSelectorFromBluetoothAddress")]
    [MethodImpl]
    public static extern string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string from a 64-bit address and address type that represents a Bluetooth LE device. The AQS string is passed into the CreateWatcher method.</summary>
    /// <param name="bluetoothAddress">A 64-bit Bluetooth LE device address used for constructing the AQS string.</param>
    /// <param name="bluetoothAddressType">The Bluetooth LE device address type.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [Overload("GetDeviceSelectorFromBluetoothAddressWithBluetoothAddressType")]
    [MethodImpl]
    public static extern string GetDeviceSelectorFromBluetoothAddress(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string from a BluetoothLEAppearance object. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects with the specified appearance.</summary>
    /// <param name="appearance">The Bluetooth LE appearance used for constructing the AQS string.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromAppearance(BluetoothLEAppearance appearance);

    /// <summary>Returns a BluetoothLEDevice object representing the peer device with the given address and address type. See **Remarks**.</summary>
    /// <param name="bluetoothAddress">A BluetoothAddress value containing the 64-bit address of the peer Bluetooth LE device.</param>
    /// <param name="bluetoothAddressType">A BluetoothAddressType value containing the address type of the peer Bluetooth LE device.</param>
    /// <returns>Returns an object representing an asynchronous operation. When that object completes, it contains a BluetoothLEDevice object representing the peer device with the given address and address type.</returns>
    [RemoteAsync]
    [Overload("FromBluetoothAddressWithBluetoothAddressTypeAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress,
      BluetoothAddressType bluetoothAddressType);

    /// <summary>Returns a BluetoothLEDevice object for the given Id. See **Remarks**.</summary>
    /// <param name="deviceId">The Id of the Bluetooth LE device.</param>
    /// <returns>After the asynchronous operation completes, returns the BluetoothLEDevice object with the given Id.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothLEDevice> FromIdAsync(
      string deviceId);

    /// <summary>Returns a BluetoothLEDevice object representing the peer Bluetooth LE device with the given address. See **Remarks**.</summary>
    /// <param name="bluetoothAddress">A BluetoothAddress value containing the 64-bit address of the peer Bluetooth LE device.</param>
    /// <returns>Returns an object representing an asynchronous operation. When that object completes, it contains a BluetoothLEDevice object representing the peer Bluetooth LE device with the given address.</returns>
    [RemoteAsync]
    [Overload("FromBluetoothAddressAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothLEDevice> FromBluetoothAddressAsync(
      ulong bluetoothAddress);

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying all Bluetooth Low Energy (LE) devices. This string is passed to the FindAllAsync or CreateWatcher method in order to get a list of Bluetooth LE devices.</summary>
    /// <returns>The device selector for this device.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
