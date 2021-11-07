// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterruptInEndpointDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterruptInEndpointDescriptor))]
  [Guid(3226634599, 51473, 19514, 134, 178, 65, 156, 45, 168, 144, 57)]
  internal interface IUsbInterruptInEndpointDescriptor
  {
    uint MaxPacketSize { get; }

    byte EndpointNumber { get; }

    TimeSpan Interval { get; }

    UsbInterruptInPipe Pipe { get; }
  }
}
