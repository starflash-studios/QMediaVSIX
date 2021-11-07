// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialAnchor))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(86631886, 7476, 14082, 188, 236, 234, 191, 245, 120, 168, 105)]
  internal interface ISpatialAnchor
  {
    SpatialCoordinateSystem CoordinateSystem { get; }

    SpatialCoordinateSystem RawCoordinateSystem { get; }

    event TypedEventHandler<SpatialAnchor, SpatialAnchorRawCoordinateSystemAdjustedEventArgs> RawCoordinateSystemAdjusted;
  }
}
