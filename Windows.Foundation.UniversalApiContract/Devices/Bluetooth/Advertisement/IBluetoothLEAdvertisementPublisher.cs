// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementPublisher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3454542073, 55802, 17366, 162, 100, 221, 216, 183, 218, 139, 120)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisher))]
  internal interface IBluetoothLEAdvertisementPublisher
  {
    BluetoothLEAdvertisementPublisherStatus Status { get; }

    BluetoothLEAdvertisement Advertisement { get; }

    void Start();

    void Stop();

    event TypedEventHandler<BluetoothLEAdvertisementPublisher, BluetoothLEAdvertisementPublisherStatusChangedEventArgs> StatusChanged;
  }
}
