// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.IHandMeshVertexState
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Perception.People
{
  [Guid(74211311, 7563, 21982, 171, 44, 28, 212, 36, 136, 109, 143)]
  [ExclusiveTo(typeof (HandMeshVertexState))]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface IHandMeshVertexState
  {
    SpatialCoordinateSystem CoordinateSystem { get; }

    void GetVertices([Out] HandMeshVertex[] vertices);

    PerceptionTimestamp UpdateTimestamp { get; }
  }
}
