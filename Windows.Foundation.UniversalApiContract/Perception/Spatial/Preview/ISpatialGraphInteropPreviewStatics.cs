// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Preview.ISpatialGraphInteropPreviewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Preview
{
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  [ExclusiveTo(typeof (SpatialGraphInteropPreview))]
  [Guid(3225576524, 8408, 20176, 174, 247, 104, 5, 184, 229, 63, 85)]
  internal interface ISpatialGraphInteropPreviewStatics
  {
    [Overload("CreateCoordinateSystemForNode")]
    SpatialCoordinateSystem CreateCoordinateSystemForNode(Guid nodeId);

    [Overload("CreateCoordinateSystemForNodeWithPosition")]
    SpatialCoordinateSystem CreateCoordinateSystemForNode(
      Guid nodeId,
      Vector3 relativePosition);

    [Overload("CreateCoordinateSystemForNodeWithPositionAndOrientation")]
    SpatialCoordinateSystem CreateCoordinateSystemForNode(
      Guid nodeId,
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    SpatialLocator CreateLocatorForNode(Guid nodeId);
  }
}
