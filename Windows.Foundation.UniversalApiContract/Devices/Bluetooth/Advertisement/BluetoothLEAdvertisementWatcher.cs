// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>An object to receive Bluetooth Low Energy (LE) advertisements.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IBluetoothLEAdvertisementWatcherFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  public sealed class BluetoothLEAdvertisementWatcher : 
    IBluetoothLEAdvertisementWatcher,
    IBluetoothLEAdvertisementWatcher2
  {
    /// <summary>Creates a new BluetoothLEAdvertisementWatcher object.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisementWatcher();

    /// <summary>Creates a new BluetoothLEAdvertisementWatcher object with an advertisement filter to initialize the watcher.</summary>
    /// <param name="advertisementFilter">The advertisement filter to initialize the watcher.</param>
    [MethodImpl]
    public extern BluetoothLEAdvertisementWatcher(BluetoothLEAdvertisementFilter advertisementFilter);

    /// <summary>Gets the minimum sampling interval.</summary>
    /// <returns>The minimum sampling interval.</returns>
    public extern TimeSpan MinSamplingInterval { [MethodImpl] get; }

    /// <summary>Gets the maximum sampling interval.</summary>
    /// <returns>The maximum sampling interval.</returns>
    public extern TimeSpan MaxSamplingInterval { [MethodImpl] get; }

    /// <summary>Gets the minimum out of range timeout.</summary>
    /// <returns>The minimum out of range timeout.</returns>
    public extern TimeSpan MinOutOfRangeTimeout { [MethodImpl] get; }

    /// <summary>Gets the maximum out of range timeout.</summary>
    /// <returns>The maximum out of range timeout.</returns>
    public extern TimeSpan MaxOutOfRangeTimeout { [MethodImpl] get; }

    /// <summary>Gets the current status of the BluetoothLEAdvertisementWatcher.</summary>
    /// <returns>The current status of the BluetoothLEAdvertisementWatcher.</returns>
    public extern BluetoothLEAdvertisementWatcherStatus Status { [MethodImpl] get; }

    /// <summary>Gets or sets the Bluetooth LE scanning mode.</summary>
    /// <returns>The Bluetooth LE scanning mode.</returns>
    public extern BluetoothLEScanningMode ScanningMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a BluetoothSignalStrengthFilter object used for configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.</summary>
    /// <returns>Configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.</returns>
    public extern BluetoothSignalStrengthFilter SignalStrengthFilter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a BluetoothLEAdvertisementFilter object used for configuration of Bluetooth LE advertisement filtering that uses payload section-based filtering.</summary>
    /// <returns>Configuration of Bluetooth LE advertisement filtering that uses payload section-based filtering.</returns>
    public extern BluetoothLEAdvertisementFilter AdvertisementFilter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Start the BluetoothLEAdvertisementWatcher to scan for Bluetooth LE advertisements.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stop the BluetoothLEAdvertisementWatcher and disable the scanning for Bluetooth LE advertisements.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Notification for new Bluetooth LE advertisement events received.</summary>
    public extern event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementReceivedEventArgs> Received;

    /// <summary>Notification to the app that the Bluetooth LE scanning for advertisements has been cancelled or aborted either by the app or due to an error.</summary>
    public extern event TypedEventHandler<BluetoothLEAdvertisementWatcher, BluetoothLEAdvertisementWatcherStoppedEventArgs> Stopped;

    /// <summary>Enables reception of advertisements using the Extended Advertising format. Defaults to False.</summary>
    /// <returns>Indicates whether advertisements of the Extended Advertising format can be received. The default value is False.</returns>
    public extern bool AllowExtendedAdvertisements { [MethodImpl] get; [MethodImpl] set; }
  }
}
