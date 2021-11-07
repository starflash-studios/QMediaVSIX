// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteLeg
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRouteLeg))]
  [Guid(2532881142, 23482, 19735, 157, 182, 26, 38, 63, 236, 116, 113)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRouteLeg
  {
    GeoboundingBox BoundingBox { get; }

    Geopath Path { get; }

    double LengthInMeters { get; }

    TimeSpan EstimatedDuration { get; }

    IVectorView<MapRouteManeuver> Maneuvers { get; }
  }
}
