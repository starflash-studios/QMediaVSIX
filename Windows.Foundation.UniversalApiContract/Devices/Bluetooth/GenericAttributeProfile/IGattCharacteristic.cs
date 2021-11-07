// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristic
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(1506496705, 22836, 20328, 161, 152, 235, 134, 79, 164, 78, 107)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GattCharacteristic))]
  internal interface IGattCharacteristic
  {
    [Deprecated("Use GetDescriptorsForUuidAsync instead of GetDescriptors.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattDescriptor> GetDescriptors(Guid descriptorUuid);

    GattCharacteristicProperties CharacteristicProperties { get; }

    GattProtectionLevel ProtectionLevel { get; set; }

    string UserDescription { get; }

    Guid Uuid { get; }

    ushort AttributeHandle { get; }

    IVectorView<GattPresentationFormat> PresentationFormats { get; }

    [RemoteAsync]
    [Overload("ReadValueAsync")]
    IAsyncOperation<GattReadResult> ReadValueAsync();

    [RemoteAsync]
    [Overload("ReadValueWithCacheModeAsync")]
    IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    [Overload("WriteValueAsync")]
    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);

    [RemoteAsync]
    [Overload("WriteValueWithOptionAsync")]
    IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value,
      GattWriteOption writeOption);

    [RemoteAsync]
    IAsyncOperation<GattReadClientCharacteristicConfigurationDescriptorResult> ReadClientCharacteristicConfigurationDescriptorAsync();

    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> WriteClientCharacteristicConfigurationDescriptorAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);

    event TypedEventHandler<GattCharacteristic, GattValueChangedEventArgs> ValueChanged;
  }
}
