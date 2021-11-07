// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementBytePatternFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3269610867, 64860, 20163, 190, 42, 156, 166, 250, 17, 183, 189)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementBytePattern))]
  internal interface IBluetoothLEAdvertisementBytePatternFactory
  {
    BluetoothLEAdvertisementBytePattern Create(
      byte dataType,
      short offset,
      IBuffer data);
  }
}
