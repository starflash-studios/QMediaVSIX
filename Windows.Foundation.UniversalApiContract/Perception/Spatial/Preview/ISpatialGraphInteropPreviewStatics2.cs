// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Preview.ISpatialGraphInteropPreviewStatics2
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Preview
{
  [Guid(613462367, 27837, 19230, 183, 101, 49, 228, 98, 163, 45, 242)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [ExclusiveTo(typeof (SpatialGraphInteropPreview))]
  internal interface ISpatialGraphInteropPreviewStatics2
  {
    [Overload("TryCreateFrameOfReference")]
    SpatialGraphInteropFrameOfReferencePreview TryCreateFrameOfReference(
      SpatialCoordinateSystem coordinateSystem);

    [Overload("TryCreateFrameOfReferenceWithPosition")]
    SpatialGraphInteropFrameOfReferencePreview TryCreateFrameOfReference(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 relativePosition);

    [Overload("TryCreateFrameOfReferenceWithPositionAndOrientation")]
    SpatialGraphInteropFrameOfReferencePreview TryCreateFrameOfReference(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 relativePosition,
      Quaternion relativeOrientation);
  }
}
