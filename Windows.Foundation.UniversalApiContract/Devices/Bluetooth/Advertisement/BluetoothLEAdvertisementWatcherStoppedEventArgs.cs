// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcherStoppedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Provides data for a Stopped event on a BluetoothLEAdvertisementWatcher. A BluetoothLEAdvertisementWatcherStoppedEventArgs instance is created when the Stopped event occurs on a BluetoothLEAdvertisementWatcher object.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BluetoothLEAdvertisementWatcherStoppedEventArgs : 
    IBluetoothLEAdvertisementWatcherStoppedEventArgs
  {
    /// <summary>Gets the error status for Stopped event.</summary>
    /// <returns>The error status for Stopped event.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }
  }
}
