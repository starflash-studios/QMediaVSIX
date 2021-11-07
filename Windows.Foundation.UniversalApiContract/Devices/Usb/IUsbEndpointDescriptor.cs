// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbEndpointDescriptor))]
  [Guid(1799906009, 36343, 19264, 172, 131, 87, 143, 19, 159, 5, 117)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbEndpointDescriptor
  {
    byte EndpointNumber { get; }

    UsbTransferDirection Direction { get; }

    UsbEndpointType EndpointType { get; }

    UsbBulkInEndpointDescriptor AsBulkInEndpointDescriptor { get; }

    UsbInterruptInEndpointDescriptor AsInterruptInEndpointDescriptor { get; }

    UsbBulkOutEndpointDescriptor AsBulkOutEndpointDescriptor { get; }

    UsbInterruptOutEndpointDescriptor AsInterruptOutEndpointDescriptor { get; }
  }
}
