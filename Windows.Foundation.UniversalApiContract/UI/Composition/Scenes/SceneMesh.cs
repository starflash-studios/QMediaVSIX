// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneMesh
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.DirectX;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a mesh (the list of vertices that describe the polygons that make up a scene).</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [WebHostHidden]
  [DualApiPartition(version = 167772166)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISceneMeshStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  public sealed class SceneMesh : SceneObject, ISceneMesh
  {
    /// <summary>Gets the bounds of the mesh.</summary>
    /// <returns>The bounds of the mesh.</returns>
    public extern SceneBoundingBox Bounds { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates how the vertex data is interpreted by the graphics pipeline and rendered on screen.</summary>
    /// <returns>A value of the enumeration that indicates how the vertex data is interpreted.</returns>
    public extern DirectXPrimitiveTopology PrimitiveTopology { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates a copy of information about the mesh for use by this SceneMesh.</summary>
    /// <param name="semantic">The attribute semantic.</param>
    /// <param name="format">The pixel format.</param>
    /// <param name="memory">The memory buffer.</param>
    [MethodImpl]
    public extern void FillMeshAttribute(
      SceneAttributeSemantic semantic,
      DirectXPixelFormat format,
      MemoryBuffer memory);

    /// <summary>Creates an instance of SceneMesh.</summary>
    /// <param name="compositor">An instance of the Compositor class.</param>
    /// <returns>Returns the created SceneMesh object.</returns>
    [MethodImpl]
    public static extern SceneMesh Create(Compositor compositor);
  }
}
