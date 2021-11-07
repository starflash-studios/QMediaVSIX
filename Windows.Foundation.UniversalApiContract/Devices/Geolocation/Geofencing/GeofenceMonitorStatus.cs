// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.GeofenceMonitorStatus
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  /// <summary>Indicates the current state of a GeofenceMonitor.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum GeofenceMonitorStatus
  {
    /// <summary>The monitor is ready and active.</summary>
    Ready,
    /// <summary>The monitor is in the process of initializing.</summary>
    Initializing,
    /// <summary>There is no data on the status of the monitor.</summary>
    NoData,
    /// <summary>Access to location is denied.</summary>
    Disabled,
    /// <summary>The geofence monitor has not been initialized.</summary>
    NotInitialized,
    /// <summary>The geofence monitor is not available.</summary>
    NotAvailable,
  }
}
