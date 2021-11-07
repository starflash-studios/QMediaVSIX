// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbBulkInEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1013860422, 1743, 17065, 157, 194, 151, 28, 27, 20, 182, 227)]
  [ExclusiveTo(typeof (UsbBulkInEndpointDescriptor))]
  internal interface IUsbBulkInEndpointDescriptor
  {
    uint MaxPacketSize { get; }

    byte EndpointNumber { get; }

    UsbBulkInPipe Pipe { get; }
  }
}
