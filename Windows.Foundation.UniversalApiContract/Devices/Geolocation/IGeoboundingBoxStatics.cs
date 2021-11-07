// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoboundingBoxStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(1740113672, 58906, 19664, 132, 27, 147, 35, 55, 146, 181, 202)]
  [ExclusiveTo(typeof (GeoboundingBox))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeoboundingBoxStatics
  {
    [Overload("TryCompute")]
    GeoboundingBox TryCompute(IIterable<BasicGeoposition> positions);

    [Overload("TryComputeWithAltitudeReference")]
    GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem);

    [Overload("TryComputeWithAltitudeReferenceAndSpatialReference")]
    GeoboundingBox TryCompute(
      IIterable<BasicGeoposition> positions,
      AltitudeReferenceSystem altitudeRefSystem,
      uint spatialReferenceId);
  }
}
