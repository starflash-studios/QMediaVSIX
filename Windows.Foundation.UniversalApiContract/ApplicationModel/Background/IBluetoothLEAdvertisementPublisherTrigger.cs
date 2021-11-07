// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBluetoothLEAdvertisementPublisherTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2872976914, 9683, 18606, 135, 36, 216, 24, 119, 174, 97, 41)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisherTrigger))]
  internal interface IBluetoothLEAdvertisementPublisherTrigger : IBackgroundTrigger
  {
    BluetoothLEAdvertisement Advertisement { get; }
  }
}
