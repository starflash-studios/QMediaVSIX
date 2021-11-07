// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IPlaceInfoStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Guid(2193227633, 27856, 18596, 175, 217, 94, 216, 32, 151, 147, 107)]
  [ExclusiveTo(typeof (PlaceInfo))]
  internal interface IPlaceInfoStatics
  {
    [Overload("Create")]
    PlaceInfo Create(Geopoint referencePoint);

    [Overload("CreateWithGeopointAndOptions")]
    PlaceInfo Create(Geopoint referencePoint, PlaceInfoCreateOptions options);

    [Overload("CreateFromIdentifier")]
    PlaceInfo CreateFromIdentifier(string identifier);

    [Overload("CreateFromIdentifierWithOptions")]
    PlaceInfo CreateFromIdentifier(
      string identifier,
      Geopoint defaultPoint,
      PlaceInfoCreateOptions options);

    PlaceInfo CreateFromMapLocation(MapLocation location);

    bool IsShowSupported { get; }
  }
}
