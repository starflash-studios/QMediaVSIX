// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRoute
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
  [Guid(4211586866, 22605, 17795, 156, 96, 100, 31, 234, 39, 67, 73)]
  [ExclusiveTo(typeof (MapRoute))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRoute
  {
    GeoboundingBox BoundingBox { get; }

    double LengthInMeters { get; }

    TimeSpan EstimatedDuration { get; }

    Geopath Path { get; }

    IVectorView<MapRouteLeg> Legs { get; }

    bool IsTrafficBased { get; }
  }
}
