// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(664305119, 58774, 16830, 141, 67, 158, 103, 49, 212, 169, 19)]
  internal interface IBluetoothLEAdvertisementReceivedEventArgs
  {
    short RawSignalStrengthInDBm { get; }

    ulong BluetoothAddress { get; }

    BluetoothLEAdvertisementType AdvertisementType { get; }

    DateTime Timestamp { get; }

    BluetoothLEAdvertisement Advertisement { get; }
  }
}
