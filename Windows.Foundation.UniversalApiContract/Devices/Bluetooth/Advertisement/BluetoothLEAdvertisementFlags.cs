// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementFlags
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Defines constants that specify flags used to match flags contained inside a Bluetooth LE advertisement payload.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum BluetoothLEAdvertisementFlags : uint
  {
    /// <summary>Specifies no flag.</summary>
    None = 0,
    /// <summary>Specifies Bluetooth LE Limited Discoverable Mode.</summary>
    LimitedDiscoverableMode = 1,
    /// <summary>Specifies Bluetooth LE General Discoverable Mode.</summary>
    GeneralDiscoverableMode = 2,
    /// <summary>Specifies Bluetooth BR/EDR not supported.</summary>
    ClassicNotSupported = 4,
    /// <summary>Specifies simultaneous Bluetooth LE and BR/EDR to same device capable (controller).</summary>
    DualModeControllerCapable = 8,
    /// <summary>Specifies simultaneous Bluetooth LE and BR/EDR to same device capable (host)</summary>
    DualModeHostCapable = 16, // 0x00000010
  }
}
