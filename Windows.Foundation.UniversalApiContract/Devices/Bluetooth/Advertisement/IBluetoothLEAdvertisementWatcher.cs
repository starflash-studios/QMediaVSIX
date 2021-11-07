// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcher))]
  [Guid(2796303215, 62419, 17047, 141, 108, 200, 30, 166, 98, 63, 64)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IBluetoothLEAdvertisementWatcher
  {
    TimeSpan MinSamplingInterval { get; }

    TimeSpan MaxSamplingInterval { get; }

    TimeSpan MinOutOfRangeTimeout { get; }

    TimeSpan MaxOutOfRangeTimeout { get; }

    BluetoothLEAdvertisementWatcherStatus Status { get; }

    BluetoothLEScanningMode ScanningMode { get; set; }

    BluetoothSignalStrengthFilter SignalStrengthFilter { get; set; }

    BluetoothLEAdvertisementFilter AdvertisementFilter { get; set; }

    void Start();

    void Stop();

    event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementReceivedEventArgs> Received;

    event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementWatcherStoppedEventArgs> Stopped;
  }
}
