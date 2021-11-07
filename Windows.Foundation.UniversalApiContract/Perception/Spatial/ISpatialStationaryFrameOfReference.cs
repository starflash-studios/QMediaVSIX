// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialStationaryFrameOfReference
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialStationaryFrameOfReference))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(165399737, 48376, 15999, 190, 126, 126, 220, 203, 177, 120, 168)]
  internal interface ISpatialStationaryFrameOfReference
  {
    SpatialCoordinateSystem CoordinateSystem { get; }
  }
}
