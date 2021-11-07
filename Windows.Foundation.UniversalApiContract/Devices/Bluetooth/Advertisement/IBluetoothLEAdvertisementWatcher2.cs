// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementWatcher2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [Guid(29304508, 45412, 22533, 144, 163, 232, 167, 153, 127, 242, 37)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcher))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  internal interface IBluetoothLEAdvertisementWatcher2
  {
    bool AllowExtendedAdvertisements { get; set; }
  }
}
