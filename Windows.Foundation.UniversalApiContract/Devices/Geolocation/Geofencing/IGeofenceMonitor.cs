// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ExclusiveTo(typeof (GeofenceMonitor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1276075896, 7199, 17953, 187, 189, 131, 59, 146, 36, 114, 38)]
  internal interface IGeofenceMonitor
  {
    GeofenceMonitorStatus Status { get; }

    IVector<Geofence> Geofences { get; }

    Geoposition LastKnownGeoposition { get; }

    event TypedEventHandler<GeofenceMonitor, object> GeofenceStateChanged;

    IVectorView<GeofenceStateChangeReport> ReadReports();

    event TypedEventHandler<GeofenceMonitor, object> StatusChanged;
  }
}
