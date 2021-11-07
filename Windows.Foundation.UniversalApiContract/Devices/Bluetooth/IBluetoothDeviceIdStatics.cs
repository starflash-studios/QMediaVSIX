// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDeviceIdStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(2810728039, 16123, 20273, 187, 194, 129, 14, 9, 151, 116, 4)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [ExclusiveTo(typeof (BluetoothDeviceId))]
  internal interface IBluetoothDeviceIdStatics
  {
    BluetoothDeviceId FromId(string deviceId);
  }
}
