﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementPublisherFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1549731422, 47203, 18817, 161, 175, 28, 84, 77, 139, 12, 13)]
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisher))]
  internal interface IBluetoothLEAdvertisementPublisherFactory
  {
    BluetoothLEAdvertisementPublisher Create(
      BluetoothLEAdvertisement advertisement);
  }
}