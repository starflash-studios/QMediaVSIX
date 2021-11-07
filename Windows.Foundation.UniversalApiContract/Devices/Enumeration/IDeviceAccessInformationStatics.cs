// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceAccessInformationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceAccessInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1464587219, 24368, 17869, 138, 148, 114, 79, 229, 151, 48, 132)]
  internal interface IDeviceAccessInformationStatics
  {
    DeviceAccessInformation CreateFromId(string deviceId);

    DeviceAccessInformation CreateFromDeviceClassId(Guid deviceClassId);

    DeviceAccessInformation CreateFromDeviceClass(DeviceClass deviceClass);
  }
}
