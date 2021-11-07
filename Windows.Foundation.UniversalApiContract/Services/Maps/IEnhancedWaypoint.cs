// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IEnhancedWaypoint
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3978726516, 22803, 4582, 139, 119, 134, 243, 12, 168, 147, 211)]
  [ExclusiveTo(typeof (EnhancedWaypoint))]
  [WebHostHidden]
  internal interface IEnhancedWaypoint
  {
    Geopoint Point { get; }

    WaypointKind Kind { get; }
  }
}
