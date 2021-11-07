// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(107709858, 2487, 17478, 133, 2, 111, 230, 220, 170, 115, 9)]
  [ExclusiveTo(typeof (UsbDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbDeviceStatics
  {
    [Overload("GetDeviceSelector")]
    string GetDeviceSelector(uint vendorId, uint productId, Guid winUsbInterfaceClass);

    [Overload("GetDeviceSelectorGuidOnly")]
    string GetDeviceSelector(Guid winUsbInterfaceClass);

    [Overload("GetDeviceSelectorVidPidOnly")]
    string GetDeviceSelector(uint vendorId, uint productId);

    string GetDeviceClassSelector(UsbDeviceClass usbClass);

    [RemoteAsync]
    IAsyncOperation<UsbDevice> FromIdAsync(string deviceId);
  }
}
