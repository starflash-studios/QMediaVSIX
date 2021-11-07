// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbConfigurationDescriptor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(4061621650, 46146, 16506, 130, 7, 125, 100, 108, 3, 133, 243)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbConfigurationDescriptor))]
  internal interface IUsbConfigurationDescriptor
  {
    byte ConfigurationValue { get; }

    uint MaxPowerMilliamps { get; }

    bool SelfPowered { get; }

    bool RemoteWakeup { get; }
  }
}
