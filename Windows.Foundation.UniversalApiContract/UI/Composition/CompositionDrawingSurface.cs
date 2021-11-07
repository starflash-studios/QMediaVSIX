// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionDrawingSurface
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
  /// <summary>A drawing surface for interoperation with Direct2D or Direct3D.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ICompositionDrawingSurfaceFactory), CompositionType.Public, 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  public class CompositionDrawingSurface : 
    CompositionObject,
    ICompositionDrawingSurface,
    ICompositionDrawingSurface2,
    ICompositionSurface
  {
    /// <summary>The alpha mode of the drawing surface.</summary>
    /// <returns>The alpha mode of the drawing surface.</returns>
    public extern DirectXAlphaMode AlphaMode { [MethodImpl] get; }

    /// <summary>The pixel format of the drawing surface.</summary>
    /// <returns>The pixel format of the drawing surface.</returns>
    public extern DirectXPixelFormat PixelFormat { [MethodImpl] get; }

    /// <summary>The size of the drawing surface.</summary>
    /// <returns>The size of the drawing surface.</returns>
    public extern Size Size { [MethodImpl] get; }

    /// <summary>The size of the drawing surface.</summary>
    /// <returns>The size of the drawing surface.</returns>
    public extern SizeInt32 SizeInt32 { [MethodImpl] get; }

    /// <summary>Resizes the drawing surface to the specified size.</summary>
    /// <param name="sizePixels">The new size in pixels for the drawing surface.</param>
    [MethodImpl]
    public extern void Resize(SizeInt32 sizePixels);

    /// <summary>Scrolls the drawing surface.</summary>
    /// <param name="offset">The scrolling offset.</param>
    [Overload("Scroll")]
    [MethodImpl]
    public extern void Scroll(PointInt32 offset);

    /// <summary>Scrolls the drawing surface.</summary>
    /// <param name="offset">The scrolling offset.</param>
    /// <param name="scrollRect">The scrolling rectangle.</param>
    [Overload("ScrollRect")]
    [MethodImpl]
    public extern void Scroll(PointInt32 offset, RectInt32 scrollRect);

    /// <summary>Scrolls the drawing surface using the specified clip rectangle.</summary>
    /// <param name="offset">The scrolling offset.</param>
    /// <param name="clipRect">The clipping rectangle to apply.</param>
    [Overload("ScrollWithClip")]
    [MethodImpl]
    public extern void ScrollWithClip(PointInt32 offset, RectInt32 clipRect);

    /// <summary>Scrolls the drawing surface with the specified clip rectangle.</summary>
    /// <param name="offset">The scrolling offset.</param>
    /// <param name="clipRect">The clipping rectangle to apply.</param>
    /// <param name="scrollRect">The scrolling rectangle.</param>
    [Overload("ScrollRectWithClip")]
    [MethodImpl]
    public extern void ScrollWithClip(PointInt32 offset, RectInt32 clipRect, RectInt32 scrollRect);
  }
}
