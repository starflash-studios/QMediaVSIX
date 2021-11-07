// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEManufacturerData
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(2435693080, 26979, 17715, 176, 97, 70, 148, 218, 251, 52, 229)]
  [ExclusiveTo(typeof (BluetoothLEManufacturerData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEManufacturerData
  {
    ushort CompanyId { get; set; }

    IBuffer Data { get; set; }
  }
}
