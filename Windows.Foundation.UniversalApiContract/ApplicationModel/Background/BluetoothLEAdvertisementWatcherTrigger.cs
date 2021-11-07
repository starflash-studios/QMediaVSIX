// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that is registered to scan for Bluetooth LE advertisement in the background.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class BluetoothLEAdvertisementWatcherTrigger : 
    IBluetoothLEAdvertisementWatcherTrigger,
    IBackgroundTrigger,
    IBluetoothLEAdvertisementWatcherTrigger2
  {
    /// <summary>Creates a new instance of the BluetoothLEAdvertisementWatcherTrigger class.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisementWatcherTrigger();

    /// <summary>Gets the minimum sampling interval supported for the SignalStrengthFilter property of this trigger. The minimum sampling interval for the background watcher cannot be zero unlike its foreground counterpart.</summary>
    /// <returns>Gets the minimum sampling interval supported for the SignalStrengthFilter property of this trigger.</returns>
    public extern TimeSpan MinSamplingInterval { [MethodImpl] get; }

    /// <summary>Gets the maximum sampling interval supported for the SignalStrengthFilter property of this trigger. The maximum sampling interval is used to deactivate the sampling filter and only trigger received events based on the device coming in and out of range.</summary>
    /// <returns>The maximum sampling interval supported for the SignalStrengthFilter property of this trigger.</returns>
    public extern TimeSpan MaxSamplingInterval { [MethodImpl] get; }

    /// <summary>Gets the minimum out of range timeout supported for the SignalStrengthFilter property of this trigger.</summary>
    /// <returns>The minimum out of range timeout supported for the SignalStrengthFilter property of this trigger.</returns>
    public extern TimeSpan MinOutOfRangeTimeout { [MethodImpl] get; }

    /// <summary>Gets the maximum out of range timeout supported for the SignalStrengthFilter property of this trigger.</summary>
    /// <returns>The maximum out of range timeout supported for the SignalStrengthFilter property of this trigger.</returns>
    public extern TimeSpan MaxOutOfRangeTimeout { [MethodImpl] get; }

    /// <summary>Gets or sets the configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.</summary>
    /// <returns>The configuration of Bluetooth LE advertisement filtering that uses signal strength-based filtering.</returns>
    public extern BluetoothSignalStrengthFilter SignalStrengthFilter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the configuration of Bluetooth LE advertisement filtering that uses payload section-based filtering.</summary>
    /// <returns>The configuration of Bluetooth LE advertisement filtering that uses payload section-based filtering.</returns>
    public extern BluetoothLEAdvertisementFilter AdvertisementFilter { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Enables reception of advertisements using the Extended Advertising format. Defaults to False.</summary>
    /// <returns>Indicates whether advertisements of the Extended Advertising format can be received. The default value is False.</returns>
    public extern bool AllowExtendedAdvertisements { [MethodImpl] get; [MethodImpl] set; }
  }
}
