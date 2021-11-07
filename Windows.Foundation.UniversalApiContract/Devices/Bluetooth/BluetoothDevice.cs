// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Rfcomm;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Represents a Bluetooth device.</summary>
  [Static(typeof (IBluetoothDeviceStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBluetoothDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothDevice : 
    IBluetoothDevice,
    IBluetoothDevice2,
    IBluetoothDevice3,
    IBluetoothDevice4,
    IBluetoothDevice5,
    IClosable
  {
    /// <summary>Gets the device ID that came from the Windows.Devices.Enumeration.DeviceInformation.Id</summary>
    /// <returns>The ID of the device.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the HostName of the device.</summary>
    /// <returns>The HostName of the device.</returns>
    public extern HostName HostName { [MethodImpl] get; }

    /// <summary>Gets the Name of the device.</summary>
    /// <returns>The name of the device.</returns>
    public extern string Name { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth Class Of Device information of the device.</summary>
    /// <returns>The Bluetooth Class Of Device information of the device.</returns>
    public extern BluetoothClassOfDevice ClassOfDevice { [MethodImpl] get; }

    /// <summary>Gets the read-only list of Service Discovery Protocol (SDP) records for the device.</summary>
    /// <returns>The read-only list of Service Discovery Protocol (SDP) records for the device.</returns>
    public extern IVectorView<IBuffer> SdpRecords { [MethodImpl] get; }

    /// <summary>Gets the read-only list of RFCOMM services supported by the device.</summary>
    /// <returns>The read-only list of RFCOMM services supported by the device.</returns>
    public extern IVectorView<RfcommDeviceService> RfcommServices { [Deprecated("Use GetRfcommServicesAsync instead of RfcommServices.  For more info, see MSDN.", DeprecationType.Deprecate, 196608, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the connection status of the device.</summary>
    /// <returns>One of the BluetoothConnectionStatus enumeration values that specifies the connection status of the device.</returns>
    public extern BluetoothConnectionStatus ConnectionStatus { [MethodImpl] get; }

    /// <summary>Gets the device address.</summary>
    /// <returns>The device address.</returns>
    public extern ulong BluetoothAddress { [MethodImpl] get; }

    /// <summary>Occurs when the name of the device has changed.</summary>
    public extern event TypedEventHandler<BluetoothDevice, object> NameChanged;

    /// <summary>Occurs when the list SDP records for the device has changed.</summary>
    public extern event TypedEventHandler<BluetoothDevice, object> SdpRecordsChanged;

    /// <summary>Occurs when the connection status of the device has changed.</summary>
    public extern event TypedEventHandler<BluetoothDevice, object> ConnectionStatusChanged;

    /// <summary>Gets the DeviceInformation object for the Bluetooth device.</summary>
    /// <returns>The device information.</returns>
    public extern DeviceInformation DeviceInformation { [MethodImpl] get; }

    /// <summary>The current **DeviceAccessInformation** object for the device. Used to check and monitor access changes to the device.</summary>
    /// <returns>The current **DeviceAccessInformation** object for the device.</returns>
    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    /// <summary>Used to request explicit access to the Bluetooth device. This invokes Device Consent and must be called on the UI thread.</summary>
    /// <returns>After the asynchronous operation completes, returns a DeviceAccessStatus enumeration value.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    /// <summary>Retrieves all Rfcomm Services on the remote Bluetooth Device.</summary>
    /// <returns>After the asynchronous operation completes, returns a RfcommDeviceServicesResult object.</returns>
    [RemoteAsync]
    [Overload("GetRfcommServicesAsync")]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync();

    /// <summary>Retrieves all cached Rfcomm Services on the remote Bluetooth Device.</summary>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>After the asynchronous operation completes, returns a RfcommDeviceServicesResult object.</returns>
    [RemoteAsync]
    [Overload("GetRfcommServicesWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Retrieves all Rfcomm Services on the Remote Bluetooth Device matching the specified RfcommServiceId.</summary>
    /// <param name="serviceId">The Rfcomm service id.</param>
    /// <returns>After the asynchronous operation completes, returns an RfcommDeviceServicesResult object.</returns>
    [RemoteAsync]
    [Overload("GetRfcommServicesForIdAsync")]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId);

    /// <summary>Retrieves all cached Rfcomm Services on the Remote Bluetooth Device matching the specified RfcommServiceId.</summary>
    /// <param name="serviceId">The Rfcomm service id.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>After the asynchronous operation completes, returns an RfcommDeviceServicesResult object.</returns>
    [Overload("GetRfcommServicesForIdWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<RfcommDeviceServicesResult> GetRfcommServicesForIdAsync(
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);

    /// <summary>Gets the bluetooth device ID.</summary>
    /// <returns>The bluetooth device ID.</returns>
    public extern BluetoothDeviceId BluetoothDeviceId { [MethodImpl] get; }

    /// <summary>Gets a boolean indicating whether the BluetoothDevice was paired using a Secure Connection.</summary>
    /// <returns>A boolean indicating whether the BluetoothDevice was paired using a Secure Connection.</returns>
    public extern bool WasSecureConnectionUsedForPairing { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string that contains a query for Bluetooth devices that are either paired or unpaired. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects.</summary>
    /// <param name="pairingState">The current pairing state for Bluetooth devices used for constructing the AQS string. Bluetooth devices can be either paired (true) or unpaired (false). The AQS Filter string will request scanning to be performed when the pairingState is false.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromPairingState(bool pairingState);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string that contains a query for Bluetooth devices with the indicated BluetoothConnectionStatus. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects with the indicated Bluetooth connection status.</summary>
    /// <param name="connectionStatus">The connection status used for constructing the AQS string.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromConnectionStatus(
      BluetoothConnectionStatus connectionStatus);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string that contains a query for the Bluetooth device name. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects containing the specified Bluetooth device name.</summary>
    /// <param name="deviceName">The Bluetooth device name used for constructing the AQS string.</param>
    /// <returns>An AQS string that is passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromDeviceName(string deviceName);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string from a 64-bit address that represents a Bluetooth device. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects.</summary>
    /// <param name="bluetoothAddress">A 64-bit Bluetooth device address used for constructing the AQS string.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromBluetoothAddress(ulong bluetoothAddress);

    /// <summary>Creates an Advanced Query Syntax (AQS) filter string from a BluetoothClassOfDevice object. The AQS string is passed into the CreateWatcher method to return a collection of DeviceInformation objects.</summary>
    /// <param name="classOfDevice">The class of device used for constructing the AQS string.</param>
    /// <returns>An AQS string that can be passed as a parameter to the CreateWatcher method.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromClassOfDevice(
      BluetoothClassOfDevice classOfDevice);

    /// <summary>Returns a BluetoothDevice object identified by the given DeviceId.</summary>
    /// <param name="deviceId">The DeviceId value that identifies the BluetoothDevice instance.</param>
    /// <returns>After the asynchronous operation completes, returns the BluetoothDevice object identified by the given DeviceId.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothDevice> FromIdAsync(
      string deviceId);

    /// <summary>Returns a BluetoothDevice object identified by the given HostName.</summary>
    /// <param name="hostName">The HostName that identifies the BluetoothDevice instance.</param>
    /// <returns>After the asynchronous operation completes, returns the BluetoothDevice object identified by the given HostName.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothDevice> FromHostNameAsync(
      HostName hostName);

    /// <summary>Returns a BluetoothDevice object for the given BluetoothAddress.</summary>
    /// <param name="address">The address of the Bluetooth device.</param>
    /// <returns>After the asynchronous operation completes, returns the BluetoothDevice object with the given BluetoothAddress or null if the address does not resolve to a valid device.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BluetoothDevice> FromBluetoothAddressAsync(
      ulong address);

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying instances of this device. This string is passed to the FindAllAsync or CreateWatcher method.</summary>
    /// <returns>The device selector for this device.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
