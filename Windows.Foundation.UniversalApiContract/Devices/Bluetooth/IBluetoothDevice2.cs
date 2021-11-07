// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDevice2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(20183380, 45398, 19920, 177, 245, 193, 27, 195, 26, 81, 99)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (BluetoothDevice))]
  internal interface IBluetoothDevice2
  {
    DeviceInformation DeviceInformation { get; }
  }
}
