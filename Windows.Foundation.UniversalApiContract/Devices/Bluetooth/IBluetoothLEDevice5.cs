﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.IBluetoothLEDevice5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  [ExclusiveTo(typeof (BluetoothLEDevice))]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [Guid(2640974432, 21127, 17806, 149, 186, 23, 200, 183, 187, 50, 110)]
  internal interface IBluetoothLEDevice5
  {
    bool WasSecureConnectionUsedForPairing { get; }
  }
}