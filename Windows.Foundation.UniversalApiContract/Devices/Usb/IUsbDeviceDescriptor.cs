// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbDeviceDescriptor))]
  [Guid(524866038, 47767, 17186, 185, 44, 181, 177, 137, 33, 101, 136)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbDeviceDescriptor
  {
    uint BcdUsb { get; }

    byte MaxPacketSize0 { get; }

    uint VendorId { get; }

    uint ProductId { get; }

    uint BcdDeviceRevision { get; }

    byte NumberOfConfigurations { get; }
  }
}
