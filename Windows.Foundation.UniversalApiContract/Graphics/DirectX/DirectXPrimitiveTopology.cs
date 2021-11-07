// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.DirectXPrimitiveTopology
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX
{
  /// <summary>Values that indicate how the pipeline interprets vertex data that is bound to the input-assembler stage. These primitive topology values determine how the vertex data is rendered on screen. This is a Windows Runtime equivalent of the D3D_PRIMITIVE_TOPOLOGY enumeration.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public enum DirectXPrimitiveTopology
  {
    /// <summary>See D3D_PRIMITIVE_TOPOLOGY_UNDEFINED.</summary>
    Undefined,
    /// <summary>See D3D_PRIMITIVE_TOPOLOGY_POINTLIST.</summary>
    PointList,
    /// <summary>See D3D_PRIMITIVE_TOPOLOGY_LINELIST.</summary>
    LineList,
    /// <summary>See D3D_PRIMITIVE_TOPOLOGY_LINESTRIP.</summary>
    LineStrip,
    /// <summary>See D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST.</summary>
    TriangleList,
    /// <summary>See D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP.</summary>
    TriangleStrip,
  }
}
