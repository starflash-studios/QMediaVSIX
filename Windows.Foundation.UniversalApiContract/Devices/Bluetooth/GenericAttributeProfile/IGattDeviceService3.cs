// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService3
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [Guid(2996021584, 3155, 17276, 169, 179, 92, 50, 16, 198, 229, 105)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (GattDeviceService))]
  internal interface IGattDeviceService3
  {
    DeviceAccessInformation DeviceAccessInformation { get; }

    GattSession Session { get; }

    GattSharingMode SharingMode { get; }

    [RemoteAsync]
    IAsyncOperation<DeviceAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    IAsyncOperation<GattOpenStatus> OpenAsync(
      GattSharingMode sharingMode);

    [RemoteAsync]
    [Overload("GetCharacteristicsAsync")]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync();

    [Overload("GetCharacteristicsWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetCharacteristicsForUuidAsync")]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid);

    [RemoteAsync]
    [Overload("GetCharacteristicsForUuidWithCacheModeAsync")]
    IAsyncOperation<GattCharacteristicsResult> GetCharacteristicsForUuidAsync(
      Guid characteristicUuid,
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetIncludedServicesAsync")]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync();

    [RemoteAsync]
    [Overload("GetIncludedServicesWithCacheModeAsync")]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    [Overload("GetIncludedServicesForUuidAsync")]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid);

    [Overload("GetIncludedServicesForUuidWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattDeviceServicesResult> GetIncludedServicesForUuidAsync(
      Guid serviceUuid,
      BluetoothCacheMode cacheMode);
  }
}
