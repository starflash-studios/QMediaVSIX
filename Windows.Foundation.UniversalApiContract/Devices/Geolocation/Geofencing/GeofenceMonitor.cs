// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.GeofenceMonitor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  /// <summary>Contains the information about the monitored Geofence objects.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IGeofenceMonitorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class GeofenceMonitor : IGeofenceMonitor
  {
    /// <summary>Indicates the current state of the GeofenceMonitor.</summary>
    /// <returns>Indicates the current state of a GeofenceMonitor.</returns>
    public extern GeofenceMonitorStatus Status { [MethodImpl] get; }

    /// <summary>Returns a vector of the app's Geofence objects currently registered with the system-wide GeofenceMonitor.</summary>
    /// <returns>A collection of the Geofence objects to monitor.</returns>
    public extern IVector<Geofence> Geofences { [MethodImpl] get; }

    /// <summary>Last reading of the device's location.</summary>
    /// <returns>Last reading of the device's location.</returns>
    public extern Geoposition LastKnownGeoposition { [MethodImpl] get; }

    /// <summary>Raised when the state of one or more Geofence objects in the Geofences collection of the GeofenceMonitor has changed</summary>
    public extern event TypedEventHandler<GeofenceMonitor, object> GeofenceStateChanged;

    /// <summary>Gets a collection of status changes to the Geofence objects in the Geofences collection of the GeofenceMonitor.</summary>
    /// <returns>collection of status changes to the Geofence object(s) in GeofenceMonitor.</returns>
    [MethodImpl]
    public extern IVectorView<GeofenceStateChangeReport> ReadReports();

    /// <summary>Raised when the status of the GeofenceMonitor has changed.</summary>
    public extern event TypedEventHandler<GeofenceMonitor, object> StatusChanged;

    /// <summary>Gets the GeofenceMonitor object which contains all of an app's Geofence information.</summary>
    /// <returns>Gets the GeofenceMonitor object which contains all of an app's geofence information.</returns>
    public static extern GeofenceMonitor Current { [MethodImpl] get; }
  }
}
