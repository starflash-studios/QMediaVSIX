// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BluetoothLEAdvertisementPublisherTrigger
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  /// <summary>Represents a trigger that is registered to advertise a Bluetooth LE advertisement in the background.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class BluetoothLEAdvertisementPublisherTrigger : 
    IBluetoothLEAdvertisementPublisherTrigger,
    IBackgroundTrigger,
    IBluetoothLEAdvertisementPublisherTrigger2
  {
    /// <summary>Creates a new instance of the BluetoothLEAdvertisementPublisherTrigger class.</summary>
    [MethodImpl]
    public extern BluetoothLEAdvertisementPublisherTrigger();

    /// <summary>Gets the Bluetooth LE advertisement to configure and publish in the background.</summary>
    /// <returns>The Bluetooth LE advertisement to configure and publish in the background.</returns>
    public extern BluetoothLEAdvertisement Advertisement { [MethodImpl] get; }

    /// <summary>If specified, requests that the radio use the indicated transmit power level for the advertisement. Defaults to Null.</summary>
    /// <returns>The requested power level for the radio transmission. The default is Null.</returns>
    public extern IReference<short> PreferredTransmitPowerLevelInDBm { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies that the advertisement publisher should use the Extended Advertising format.</summary>
    /// <returns>Indicates whether or not the Extended Advertising format should be used. The default value is False.</returns>
    public extern bool UseExtendedFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether or not the device address is included in the advertisement header. By default, the address is included.</summary>
    /// <returns>Indicates whether the device address is hidden. The default value is False, indicating that the address is included.</returns>
    public extern bool IsAnonymous { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether the transmit power level is included in the advertisement header. Defaults to False.</summary>
    /// <returns>Indicates whether the transmit power level is included. The default value is False.</returns>
    public extern bool IncludeTransmitPowerLevel { [MethodImpl] get; [MethodImpl] set; }
  }
}
