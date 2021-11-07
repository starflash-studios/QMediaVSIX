// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattDeviceService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents a GATT Primary Service on a Bluetooth device. The GattDeviceService class represents a GATT service on a Bluetooth LE device. It is instantiated by using a device service instance path, obtained by finding a device using the Windows.Devices.Enumeration API.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGattDeviceServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGattDeviceServiceStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class GattDeviceService : 
    IGattDeviceService,
    IClosable,
    IGattDeviceService2,
    IGattDeviceService3
  {
    /// <summary>Returns a vector of characteristics, that are identified by the specified UUID and belong to this GattDeviceService instance.</summary>
    /// <deprecated type="deprecate">Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.</deprecated>
    /// <param name="characteristicUuid">The UUID for the characteristics to be retrieved.</param>
    /// <returns>A vector of GattCharacteristic objects whose UUIDs match characteristicUuid.</returns>
    [Deprecated("Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattCharacteristic> GetCharacteristics(
      Guid characteristicUuid);

    /// <summary>Returns a vector of included services, that are identified by the specified UUID and belong to this GattDeviceService instance.</summary>
    /// <deprecated type="deprecate">Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.</deprecated>
    /// <param name="serviceUuid">The UUID for the included services to be retrieved.</param>
    /// <returns>A vector of included services whose UUIDs match serviceUuid.</returns>
    [Deprecated("Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDeviceService> GetIncludedServices(
      Guid serviceUuid);

    /// <summary>Get the string that represents the GATT service instance path used to instantiate the GattDeviceService.</summary>
    /// <returns>String that represents the GATT service instance path used to instantiate the GattDeviceService.</returns>
    public extern string DeviceId { [MethodImpl] get; }

    /// <summary>Gets the GATT Service UUID associated with this **GattDeviceService**.</summary>
    /// <returns>**A 128-bit Bluetooth GATT Service UUID, represented as a standard GUID object.**</returns>
    public extern Guid Uuid { [MethodImpl] get; }

    /// <summary>Gets the handle used to uniquely identify GATT-based service attributes as declared on the Bluetooth LE device.</summary>
    /// <returns>Handle to uniquely identify GATT-based service attributes.</returns>
    public extern ushort AttributeHandle { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets the BluetoothLEDevice object describing the device associated with the current GattDeviceService object.</summary>
    /// <returns>The BluetoothLEDevice object describing the device associated with the current GattDeviceService object.</returns>
    public extern BluetoothLEDevice Device { [Deprecated("Use Session instead of Device property.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the read-only list of parent services for this service.</summary>
    /// <returns>A read-only list of parent services from which this object is derived, if this GattDeviceService is an included service; Otherwise, null.</returns>
    public extern IVectorView<GattDeviceService> ParentServices { [Deprecated("ParentServices may be altered or unavailable in future releases.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    /// <summary>Gets the collection of all characteristics belonging to this GattDeviceService instance.</summary>
    /// <deprecated type="deprecate">Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN.</deprecated>
    /// <returns>The collection of all characteristics belonging to this GattDeviceService instance.</returns>
    [Deprecated("Use GetCharacteristicsAsync instead of GetAllCharacteristics.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattCharacteristic> GetAllCharacteristics();

    /// <summary>Gets the collection of all included services belonging to this GattDeviceService instance.</summary>
    /// <deprecated type="deprecate">Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN.</deprecated>
    /// <returns>The collection of all included services belonging to this GattDeviceService instance.</returns>
    [Deprecated("Use GetIncludedServicesAsync instead of GetAllIncludedServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDeviceService> GetAllIncludedServices();

    /// <summary>Gets the device access information associated with the current GattDeviceService object.</summary>
    /// <returns>The device access information associated with the current GattDeviceService object.</returns>
    public extern DeviceAccessInformation DeviceAccessInformation { [MethodImpl] get; }

    /// <summary>Gets the session for this GATT device service instance.</summary>
    /// <returns>The session for this GATT device service instance.</returns>
    public extern GattSession Session { [MethodImpl] get; }

    /// <summary>Gets the sharing mode for this GATT device service instance.</summary>
    /// <returns>The sharing mode for this GATT device service instance.</returns>
    public extern GattSharingMode SharingMode { [MethodImpl] get; }

    /// <summary>Requests access to the GattDeviceService.</summary>
    /// <returns>An asynchronous operation that completes with a DeviceAccessStatus object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    /// <summary>Opens the GATT device service with the specified sharingMode.</summary>
    /// <param name="sharingMode">The sharing mode.</param>
    /// <returns>An asynchronous operation that completes with a GattOpenStatus object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattOpenStatus> OpenAsync(
      GattSharingMode sharingMode);

    /// <summary>Gets the characterisitics that are part of this GattDeviceService instance.</summary>
    /// <returns>An asynchronous operation that completes with a GattCharacteristicsResult object.</returns>
    [Overload("GetCharacteristicsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync();

    /// <summary>Gets the characterisitics that are part of this GattDeviceService instance.</summary>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>An asynchronous operation that completes with a GattCharacteristicsResult object.</returns>
    [RemoteAsync]
    [Overload("GetCharacteristicsWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Gets the characterisitics that are part of this GattDeviceService instance and associated with the characteristicUuid.</summary>
    /// <param name="characteristicUuid">The UUID for the characteristics to be retrieved.</param>
    /// <returns>An asynchronous operation that completes with a GattCharacteristicsResult object.</returns>
    [Overload("GetCharacteristicsForUuidAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid);

    /// <summary>Gets the characterisitics that are part of this GattDeviceService instance and associated with the characteristicUuid.</summary>
    /// <param name="characteristicUuid">The UUID for the characteristics to be retrieved.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>An asynchronous operation that completes with a GattCharacteristicsResult object.</returns>
    [RemoteAsync]
    [Overload("GetCharacteristicsForUuidWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid,
      BluetoothCacheMode cacheMode);

    /// <summary>Gets the included services that are associated with this GattDeviceService instance.</summary>
    /// <returns>An asynchronous operation that completes with a GattDeviceServicesResult object.</returns>
    [Overload("GetIncludedServicesAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync();

    /// <summary>Gets the included services that are associated with this GattDeviceService instance.</summary>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>An asynchronous operation that completes with a GattDeviceServicesResult object.</returns>
    [Overload("GetIncludedServicesWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Gets the included services from the serviceUuid that is associated with this GattDeviceService instance.</summary>
    /// <param name="serviceUuid">A 128-bit Bluetooth GATT Service UUID, represented as a standard GUID object.</param>
    /// <returns>An asynchronous operation that completes with a GattDeviceServicesResult object.</returns>
    [RemoteAsync]
    [Overload("GetIncludedServicesForUuidAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid);

    /// <summary>Gets the included services from the serviceUuid that is associated with this GattDeviceService instance.</summary>
    /// <param name="serviceUuid">A 128-bit Bluetooth GATT Service UUID, represented as a standard GUID object.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>An asynchronous operation that completes with a GattDeviceServicesResult object.</returns>
    [RemoteAsync]
    [Overload("GetIncludedServicesForUuidWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);

    /// <summary>Instantiates a new GattDeviceService object from the device ID.</summary>
    /// <param name="deviceId">The GATT device ID.</param>
    /// <param name="sharingMode">The sharing mode of the GATT device.</param>
    /// <returns>An asynchronous operation that completes with a GattDeviceService object.</returns>
    [Overload("FromIdWithSharingModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<GattDeviceService> FromIdAsync(
      string deviceId,
      GattSharingMode sharingMode);

    /// <summary>Creates a suitable AQS Filter string for use with the CreateWatcher method, from a BluetoothDeviceId.</summary>
    /// <param name="bluetoothDeviceId">The bluetooth device ID.</param>
    /// <returns>A suitable AQS Selector String which can be passed as a parameter to the CreateWatcher method, in order to retrieve a GATT service instance path</returns>
    [Overload("GetDeviceSelectorForBluetoothDeviceId")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceId(
      BluetoothDeviceId bluetoothDeviceId);

    /// <summary>Creates a suitable AQS Filter string for use with the CreateWatcher method, from a BluetoothDeviceId.</summary>
    /// <param name="bluetoothDeviceId">The bluetooth device ID.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>A suitable AQS Selector String which can be passed as a parameter to the CreateWatcher method, in order to retrieve a GATT service instance path</returns>
    [Overload("GetDeviceSelectorForBluetoothDeviceIdWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceId(
      BluetoothDeviceId bluetoothDeviceId,
      BluetoothCacheMode cacheMode);

    /// <summary>Creates a suitable AQS Filter string for use with the CreateWatcher method, from a BluetoothDeviceId and serviceUuid.</summary>
    /// <param name="bluetoothDeviceId">The bluetooth device ID.</param>
    /// <param name="serviceUuid">The GATT service ID.</param>
    /// <returns>A suitable AQS Selector String which can be passed as a parameter to the CreateWatcher method, in order to retrieve a GATT service instance path</returns>
    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuid")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid);

    /// <summary>Creates a suitable AQS Filter string for use with the CreateWatcher method, from a BluetoothDeviceId and serviceUuid.</summary>
    /// <param name="bluetoothDeviceId">The bluetooth device ID.</param>
    /// <param name="serviceUuid">The GATT service ID.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>A suitable AQS Selector String which can be passed as a parameter to the CreateWatcher method, in order to retrieve a GATT service instance path</returns>
    [Overload("GetDeviceSelectorForBluetoothDeviceIdAndUuidWithCacheMode")]
    [MethodImpl]
    public static extern string GetDeviceSelectorForBluetoothDeviceIdAndUuid(
      BluetoothDeviceId bluetoothDeviceId,
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);

    /// <summary>Instantiates a new GattDeviceService from the device ID.</summary>
    /// <param name="deviceId">The GATT device ID.</param>
    /// <returns>The object for managing the asynchronous operation, which, upon completion, returns the newly instantiated GattDeviceService.</returns>
    [RemoteAsync]
    [Overload("FromIdAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<GattDeviceService> FromIdAsync(
      string deviceId);

    /// <summary>Creates a suitable AQS Filter string for use with the CreateWatcher method, from a Bluetooth service UUID.</summary>
    /// <param name="serviceUuid">A 128-bit Bluetooth GATT Service UUID, represented as a standard GUID object.</param>
    /// <returns>A suitable AQS Selector String which can be passed as a parameter to the CreateWatcher method, in order to retrieve a GATT service instance path.</returns>
    [MethodImpl]
    public static extern string GetDeviceSelectorFromUuid(Guid serviceUuid);

    /// <summary>Creates a suitable AQS Filter string for use with the CreateWatcher method, from a 16-bit Bluetooth GATT Service UUID.</summary>
    /// <deprecated type="deprecate">Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.</deprecated>
    /// <param name="serviceShortId">A 16-bit Bluetooth GATT Service UUID.</param>
    /// <returns>A suitable AQS Selector String which can be passed as a parameter to the CreateWatcher method, in order to retrieve a GATT service instance path</returns>
    [Deprecated("Use GetDeviceSelectorFromUuid instead of GetDeviceSelectorFromShortId.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern string GetDeviceSelectorFromShortId(ushort serviceShortId);

    /// <summary>Converts a Bluetooth SIG defined short Id to a full GATT UUID.</summary>
    /// <deprecated type="deprecate">Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.</deprecated>
    /// <param name="shortId">A 16-bit Bluetooth GATT Service UUID.</param>
    /// <returns>The corresponding 128-bit GATT Service UUID, that uniquely identifies this service.</returns>
    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern Guid ConvertShortIdToUuid(ushort shortId);
  }
}
