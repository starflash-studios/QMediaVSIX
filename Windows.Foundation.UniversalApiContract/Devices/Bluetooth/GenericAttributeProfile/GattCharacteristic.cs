// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents a Characteristic of a GATT service. The GattCharacteristic object represents a GATT Characteristic of a particular service, and is obtained from the Characteristics property of the GattDeviceService object.</summary>
  [Static(typeof (IGattCharacteristicStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattCharacteristic : 
    IGattCharacteristic,
    IGattCharacteristic2,
    IGattCharacteristic3
  {
    /// <summary>Returns a vector of descriptors, that are identified by the specified UUID, and belong to this GattCharacteristic instance.</summary>
    /// <deprecated type="deprecate">Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.</deprecated>
    /// <param name="descriptorUuid">The UUID for the descriptors to be retrieved.</param>
    /// <returns>A vector of descriptors whose UUIDs match descriptorUuid.</returns>
    [Deprecated("Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDescriptor> GetDescriptors(
      Guid descriptorUuid);

    /// <summary>Gets the GATT characteristic properties, as defined by the GATT profile.</summary>
    /// <returns>The GATT characteristic properties, as defined by the GATT profile.</returns>
    public extern GattCharacteristicProperties CharacteristicProperties { [MethodImpl] get; }

    /// <summary>Gets or sets the desired GATT security options for over the air communication with the device.</summary>
    /// <returns>The desired GATT security options for over the air communication with the device.</returns>
    public extern GattProtectionLevel ProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Get the user friendly description for this GattCharacteristic, if the User Description Descriptor is present, otherwise this will be an empty string.</summary>
    /// <returns>The user friendly description for this GattCharacteristic, if the User Description Descriptor is present, otherwise this will be an empty string.</returns>
    public extern string UserDescription { [MethodImpl] get; }

    /// <summary>Gets the GATT Characteristic UUID for this GattCharacteristic.</summary>
    /// <returns>The GATT Characteristic UUID for this GattCharacteristic.</returns>
    public extern Guid Uuid { [MethodImpl] get; }

    /// <summary>Gets the handle used to uniquely identify GATT-based characteristic attributes as declared on the Bluetooth LE device.</summary>
    /// <returns>Handle that uniquely identifies GATT-based characteristic attributes.</returns>
    public extern ushort AttributeHandle { [MethodImpl] get; }

    /// <summary>Gets the list of presentation format descriptors associated with this GattCharacteristic, in the order specified by the Aggregate Format Descriptor.</summary>
    /// <returns>An array of GattPresentationFormat objects that contain the list of presentation format descriptors associated with this GattCharacteristic, in the order specified by the Aggregate Format Descriptor.</returns>
    public extern IVectorView<GattPresentationFormat> PresentationFormats { [MethodImpl] get; }

    /// <summary>Performs a Characteristic Value read from the value cache maintained by Windows.</summary>
    /// <returns>The object required to manage the asynchronous operation, which, upon completion, returns a GattReadResult object, which in turn contains the completion status of the asynchronous operation and, if successful, the data read from the device.</returns>
    [RemoteAsync]
    [Overload("ReadValueAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync();

    /// <summary>Performs a Characteristic Value read either from the value cache maintained by Windows, or directly from the device.</summary>
    /// <param name="cacheMode">Specifies whether to read the value directly from the device or from a value cache maintained by Windows.</param>
    /// <returns>The object required to manage the asynchronous operation, which, upon completion, returns a GattReadResult object, which in turn contains the completion status of the asynchronous operation and, if successful, the data read from the device.</returns>
    [RemoteAsync]
    [Overload("ReadValueWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Performs a Characteristic Value write to a Bluetooth LE device.</summary>
    /// <param name="value">A Windows.Storage.Streams.IBuffer object which contains the data to be written to the Bluetooth LE device.</param>
    /// <returns>The object that manages the asynchronous operation, which, upon completion, returns the status with which the operation completed.</returns>
    [Overload("WriteValueAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);

    /// <summary>Performs a Characteristic Value write to a Bluetooth LE device.</summary>
    /// <param name="value">A Windows.Storage.Streams.IBuffer object which contains the data to be written to the Bluetooth LE device.</param>
    /// <param name="writeOption">Specifies what type of GATT write should be performed.</param>
    /// <returns>The object that manages the asynchronous operation, which, upon completion, returns the status with which the operation completed.</returns>
    [RemoteAsync]
    [Overload("WriteValueWithOptionAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value,
      GattWriteOption writeOption);

    /// <summary>Reads the current value of the ClientCharacteristicConfigurationDescriptor.</summary>
    /// <returns>The object that manages the asynchronous operation. Upon completion of the asynchronous method, the IAsyncOperation(GattReadClientCharacteristicConfigurationDescriptorResult) contains the result of the read operation, which contains the status of completed operation. The Status property on the GattReadClientCharacteristicConfigurationDescriptorResult returned indicates if the result of the operation was successful.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattReadClientCharacteristicConfigurationDescriptorResult> ReadClientCharacteristicConfigurationDescriptorAsync();

    /// <summary>Writes the ClientCharacteristicConfigurationDescriptor to the Bluetooth LE device, and if the value to be written represents an indication or a notification and a ValueChanged event handler is registered, enables receiving ValueChanged events from the device.</summary>
    /// <param name="clientCharacteristicConfigurationDescriptorValue">Specifies a new value for the ClientCharacteristicConfigurationDescriptor of this Characteristic object.</param>
    /// <returns>The object that manages the asynchronous operation, which, upon completion, returns the status with which the operation completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteClientCharacteristicConfigurationDescriptorAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);

    /// <summary>An App can register an event handler in order to receive events when notification or indications are received from a device, after setting the Client Characteristic Configuration Descriptor.</summary>
    public extern event TypedEventHandler<GattCharacteristic, GattValueChangedEventArgs> ValueChanged;

    /// <summary>Gets the GattDeviceService of which this characteristic is a member.</summary>
    /// <returns>The GattDeviceService of which this characteristic is a member.</returns>
    public extern GattDeviceService Service { [MethodImpl] get; }

    /// <summary>Gets the collection of all descriptors belonging to this GattCharacteristic instance.</summary>
    /// <deprecated type="deprecate">Use GetDescriptorsAsync instead of GetAllDescriptors.  For more information, see MSDN.</deprecated>
    /// <returns>The collection of all descriptors belonging to this GattCharacteristic instance.</returns>
    [Deprecated("Use GetDescriptorsAsync instead of GetAllDescriptors.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern IVectorView<GattDescriptor> GetAllDescriptors();

    /// <summary>Returns the descriptors for this GattCharacteristic instance.</summary>
    /// <returns>An asynchronous operation that completes with the descriptors for this GattCharacteristic instance.</returns>
    [RemoteAsync]
    [Overload("GetDescriptorsAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync();

    /// <summary>Returns the descriptors with the specified cache mode for this GattCharacteristic instance.</summary>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>An asynchronous operation that completes with the descriptors.</returns>
    [Overload("GetDescriptorsWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Returns the descriptors whose UUIDs match descriptorUuid.</summary>
    /// <param name="descriptorUuid">The UUID for the descriptors to be retrieved.</param>
    /// <returns>An asynchronous operation that completes with the descriptors whose UUIDs match descriptorUuid.</returns>
    [RemoteAsync]
    [Overload("GetDescriptorsForUuidAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid);

    /// <summary>Returns the descriptors whose UUIDs match descriptorUuid with the specified cacheMode.</summary>
    /// <param name="descriptorUuid">The UUID for the descriptors to be retrieved.</param>
    /// <param name="cacheMode">The cache mode.</param>
    /// <returns>Returns an asynchronous operation that completes with the descriptors for the descriptorUuid.</returns>
    [RemoteAsync]
    [Overload("GetDescriptorsForUuidWithCacheModeAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid,
      BluetoothCacheMode cacheMode);

    /// <summary>Performs a Characteristic Value write to a Bluetooth LE device.</summary>
    /// <param name="value">A Windows.Storage.Streams.IBuffer object which contains the data to be written to the Bluetooth LE device.</param>
    /// <returns>An asynchronous operation that completes with a GattWriteResult object.</returns>
    [Overload("WriteValueWithResultAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value);

    /// <summary>Performs a Characteristic Value write to a Bluetooth LE device.</summary>
    /// <param name="value">A Windows.Storage.Streams.IBuffer object which contains the data to be written to the Bluetooth LE device.</param>
    /// <param name="writeOption">Specifies what type of GATT write should be performed.</param>
    /// <returns>An asynchronous operation that completes with a GattWriteResult object.</returns>
    [Overload("WriteValueWithResultAndOptionAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value,
      GattWriteOption writeOption);

    /// <summary>Writes the ClientCharacteristicConfigurationDescriptor to the Bluetooth LE device, and if the value to be written represents an indication or a notification and a ValueChanged event handler is registered, enables receiving ValueChanged events from the device.</summary>
    /// <param name="clientCharacteristicConfigurationDescriptorValue">Specifies a new value for the ClientCharacteristicConfigurationDescriptor of this Characteristic object.</param>
    /// <returns>Returns an asynchronous operation that completes with a GattWriteResult object.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteClientCharacteristicConfigurationDescriptorWithResultAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);

    /// <summary>Converts a Bluetooth SIG defined short Id to a full GATT UUID.</summary>
    /// <deprecated type="deprecate">Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.</deprecated>
    /// <param name="shortId">A 16-bit Bluetooth GATT Service UUID.</param>
    /// <returns>The corresponding 128-bit GATT Characteristic UUID, that uniquely identifies this characteristic.</returns>
    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern Guid ConvertShortIdToUuid(ushort shortId);
  }
}
