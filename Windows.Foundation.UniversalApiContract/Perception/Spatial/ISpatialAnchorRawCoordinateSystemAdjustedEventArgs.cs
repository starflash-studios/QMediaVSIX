// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorRawCoordinateSystemAdjustedEventArgs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialAnchorRawCoordinateSystemAdjustedEventArgs))]
  [Guid(2716343992, 22215, 12567, 162, 228, 129, 224, 252, 242, 142, 0)]
  internal interface ISpatialAnchorRawCoordinateSystemAdjustedEventArgs
  {
    Matrix4x4 OldRawCoordinateSystemToNewRawCoordinateSystemTransform { get; }
  }
}
