// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  /// <summary>This represents an IDXGISurface and can be used to interop between Windows Runtime components that need to exchange **IDXGISurface** references.</summary>
  [Guid(200581446, 5057, 18068, 190, 227, 122, 191, 21, 234, 245, 134)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDirect3DSurface : IClosable
  {
    /// <summary>Gets a Direct3DSurfaceDescription describing the surface.</summary>
    /// <returns>A Direct3DSurfaceDescription describing the surface.</returns>
    Direct3DSurfaceDescription Description { get; }
  }
}
