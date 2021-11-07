// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbBulkInEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>The endpoint descriptor for a USB bulk IN endpoint. The descriptor specifies the endpoint type, direction, number and also the maximum number of bytes that can be read from the endpoint, in a single transfer.</summary>
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UsbBulkInEndpointDescriptor : IUsbBulkInEndpointDescriptor
  {
    /// <summary>Gets the maximum number of bytes that can be sent to or received from this endpoint, in a single packet.</summary>
    /// <returns>Indicates the maximum packet size of the endpoint. This value is derived from the **wMaxPacketSize** field value of the endpoint descriptor. For information, see Table 9-13 in the Universal Serial Bus Specification (version 2.0) or Table 9-18 in the Universal Serial Bus 3.0 Specification.</returns>
    public extern uint MaxPacketSize { [MethodImpl] get; }

    /// <summary>Gets the USB endpoint number of the bulk IN endpoint.</summary>
    /// <returns>The endpoint number of the bulk IN endpoint. That number is in Bit 3...0 of the **bEndpointAddress** field of an endpoint descriptor. For information, see Table 9-13 in the Universal Serial Bus Specification (version 2.0) or Table 9-18 in the Universal Serial Bus 3.0 Specification.</returns>
    public extern byte EndpointNumber { [MethodImpl] get; }

    /// <summary>Gets the object that represents the pipe that the host opens to communicate with the bulk IN endpoint.</summary>
    /// <returns>An UsbBulkInPipe object that is the pipe for the bulk IN endpoint.</returns>
    public extern UsbBulkInPipe Pipe { [MethodImpl] get; }
  }
}
