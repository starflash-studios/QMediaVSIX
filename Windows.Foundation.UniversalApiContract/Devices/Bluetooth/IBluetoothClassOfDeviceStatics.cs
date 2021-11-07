// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothClassOfDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3831575997, 4002, 16748, 145, 180, 193, 228, 140, 160, 97, 193)]
  [ExclusiveTo(typeof (BluetoothClassOfDevice))]
  internal interface IBluetoothClassOfDeviceStatics
  {
    BluetoothClassOfDevice FromRawValue(uint rawValue);

    BluetoothClassOfDevice FromParts(
      BluetoothMajorClass majorClass,
      BluetoothMinorClass minorClass,
      BluetoothServiceCapabilities serviceCapabilities);
  }
}
