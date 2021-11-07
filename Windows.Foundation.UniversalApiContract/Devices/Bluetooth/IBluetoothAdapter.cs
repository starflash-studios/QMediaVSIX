// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothAdapter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Radios;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [Guid(2037706828, 24442, 18996, 146, 37, 168, 85, 248, 75, 26, 139)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (BluetoothAdapter))]
  internal interface IBluetoothAdapter
  {
    string DeviceId { get; }

    ulong BluetoothAddress { get; }

    bool IsClassicSupported { get; }

    bool IsLowEnergySupported { get; }

    bool IsPeripheralRoleSupported { get; }

    bool IsCentralRoleSupported { get; }

    bool IsAdvertisementOffloadSupported { get; }

    [RemoteAsync]
    IAsyncOperation<Radio> GetRadioAsync();
  }
}
