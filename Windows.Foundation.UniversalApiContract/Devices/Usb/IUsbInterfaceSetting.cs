// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterfaceSetting
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbInterfaceSetting))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(405257127, 36263, 19191, 143, 76, 127, 48, 50, 231, 129, 245)]
  internal interface IUsbInterfaceSetting
  {
    IVectorView<UsbBulkInEndpointDescriptor> BulkInEndpoints { get; }

    IVectorView<UsbInterruptInEndpointDescriptor> InterruptInEndpoints { get; }

    IVectorView<UsbBulkOutEndpointDescriptor> BulkOutEndpoints { get; }

    IVectorView<UsbInterruptOutEndpointDescriptor> InterruptOutEndpoints { get; }

    bool Selected { get; }

    [RemoteAsync]
    IAsyncAction SelectSettingAsync();

    UsbInterfaceDescriptor InterfaceDescriptor { get; }

    IVectorView<UsbDescriptor> Descriptors { get; }
  }
}
