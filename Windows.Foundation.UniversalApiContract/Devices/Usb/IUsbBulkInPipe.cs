// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkInPipe
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbBulkInPipe))]
  [Guid(4028443963, 17736, 19792, 179, 38, 216, 44, 218, 190, 18, 32)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbBulkInPipe
  {
    uint MaxTransferSizeBytes { get; }

    UsbBulkInEndpointDescriptor EndpointDescriptor { get; }

    [RemoteAsync]
    IAsyncAction ClearStallAsync();

    UsbReadOptions ReadOptions { set; get; }

    void FlushBuffer();

    IInputStream InputStream { get; }
  }
}
