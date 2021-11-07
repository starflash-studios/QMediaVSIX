// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.CameraIntrinsics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Media.Devices.Core
{
  /// <summary>Represents the intrinsics that describe the camera distortion model.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (ICameraIntrinsicsFactory), 458752, "Windows.Foundation.UniversalApiContract")]
  public sealed class CameraIntrinsics : ICameraIntrinsics, ICameraIntrinsics2
  {
    [MethodImpl]
    public extern CameraIntrinsics(
      Vector2 focalLength,
      Vector2 principalPoint,
      Vector3 radialDistortion,
      Vector2 tangentialDistortion,
      uint imageWidth,
      uint imageHeight);

    /// <summary>Gets the focal length of the camera.</summary>
    /// <returns>The focal length of the camera.</returns>
    public extern Vector2 FocalLength { [MethodImpl] get; }

    /// <summary>Gets the principal point of the camera.</summary>
    /// <returns>The principal point of the camera.</returns>
    public extern Vector2 PrincipalPoint { [MethodImpl] get; }

    /// <summary>Gets the radial distortion coefficient of the camera.</summary>
    /// <returns>The radial distortion coefficient of the camera.</returns>
    public extern Vector3 RadialDistortion { [MethodImpl] get; }

    /// <summary>Gets the tangential distortion coefficient of the camera.</summary>
    /// <returns>The tangential distortion coefficient of the camera.</returns>
    public extern Vector2 TangentialDistortion { [MethodImpl] get; }

    /// <summary>Gets the image width of the camera, in pixels.</summary>
    /// <returns>The image width of the camera, in pixels.</returns>
    public extern uint ImageWidth { [MethodImpl] get; }

    /// <summary>Gets the image height of the camera, in pixels.</summary>
    /// <returns>The image height of the camera, in pixels.</returns>
    public extern uint ImageHeight { [MethodImpl] get; }

    [MethodImpl]
    public extern Point ProjectOntoFrame(Vector3 coordinate);

    /// <summary>Unprojects pixel coordinates into a camera space ray from the camera origin, expressed as a X, Y coordinates on the plane at Z = 1.0.</summary>
    /// <param name="pixelCoordinate">The pixel coordinates to unproject into camera space.</param>
    /// <returns>The X, Y coordinates of the unprojected pixel on the plane at Z = 1.0.</returns>
    [MethodImpl]
    public extern Vector2 UnprojectAtUnitDepth(Point pixelCoordinate);

    [MethodImpl]
    public extern void ProjectManyOntoFrame(Vector3[] coordinates, [Out] Point[] results);

    [MethodImpl]
    public extern void UnprojectPixelsAtUnitDepth(Point[] pixelCoordinates, [Out] Vector2[] results);

    /// <summary>Gets a matrix that transforms a 3D point to video frame pixel coordinates without compensating for the distortion model of the camera. The 2D point resulting from this transformation will not accurately map to the pixel coordinate in a video frame unless the app applies its own distortion compensation.   This is useful for apps that choose to implement GPU-based distortion compensation instead of using UndistortPoint, which uses the CPU to compute the distortion compensation.</summary>
    /// <returns>Gets a matrix that transforms a 3D point to the video frame pixel coordinates without compensating for the distortion model of the camera.</returns>
    public extern Matrix4x4 UndistortedProjectionTransform { [MethodImpl] get; }

    /// <summary>Applies the distortion model of the camera to an undistorted point so that the resulting point's location is distorted as if it were captured by the camera's lens.</summary>
    /// <param name="input">The point to undestort.</param>
    /// <returns>An undistorted point.</returns>
    [MethodImpl]
    public extern Point DistortPoint(Point input);

    /// <summary>Applies the distortion model of the camera to an array of undistorted points so that the resulting points' locations are distorted as if they were captured by the camera's lens.</summary>
    /// <param name="inputs">The array of points to undestort.</param>
    /// <param name="results">An array of undistorted points.</param>
    [MethodImpl]
    public extern void DistortPoints(Point[] inputs, [Out] Point[] results);

    /// <summary>Transforms a point to compensate for the distortion model of the camera, resulting in an undistorted point.</summary>
    /// <param name="input">The point to undistort.</param>
    /// <returns>An undistorted point.</returns>
    [MethodImpl]
    public extern Point UndistortPoint(Point input);

    /// <summary>Transforms an array of points to compensate for the distortion model of the camera, resulting in an array of undistorted points.</summary>
    /// <param name="inputs">The array of points to undistort.</param>
    /// <param name="results">An array of undistorted points.</param>
    [MethodImpl]
    public extern void UndistortPoints(Point[] inputs, [Out] Point[] results);
  }
}
