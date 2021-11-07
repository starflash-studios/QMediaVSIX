// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>An object to send Bluetooth Low Energy (LE) advertisements.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IBluetoothLEAdvertisementPublisherFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class BluetoothLEAdvertisementPublisher : 
    IBluetoothLEAdvertisementPublisher,
    IBluetoothLEAdvertisementPublisher2
  {
    /// <summary>Creates a new BluetoothLEAdvertisementPublisher object.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisementPublisher();

    /// <summary>Creates a new BluetoothLEAdvertisementPublisher object with the Bluetooth LE advertisement to publish.</summary>
    /// <param name="advertisement">The Bluetooth LE advertisement to publish.</param>
    [MethodImpl]
    public extern BluetoothLEAdvertisementPublisher(BluetoothLEAdvertisement advertisement);

    /// <summary>Gets the current status of the BluetoothLEAdvertisementPublisher.</summary>
    /// <returns>The current status of the BluetoothLEAdvertisementPublisher.</returns>
    public extern BluetoothLEAdvertisementPublisherStatus Status { [MethodImpl] get; }

    /// <summary>Gets a copy of the Bluetooth LE advertisement to publish.</summary>
    /// <returns>A copy of the Bluetooth LE advertisement to publish.</returns>
    public extern BluetoothLEAdvertisement Advertisement { [MethodImpl] get; }

    /// <summary>Start advertising a Bluetooth LE advertisement payload.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stop the publisher and stop advertising a Bluetooth LE advertisement payload.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>Notification that the status of the BluetoothLEAdvertisementPublisher has changed.</summary>
    public extern event TypedEventHandler<BluetoothLEAdvertisementPublisher, BluetoothLEAdvertisementPublisherStatusChangedEventArgs> StatusChanged;

    /// <summary>If specified, requests that the radio use the indicated transmit power level for the advertisement. Defaults to Null.</summary>
    /// <returns>The requested power level for the radio transmission. The default is Null.</returns>
    public extern IReference<short> PreferredTransmitPowerLevelInDBm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies that the advertisement publisher should use the Extended Advertising format.</summary>
    /// <returns>Indicates whether or not the Extended Advertising format should be used. The default value is False.</returns>
    public extern bool UseExtendedAdvertisement { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether or not the device address is included in the advertisement header. By default, the address is included.</summary>
    /// <returns>Indicates whether the device address is hidden. The default value is False, indicating that the address is included.</returns>
    public extern bool IsAnonymous { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether the transmit power level is included in the advertisement header. Defaults to False.</summary>
    /// <returns>Indicates whether the transmit power level is included. The default value is False.</returns>
    public extern bool IncludeTransmitPowerLevel { [MethodImpl] get; [MethodImpl] set; }
  }
}
