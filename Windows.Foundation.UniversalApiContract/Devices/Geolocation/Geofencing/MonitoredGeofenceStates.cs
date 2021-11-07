// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.MonitoredGeofenceStates
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  /// <summary>Indicates the state or states of the Geofences that are currently being monitored by the system.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MonitoredGeofenceStates : uint
  {
    /// <summary>No flag is set.</summary>
    None = 0,
    /// <summary>The device has entered a geofence area.</summary>
    Entered = 1,
    /// <summary>The device has left a geofence area.</summary>
    Exited = 2,
    /// <summary>The geofence has been removed.</summary>
    Removed = 4,
  }
}
