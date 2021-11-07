// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceClassesStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(2987066663, 50560, 17817, 161, 101, 152, 27, 79, 208, 50, 48)]
  [ExclusiveTo(typeof (UsbDeviceClasses))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbDeviceClassesStatics
  {
    UsbDeviceClass CdcControl { get; }

    UsbDeviceClass Physical { get; }

    UsbDeviceClass PersonalHealthcare { get; }

    UsbDeviceClass ActiveSync { get; }

    UsbDeviceClass PalmSync { get; }

    UsbDeviceClass DeviceFirmwareUpdate { get; }

    UsbDeviceClass Irda { get; }

    UsbDeviceClass Measurement { get; }

    UsbDeviceClass VendorSpecific { get; }
  }
}
