// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementDataTypes
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.Advertisement
{
  /// <summary>Some of the Bluetooth LE advertisement types defined in the Generic Access Profile (GAP) by the Bluetooth Special Interest Group (SIG).</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBluetoothLEAdvertisementDataTypesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class BluetoothLEAdvertisementDataTypes
  {
    /// <summary>Section data type for a set of flags for internal use.</summary>
    /// <returns>A set of flags for internal use.</returns>
    public static extern byte Flags { [MethodImpl] get; }

    /// <summary>Section data type for an incomplete list of 16-bit Bluetooth LE service UUIDs.</summary>
    /// <returns>An incomplete list of 16-bit Bluetooth LE service UUIDs.</returns>
    public static extern byte IncompleteService16BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for the complete list of 16-bit Bluetooth LE service UUIDs</summary>
    /// <returns>The complete list of 16-bit Bluetooth LE service UUIDs</returns>
    public static extern byte CompleteService16BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for an incomplete list of 32-bit Bluetooth LE service UUIDs.</summary>
    /// <returns>An incomplete list of 32-bit Bluetooth LE service UUIDs.</returns>
    public static extern byte IncompleteService32BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for the complete list of 32-bit Bluetooth LE service UUIDs</summary>
    /// <returns>The complete list of 32-bit Bluetooth LE service UUIDs</returns>
    public static extern byte CompleteService32BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for an incomplete list of 128-bit Bluetooth LE service UUIDs.</summary>
    /// <returns>An incomplete list of 128-bit Bluetooth LE service UUIDs.</returns>
    public static extern byte IncompleteService128BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for the complete list of 128-bit Bluetooth LE service UUIDs</summary>
    /// <returns>The complete list of 128-bit Bluetooth LE service UUIDs</returns>
    public static extern byte CompleteService128BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for a shortened local name.</summary>
    /// <returns>A shortened local name.</returns>
    public static extern byte ShortenedLocalName { [MethodImpl] get; }

    /// <summary>Section data type for the Bluetooth LE complete local name.</summary>
    /// <returns>The Bluetooth LE complete local name.</returns>
    public static extern byte CompleteLocalName { [MethodImpl] get; }

    /// <summary>Section data type for the Bluetooth LE transmit power level.</summary>
    /// <returns>The Bluetooth LE transmit power level.</returns>
    public static extern byte TxPowerLevel { [MethodImpl] get; }

    /// <summary>Section data type for the slave connection interval range.</summary>
    /// <returns>The slave connection interval range.</returns>
    public static extern byte SlaveConnectionIntervalRange { [MethodImpl] get; }

    /// <summary>Section data type for a list of 16-bit Bluetooth LE service solicitation UUIDs.</summary>
    /// <returns>A list of 16-bit Bluetooth LE service solicitation UUIDs.</returns>
    public static extern byte ServiceSolicitation16BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for a list of 32-bit Bluetooth LE service solicitation UUIDs.</summary>
    /// <returns>A list of 32-bit Bluetooth LE service solicitation UUIDs.</returns>
    public static extern byte ServiceSolicitation32BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for a list of 128-bit Bluetooth LE service solicitation UUIDs.</summary>
    /// <returns>A list of 128-bit Bluetooth LE service solicitation UUIDs.</returns>
    public static extern byte ServiceSolicitation128BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for service data for 16-bit Bluetooth LE UUIDs.</summary>
    /// <returns>Service data for 16-bit Bluetooth LE UUIDs.</returns>
    public static extern byte ServiceData16BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for service data for 32-bit Bluetooth LE UUIDs..</summary>
    /// <returns>Service data for 32-bit Bluetooth LE UUIDs.</returns>
    public static extern byte ServiceData32BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for service data for 128-bit Bluetooth LE UUIDs.</summary>
    /// <returns>Service data for 128-bit Bluetooth LE UUIDs.</returns>
    public static extern byte ServiceData128BitUuids { [MethodImpl] get; }

    /// <summary>Section data type for a list of public Bluetooth LE target addresses.</summary>
    /// <returns>A list of public Bluetooth LE target addresses.</returns>
    public static extern byte PublicTargetAddress { [MethodImpl] get; }

    /// <summary>Section data type for a list of random Bluetooth LE target addresses.</summary>
    /// <returns>A list of random Bluetooth LE target addresses.</returns>
    public static extern byte RandomTargetAddress { [MethodImpl] get; }

    /// <summary>Section data type for the Bluetooth LE advertising appearance.</summary>
    /// <returns>The Bluetooth LE advertising appearance.</returns>
    public static extern byte Appearance { [MethodImpl] get; }

    /// <summary>Section data type for the Bluetooth LE advertising interval.</summary>
    /// <returns>The Bluetooth LE advertising interval.</returns>
    public static extern byte AdvertisingInterval { [MethodImpl] get; }

    /// <summary>Section data type for manufacturer-specific data for a Bluetooth LE advertisements.</summary>
    /// <returns>Manufacturer-specific data for a Bluetooth LE advertisements.</returns>
    public static extern byte ManufacturerSpecificData { [MethodImpl] get; }
  }
}
