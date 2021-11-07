// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialLocatorAttachedFrameOfReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [Guid(3782692598, 8015, 18844, 150, 37, 239, 94, 110, 215, 160, 72)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialLocatorAttachedFrameOfReference))]
  internal interface ISpatialLocatorAttachedFrameOfReference
  {
    Vector3 RelativePosition { get; set; }

    Quaternion RelativeOrientation { get; set; }

    void AdjustHeading(double headingOffsetInRadians);

    SpatialCoordinateSystem GetStationaryCoordinateSystemAtTimestamp(
      PerceptionTimestamp timestamp);

    IReference<double> TryGetRelativeHeadingAtTimestamp(PerceptionTimestamp timestamp);
  }
}
