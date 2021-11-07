// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.SceneMetallicRoughnessMaterial
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a material that has that has the appearance of metal.</summary>
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772166)]
  [Static(typeof (ISceneMetallicRoughnessMaterialStatics), 524288, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class SceneMetallicRoughnessMaterial : 
    ScenePbrMaterial,
    ISceneMetallicRoughnessMaterial
  {
    /// <summary>Gets or sets the input for material's base color.</summary>
    /// <returns>The input for for material's base color.</returns>
    public extern SceneMaterialInput BaseColorInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates the base color.</summary>
    /// <returns>A value that indicates the base color.</returns>
    public extern Vector4 BaseColorFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how metallic the material appears.</summary>
    /// <returns>A value that indicates how metallic the material appears.</returns>
    public extern float MetallicFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the input for how rough or smooth the material is.</summary>
    /// <returns>The input for how rough or smooth the material is.</returns>
    public extern SceneMaterialInput MetallicRoughnessInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how rough or smooth the material appears.</summary>
    /// <returns>A value that indicates how rough or smooth the material appears.</returns>
    public extern float RoughnessFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of SceneMetallicRoughnessMaterial.</summary>
    /// <param name="compositor">An instance of the Compositor class.</param>
    /// <returns>Returns the created SceneMetallicRoughnessMaterial object.</returns>
    [MethodImpl]
    public static extern SceneMetallicRoughnessMaterial Create(
      Compositor compositor);
  }
}
