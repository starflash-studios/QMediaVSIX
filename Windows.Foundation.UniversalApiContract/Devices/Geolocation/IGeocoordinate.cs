// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinate
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(3995181994, 38762, 19568, 128, 61, 8, 62, 165, 91, 203, 196)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geocoordinate))]
  internal interface IGeocoordinate
  {
    double Latitude { [Deprecated("Latitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Latitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    double Longitude { [Deprecated("Longitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Longitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    IReference<double> Altitude { [Deprecated("Altitude may be altered or unavailable after Windows 8.1. Instead, use Point.Position.Altitude", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    double Accuracy { get; }

    IReference<double> AltitudeAccuracy { get; }

    IReference<double> Heading { get; }

    IReference<double> Speed { get; }

    DateTime Timestamp { get; }
  }
}
