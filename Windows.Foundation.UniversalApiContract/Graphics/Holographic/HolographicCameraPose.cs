// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCameraPose
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents the predicted location of a holographic camera for a particular frame.</summary>
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicCameraPose : IHolographicCameraPose, IHolographicCameraPose2
  {
    /// <summary>Gets the HolographicCamera that's described by this camera pose.</summary>
    /// <returns>The HolographicCamera.</returns>
    public extern HolographicCamera HolographicCamera { [MethodImpl] get; }

    /// <summary>Gets the viewport rectangle that the app must render to for this camera in this frame.</summary>
    /// <returns>The viewport rect.</returns>
    public extern Rect Viewport { [MethodImpl] get; }

    /// <summary>Gets the stereo view transform for this camera pose, expressed as a transform from the specified coordinate system. This method will return null if the specified coordinate system cannot be located at the moment.</summary>
    /// <param name="coordinateSystem">The coordinate system from which the rendered geometry should be transformed.</param>
    /// <returns>The transforms.</returns>
    [MethodImpl]
    public extern IReference<HolographicStereoTransform> TryGetViewTransform(
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets the stereo projection transform for this camera pose.</summary>
    /// <returns>The transforms.</returns>
    public extern HolographicStereoTransform ProjectionTransform { [MethodImpl] get; }

    /// <summary>Gets the predicted conservative culling frustum for this camera pose, expressed in the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the culling frustum.</param>
    /// <returns>The culling frustum.</returns>
    [MethodImpl]
    public extern IReference<SpatialBoundingFrustum> TryGetCullingFrustum(
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets the predicted view frustum for the current pose, expressed in the specified coordinate system.</summary>
    /// <param name="coordinateSystem">The coordinate system in which to express the visible frustum.</param>
    /// <returns>The visible frustum.</returns>
    [MethodImpl]
    public extern IReference<SpatialBoundingFrustum> TryGetVisibleFrustum(
      SpatialCoordinateSystem coordinateSystem);

    /// <summary>Gets the near plane distance for this frame, which you set by calling the HolographicCamera.SetNearPlaneDistance method.</summary>
    /// <returns>The near plane distance for this frame, in meters. By default, this is set to 0.01 meters.</returns>
    public extern double NearPlaneDistance { [MethodImpl] get; }

    /// <summary>Gets the far plane distance for this frame, which is set by calling the HolographicCamera.SetFarPlaneDistance method.</summary>
    /// <returns>The far plane distance for this frame, in meters. By default, this is set to 20 meters.</returns>
    public extern double FarPlaneDistance { [MethodImpl] get; }

    /// <summary>Notifies the compositor that the app is rendering with an alternate suboptimal view transform this frame.</summary>
    /// <param name="coordinateSystem">The coordinate system in which the alternate suboptimal view transform will be expressed.</param>
    /// <param name="coordinateSystemToViewTransform">The alternate suboptimal view transform.</param>
    [MethodImpl]
    public extern void OverrideViewTransform(
      SpatialCoordinateSystem coordinateSystem,
      HolographicStereoTransform coordinateSystemToViewTransform);

    /// <summary>Notifies the compositor that the app is rendering with an alternate suboptimal projection transform this frame.</summary>
    /// <param name="projectionTransform">The alternate suboptimal projection transform.</param>
    [MethodImpl]
    public extern void OverrideProjectionTransform(HolographicStereoTransform projectionTransform);

    /// <summary>Specifies an alternate viewport rectangle within the frame buffer that the app is rendering into this frame.</summary>
    /// <param name="leftViewport">The left eye viewport rectangle.</param>
    /// <param name="rightViewport">The right eye viewport rectangle.</param>
    [MethodImpl]
    public extern void OverrideViewport(Rect leftViewport, Rect rightViewport);
  }
}
