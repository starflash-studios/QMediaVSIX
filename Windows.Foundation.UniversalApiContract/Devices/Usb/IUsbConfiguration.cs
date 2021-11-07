﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Usb.IUsbConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Usb
{
  [Guid(1746367529, 13993, 18135, 184, 115, 252, 104, 146, 81, 236, 48)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UsbConfiguration))]
  internal interface IUsbConfiguration
  {
    IVectorView<UsbInterface> UsbInterfaces { get; }

    UsbConfigurationDescriptor ConfigurationDescriptor { get; }

    IVectorView<UsbDescriptor> Descriptors { get; }
  }
}