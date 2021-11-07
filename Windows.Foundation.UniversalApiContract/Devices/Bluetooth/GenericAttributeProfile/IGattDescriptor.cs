// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2449825579, 32900, 17220, 180, 194, 40, 77, 225, 154, 133, 6)]
  [ExclusiveTo(typeof (GattDescriptor))]
  internal interface IGattDescriptor
  {
    GattProtectionLevel ProtectionLevel { get; set; }

    Guid Uuid { get; }

    ushort AttributeHandle { get; }

    [RemoteAsync]
    [Overload("ReadValueAsync")]
    IAsyncOperation<GattReadResult> ReadValueAsync();

    [Overload("ReadValueWithCacheModeAsync")]
    [RemoteAsync]
    IAsyncOperation<GattReadResult> ReadValueAsync(
      BluetoothCacheMode cacheMode);

    [RemoteAsync]
    IAsyncOperation<GattCommunicationStatus> WriteValueAsync(
      IBuffer value);
  }
}
