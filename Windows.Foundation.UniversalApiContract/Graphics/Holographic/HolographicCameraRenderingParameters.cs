// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCameraRenderingParameters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.Perception.Spatial;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents per-camera parameters for rendering holographic content.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public sealed class HolographicCameraRenderingParameters : 
    IHolographicCameraRenderingParameters,
    IHolographicCameraRenderingParameters2,
    IHolographicCameraRenderingParameters3,
    IHolographicCameraRenderingParameters4
  {
    [Overload("SetFocusPoint")]
    [MethodImpl]
    public extern void SetFocusPoint(SpatialCoordinateSystem coordinateSystem, Vector3 position);

    [Overload("SetFocusPointWithNormal")]
    [MethodImpl]
    public extern void SetFocusPoint(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Vector3 normal);

    [Overload("SetFocusPointWithNormalLinearVelocity")]
    [MethodImpl]
    public extern void SetFocusPoint(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Vector3 normal,
      Vector3 linearVelocity);

    /// <summary>Gets the Direct3D 11 device for this camera.</summary>
    /// <returns>The Direct3D 11 device.</returns>
    public extern IDirect3DDevice Direct3D11Device { [MethodImpl] get; }

    /// <summary>Gets the Direct3D 11 back buffer surface for this camera. Apps must retrieve a new back buffer surface for rendering each frame.</summary>
    /// <returns>The Direct3D 11 surface that holds the back buffer.</returns>
    public extern IDirect3DSurface Direct3D11BackBuffer { [MethodImpl] get; }

    /// <summary>Gets or sets the kind of reprojection the app is requesting to stabilize its holographic rendering relative to the user's head motion.</summary>
    /// <returns>The kind of reprojection.</returns>
    public extern HolographicReprojectionMode ReprojectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Provides a depth buffer for this frame to the holographic display pipeline, enabling depth-based stabilization of the frame relative to the user's head motion.</summary>
    /// <param name="value">The Direct3D 11 surface containing the app's depth buffer.</param>
    [MethodImpl]
    public extern void CommitDirect3D11DepthBuffer(IDirect3DSurface value);

    /// <summary>Gets or sets whether the application is displaying protected content.</summary>
    /// <returns>Whether content protection is enabled.</returns>
    public extern bool IsContentProtectionEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern HolographicDepthReprojectionMethod DepthReprojectionMethod { [MethodImpl] get; [MethodImpl] set; }
  }
}
