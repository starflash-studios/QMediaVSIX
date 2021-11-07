// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbBulkInPipe
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  /// <summary>Represents the pipe that the underlying USB driver opens to communicate with a USB bulk IN endpoint of the device. The app can get an input stream from the pipe and access data is being read from the endpoint.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbBulkInPipe : IUsbBulkInPipe
  {
    /// <summary>Gets the maximum number of bytes that can be read from the bulk IN pipe in a single transfer.</summary>
    /// <returns>The maximum number of bytes that can be read from the bulk IN pipe in a single transfer.</returns>
    public extern uint MaxTransferSizeBytes { [MethodImpl] get; }

    /// <summary>Gets the object that represents endpoint descriptor associated with the USB bulk IN endpoint.</summary>
    /// <returns>A UsbBulkInEndpointDescriptor object that represents endpoint descriptor associated with the USB bulk IN endpoint.</returns>
    public extern UsbBulkInEndpointDescriptor EndpointDescriptor { [MethodImpl] get; }

    /// <summary>Starts an asynchronous operation to clear a stall condition (endpoint halt) on the USB bulk IN endpoint that is associated with the pipe.</summary>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearStallAsync();

    /// <summary>Gets or sets configuration flags that controls the behavior of the pipe that reads data from a USB bulk IN endpoint.</summary>
    /// <returns>A UsbReadOptions value that indicates the pipe policy.</returns>
    public extern UsbReadOptions ReadOptions { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Discards any data that is cached in the bulk IN pipe.</summary>
    [MethodImpl]
    public extern void FlushBuffer();

    /// <summary>Input stream that stores the data that the bulk IN pipe received from the endpoint.</summary>
    /// <returns>Input stream that contains data read from the endpoint.</returns>
    public extern IInputStream InputStream { [MethodImpl] get; }
  }
}
