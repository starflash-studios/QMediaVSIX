// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocator
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geolocator))]
  [Guid(2848178018, 17700, 18825, 138, 169, 222, 1, 157, 46, 85, 31)]
  internal interface IGeolocator
  {
    PositionAccuracy DesiredAccuracy { get; set; }

    double MovementThreshold { get; set; }

    uint ReportInterval { get; set; }

    PositionStatus LocationStatus { get; }

    [Overload("GetGeopositionAsync")]
    [RemoteAsync]
    IAsyncOperation<Geoposition> GetGeopositionAsync();

    [RemoteAsync]
    [Overload("GetGeopositionAsyncWithAgeAndTimeout")]
    IAsyncOperation<Geoposition> GetGeopositionAsync(
      TimeSpan maximumAge,
      TimeSpan timeout);

    event TypedEventHandler<Geolocator, PositionChangedEventArgs> PositionChanged;

    event TypedEventHandler<Geolocator, StatusChangedEventArgs> StatusChanged;
  }
}
