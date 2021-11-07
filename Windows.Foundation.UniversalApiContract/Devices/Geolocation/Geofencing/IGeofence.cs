// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofence
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ExclusiveTo(typeof (Geofence))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2617837603, 60856, 18400, 130, 69, 91, 246, 29, 50, 31, 45)]
  internal interface IGeofence
  {
    DateTime StartTime { get; }

    TimeSpan Duration { get; }

    TimeSpan DwellTime { get; }

    string Id { get; }

    MonitoredGeofenceStates MonitoredStates { get; }

    IGeoshape Geoshape { get; }

    bool SingleUse { get; }
  }
}
