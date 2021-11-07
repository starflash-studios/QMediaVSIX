// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice4
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(2172400813, 3740, 17074, 168, 220, 62, 128, 148, 148, 13, 18)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  internal interface IBluetoothDevice4
  {
    BluetoothDeviceId BluetoothDeviceId { get; }
  }
}
