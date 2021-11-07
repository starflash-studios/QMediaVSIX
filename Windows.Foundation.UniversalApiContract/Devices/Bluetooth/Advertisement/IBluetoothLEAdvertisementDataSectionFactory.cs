// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementDataSectionFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementDataSection))]
  [Guid(3886287170, 43077, 16453, 191, 126, 62, 153, 113, 219, 138, 107)]
  internal interface IBluetoothLEAdvertisementDataSectionFactory
  {
    BluetoothLEAdvertisementDataSection Create(
      byte dataType,
      IBuffer data);
  }
}
