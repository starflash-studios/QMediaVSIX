// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkOutPipe
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbBulkOutPipe))]
  [Guid(2833903214, 277, 17834, 139, 33, 55, 178, 37, 188, 206, 231)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbBulkOutPipe
  {
    UsbBulkOutEndpointDescriptor EndpointDescriptor { get; }

    [RemoteAsync]
    IAsyncAction ClearStallAsync();

    UsbWriteOptions WriteOptions { set; get; }

    IOutputStream OutputStream { get; }
  }
}
