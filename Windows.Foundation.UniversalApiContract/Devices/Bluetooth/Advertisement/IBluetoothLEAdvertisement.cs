// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisement
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisement))]
  [Guid(107983543, 13265, 20093, 131, 103, 207, 129, 208, 247, 150, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEAdvertisement
  {
    IReference<BluetoothLEAdvertisementFlags> Flags { get; set; }

    string LocalName { get; set; }

    IVector<Guid> ServiceUuids { get; }

    IVector<BluetoothLEManufacturerData> ManufacturerData { get; }

    IVector<BluetoothLEAdvertisementDataSection> DataSections { get; }

    IVectorView<BluetoothLEManufacturerData> GetManufacturerDataByCompanyId(
      ushort companyId);

    IVectorView<BluetoothLEAdvertisementDataSection> GetSectionsByType(
      byte type);
  }
}
