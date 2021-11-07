// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Frames.DepthMediaFrame
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;
using Windows.Perception.Spatial;

namespace Windows.Media.Capture.Frames
{
  /// <summary>Represents a VideoMediaFrame that contains depth video data.</summary>
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DepthMediaFrame : IDepthMediaFrame, IDepthMediaFrame2
  {
    /// <summary>Gets the MediaFrameReference wrapper object associated with the DepthMediaFrame, which provides access to format information and other properties of the media frame.</summary>
    /// <returns>The MediaFrameReference wrapper object associated with the DepthMediaFrame</returns>
    public extern MediaFrameReference FrameReference { [MethodImpl] get; }

    /// <summary>Gets the VideoMediaFrame associated with the DepthMediaFrame.</summary>
    /// <returns>The VideoMediaFrame associated with the DepthMediaFrame.</returns>
    public extern VideoMediaFrame VideoMediaFrame { [MethodImpl] get; }

    /// <summary>Gets an object that describes the format of the depth data in the DepthMediaFrame.</summary>
    /// <returns>An object that describes the format of the depth data in the DepthMediaFrame.</returns>
    public extern DepthMediaFrameFormat DepthFormat { [MethodImpl] get; }

    /// <summary>Attempts to create a DepthCorrelatedCoordinateMapper for the DepthMediaFrame. This object provides methods for mapping pixel coordinates from a MediaFrameSource camera to the coordinate system of a different **MediaFrameSource** or to 3D space.</summary>
    /// <param name="cameraIntrinsics">An object that describes the distortion model of the **MediaFrameSource** camera for which coordinates will be mapped using the DepthMediaFrame data.</param>
    /// <param name="coordinateSystem">An object representing the spatial coordinate system of the camera for which coordinates will be mapped using the DepthMediaFrame data.</param>
    /// <returns>A DepthCorrelatedCoordinateMapper if the operation was successful; otherwise, null.</returns>
    [MethodImpl]
    public extern DepthCorrelatedCoordinateMapper TryCreateCoordinateMapper(
      CameraIntrinsics cameraIntrinsics,
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets a value that specifies the maximum reliable depth value for the camera that captured the depth frame.</summary>
    /// <returns>A value that specifies the maximum reliable depth value for the camera that captured the depth frame.</returns>
    public extern uint MaxReliableDepth { [MethodImpl] get; }

    /// <summary>Gets a value that specifies the minimum reliable depth value for the camera that captured the depth frame.</summary>
    /// <returns>A value that specifies the minimum reliable depth value for the camera that captured the depth frame.</returns>
    public extern uint MinReliableDepth { [MethodImpl] get; }
  }
}
