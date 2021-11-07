// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDeviceClass
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(85541625, 33886, 18411, 177, 42, 56, 242, 246, 23, 175, 231)]
  [ExclusiveTo(typeof (UsbDeviceClass))]
  internal interface IUsbDeviceClass
  {
    byte ClassCode { get; set; }

    IReference<byte> SubclassCode { get; set; }

    IReference<byte> ProtocolCode { get; set; }
  }
}
