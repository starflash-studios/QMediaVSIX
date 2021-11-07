// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.Direct3DSurfaceDescription
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  /// <summary>This is a Windows Runtime equivalent of the Desktop DXGI_SURFACE_DESC structure. Describes an IDirect3DSurface.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public struct Direct3DSurfaceDescription
  {
    /// <summary>Width of the surface.</summary>
    public int Width;
    /// <summary>Height of the surface.</summary>
    public int Height;
    /// <summary>Pixel format of the surface.</summary>
    public DirectXPixelFormat Format;
    /// <summary>Multi-sampling parameters for the surface.</summary>
    public Direct3DMultisampleDescription MultisampleDescription;
  }
}
