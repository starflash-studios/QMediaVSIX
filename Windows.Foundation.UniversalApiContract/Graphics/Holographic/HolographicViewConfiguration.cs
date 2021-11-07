// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicViewConfiguration
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents a view configuration for a HolographicDisplay. This object provides apps with fine-grained control of the rendering configuration for a HolographicCamera.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HolographicViewConfiguration : 
    IHolographicViewConfiguration,
    IHolographicViewConfiguration2
  {
    /// <summary>Gets the native render target size for this HolographicViewConfiguration.</summary>
    /// <returns>A Size representing the native render target size for the HolographicViewConfiguration.</returns>
    public extern Size NativeRenderTargetSize { [MethodImpl] get; }

    /// <summary>Gets the render target size for this HolographicViewConfiguration.</summary>
    /// <returns>A Size representing the render target size for this HolographicViewConfiguration.</returns>
    public extern Size RenderTargetSize { [MethodImpl] get; }

    /// <summary>Requests a new minimum render target size for this HolographicViewConfiguration.</summary>
    /// <param name="size">A Size representing the desired render target size. Must be at least [1, 1].</param>
    /// <returns>A Size representing the render target size that was actually set.</returns>
    [MethodImpl]
    public extern Size RequestRenderTargetSize(Size size);

    /// <summary>Gets a list of the supported pixel formats for this HolographicViewConfiguration.</summary>
    /// <returns>A collection of Windows.Graphics.DirectX.DirectXPixelFormat values, each of which can be set using the HolographicViewConfiguration.PixelFormat property.</returns>
    public extern IVectorView<DirectXPixelFormat> SupportedPixelFormats { [MethodImpl] get; }

    /// <summary>Gets or sets the pixel format of this HolographicViewConfiguration.</summary>
    /// <returns>A Windows.Graphics.DirectX.DirectXPixelFormat value.</returns>
    public extern DirectXPixelFormat PixelFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets whether this HolographicViewConfiguration is stereoscopic.</summary>
    /// <returns>This value is `true` if the HolographicViewConfiguration is stereoscopic, otherwise `false`.</returns>
    public extern bool IsStereo { [MethodImpl] get; }

    /// <summary>Gets the refresh rate for this HolographicViewConfiguration.</summary>
    /// <returns>A double-precision floating point number representing the refresh rate frequency, in Hertz (Hz).</returns>
    public extern double RefreshRate { [MethodImpl] get; }

    /// <summary>Gets the kind of rendering this HolographicViewConfiguration is for.</summary>
    /// <returns>A HolographicViewConfigurationKind specifying a kind of HolographicViewConfiguration for a HolographicDisplay.</returns>
    public extern HolographicViewConfigurationKind Kind { [MethodImpl] get; }

    /// <summary>Gets the HolographicDisplay which this HolographicViewConfiguration is for.</summary>
    /// <returns>The HolographicDisplay which this HolographicViewConfiguration is for.</returns>
    public extern HolographicDisplay Display { [MethodImpl] get; }

    /// <summary>Gets or sets whether this HolographicViewConfiguration is enabled.</summary>
    /// <returns>This value is `true` if the HolographicViewConfiguration is enabled, otherwise `false`.</returns>
    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern IVectorView<HolographicDepthReprojectionMethod> SupportedDepthReprojectionMethods { [MethodImpl] get; }
  }
}
