// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionMipmapSurface
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
  /// <summary>Represents a drawing surface for mipmap textures.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772166)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public sealed class CompositionMipmapSurface : 
    CompositionObject,
    ICompositionMipmapSurface,
    ICompositionSurface
  {
    /// <summary>Gets the number of texture levels in the mipmap.</summary>
    /// <returns>The number of texture levels in the mipmap.</returns>
    public extern uint LevelCount { [MethodImpl] get; }

    /// <summary>Gets the alpha mode of the mipmap surface.</summary>
    /// <returns>The alpha mode of the mipmap surface.</returns>
    public extern DirectXAlphaMode AlphaMode { [MethodImpl] get; }

    /// <summary>Gets the pixel format of the mipmap surface.</summary>
    /// <returns>The pixel format of the mipmap surface.</returns>
    public extern DirectXPixelFormat PixelFormat { [MethodImpl] get; }

    /// <summary>Gets the size of the mipmap surface.</summary>
    /// <returns>The size of the mipmap surface.</returns>
    public extern SizeInt32 SizeInt32 { [MethodImpl] get; }

    /// <summary>Retrieves the texture at the specified level of the mipmap.</summary>
    /// <param name="level">The level from which to retrieve the texture.</param>
    /// <returns>The texture at the specified level of the mipmap.</returns>
    [MethodImpl]
    public extern CompositionDrawingSurface GetDrawingSurfaceForLevel(
      uint level);
  }
}
