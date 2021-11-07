// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkOutEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbBulkOutEndpointDescriptor))]
  [Guid(673219706, 65518, 20320, 155, 225, 149, 108, 172, 62, 203, 101)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbBulkOutEndpointDescriptor
  {
    uint MaxPacketSize { get; }

    byte EndpointNumber { get; }

    UsbBulkOutPipe Pipe { get; }
  }
}
