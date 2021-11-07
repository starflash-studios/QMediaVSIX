// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEScanningMode
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Defines constants that specify a Bluetooth LE scanning mode.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothLEScanningMode
  {
    /// <summary>Specifies a passive scanning mode. This is the default scanning mode.</summary>
    Passive,
    /// <summary>Specifies an active scanning mode. This indicates that scan request packets will be sent from the platform to actively query for more advertisement data of type BluetoothLEAdvertisementType.ScanResponse.</summary>
    Active,
    /// <summary>Specifies no scanning mode. The watcher will provide advertisements as the system receives them, but will not initiate its own scanning.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] None,
  }
}
