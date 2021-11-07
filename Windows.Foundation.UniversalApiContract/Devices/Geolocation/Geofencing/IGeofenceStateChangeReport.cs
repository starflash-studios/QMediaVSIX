// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceStateChangeReport
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ExclusiveTo(typeof (GeofenceStateChangeReport))]
  [Guid(2586065944, 9316, 19593, 190, 5, 179, 255, 255, 91, 171, 197)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeofenceStateChangeReport
  {
    GeofenceState NewState { get; }

    Geofence Geofence { get; }

    Geoposition Geoposition { get; }

    GeofenceRemovalReason RemovalReason { get; }
  }
}
