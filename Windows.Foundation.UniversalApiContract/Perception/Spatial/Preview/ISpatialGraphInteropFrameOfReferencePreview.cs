// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Preview.ISpatialGraphInteropFrameOfReferencePreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Preview
{
  [ExclusiveTo(typeof (SpatialGraphInteropFrameOfReferencePreview))]
  [Guid(2821135139, 29535, 22313, 169, 142, 230, 78, 209, 137, 171, 197)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  internal interface ISpatialGraphInteropFrameOfReferencePreview
  {
    SpatialCoordinateSystem CoordinateSystem { get; }

    Guid NodeId { get; }

    Matrix4x4 CoordinateSystemToNodeTransform { get; }
  }
}
