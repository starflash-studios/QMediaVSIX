// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapAddress
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [Guid(3483871603, 41908, 17556, 179, 255, 203, 169, 77, 182, 150, 153)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapAddress))]
  internal interface IMapAddress
  {
    string BuildingName { get; }

    string BuildingFloor { get; }

    string BuildingRoom { get; }

    string BuildingWing { get; }

    string StreetNumber { get; }

    string Street { get; }

    string Neighborhood { get; }

    string District { get; }

    string Town { get; }

    string Region { get; }

    string RegionCode { get; }

    string Country { get; }

    string CountryCode { get; }

    string PostCode { get; }

    string Continent { get; }
  }
}
