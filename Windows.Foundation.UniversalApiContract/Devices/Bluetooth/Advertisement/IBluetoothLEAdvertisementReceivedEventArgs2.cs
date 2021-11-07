// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementReceivedEventArgs2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementReceivedEventArgs))]
  [Guid(316262523, 921, 24334, 163, 72, 83, 176, 43, 107, 22, 46)]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IBluetoothLEAdvertisementReceivedEventArgs2
  {
    BluetoothAddressType BluetoothAddressType { get; }

    IReference<short> TransmitPowerLevelInDBm { get; }

    bool IsAnonymous { get; }

    bool IsConnectable { get; }

    bool IsScannable { get; }

    bool IsDirected { get; }

    bool IsScanResponse { get; }
  }
}
