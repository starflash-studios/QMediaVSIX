// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbConfigurationDescriptorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbConfigurationDescriptor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1112337811, 59200, 16545, 146, 189, 218, 18, 14, 160, 73, 20)]
  internal interface IUsbConfigurationDescriptorStatics
  {
    bool TryParse(UsbDescriptor descriptor, out UsbConfigurationDescriptor parsed);

    UsbConfigurationDescriptor Parse(UsbDescriptor descriptor);
  }
}
