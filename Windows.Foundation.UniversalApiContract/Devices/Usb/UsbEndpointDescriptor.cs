// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Derives information from the USB endpoint descriptor of the endpoint, such as type, direction, and endpoint number. This object also gets the specific endpoint descriptors based on the type of endpoint. For an explanation of an endpoint descriptor, see Section 9.6.5 in the Universal Serial Bus Specification:</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IUsbEndpointDescriptorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class UsbEndpointDescriptor : IUsbEndpointDescriptor
  {
    /// <summary>Gets the USB endpoint number.</summary>
    /// <returns>The USB endpoint number. That number is in Bit 3...0 of the **bEndpointAddress** field of an endpoint descriptor. For information, see Table 9-13 in the Universal Serial Bus Specification (version 2.0) or Table 9-18 in the Universal Serial Bus 3.0 Specification.</returns>
    public extern byte EndpointNumber { [MethodImpl] get; }

    /// <summary>Gets the direction of the USB endpoint.</summary>
    /// <returns>A UsbTransferDirection value that indicates the direction of the endpoint. This value is Bit 7 of the **bEndpointAddress** field of an endpoint descriptor. For information, see Table 9-13 in the Universal Serial Bus Specification (version 2.0) or Table 9-18 in the Universal Serial Bus 3.0 Specification.</returns>
    public extern UsbTransferDirection Direction { [MethodImpl] get; }

    /// <summary>Gets the type of USB endpoint.</summary>
    /// <returns>A UsbEndpointType constant that indicates the type of USB endpoint. This value is Bit 1...0 of the **bmAttributes** field of an endpoint descriptor. For information, see Table 9-13 in the Universal Serial Bus Specification (version 2.0) or Table 9-18 in the Universal Serial Bus 3.0 Specification.</returns>
    public extern UsbEndpointType EndpointType { [MethodImpl] get; }

    /// <summary>Gets an object that represents the endpoint descriptor for the USB bulk IN endpoint.</summary>
    /// <returns>A UsbBulkInEndpointDescriptor object that describes the USB bulk IN endpoint.</returns>
    public extern UsbBulkInEndpointDescriptor AsBulkInEndpointDescriptor { [MethodImpl] get; }

    /// <summary>Gets an object that represents the endpoint descriptor for the USB interrupt IN endpoint.</summary>
    /// <returns>An UsbInterruptInEndpointDescriptor that describes the USB interrupt IN endpoint.</returns>
    public extern UsbInterruptInEndpointDescriptor AsInterruptInEndpointDescriptor { [MethodImpl] get; }

    /// <summary>Gets an object that represents the endpoint descriptor for the USB bulk OUT endpoint.</summary>
    /// <returns>A UsbBulkOutEndpointDescriptor that describes the USB bulk OUT endpoint.</returns>
    public extern UsbBulkOutEndpointDescriptor AsBulkOutEndpointDescriptor { [MethodImpl] get; }

    /// <summary>Gets an object that represents the endpoint descriptor for the USB interrupt OUT endpoint.</summary>
    /// <returns>An UsbInterruptOutEndpointDescriptor object that describes the interrupt OUT endpoint.</returns>
    public extern UsbInterruptOutEndpointDescriptor AsInterruptOutEndpointDescriptor { [MethodImpl] get; }

    /// <summary>Retrieves the USB endpoint descriptor in a UsbEndpointDescriptor object that is contained in a UsbDescriptor object.</summary>
    /// <param name="descriptor">The UsbDescriptor object to parse.</param>
    /// <param name="parsed">Receives a UsbEndpointDescriptor object.</param>
    /// <returns>True, if the specified UsbDescriptor object is a USB endpoint descriptor. Otherwise, false.</returns>
    [MethodImpl]
    public static extern bool TryParse(UsbDescriptor descriptor, out UsbEndpointDescriptor parsed);

    /// <summary>Parses the specified USB descriptor and returns the USB endpoint descriptor in a UsbEndpointDescriptor object.</summary>
    /// <param name="descriptor">A UsbDescriptor object that contains the USB endpoint descriptor.</param>
    /// <returns>A UsbEndpointDescriptor object that contains the USB endpoint descriptor.</returns>
    [MethodImpl]
    public static extern UsbEndpointDescriptor Parse(UsbDescriptor descriptor);
  }
}
