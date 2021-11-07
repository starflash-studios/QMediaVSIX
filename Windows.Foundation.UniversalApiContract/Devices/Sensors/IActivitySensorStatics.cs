// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2803764893, 61067, 17873, 178, 91, 8, 204, 13, 249, 42, 182)]
  [ExclusiveTo(typeof (ActivitySensor))]
  internal interface IActivitySensorStatics
  {
    [RemoteAsync]
    IAsyncOperation<ActivitySensor> GetDefaultAsync();

    string GetDeviceSelector();

    [RemoteAsync]
    IAsyncOperation<ActivitySensor> FromIdAsync(string deviceId);

    [Overload("GetSystemHistoryAsync")]
    [RemoteAsync]
    IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [RemoteAsync]
    [Overload("GetSystemHistoryWithDurationAsync")]
    IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
