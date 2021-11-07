// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterruptOutEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>The endpoint descriptor for a USB interrupt OUT endpoint. The descriptor specifies the endpoint type, direction, number and also the maximum number of bytes that can be written to the endpoint, in a single transfer. The app can also get information about how often the host polls the endpoint to send data.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbInterruptOutEndpointDescriptor : IUsbInterruptOutEndpointDescriptor
  {
    /// <summary>Gets the maximum number of bytes that can be sent to or received from this endpoint.</summary>
    /// <returns>Indicates the maximum packet size of the endpoint. This value is the **wMaxPacketSize** field value of the endpoint descriptor. For information, see Table 9-13 in the Universal Serial Bus Specification (version 2.0) or Table 9-18 in the Universal Serial Bus 3.0 Specification.</returns>
    public extern uint MaxPacketSize { [MethodImpl] get; }

    /// <summary>Gets the USB endpoint number of the interrupt OUT endpoint.</summary>
    /// <returns>The USB endpoint number.</returns>
    public extern byte EndpointNumber { [MethodImpl] get; }

    /// <summary>Gets the poling interval of the USB interrupt endpoint.</summary>
    /// <returns>The poling interval of the USB interrupt endpoint.</returns>
    public extern TimeSpan Interval { [MethodImpl] get; }

    /// <summary>Gets the object that represents the pipe that the host opens to communicate with the interrupt OUT endpoint.</summary>
    /// <returns>An UsbInterruptInPipe object that is the pipe for the interrupt OUT endpoint.</returns>
    public extern UsbInterruptOutPipe Pipe { [MethodImpl] get; }
  }
}
