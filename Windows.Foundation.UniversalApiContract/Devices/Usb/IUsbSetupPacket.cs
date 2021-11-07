// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbSetupPacket
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ExclusiveTo(typeof (UsbSetupPacket))]
  [Guid(273391922, 51087, 19537, 182, 84, 228, 157, 2, 242, 203, 3)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbSetupPacket
  {
    UsbControlRequestType RequestType { get; set; }

    byte Request { get; set; }

    uint Value { get; set; }

    uint Index { get; set; }

    uint Length { get; set; }
  }
}
