// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IEnhancedWaypointFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(2944828535, 41642, 18141, 182, 69, 35, 179, 27, 138, 166, 199)]
  [ExclusiveTo(typeof (EnhancedWaypoint))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IEnhancedWaypointFactory
  {
    EnhancedWaypoint Create(Geopoint point, WaypointKind kind);
  }
}
