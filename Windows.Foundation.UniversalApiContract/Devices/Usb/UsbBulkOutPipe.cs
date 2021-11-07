// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbBulkOutPipe
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  /// <summary>Represents the pipe that the underlying USB driver opens to communicate with a USB bulk OUT endpoint of the device. The object provides access to an output stream to which the app can write data to send to the endpoint.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class UsbBulkOutPipe : IUsbBulkOutPipe
  {
    /// <summary>Gets the object that represents the endpoint descriptor associated with the USB bulk OUT endpoint.</summary>
    /// <returns>A UsbBulkOutEndpointDescriptor that represents the endpoint descriptor associated with the USB bulk OUT endpoint.</returns>
    public extern UsbBulkOutEndpointDescriptor EndpointDescriptor { [MethodImpl] get; }

    /// <summary>Starts an asynchronous operation to clear a stall condition (endpoint halt) on the USB bulk OUT endpoint that is associated with the pipe.</summary>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearStallAsync();

    /// <summary>Gets or sets configuration flags that controls the behavior of the pipe that writes data to a USB bulk IN endpoint.</summary>
    /// <returns>A UsbWriteOptions constant that indicates the pipe policy.</returns>
    public extern UsbWriteOptions WriteOptions { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets an output stream to which the app can write data to send to the endpoint.</summary>
    /// <returns>The output steam that contains the transfer data.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }
  }
}
