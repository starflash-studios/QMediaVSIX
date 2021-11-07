// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Represents the possible states of the BluetoothLEAdvertisementWatcher.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BluetoothLEAdvertisementWatcherStatus
  {
    /// <summary>The initial status of the watcher.</summary>
    Created,
    /// <summary>The watcher is started.</summary>
    Started,
    /// <summary>The watcher stop command was issued.</summary>
    Stopping,
    /// <summary>The watcher is stopped.</summary>
    Stopped,
    /// <summary>An error occurred during transition or scanning that stopped the watcher due to an error.</summary>
    Aborted,
  }
}
