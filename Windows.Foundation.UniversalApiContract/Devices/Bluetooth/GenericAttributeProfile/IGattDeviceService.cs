// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattDeviceService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattDeviceService))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2893773829, 45884, 18383, 153, 15, 107, 143, 85, 119, 223, 113)]
  internal interface IGattDeviceService : IClosable
  {
    [Deprecated("Use GetCharacteristicsForUuidAsync instead of GetCharacteristics.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattCharacteristic> GetCharacteristics(
      Guid characteristicUuid);

    [Deprecated("Use GetIncludedServicesForUuidAsync instead of GetIncludedServices.  For more information, see MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
    IVectorView<GattDeviceService> GetIncludedServices(Guid serviceUuid);

    string DeviceId { get; }

    Guid Uuid { get; }

    ushort AttributeHandle { get; }
  }
}
