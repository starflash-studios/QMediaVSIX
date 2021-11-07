// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.Geofence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  /// <summary>Contains the functionality to define a geofence (a geographical area of interest) to monitor.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IGeofenceFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Geofence : IGeofence
  {
    /// <summary>Initializes a new Geofence object given the *id* and the shape of the geofence.</summary>
    /// <param name="id">The Id of the geofence.</param>
    /// <param name="geoshape">The area that defines the geofence to monitor.</param>
    [MethodImpl]
    public extern Geofence(string id, IGeoshape geoshape);

    /// <summary>Initializes a new Geofence object given the *id*, the shape of the geofence, the states to monitor the geofence for, and the *singleUse* flag.</summary>
    /// <param name="id">The Id of the geofence.</param>
    /// <param name="geoshape">The area that defines the geofence to monitor.</param>
    /// <param name="monitoredStates">The states to monitor the geofence for.</param>
    /// <param name="singleUse">True indicates the geofence should be monitored only for one use. False indicates the geofence should be monitored for multiple uses.</param>
    [MethodImpl]
    public extern Geofence(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse);

    [MethodImpl]
    public extern Geofence(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime);

    [MethodImpl]
    public extern Geofence(
      string id,
      IGeoshape geoshape,
      MonitoredGeofenceStates monitoredStates,
      bool singleUse,
      TimeSpan dwellTime,
      DateTime startTime,
      TimeSpan duration);

    /// <summary>The time to start monitoring the Geofence.</summary>
    /// <returns>The time to start monitoring the geofence. The default value is 0, which is the beginning of time, epoch.</returns>
    public extern DateTime StartTime { [MethodImpl] get; }

    /// <summary>Gets the time window, beginning after the StartTime, during which the Geofence is monitored.</summary>
    /// <returns>The time window, beginning after the StartTime, during which the Geofence is monitored.</returns>
    public extern TimeSpan Duration { [MethodImpl] get; }

    /// <summary>The minimum time that a position has to be inside or outside of the Geofence in order for the notification to be triggered.</summary>
    /// <returns>The minimum time that a position has to be inside or outside of the geofence in order for the notification to be triggered.</returns>
    public extern TimeSpan DwellTime { [MethodImpl] get; }

    /// <summary>The id of the Geofence.</summary>
    /// <returns>The id of the geofence.</returns>
    public extern string Id { [MethodImpl] get; }

    /// <summary>Indicates the states that the Geofence is being monitored for.</summary>
    /// <returns>The states that the geofence is being monitored for.</returns>
    public extern MonitoredGeofenceStates MonitoredStates { [MethodImpl] get; }

    /// <summary>The shape of the geofence region.</summary>
    /// <returns>The shape of the geofence region.</returns>
    public extern IGeoshape Geoshape { [MethodImpl] get; }

    /// <summary>Indicates whether the Geofence should be triggered once or multiple times.</summary>
    /// <returns>**True** indicates the geofence should be monitored only for one use. **False** indicates the geofence should be monitored for multiple uses.</returns>
    public extern bool SingleUse { [MethodImpl] get; }
  }
}
