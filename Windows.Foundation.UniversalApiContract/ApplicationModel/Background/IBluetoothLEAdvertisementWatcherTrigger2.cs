// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBluetoothLEAdvertisementWatcherTrigger2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(968189849, 60217, 23222, 153, 50, 170, 158, 69, 73, 96, 77)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementWatcherTrigger))]
  internal interface IBluetoothLEAdvertisementWatcherTrigger2
  {
    bool AllowExtendedAdvertisements { get; set; }
  }
}
