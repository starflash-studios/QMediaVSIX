// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IGeotagHelperStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [Guid(1095316036, 9508, 18005, 134, 166, 237, 22, 245, 252, 113, 107)]
  [ExclusiveTo(typeof (GeotagHelper))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeotagHelperStatics
  {
    [RemoteAsync]
    IAsyncOperation<Geopoint> GetGeotagAsync(IStorageFile file);

    [RemoteAsync]
    IAsyncAction SetGeotagFromGeolocatorAsync(IStorageFile file, Geolocator geolocator);

    [RemoteAsync]
    IAsyncAction SetGeotagAsync(IStorageFile file, Geopoint geopoint);
  }
}
