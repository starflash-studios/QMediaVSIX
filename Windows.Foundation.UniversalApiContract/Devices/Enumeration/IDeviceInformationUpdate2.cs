// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationUpdate2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(1570575500, 43123, 18526, 186, 166, 170, 98, 7, 136, 227, 204)]
  [ExclusiveTo(typeof (DeviceInformationUpdate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceInformationUpdate2
  {
    DeviceInformationKind Kind { get; }
  }
}
