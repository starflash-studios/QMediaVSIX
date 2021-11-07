// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapCameraFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapCamera))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3929739030, 33711, 19150, 142, 113, 16, 173, 159, 30, 158, 127)]
  internal interface IMapCameraFactory
  {
    MapCamera CreateInstanceWithLocation(Geopoint location);

    MapCamera CreateInstanceWithLocationAndHeading(
      Geopoint location,
      double headingInDegrees);

    MapCamera CreateInstanceWithLocationHeadingAndPitch(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees);

    MapCamera CreateInstanceWithLocationHeadingPitchRollAndFieldOfView(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees,
      double rollInDegrees,
      double fieldOfViewInDegrees);
  }
}
