// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterruptInPipe
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  /// <summary>Represents the pipe that the underlying USB driver opens to communicate with a USB interrupt IN endpoint of the device. The object also enables the app to specify an event handler. That handler that gets invoked when data is read from the endpoint.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UsbInterruptInPipe : IUsbInterruptInPipe
  {
    /// <summary>Gets the object that represents the endpoint descriptor associated with the USB interrupt IN endpoint.</summary>
    /// <returns>A UsbInterruptInEndpointDescriptor object that represents the endpoint descriptor associated with the USB interrupt IN endpoint.</returns>
    public extern UsbInterruptInEndpointDescriptor EndpointDescriptor { [MethodImpl] get; }

    /// <summary>Starts an asynchronous operation to clear a stall condition (endpoint halt) on the USB interrupt IN endpoint that is associated with the pipe.</summary>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearStallAsync();

    /// <summary>Raised when the interrupt pipe receives data from the interrupt IN endpoint.</summary>
    public extern event TypedEventHandler<UsbInterruptInPipe, UsbInterruptInEventArgs> DataReceived;
  }
}
