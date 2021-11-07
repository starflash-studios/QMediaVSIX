// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothDeviceId
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothDeviceId))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3245951407, 22465, 17986, 188, 206, 230, 192, 107, 32, 174, 118)]
  internal interface IBluetoothDeviceId
  {
    string Id { get; }

    bool IsClassicDevice { get; }

    bool IsLowEnergyDevice { get; }
  }
}
