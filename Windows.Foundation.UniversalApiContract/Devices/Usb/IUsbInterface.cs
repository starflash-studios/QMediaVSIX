// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2687642517, 32583, 18603, 167, 39, 103, 140, 37, 190, 33, 18)]
  [ExclusiveTo(typeof (UsbInterface))]
  internal interface IUsbInterface
  {
    IVectorView<UsbBulkInPipe> BulkInPipes { get; }

    IVectorView<UsbInterruptInPipe> InterruptInPipes { get; }

    IVectorView<UsbBulkOutPipe> BulkOutPipes { get; }

    IVectorView<UsbInterruptOutPipe> InterruptOutPipes { get; }

    IVectorView<UsbInterfaceSetting> InterfaceSettings { get; }

    byte InterfaceNumber { get; }

    IVectorView<UsbDescriptor> Descriptors { get; }
  }
}
