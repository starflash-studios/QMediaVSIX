// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.Direct3D11.Direct3DBindings
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX.Direct3D11
{
  /// <summary>This is a Windows Runtime equivalent of the Desktop D3D11_BIND_FLAG enumeration. Identifies the ways in which a resource may be bound to the graphics pipeline.</summary>
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum Direct3DBindings : uint
  {
    /// <summary>Bind a buffer as a vertex buffer to the input-assembler stage.</summary>
    VertexBuffer = 1,
    /// <summary>Bind a buffer as an index buffer to the input-assembler stage.</summary>
    IndexBuffer = 2,
    /// <summary>Bind a buffer as a constant buffer to a shader stage.</summary>
    ConstantBuffer = 4,
    /// <summary>Bind a buffer or texture to a shader stage.</summary>
    ShaderResource = 8,
    /// <summary>Bind an output buffer for the stream-output stage.</summary>
    StreamOutput = 16, // 0x00000010
    /// <summary>Bind a texture as a render target for the output-merger stage.</summary>
    RenderTarget = 32, // 0x00000020
    /// <summary>Bind a texture as a depth-stencil target for the output-merger stage.</summary>
    DepthStencil = 64, // 0x00000040
    /// <summary>Bind an unordered access resource.</summary>
    UnorderedAccess = 128, // 0x00000080
    /// <summary>Set this flag to indicate that a 2D texture is used to receive output from the decoder API.</summary>
    Decoder = 512, // 0x00000200
    /// <summary>Set this flag to indicate that a 2D texture is used to receive input from the video encoder API.</summary>
    VideoEncoder = 1024, // 0x00000400
  }
}
