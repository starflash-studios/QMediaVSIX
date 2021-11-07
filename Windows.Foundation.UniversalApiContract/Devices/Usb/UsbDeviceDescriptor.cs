// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbDeviceDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Derives information from the USB device descriptor of the device. For an explanation of the device descriptor, see Table 9.8 in the Universal Serial Bus Specification.</summary>
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbDeviceDescriptor : IUsbDeviceDescriptor
  {
    /// <summary>Gets the **bcdUSB** field of the USB device descriptor. The value indicates the version of the USB specification to which the device conforms.</summary>
    /// <returns>The version of the USB specification to which the device conforms.</returns>
    public extern uint BcdUsb { [MethodImpl] get; }

    /// <summary>Gets the **bMaxPacketSize0** field of the USB device descriptor. The value indicates the maximum packet size, in bytes, for endpoint zero of the device. This value can be 8, 16, 32, or 64.</summary>
    /// <returns>The maximum packet size, in bytes, for endpoint zero of the device.</returns>
    public extern byte MaxPacketSize0 { [MethodImpl] get; }

    /// <summary>Gets the **idVendor** field of the USB device descriptor. The value indicates the vendor identifier for the device as assigned by the USB specification committee.</summary>
    /// <returns>The vendor identifier for the device as assigned by the USB specification committee.</returns>
    public extern uint VendorId { [MethodImpl] get; }

    /// <summary>Gets the **idProduct** field of the USB device descriptor. This value indicates the device-specific product identifier and is assigned by the manufacturer.</summary>
    /// <returns>The device-defined product identifier.</returns>
    public extern uint ProductId { [MethodImpl] get; }

    /// <summary>Gets the **bcdDeviceRevision** field of the USB device descriptor. The value indicates the revision number defined by the device and is a binary-coded decimal number.</summary>
    /// <returns>The revision number defined by the device.</returns>
    public extern uint BcdDeviceRevision { [MethodImpl] get; }

    /// <summary>Gets the **bNumConfigurations** field of the USB device descriptor. The value indicates the total count of USB configurations supported by the device.</summary>
    /// <returns>A number that indicates the total count of USB configurations supported by the device.</returns>
    public extern byte NumberOfConfigurations { [MethodImpl] get; }
  }
}
