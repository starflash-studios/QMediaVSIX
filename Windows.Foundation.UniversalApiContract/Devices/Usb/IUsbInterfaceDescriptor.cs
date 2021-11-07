// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbInterfaceDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(429289671, 47086, 20368, 140, 213, 148, 162, 226, 87, 89, 138)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbInterfaceDescriptor))]
  internal interface IUsbInterfaceDescriptor
  {
    byte ClassCode { get; }

    byte SubclassCode { get; }

    byte ProtocolCode { get; }

    byte AlternateSettingNumber { get; }

    byte InterfaceNumber { get; }
  }
}
