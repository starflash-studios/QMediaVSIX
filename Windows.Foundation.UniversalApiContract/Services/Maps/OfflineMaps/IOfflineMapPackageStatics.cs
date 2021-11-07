// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.OfflineMaps.IOfflineMapPackageStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.OfflineMaps
{
  [Guid(408844578, 43057, 19120, 148, 31, 105, 152, 250, 146, 146, 133)]
  [ExclusiveTo(typeof (OfflineMapPackage))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IOfflineMapPackageStatics
  {
    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesAsync(
      Geopoint queryPoint);

    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInBoundingBoxAsync(
      GeoboundingBox queryBoundingBox);

    [RemoteAsync]
    IAsyncOperation<OfflineMapPackageQueryResult> FindPackagesInGeocircleAsync(
      Geocircle queryCircle);
  }
}
