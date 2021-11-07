// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2216649291, 12895, 19344, 188, 167, 43, 128, 34, 169, 55, 150)]
  [ExclusiveTo(typeof (Geofence))]
  internal interface IGeofenceFactory
  {
    Geofence Create(string id, IGeoshape geoshape);

    Geofence CreateWithMonitorStates(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse);

    Geofence CreateWithMonitorStatesAndDwellTime(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime);

    Geofence CreateWithMonitorStatesDwellTimeStartTimeAndDuration(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime,
      DateTime startTime,
      TimeSpan duration);
  }
}
