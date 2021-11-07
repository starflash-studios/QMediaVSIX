// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [Guid(727732273, 8776, 19247, 172, 240, 124, 238, 54, 252, 88, 112)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  internal interface IBluetoothLEDevice4
  {
    BluetoothDeviceId BluetoothDeviceId { get; }
  }
}
