﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.IBluetoothLEAdvertisementPublisherTriggerDetails2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  [ExclusiveTo(typeof (BluetoothLEAdvertisementPublisherTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 655360)]
  [Guid(3567505445, 50689, 17110, 152, 41, 76, 203, 63, 92, 215, 127)]
  internal interface IBluetoothLEAdvertisementPublisherTriggerDetails2
  {
    IReference<short> SelectedTransmitPowerLevelInDBm { get; }
  }
}