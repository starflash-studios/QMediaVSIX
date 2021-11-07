// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDeviceClasses
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Provides a way for the app to create a UsbDeviceClass object by specifying the USB device class of the device. The properties defined in this class represent the supported USB device classes and are passed in the constructor call to instantiate UsbDeviceClass. For information about USB device classes, see the official USB Website for  Approved Class Specification Documents.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IUsbDeviceClassesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbDeviceClasses : IUsbDeviceClasses
  {
    /// <summary>Gets the device class object for the device that conforms to the Communication Device Class (CDC).</summary>
    /// <returns>A UsbDeviceClass object for the CDC-compliant device.</returns>
    public static extern UsbDeviceClass CdcControl { [MethodImpl] get; }

    /// <summary>Gets the device class object for a device that conforms to the Physical Interface Devices (PID) specification.</summary>
    /// <returns>A UsbDeviceClass object for a PID-compliant device.</returns>
    public static extern UsbDeviceClass Physical { [MethodImpl] get; }

    /// <summary>Gets the device class object for a device that conforms to the USB Personal Healthcare Device Class (PHDC).</summary>
    /// <returns>A UsbDeviceClass object for a PHDC-compliant healthcare device.</returns>
    public static extern UsbDeviceClass PersonalHealthcare { [MethodImpl] get; }

    /// <summary>Gets the device class object for the device that conforms to the Active Sync device class.</summary>
    /// <returns>A UsbDeviceClass object for the Active Sync device class.</returns>
    public static extern UsbDeviceClass ActiveSync { [MethodImpl] get; }

    /// <summary>Gets the device class object for the device that conforms to the Palm Sync device class.</summary>
    /// <returns>A UsbDeviceClass object for the Palm Sync device class.</returns>
    public static extern UsbDeviceClass PalmSync { [MethodImpl] get; }

    /// <summary>Gets the device class object for the device that conforms to the Device Firmware Update device class.</summary>
    /// <returns>A UsbDeviceClass object for the Device Firmware Update device class.</returns>
    public static extern UsbDeviceClass DeviceFirmwareUpdate { [MethodImpl] get; }

    /// <summary>Gets the device class object for an infrared transceiver that conforms to the IrDA class defined as per the IrDA Bridge Device Definition 1.0 specification.</summary>
    /// <returns>A UsbDeviceClass object for the IrDA class.</returns>
    public static extern UsbDeviceClass Irda { [MethodImpl] get; }

    /// <summary>Gets the device class object for a device that conforms to the USB test and measurement class (USBTMC).</summary>
    /// <returns>A UsbDeviceClass object for the USBTMC-compliant device.</returns>
    public static extern UsbDeviceClass Measurement { [MethodImpl] get; }

    /// <summary>Gets the device class object for a custom device that has 0xFF class code. This indicates that the device does not belong to a class approved by USB-IF.</summary>
    /// <returns>A UsbDeviceClass object for a custom device.</returns>
    public static extern UsbDeviceClass VendorSpecific { [MethodImpl] get; }
  }
}
