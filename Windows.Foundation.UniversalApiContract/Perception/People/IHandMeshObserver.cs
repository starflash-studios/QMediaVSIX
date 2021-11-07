// Decompiled with JetBrains decompiler
// Type: Windows.Perception.People.IHandMeshObserver
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Spatial;

namespace Windows.Perception.People
{
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (HandMeshObserver))]
  [Guid(2242785483, 28611, 21956, 167, 180, 41, 227, 56, 150, 202, 105)]
  internal interface IHandMeshObserver
  {
    SpatialInteractionSource Source { get; }

    uint TriangleIndexCount { get; }

    uint VertexCount { get; }

    void GetTriangleIndices([Out] ushort[] indices);

    HandMeshVertexState GetVertexStateForPose(HandPose handPose);

    HandPose NeutralPose { get; }

    int NeutralPoseVersion { get; }

    int ModelId { get; }
  }
}
