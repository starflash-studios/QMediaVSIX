// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3447350028, 64351, 18667, 176, 155, 162, 112, 141, 28, 97, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ActivitySensor))]
  internal interface IActivitySensor
  {
    [RemoteAsync]
    IAsyncOperation<ActivitySensorReading> GetCurrentReadingAsync();

    IVector<ActivityType> SubscribedActivities { get; }

    double PowerInMilliwatts { get; }

    string DeviceId { get; }

    IVectorView<ActivityType> SupportedActivities { get; }

    uint MinimumReportInterval { get; }

    event TypedEventHandler<ActivitySensor, ActivitySensorReadingChangedEventArgs> ReadingChanged;
  }
}
