// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterfaceDescriptorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbInterfaceDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3813318645, 30678, 18614, 176, 190, 22, 198, 66, 35, 22, 254)]
  internal interface IUsbInterfaceDescriptorStatics
  {
    bool TryParse(UsbDescriptor descriptor, out UsbInterfaceDescriptor parsed);

    UsbInterfaceDescriptor Parse(UsbDescriptor descriptor);
  }
}
