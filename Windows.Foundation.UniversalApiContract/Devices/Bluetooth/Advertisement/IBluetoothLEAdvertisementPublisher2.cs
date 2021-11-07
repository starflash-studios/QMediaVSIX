// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementPublisher2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(4225455198, 22257, 20751, 164, 52, 33, 127, 189, 158, 123, 210)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisher))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IBluetoothLEAdvertisementPublisher2
  {
    IReference<short> PreferredTransmitPowerLevelInDBm { get; set; }

    bool UseExtendedAdvertisement { get; set; }

    bool IsAnonymous { get; set; }

    bool IncludeTransmitPowerLevel { get; set; }
  }
}
