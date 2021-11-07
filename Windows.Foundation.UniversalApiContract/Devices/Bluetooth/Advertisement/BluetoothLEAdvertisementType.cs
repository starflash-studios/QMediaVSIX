// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Specifies the different types of Bluetooth LE advertisement payloads.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothLEAdvertisementType
  {
    /// <summary>The advertisement is undirected and indicates that the device is connectable and scannable. This advertisement type can carry data.</summary>
    ConnectableUndirected,
    /// <summary>The advertisement is directed and indicates that the device is connectable but not scannable. This advertisement type cannot carry data.</summary>
    ConnectableDirected,
    /// <summary>The advertisement is undirected and indicates that the device is scannable but not connectable. This advertisement type can carry data.</summary>
    ScannableUndirected,
    /// <summary>The advertisement is undirected and indicates that the device is not connectable nor scannable. This advertisement type can carry data.</summary>
    NonConnectableUndirected,
    /// <summary>This advertisement is a scan response to a scan request issued for a scannable advertisement. This advertisement type can carry data.</summary>
    ScanResponse,
    /// <summary>This advertisement is a 5.0 extended advertisement. This advertisement type may have different properties, and is not necessarily directed, connected, scannable, nor a scan response.</summary>
    [ContractVersion("Windows.Foundation.UniversalApiContract", 655360)] Extended,
  }
}
