// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoposition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geoposition))]
  [Guid(3247244372, 32065, 20471, 169, 87, 157, 255, 180, 239, 127, 91)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeoposition
  {
    Geocoordinate Coordinate { get; }

    CivicAddress CivicAddress { get; }
  }
}
