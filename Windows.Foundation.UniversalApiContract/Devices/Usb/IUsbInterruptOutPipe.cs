// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptOutPipe
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3917793449, 43769, 18896, 185, 108, 246, 97, 171, 74, 127, 149)]
  [ExclusiveTo(typeof (UsbInterruptOutPipe))]
  internal interface IUsbInterruptOutPipe
  {
    UsbInterruptOutEndpointDescriptor EndpointDescriptor { get; }

    [RemoteAsync]
    IAsyncAction ClearStallAsync();

    UsbWriteOptions WriteOptions { set; get; }

    IOutputStream OutputStream { get; }
  }
}
