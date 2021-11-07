// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneMeshRendererComponent
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a component that renders a SceneMesh.</summary>
  [WebHostHidden]
  [Static(typeof (ISceneMeshRendererComponentStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772166)]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SceneMeshRendererComponent : 
    SceneRendererComponent,
    ISceneMeshRendererComponent
  {
    /// <summary>Gets or sets the material that describes how the mesh surface is rendered.</summary>
    /// <returns>The material that describes how the mesh surface is rendered.</returns>
    public extern SceneMaterial Material { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the SceneMesh to be rendered.</summary>
    /// <returns>The SceneMesh to be rendered.</returns>
    public extern SceneMesh Mesh { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the UV mappings for the material to the mesh.</summary>
    /// <returns>The UV mappings for the material to the mesh.</returns>
    public extern SceneMeshMaterialAttributeMap UVMappings { [MethodImpl] get; }

    /// <summary>Creates an instance of SceneMeshRendererComponent.</summary>
    /// <param name="compositor">An instance of the Compositor class.</param>
    /// <returns>Returns the created SceneMeshRendererComponent object.</returns>
    [MethodImpl]
    public static extern SceneMeshRendererComponent Create(
      Compositor compositor);
  }
}
