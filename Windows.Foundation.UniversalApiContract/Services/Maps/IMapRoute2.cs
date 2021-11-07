// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRoute2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(3519403020, 8723, 19120, 162, 96, 70, 179, 129, 105, 190, 172)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapRoute))]
  internal interface IMapRoute2
  {
    MapRouteRestrictions ViolatedRestrictions { get; }

    bool HasBlockedRoads { get; }
  }
}
