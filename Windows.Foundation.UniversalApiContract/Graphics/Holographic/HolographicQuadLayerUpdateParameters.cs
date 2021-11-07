// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters
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
  /// <summary>Represents an update payload that lets an application configure a specific quad layer's parameters from a given frame forward.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicQuadLayerUpdateParameters : 
    IHolographicQuadLayerUpdateParameters,
    IHolographicQuadLayerUpdateParameters2
  {
    /// <summary>Gets a Direct3D 11 back buffer whose contents will be displayed for this quad layer from this frame forward.</summary>
    /// <returns>The Direct3D 11 surface that holds the back buffer.</returns>
    [MethodImpl]
    public extern IDirect3DSurface AcquireBufferToUpdateContent();

    /// <summary>Updates the viewport rectangle within the quad layer's texture that will be displayed to the screen.</summary>
    /// <param name="value">The viewport rectangle.</param>
    [MethodImpl]
    public extern void UpdateViewport(Rect value);

    /// <summary>Updates whether this quad layer contains protected content.</summary>
    /// <param name="value">Whether content protection should be enabled for this quad layer.</param>
    [MethodImpl]
    public extern void UpdateContentProtectionEnabled(bool value);

    [MethodImpl]
    public extern void UpdateExtents(Vector2 value);

    [MethodImpl]
    public extern void UpdateLocationWithStationaryMode(
      SpatialCoordinateSystem coordinateSystem,
      Vector3 position,
      Quaternion orientation);

    [MethodImpl]
    public extern void UpdateLocationWithDisplayRelativeMode(
      Vector3 position,
      Quaternion orientation);

    /// <summary>Gets whether hardware content protection is supported for this quad layer.</summary>
    /// <returns>Whether hardware content protection is supported.</returns>
    public extern bool CanAcquireWithHardwareProtection { [MethodImpl] get; }

    /// <summary>Gets a hardware-protected Direct3D 11 back buffer whose contents will be displayed for this quad layer from this frame forward.</summary>
    /// <returns>The Direct3D 11 surface that holds the hardware-protected back buffer.</returns>
    [MethodImpl]
    public extern IDirect3DSurface AcquireBufferToUpdateContentWithHardwareProtection();
  }
}
