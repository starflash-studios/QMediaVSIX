// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.Preview.SpatialGraphInteropPreview
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Perception.Spatial.Preview
{
  /// <summary>Provides preview functionality that lets apps track spatial nodes, allowing the user to reason about places and things in their surroundings.</summary>
  [Static(typeof (ISpatialGraphInteropPreviewStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISpatialGraphInteropPreviewStatics), 458752, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 458752)]
  public static class SpatialGraphInteropPreview
  {
    /// <summary>Creates an interop frame of reference based on a given spatial coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system.</param>
    /// <returns>The interop frame of reference.</returns>
    [Overload("TryCreateFrameOfReference")]
    [MethodImpl]
    public static extern SpatialGraphInteropFrameOfReferencePreview TryCreateFrameOfReference(
      SpatialCoordinateSystem coordinateSystem);

    [Overload("TryCreateFrameOfReferenceWithPosition")]
    [MethodImpl]
    public static extern SpatialGraphInteropFrameOfReferencePreview TryCreateFrameOfReference(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 relativePosition);

    [Overload("TryCreateFrameOfReferenceWithPositionAndOrientation")]
    [MethodImpl]
    public static extern SpatialGraphInteropFrameOfReferencePreview TryCreateFrameOfReference(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    /// <summary>Creates a spatial coordinate system that tracks adjustments to a static spatial node.</summary>
    /// <param name="nodeId">The static spatial node's ID.</param>
    /// <returns>The spatial coordinate system.</returns>
    [Overload("CreateCoordinateSystemForNode")]
    [MethodImpl]
    public static extern SpatialCoordinateSystem CreateCoordinateSystemForNode(
      Guid nodeId);

    [Overload("CreateCoordinateSystemForNodeWithPosition")]
    [MethodImpl]
    public static extern SpatialCoordinateSystem CreateCoordinateSystemForNode(
      Guid nodeId,
      Vector3 relativePosition);

    [Overload("CreateCoordinateSystemForNodeWithPositionAndOrientation")]
    [MethodImpl]
    public static extern SpatialCoordinateSystem CreateCoordinateSystemForNode(
      Guid nodeId,
      Vector3 relativePosition,
      Quaternion relativeOrientation);

    /// <summary>Creates a spatial locator that tracks the motion of a dynamic spatial node.</summary>
    /// <param name="nodeId">The dynamic spatial node's ID.</param>
    /// <returns>The spatial locator.</returns>
    [MethodImpl]
    public static extern SpatialLocator CreateLocatorForNode(Guid nodeId);
  }
}
