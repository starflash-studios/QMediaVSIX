// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Capture.Direct3D11CaptureFramePool
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;
using Windows.Graphics.DirectX.Direct3D11;
using Windows.System;

namespace Windows.Graphics.Capture
{
  /// <summary>Stores frames captured by the application.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [WebHostHidden]
  [Static(typeof (IDirect3D11CaptureFramePoolStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDirect3D11CaptureFramePoolStatics2), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  public sealed class Direct3D11CaptureFramePool : IDirect3D11CaptureFramePool, IClosable
  {
    /// <summary>Recreates the frame pool based on the given inputs.</summary>
    /// <param name="device">The Direct3D device.</param>
    /// <param name="pixelFormat">The DirectX pixel format of the captured frames.</param>
    /// <param name="numberOfBuffers">The number of buffers in which to store captured frames.</param>
    /// <param name="size">The size of each buffer.</param>
    [MethodImpl]
    public extern void Recreate(
      IDirect3DDevice device,
      DirectXPixelFormat pixelFormat,
      int numberOfBuffers,
      SizeInt32 size);

    /// <summary>Tries to get the next captured frame from the frame pool.</summary>
    /// <returns>The next captured frame in the frame pool; if the pool is empty, this method returns **null**.</returns>
    [MethodImpl]
    public extern Direct3D11CaptureFrame TryGetNextFrame();

    /// <summary>An event raised when a captured frame is stored in the frame pool.</summary>
    public extern event TypedEventHandler<Direct3D11CaptureFramePool, object> FrameArrived;

    /// <summary>Creates a capture session based on the given capture item and frame pool.</summary>
    /// <param name="item">The capture item (the target of the capture).</param>
    /// <returns>A capture session created from the given capture item and frame pool.</returns>
    [MethodImpl]
    public extern GraphicsCaptureSession CreateCaptureSession(
      GraphicsCaptureItem item);

    /// <summary>The **DispatcherQueue** for the frame pool.</summary>
    /// <returns>The **DispatcherQueue** for the frame pool.</returns>
    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    /// <summary>Creates a frame pool where the dependency on the DispatcherQueue is removed and the FrameArrived event is raised on the frame pool's internal worker thread.</summary>
    /// <param name="device">The Direct3D device.</param>
    /// <param name="pixelFormat">The DirectX pixel format of the captured frames.</param>
    /// <param name="numberOfBuffers">The number of buffers in which to store captured frames.</param>
    /// <param name="size">The size of each buffer.</param>
    /// <returns>A frame pool created with the given inputs.</returns>
    [MethodImpl]
    public static extern Direct3D11CaptureFramePool CreateFreeThreaded(
      IDirect3DDevice device,
      DirectXPixelFormat pixelFormat,
      int numberOfBuffers,
      SizeInt32 size);

    /// <summary>Creates a frame pool.</summary>
    /// <param name="device">The Direct3D device.</param>
    /// <param name="pixelFormat">The DirectX pixel format of the captured frames.</param>
    /// <param name="numberOfBuffers">The number of buffers in which to store captured frames.</param>
    /// <param name="size">The size of each buffer.</param>
    /// <returns>A frame pool created with the given inputs.</returns>
    [MethodImpl]
    public static extern Direct3D11CaptureFramePool Create(
      IDirect3DDevice device,
      DirectXPixelFormat pixelFormat,
      int numberOfBuffers,
      SizeInt32 size);
  }
}
