// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Rfcomm.RfcommDeviceService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;
using Windows.Networking.Sockets;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Rfcomm
{
  /// <summary>Represents an instance of a service on a Bluetooth BR device.</summary>
  [DualApiPartition(version = 1)]
  [Static(typeof (IRfcommDeviceServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IRfcommDeviceServiceStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RfcommDeviceService : 
    IRfcommDeviceService,
    IRfcommDeviceService2,
    IClosable,
    IRfcommDeviceService3
  {
    /// <summary>Gets the connection host name of the RFCOMM service instance, which is used to connect to the remote device.</summary>
    /// <returns>The HostName object of the RFCOMM service instance.</returns>
    public extern HostName ConnectionHostName { [MethodImpl] get; }

    /// <summary>Gets the connection service name of the RFCOMM service instance, which is used to connect to the remote device.</summary>
    /// <returns>The ServiceName object of the RFCOMM service instance.</returns>
    public extern string ConnectionServiceName { [MethodImpl] get; }

    /// <summary>Gets the RfcommServiceId of this RFCOMM service instance.</summary>
    /// <returns>The RfcommServiceId of the RFCOMM service instance.</returns>
    public extern RfcommServiceId ServiceId { [MethodImpl] get; }

    /// <summary>Gets the current SocketProtectionLevel of the RFCOMM service instance.</summary>
    /// <returns>The current SocketProtectionLevel of the remote RFCOMM service instance.</returns>
    public extern SocketProtectionLevel ProtectionLevel { [MethodImpl] get; }

    /// <summary>Gets the maximum SocketProtectionLevel supported by this RFCOMM service instance.</summary>
    /// <returns>The maximum SocketProtectionLevel of the RFCOMM service instance. This level can be passed to StreamSocket.ConnectAsync to upgrade the RFCOMM link protection level.</returns>
    public extern SocketProtectionLevel MaxProtectionLevel { [MethodImpl] get; }

    /// <summary>Gets the cached SDP attributes of the RFCOMM service instance.</summary>
    /// <returns>The SDP attributes of the RFCOMM service instance.</returns>
    [Overload("GetSdpRawAttributesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync();

    /// <summary>Gets the SDP attributes of the RFCOMM service instance.</summary>
    /// <param name="cacheMode">Indicates whether SDP attributes should be retrieved from the cache or from the device.</param>
    /// <returns>The SDP attributes of the RFCOMM service instance.</returns>
    [Overload("GetSdpRawAttributesWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IMapView<uint, IBuffer>> GetSdpRawAttributesAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Gets the BluetoothDevice object describing the device associated with the current RfcommDeviceService object.</summary>
    /// <returns>The BluetoothDevice object describing the device associated with the current RfcommDeviceService object.</returns>
    public extern BluetoothDevice Device { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>The device access information. Used to check and monitor access.</summary>
    /// <returns>Gets the current DeviceAccessInformation for the service.</returns>
    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    /// <summary>Used to request explicit access to the Rfcomm service. This invokes Device Consent and must be called on the UI thread. By default, unpaired devices do not require consent, while paired devices do. FromIdAsync will only display a consent prompt when called for a paired device. RequestAccessAsync allows the app to make the access request explicit in the event where the device may become paired in the future through other uses of the device.</summary>
    /// <returns>After the async operation completes, returns a DeviceAccessStatus object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying instances of all Rfcomm services on a remote Bluetooth device.</summary>
    /// <param name="bluetoothDevice">The remote bluetooth device.</param>
    /// <returns>The AQS string for identifying instances of all Rfcomm services on a remote Bluetooth device.</returns>
    [Overload("GetDeviceSelectorForBluetoothDevice")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDevice(BluetoothDevice bluetoothDevice);

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying cached instances of all Rfcomm services on a remote Bluetooth device.</summary>
    /// <param name="bluetoothDevice">The remote Bluetooth device.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>The AQS string for identifying cached instances of all Rfcomm services on a remote Bluetooth device.</returns>
    [Overload("GetDeviceSelectorForBluetoothDeviceWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDevice(
      BluetoothDevice bluetoothDevice,
      BluetoothCacheMode cacheMode);

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying instances of Rfcomm services on a remote Bluetooth device.</summary>
    /// <param name="bluetoothDevice">The remote Bluetooth device.</param>
    /// <param name="serviceId">The service ID.</param>
    /// <returns>The AQS string for identifying instances of Rfcomm services.</returns>
    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceId")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying instances of Rfcomm services on a remote Bluetooth device.</summary>
    /// <param name="bluetoothDevice">The remote bluetooth device.</param>
    /// <param name="serviceId">The service ID.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>The AQS string for identifying instances of Rfcomm services.</returns>
    [Overload("GetDeviceSelectorForBluetoothDeviceAndServiceIdWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceAndServiceId(
      BluetoothDevice bluetoothDevice,
      RfcommServiceId serviceId,
      BluetoothCacheMode cacheMode);

    /// <summary>Gets an RfcommDeviceService object from a DeviceInformation Id for an RFCOMM service instance.</summary>
    /// <param name="deviceId">The DeviceInformation Id that identifies the RFCOMM service instance. This id can be retrieved from Windows.Devices.Enumeration.</param>
    /// <returns>The RfcommDeviceService object that represents the RFCOMM service instance.</returns>
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<RfcommDeviceService> FromIdAsync(
      string deviceId);

    /// <summary>Gets an Advanced Query Syntax (AQS) string for identifying instances of an RFCOMM service. This string is passed to the CreateWatcher method.</summary>
    /// <param name="serviceId">The service id for which to query.</param>
    /// <returns>An AQS string for identifying RFCOMM service instances.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelector(RfcommServiceId serviceId);
  }
}
