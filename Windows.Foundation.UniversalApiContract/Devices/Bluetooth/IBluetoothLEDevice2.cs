// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [Guid(653288115, 31470, 19761, 186, 186, 177, 185, 119, 95, 89, 22)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IBluetoothLEDevice2
  {
    DeviceInformation DeviceInformation { get; }

    BluetoothLEAppearance Appearance { get; }

    BluetoothAddressType BluetoothAddressType { get; }
  }
}
