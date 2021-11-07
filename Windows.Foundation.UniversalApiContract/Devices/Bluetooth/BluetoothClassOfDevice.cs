// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.BluetoothClassOfDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth
{
  /// <summary>Provides functionality to determine the Bluetooth Class Of Device (Bluetooth COD) information for a device.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 1)]
  [Static(typeof (IBluetoothClassOfDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class BluetoothClassOfDevice : IBluetoothClassOfDevice
  {
    /// <summary>Gets the Bluetooth Class Of Device information, represented as an integer value.</summary>
    /// <returns>The Bluetooth Class Of Device information, represented as a raw integer value.</returns>
    public extern uint RawValue { [MethodImpl] get; }

    /// <summary>Gets the Major Class code of the Bluetooth device.</summary>
    /// <returns>One of the enumeration values that specifies the device's Major Class code.</returns>
    public extern BluetoothMajorClass MajorClass { [MethodImpl] get; }

    /// <summary>Gets the Minor Class code of the device.</summary>
    /// <returns>One of the enumeration values that specifies the device's Minor Class code.</returns>
    public extern BluetoothMinorClass MinorClass { [MethodImpl] get; }

    /// <summary>Gets the service capabilities of the device.</summary>
    /// <returns>One of the enumeration values that specifies the service capabilities of the device.</returns>
    public extern BluetoothServiceCapabilities ServiceCapabilities { [MethodImpl] get; }

    /// <summary>Creates a BluetoothClassOfDevice object from a raw integer value representing the Major Class, Minor Class and Service Capabilities of the device.</summary>
    /// <param name="rawValue">The raw integer value from which to create the BluetoothClassOfDevice object.</param>
    /// <returns>A BluetoothClassOfDevice object.</returns>
    [MethodImpl]
    public static extern BluetoothClassOfDevice FromRawValue(uint rawValue);

    /// <summary>Creates a BluetoothClassOfDevice object by supplying values for BluetoothMajorClass, BluetoothMinorClass and BluetoothClassOfDevice.</summary>
    /// <param name="majorClass">One of the enumeration values that specifies the device's main function.</param>
    /// <param name="minorClass">One of the enumeration values that specifies the minor class value to be used.</param>
    /// <param name="serviceCapabilities">One of the enumeration values that specifies the service the device supports.</param>
    /// <returns>A BluetoothClassOfDevice object.</returns>
    [MethodImpl]
    public static extern BluetoothClassOfDevice FromParts(
      BluetoothMajorClass majorClass,
      BluetoothMinorClass minorClass,
      BluetoothServiceCapabilities serviceCapabilities);
  }
}
