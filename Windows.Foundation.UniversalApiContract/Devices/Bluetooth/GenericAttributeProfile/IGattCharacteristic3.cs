// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattCharacteristic3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattCharacteristic))]
  [Guid(1060922942, 37844, 16491, 184, 23, 219, 129, 248, 237, 83, 179)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattCharacteristic3
  {
    [RemoteAsync]
    [Overload("GetDescriptorsAsync")]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync();

    [RemoteAsync]
    [Overload("GetDescriptorsWithCacheModeAsync")]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetDescriptorsForUuidAsync")]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid);

    [Overload("GetDescriptorsForUuidWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDescriptorsResult> GetDescriptorsForUuidAsync(
      Guid descriptorUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("WriteValueWithResultAsync")]
    IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value);

    [Overload("WriteValueWithResultAndOptionAsync")]
    [RemoteAsync]
    IAsyncOperation<GattWriteResult> WriteValueWithResultAsync(
      IBuffer value,
      GattWriteOption writeOption);

    [RemoteAsync]
    IAsyncOperation<GattWriteResult> WriteClientCharacteristicConfigurationDescriptorWithResultAsync(
      GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue);
  }
}
