// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicCamera
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Holographic
{
  /// <summary>Provides per-frame rendering functionality for a HolographicViewConfiguration on a HolographicDisplay.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class HolographicCamera : 
    IHolographicCamera,
    IHolographicCamera2,
    IHolographicCamera3,
    IHolographicCamera4,
    IHolographicCamera5,
    IHolographicCamera6
  {
    /// <summary>Gets the dimensions in pixels of the back buffers allocated for this camera.</summary>
    /// <returns>The width and height of the HolographicCamera render target.</returns>
    public extern Size RenderTargetSize { [MethodImpl] get; }

    /// <summary>Gets or sets the scale factor to apply to the default viewport size.</summary>
    /// <returns>The viewport scale factor.</returns>
    public extern double ViewportScaleFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets whether the current display is stereo rather than mono.</summary>
    /// <returns>True, if the current display is stereo; otherwise, false.</returns>
    public extern bool IsStereo { [MethodImpl] get; }

    /// <summary>Gets the unique identifier for the HolographicCamera.</summary>
    /// <returns>The unique identifier.</returns>
    public extern uint Id { [MethodImpl] get; }

    /// <summary>Sets the distance, along the z-axis, from the origin of view space to the near plane of the view frustum.</summary>
    /// <param name="value">The near plane distance, in meters. By default, this is set to 0.1 meters.</param>
    [MethodImpl]
    public extern void SetNearPlaneDistance(double value);

    /// <summary>Sets the distance, along the z-axis, from the origin of view space to the far plane of the view frustum.</summary>
    /// <param name="value">The far plane distance, in meters. By default, this is set to 20 meters.</param>
    [MethodImpl]
    public extern void SetFarPlaneDistance(double value);

    /// <summary>Gets rendering parameters related to display's left-eye viewport.</summary>
    /// <returns>The left viewport parameters.</returns>
    public extern HolographicCameraViewportParameters LeftViewportParameters { [MethodImpl] get; }

    /// <summary>Gets rendering parameters related to display's right-eye viewport.</summary>
    /// <returns>The right viewport parameters.</returns>
    public extern HolographicCameraViewportParameters RightViewportParameters { [MethodImpl] get; }

    /// <summary>Gets metadata about the display represented by this HolographicCamera.</summary>
    /// <returns>The display's metadata.</returns>
    public extern HolographicDisplay Display { [MethodImpl] get; }

    /// <summary>Gets or sets whether this camera should display the primary back buffer filled by the app.</summary>
    /// <returns>True, if the primary layer should be displayed; otherwise, false.</returns>
    public extern bool IsPrimaryLayerEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the maximum number of quad layers supported by the current system.</summary>
    /// <returns>The max quad layer count.</returns>
    public extern uint MaxQuadLayerCount { [MethodImpl] get; }

    /// <summary>Gets the mutable list of quad layers to display on top of this camera's primary back buffer.</summary>
    /// <returns>The quad layer list.</returns>
    public extern IVector<HolographicQuadLayer> QuadLayers { [MethodImpl] get; }

    /// <summary>Gets whether the display supports overriding the viewport rectangles.</summary>
    /// <returns>True, if the application can override the viewport rectangles; otherwise, false.</returns>
    public extern bool CanOverrideViewport { [MethodImpl] get; }

    /// <summary>Gets whether hardware content protection is supported for this HolographicCamera.</summary>
    /// <returns>Whether hardware content protection is supported.</returns>
    public extern bool IsHardwareContentProtectionSupported { [MethodImpl] get; }

    /// <summary>Gets or sets whether this HolographicCamera will produce hardware-protected back buffers for the primary layer.</summary>
    /// <returns>Whether hardware content protection is enabled.</returns>
    public extern bool IsHardwareContentProtectionEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the HolographicViewConfiguration that this HolographicCamera provides rendering for.</summary>
    /// <returns>The HolographicViewConfiguration that can be used to configure rendering parameters for this HolographicCamera.</returns>
    public extern HolographicViewConfiguration ViewConfiguration { [MethodImpl] get; }
  }
}
