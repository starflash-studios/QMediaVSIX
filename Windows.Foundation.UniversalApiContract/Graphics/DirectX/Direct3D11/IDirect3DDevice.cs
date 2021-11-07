// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.IDirect3DDevice
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  /// <summary>This represents an IDXGIDevice, and can be used to interop between Windows Runtime components that need to exchange **IDXGIDevice** references.</summary>
  [Guid(2742428843, 36191, 18000, 157, 62, 158, 174, 61, 155, 198, 112)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IDirect3DDevice : IClosable
  {
    /// <summary>Trims any graphics memory allocated by the graphics device on the app's behalf.</summary>
    void Trim();
  }
}
