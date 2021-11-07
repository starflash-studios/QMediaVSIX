// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbSetupPacketFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [Guid(3374677328, 6958, 19009, 162, 167, 51, 143, 12, 239, 60, 20)]
  [ExclusiveTo(typeof (UsbSetupPacket))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUsbSetupPacketFactory
  {
    UsbSetupPacket CreateWithEightByteBuffer(IBuffer eightByteBuffer);
  }
}
