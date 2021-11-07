// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Usb
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(176812566, 24477, 18548, 137, 4, 218, 154, 211, 245, 82, 143)]
  [ExclusiveTo(typeof (UsbDescriptor))]
  internal interface IUsbDescriptor
  {
    byte Length { get; }

    byte DescriptorType { get; }

    void ReadDescriptorBuffer(IBuffer buffer);
  }
}
