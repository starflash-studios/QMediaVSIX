// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptOutEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3433033089, 4298, 17715, 149, 45, 158, 39, 131, 65, 232, 15)]
  [ExclusiveTo(typeof (UsbInterruptOutEndpointDescriptor))]
  internal interface IUsbInterruptOutEndpointDescriptor
  {
    uint MaxPacketSize { get; }

    byte EndpointNumber { get; }

    TimeSpan Interval { get; }

    UsbInterruptOutPipe Pipe { get; }
  }
}
