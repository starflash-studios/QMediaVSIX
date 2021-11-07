// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBluetoothLEAdvertisementWatcherTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcherTrigger))]
  [Guid(447420441, 48353, 18667, 168, 39, 89, 251, 124, 238, 82, 166)]
  internal interface IBluetoothLEAdvertisementWatcherTrigger : IBackgroundTrigger
  {
    TimeSpan MinSamplingInterval { get; }

    TimeSpan MaxSamplingInterval { get; }

    TimeSpan MinOutOfRangeTimeout { get; }

    TimeSpan MaxOutOfRangeTimeout { get; }

    BluetoothSignalStrengthFilter SignalStrengthFilter { get; set; }

    BluetoothLEAdvertisementFilter AdvertisementFilter { get; set; }
  }
}
