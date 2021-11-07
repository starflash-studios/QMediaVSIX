// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementFilter))]
  [Guid(320778451, 53326, 18353, 131, 126, 73, 64, 91, 246, 248, 15)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEAdvertisementFilter
  {
    BluetoothLEAdvertisement Advertisement { get; set; }

    IVector<BluetoothLEAdvertisementBytePattern> BytePatterns { get; }
  }
}
