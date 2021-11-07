// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionGraphicsDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition
{
  /// <summary>Used to create all hardware bound resources for a given DirectX device on a compositor session. CompositionGraphicsDevice contains a DirectX device that is used to perform the GPU operations. Developers can obtain a Graphics device from the compositor top level object.</summary>
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CompositionGraphicsDevice : 
    CompositionObject,
    ICompositionGraphicsDevice,
    ICompositionGraphicsDevice2,
    ICompositionGraphicsDevice3,
    ICompositionGraphicsDevice4
  {
    /// <summary>Creates an instance of CompositionDrawingSurface.</summary>
    /// <param name="sizePixels">The size in pixels of the surface.</param>
    /// <param name="pixelFormat">The pixel format of the surface.</param>
    /// <param name="alphaMode">How the alpha channel should be handled.</param>
    /// <returns>The created CompositionDrawingSurface.</returns>
    [MethodImpl]
    public extern CompositionDrawingSurface CreateDrawingSurface(
      Size sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    /// <summary>Event triggered when the rendering device has been replaced.</summary>
    public extern event TypedEventHandler<CompositionGraphicsDevice, RenderingDeviceReplacedEventArgs> RenderingDeviceReplaced;

    /// <summary>Creates an instance of CompositionDrawingSurface.</summary>
    /// <param name="sizePixels">The size of the drawing surface in pixels.</param>
    /// <param name="pixelFormat">The pixel format of the drawing surface.</param>
    /// <param name="alphaMode">The alpha mode of the drawing surface.</param>
    /// <returns>Returns the created CompositionDrawingSurface.</returns>
    [MethodImpl]
    public extern CompositionDrawingSurface CreateDrawingSurface2(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    /// <summary>Creates an instance of CompositionVirtualDrawingSurface.</summary>
    /// <param name="sizePixels">The size in pixels of the drawing surface.</param>
    /// <param name="pixelFormat">The pixel format of the drawing surface.</param>
    /// <param name="alphaMode">The alpha mode of the drawing surface.</param>
    /// <returns>Returns the created CompositionVirtualDrawingSurface.</returns>
    [MethodImpl]
    public extern CompositionVirtualDrawingSurface CreateVirtualDrawingSurface(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    /// <summary>Creates an instance of CompositionMipMapSurface.</summary>
    /// <param name="sizePixels">The size in pixels of the surface.</param>
    /// <param name="pixelFormat">The pixel format of the surface.</param>
    /// <param name="alphaMode">How the alpha channel should be handled.</param>
    /// <returns>The created CompositionMipMapSurface.</returns>
    [MethodImpl]
    public extern CompositionMipmapSurface CreateMipmapSurface(
      SizeInt32 sizePixels,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode);

    /// <summary>Trims any graphics memory allocated by the graphics device on the app's behalf.</summary>
    [MethodImpl]
    public extern void Trim();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ICompositionSurface> CaptureAsync(
      Visual captureVisual,
      SizeInt32 size,
      DirectXPixelFormat pixelFormat,
      DirectXAlphaMode alphaMode,
      float sdrBoost);
  }
}
