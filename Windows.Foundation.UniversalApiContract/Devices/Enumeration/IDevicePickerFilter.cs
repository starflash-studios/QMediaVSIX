// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDevicePickerFilter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(2447086242, 22475, 18673, 155, 89, 165, 155, 122, 31, 2, 162)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DevicePickerFilter))]
  internal interface IDevicePickerFilter
  {
    IVector<DeviceClass> SupportedDeviceClasses { get; }

    IVector<string> SupportedDeviceSelectors { get; }
  }
}
