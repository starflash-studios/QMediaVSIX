// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapLocationFinderStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(831183709, 7261, 20277, 162, 223, 170, 202, 148, 149, 149, 23)]
  [ExclusiveTo(typeof (MapLocationFinder))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IMapLocationFinderStatics
  {
    [RemoteAsync]
    [Overload("FindLocationsAtAsync")]
    IAsyncOperation<MapLocationFinderResult> FindLocationsAtAsync(
      Geopoint queryPoint);

    [RemoteAsync]
    [Overload("FindLocationsAsync")]
    IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint);

    [Overload("FindLocationsWithMaxCountAsync")]
    [RemoteAsync]
    IAsyncOperation<MapLocationFinderResult> FindLocationsAsync(
      string searchText,
      Geopoint referencePoint,
      uint maxCount);
  }
}
