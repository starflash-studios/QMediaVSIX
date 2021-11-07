// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [ExclusiveTo(typeof (DeviceInformation))]
  [Guid(1228623668, 43087, 17917, 145, 103, 21, 209, 203, 27, 209, 249)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDeviceInformationStatics2
  {
    string GetAqsFilterFromDeviceClass(DeviceClass deviceClass);

    [Overload("CreateFromIdAsyncWithKindAndAdditionalProperties")]
    IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("FindAllAsyncWithKindAqsFilterAndAdditionalProperties")]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);

    [Overload("CreateWatcherWithKindAqsFilterAndAdditionalProperties")]
    DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties,
      DeviceInformationKind kind);
  }
}
