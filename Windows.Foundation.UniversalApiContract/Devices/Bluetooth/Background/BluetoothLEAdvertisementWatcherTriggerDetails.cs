// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Background.BluetoothLEAdvertisementWatcherTriggerDetails
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Background
{
  /// <summary>Provides information about a BluetoothLEAdvertisementWatcher trigger. You can obtain an instance of this class through a BluetoothLEAdvertisementWatcher trigger.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothLEAdvertisementWatcherTriggerDetails : 
    IBluetoothLEAdvertisementWatcherTriggerDetails
  {
    /// <summary>Gets the error status for the trigger.</summary>
    /// <returns>The error status for the trigger.</returns>
    public extern BluetoothError Error { [MethodImpl] get; }

    /// <summary>Gets a collection of Bluetooth LE advertisements.</summary>
    /// <returns>A collection of Bluetooth LE advertisements.</returns>
    public extern IVectorView<BluetoothLEAdvertisementReceivedEventArgs> Advertisements { [MethodImpl] get; }

    /// <summary>Gets the parameters used to configure received signal strength indicator (RSSI)-based filtering.</summary>
    /// <returns>The parameters used to configure received signal strength indicator (RSSI)-based filtering.</returns>
    public extern BluetoothSignalStrengthFilter SignalStrengthFilter { [MethodImpl] get; }
  }
}
