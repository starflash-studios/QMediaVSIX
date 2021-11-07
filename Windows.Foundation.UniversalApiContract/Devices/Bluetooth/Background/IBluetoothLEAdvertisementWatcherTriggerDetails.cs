// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IBluetoothLEAdvertisementWatcherTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcherTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2816170711, 8791, 20073, 151, 132, 254, 230, 69, 193, 220, 224)]
  internal interface IBluetoothLEAdvertisementWatcherTriggerDetails
  {
    BluetoothError Error { get; }

    IVectorView<BluetoothLEAdvertisementReceivedEventArgs> Advertisements { get; }

    BluetoothSignalStrengthFilter SignalStrengthFilter { get; }
  }
}
