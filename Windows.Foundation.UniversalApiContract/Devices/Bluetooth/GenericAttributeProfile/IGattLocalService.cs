// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.IGattLocalService
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [ExclusiveTo(typeof (GattLocalService))]
  [Guid(4111721048, 63479, 18690, 184, 3, 87, 252, 199, 214, 254, 131)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IGattLocalService
  {
    Guid Uuid { get; }

    [RemoteAsync]
    IAsyncOperation<GattLocalCharacteristicResult> CreateCharacteristicAsync(
      Guid characteristicUuid,
      GattLocalCharacteristicParameters parameters);

    IVectorView<GattLocalCharacteristic> Characteristics { get; }
  }
}
