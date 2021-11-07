// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementReceivedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Provides data for a Received event on a BluetoothLEAdvertisementWatcher. A BluetoothLEAdvertisementReceivedEventArgs instance is created when the Received event occurs on a BluetoothLEAdvertisementWatcher object.</summary>
  [DualApiPartition(version = 1)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BluetoothLEAdvertisementReceivedEventArgs : 
    IBluetoothLEAdvertisementReceivedEventArgs,
    IBluetoothLEAdvertisementReceivedEventArgs2
  {
    /// <summary>Gets the received signal strength indicator (RSSI) value, in dBm, for this received Bluetooth LE advertisement event. This value could be the raw RSSI or a filtered RSSI depending on filtering settings configured through BluetoothSignalStrengthFilter.</summary>
    /// <returns>The received signal strength indicator (RSSI) value, in dBm, for this event.</returns>
    public extern short RawSignalStrengthInDBm { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth address of the device sending the Bluetooth LE advertisement.</summary>
    /// <returns>the Bluetooth address of the device sending the Bluetooth LE advertisement.</returns>
    public extern ulong BluetoothAddress { [MethodImpl] get; }

    /// <summary>Gets the type of the received Bluetooth LE advertisement packet.</summary>
    /// <returns>the type of the received Bluetooth LE advertisement packet.</returns>
    public extern BluetoothLEAdvertisementType AdvertisementType { [MethodImpl] get; }

    /// <summary>Gets the timestamp when the Received event occurred.</summary>
    /// <returns>The timestamp when the Received event occurred.</returns>
    public extern DateTime Timestamp { [MethodImpl] get; }

    /// <summary>Gets the Bluetooth LE advertisement payload data received.</summary>
    /// <returns>The Bluetooth LE advertisement payload data received.</returns>
    public extern BluetoothLEAdvertisement Advertisement { [MethodImpl] get; }

    /// <summary>Retrieves the Bluetooth Address Type of the received advertisement.</summary>
    /// <returns>The Bluetooth Address Type of the advertisement. If the advertisement is anonymous, the type returned is `Unspecified`.</returns>
    public extern BluetoothAddressType BluetoothAddressType { [MethodImpl] get; }

    /// <summary>Represents the received transmit power of the advertisement.</summary>
    /// <returns>The received transmit power of the advertisement. Ranges from -127 dBm to 20dBM.</returns>
    public extern IReference<short> TransmitPowerLevelInDBm { [MethodImpl] get; }

    /// <summary>Indicates whether a Bluetooth Address was omitted from the received advertisement.</summary>
    /// <returns>Indicates whether the advertisement was sent anonymously.</returns>
    public extern bool IsAnonymous { [MethodImpl] get; }

    /// <summary>Indicates whether the received advertisement is connectable.</summary>
    /// <returns>Indicates whether the advertisement is connectable. Returns True if it is, otherwise, returns False.</returns>
    public extern bool IsConnectable { [MethodImpl] get; }

    /// <summary>Indicates whether the received advertisement is scannable.</summary>
    /// <returns>Indicates whether the advertisement is scannable. Returns True if it is, otherwise, returns False.</returns>
    public extern bool IsScannable { [MethodImpl] get; }

    /// <summary>Indicates whether the received advertisement is directed.</summary>
    /// <returns>Indicates whether the advertisement is directed. Returns True if it is, otherwise, returns False.</returns>
    public extern bool IsDirected { [MethodImpl] get; }

    /// <summary>Indicates whether the received advertisement is a scan response.</summary>
    /// <returns>Indicates whether the advertisement is a scan response. Returns True if it is, otherwise, returns False.</returns>
    public extern bool IsScanResponse { [MethodImpl] get; }
  }
}
