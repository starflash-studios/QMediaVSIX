// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.UsbInterruptOutPipe
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  /// <summary>Represents the pipe that the underlying USB driver opens to communicate with a USB interrupt OUT endpoint of the device. The object provides access to an output stream to which the app can write data to send to the endpoint.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class UsbInterruptOutPipe : IUsbInterruptOutPipe
  {
    /// <summary>Gets the object that represents the endpoint descriptor associated with the USB interrupt OUT endpoint.</summary>
    /// <returns>A UsbInterruptOutEndpointDescriptor object that represents the endpoint descriptor associated with the USB interrupt OUT endpoint.</returns>
    public extern UsbInterruptOutEndpointDescriptor EndpointDescriptor { [MethodImpl] get; }

    /// <summary>Starts an asynchronous operation to clear a stall condition (endpoint halt) on the USB interrupt OUT endpoint that is associated with the pipe.</summary>
    /// <returns>An IAsyncAction object that is used to control the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ClearStallAsync();

    /// <summary>Gets or sets configuration flags that controls the behavior of the pipe that writes data to a USB interrupt OUT endpoint.</summary>
    /// <returns>A UsbWriteOptions constant that indicates the pipe policy.</returns>
    public extern UsbWriteOptions WriteOptions { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets an output stream to which the app can write data to send to the endpoint.</summary>
    /// <returns>Output stream that contains data to write to the endpoint.</returns>
    public extern IOutputStream OutputStream { [MethodImpl] get; }
  }
}
