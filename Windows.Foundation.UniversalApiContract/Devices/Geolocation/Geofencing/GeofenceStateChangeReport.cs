// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.GeofenceStateChangeReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  /// <summary>Contains the information about the state changes for a Geofence.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class GeofenceStateChangeReport : IGeofenceStateChangeReport
  {
    /// <summary>The new state of the Geofence object whose state has changed.</summary>
    /// <returns>The new state of the Geofence object whose state has changed.</returns>
    public extern GeofenceState NewState { [MethodImpl] get; }

    /// <summary>The Geofence object whose state has changed.</summary>
    /// <returns>The Geofence object whose state has changed.</returns>
    public extern Geofence Geofence { [MethodImpl] get; }

    /// <summary>The position of the Geofence object whose state has changed.</summary>
    /// <returns>The position of the Geofence object whose state has changed.</returns>
    public extern Geoposition Geoposition { [MethodImpl] get; }

    /// <summary>Indicates the reason a Geofence was removed.</summary>
    /// <returns>Indicates the reason a geofence was removed.</returns>
    public extern GeofenceRemovalReason RemovalReason { [MethodImpl] get; }
  }
}
