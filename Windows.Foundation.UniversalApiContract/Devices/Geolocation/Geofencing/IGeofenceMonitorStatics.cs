// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geofencing.IGeofenceMonitorStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation.Geofencing
{
  [ExclusiveTo(typeof (GeofenceMonitor))]
  [Guid(768815055, 32373, 18585, 172, 227, 43, 208, 166, 92, 206, 6)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeofenceMonitorStatics
  {
    GeofenceMonitor Current { get; }
  }
}
