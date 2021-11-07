// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbEndpointDescriptorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbEndpointDescriptor))]
  [Guid(3364925953, 39530, 18782, 168, 44, 41, 91, 158, 112, 129, 6)]
  internal interface IUsbEndpointDescriptorStatics
  {
    bool TryParse(UsbDescriptor descriptor, out UsbEndpointDescriptor parsed);

    UsbEndpointDescriptor Parse(UsbDescriptor descriptor);
  }
}
