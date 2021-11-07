// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothClassOfDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothClassOfDevice))]
  [Guid(3594527358, 55255, 18017, 148, 84, 101, 3, 156, 161, 122, 43)]
  internal interface IBluetoothClassOfDevice
  {
    uint RawValue { get; }

    BluetoothMajorClass MajorClass { get; }

    BluetoothMinorClass MinorClass { get; }

    BluetoothServiceCapabilities ServiceCapabilities { get; }
  }
}
