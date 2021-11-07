// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [Guid(1380563346, 50262, 17621, 173, 94, 36, 245, 160, 137, 246, 59)]
  [ExclusiveTo(typeof (UsbDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbDevice : IClosable
  {
    [Overload("SendControlOutTransferAsync")]
    IAsyncOperation<uint> SendControlOutTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    [Overload("SendControlOutTransferAsyncNoBuffer")]
    IAsyncOperation<uint> SendControlOutTransferAsync(UsbSetupPacket setupPacket);

    [Overload("SendControlInTransferAsync")]
    IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket,
      IBuffer buffer);

    [Overload("SendControlInTransferAsyncNoBuffer")]
    IAsyncOperation<IBuffer> SendControlInTransferAsync(
      UsbSetupPacket setupPacket);

    UsbInterface DefaultInterface { get; }

    UsbDeviceDescriptor DeviceDescriptor { get; }

    UsbConfiguration Configuration { get; }
  }
}
