// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Holographic.HolographicQuadLayer
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.Graphics.Holographic
{
  /// <summary>Represents a retained texture for the system to display at a specified location on top of the app's primary rendered content.</summary>
  [Activatable(typeof (IHolographicQuadLayerFactory), 327680, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 1)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  public sealed class HolographicQuadLayer : IClosable, IHolographicQuadLayer
  {
    /// <summary>Creates a new quad layer with a specified texture size, using a default pixel format of DXGI_FORMAT_B8G8R8A8_UNORM.</summary>
    /// <param name="size">The size in pixels of the texture that will back this quad layer.</param>
    [MethodImpl]
    public extern HolographicQuadLayer(Size size);

    /// <summary>Creates a new quad layer with a specified texture size and pixel format.</summary>
    /// <param name="size">The size in pixels of the texture that will back this quad layer.</param>
    /// <param name="pixelFormat">The pixel format for the texture that will back this quad layer.</param>
    [MethodImpl]
    public extern HolographicQuadLayer(Size size, DirectXPixelFormat pixelFormat);

    [MethodImpl]
    public extern void Close();

    /// <summary>The pixel format for the texture that will back this quad layer.</summary>
    /// <returns>The pixel format.</returns>
    public extern DirectXPixelFormat PixelFormat { [MethodImpl] get; }

    /// <summary>The size in pixels of the texture that will back this quad layer.</summary>
    /// <returns>The texture size.</returns>
    public extern Size Size { [MethodImpl] get; }
  }
}
