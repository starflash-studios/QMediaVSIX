// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Scenes.ScenePbrMaterial
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Scenes
{
  /// <summary>Represents a material that uses Physically Based Rendering (PBR).</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772166)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IScenePbrMaterialFactory), CompositionType.Public, 524288, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 524288)]
  public class ScenePbrMaterial : SceneMaterial, IScenePbrMaterial
  {
    /// <summary>Gets or sets the alpha cutoff for the material.</summary>
    /// <returns>The alpha cutoff for the material.</returns>
    public extern float AlphaCutoff { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the alpha mode for the material.</summary>
    /// <returns>The alpha mode for the material.</returns>
    public extern SceneAlphaMode AlphaMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the input for the material's emissive value.</summary>
    /// <returns>The input for the material's emissive value.</returns>
    public extern SceneMaterialInput EmissiveInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the material's emissive value.</summary>
    /// <returns>The material's emissive value.</returns>
    public extern Vector3 EmissiveFactor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the material has two sides.</summary>
    /// <returns>**true** if the material has two sides, **false** if the material has one side.</returns>
    public extern bool IsDoubleSided { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the input for material's normal.</summary>
    /// <returns>The input for for material's base normal.</returns>
    public extern SceneMaterialInput NormalInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the normal scale for the material.</summary>
    /// <returns>The normal scale for the material.</returns>
    public extern float NormalScale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the input for the material's occlusion.</summary>
    /// <returns>The input for the material's occlusion.</returns>
    public extern SceneMaterialInput OcclusionInput { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the occlusion strength.</summary>
    /// <returns>The occlusion strength.</returns>
    public extern float OcclusionStrength { [MethodImpl] get; [MethodImpl] set; }
  }
}
