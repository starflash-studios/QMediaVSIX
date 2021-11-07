// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  /// <summary>Represents a Descriptor of a GATT Characteristic. The GattDescriptor object represents a GATT Descriptor of a particular characteristic, and is obtained from the Descriptors property of the GattCharacteristic object.</summary>
  [DualApiPartition(version = 1)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGattDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class GattDescriptor : IGattDescriptor, IGattDescriptor2
  {
    /// <summary>Gets or sets the desired GATT security options for over the air communication with the device.</summary>
    /// <returns>The desired GATT security options for over the air communication with the device.</returns>
    public extern GattProtectionLevel ProtectionLevel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the GATT Descriptor UUID for this GattDescriptor.</summary>
    /// <returns>The GATT Descriptor UUID for this GattDescriptor.</returns>
    public extern Guid Uuid { [MethodImpl] get; }

    /// <summary>Gets the GATT Attribute handle used to uniquely identify this attribute on the GATT Server Device.</summary>
    /// <returns>Handle that uniquely identifies this attribute on the GATT Server Device.</returns>
    public extern ushort AttributeHandle { [MethodImpl] get; }

    /// <summary>Performs a Descriptor Value read from a value cache maintained by Windows.</summary>
    /// <returns>The object required to manage the asynchronous operation, which, upon completion, returns a GattReadResult object, which in turn contains the completion status of the asynchronous operation and, if successful, the data read from the device.</returns>
    [RemoteAsync]
    [Overload("ReadValueAsync")]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync();

    /// <summary>Performs a Descriptor Value read either from the value cache maintained by Windows, or directly from the device.</summary>
    /// <param name="cacheMode">Specifies whether to read the value directly from the device or from a value cache maintained by Windows.</param>
    /// <returns>The object required to manage the asynchronous operation, which, upon completion, returns a GattReadResult object, which in turn contains the completion status of the asynchronous operation and, if successful, the data read from the device.</returns>
    [Overload("ReadValueWithCacheModeAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    /// <summary>Performs a Descriptor Value write to a Bluetooth LE device.</summary>
    /// <param name="value">A Windows.Storage.Streams.IBuffer object which contains the data to be written to the Bluetooth LE device.</param>
    /// <returns>The object that manages the asynchronous operation, which, upon completion, returns the status with which the operation completed.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);

    /// <summary>Performs a Descriptor Value write to a Bluetooth LE device.</summary>
    /// <param name="value">A Windows.Storage.Streams.IBuffer object which contains the data to be written to the Bluetooth LE device.</param>
    /// <returns>An asynchronous operation that completes with the result.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value);

    /// <summary>Converts a Bluetooth SIG defined short Id to a full GATT UUID.</summary>
    /// <deprecated type="deprecate">Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.</deprecated>
    /// <param name="shortId">A 16-bit Bluetooth GATT Descriptor UUID.</param>
    /// <returns>The corresponding 128-bit GATT Descriptor UUID, that uniquely identifies this descriptor.</returns>
    [Deprecated("Use BluetoothUuidHelper instead of ConvertShortIdToUuid.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public static extern Guid ConvertShortIdToUuid(ushort shortId);
  }
}
