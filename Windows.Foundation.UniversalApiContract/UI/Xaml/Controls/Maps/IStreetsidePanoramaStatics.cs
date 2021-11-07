// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IStreetsidePanoramaStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(3551821673, 21683, 20165, 178, 160, 79, 130, 4, 87, 101, 7)]
  [ExclusiveTo(typeof (StreetsidePanorama))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreetsidePanoramaStatics
  {
    [RemoteAsync]
    [Overload("FindNearbyWithLocationAsync")]
    IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location);

    [RemoteAsync]
    [Overload("FindNearbyWithLocationAndRadiusAsync")]
    IAsyncOperation<StreetsidePanorama> FindNearbyAsync(
      Geopoint location,
      double radiusInMeters);
  }
}
