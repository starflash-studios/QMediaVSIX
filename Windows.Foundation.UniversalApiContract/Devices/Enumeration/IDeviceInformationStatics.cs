// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Enumeration.IDeviceInformationStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Enumeration
{
  [Guid(3246329870, 14918, 19064, 128, 19, 118, 157, 201, 185, 115, 144)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DeviceInformation))]
  internal interface IDeviceInformationStatics
  {
    [Overload("CreateFromIdAsync")]
    [RemoteAsync]
    IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId);

    [Overload("CreateFromIdAsyncAdditionalProperties")]
    IAsyncOperation<DeviceInformation> CreateFromIdAsync(
      string deviceId,
      IIterable<string> additionalProperties);

    [Overload("FindAllAsync")]
    [RemoteAsync]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync();

    [Overload("FindAllAsyncDeviceClass")]
    [DefaultOverload]
    [RemoteAsync]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      DeviceClass deviceClass);

    [Overload("FindAllAsyncAqsFilter")]
    [RemoteAsync]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter);

    [Overload("FindAllAsyncAqsFilterAndAdditionalProperties")]
    IAsyncOperation<DeviceInformationCollection> FindAllAsync(
      string aqsFilter,
      IIterable<string> additionalProperties);

    [Overload("CreateWatcher")]
    DeviceWatcher CreateWatcher();

    [Overload("CreateWatcherDeviceClass")]
    [DefaultOverload]
    DeviceWatcher CreateWatcher(DeviceClass deviceClass);

    [Overload("CreateWatcherAqsFilter")]
    DeviceWatcher CreateWatcher(string aqsFilter);

    [Overload("CreateWatcherAqsFilterAndAdditionalProperties")]
    DeviceWatcher CreateWatcher(
      string aqsFilter,
      IIterable<string> additionalProperties);
  }
}
