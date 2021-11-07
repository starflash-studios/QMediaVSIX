// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Effects.SceneLightingEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition.Effects
{
  /// <summary>Controls the reflective properties of a SpriteVisual. A SceneLightingEffect will overwrite CompositionLight defaults. It is used to control the reflective properties of a SpriteVisual. A NormalMap can be used as an input source but is not required.</summary>
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SceneLightingEffect : 
    ISceneLightingEffect,
    ISceneLightingEffect2,
    IGraphicsEffect,
    IGraphicsEffectSource
  {
    /// <summary>Creates an instance of SceneLightingEffect.</summary>
    [MethodImpl]
    public extern SceneLightingEffect();

    /// <summary>The proportion of predefined AmbientLight used by the effect.</summary>
    /// <returns>The proportion of predefined AmbientLight used by the effect. Values must be set between 0.0 and 1.0.</returns>
    public extern float AmbientAmount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Intensity of the diffuse light.</summary>
    /// <returns>Intensity of the diffuse light.</returns>
    public extern float DiffuseAmount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The normal map for the effect.</summary>
    /// <returns>The normal map for the effect.</returns>
    public extern IGraphicsEffectSource NormalMapSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Intensity of the specular light.</summary>
    /// <returns>Intensity of the specular light.</returns>
    public extern float SpecularAmount { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specular power for the Blinn-Phong lighting model.</summary>
    /// <returns>Specular power for the Blinn-Phong lighting model. Value must be set between 1.0 and 128. The default value is 16.</returns>
    public extern float SpecularShine { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates how the reflectance of a SceneLightingEffect is modeled.</summary>
    /// <returns>A value that indicates how the reflectance of a SceneLightingEffect is modeled.</returns>
    public extern SceneLightingEffectReflectanceModel ReflectanceModel { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Name of the light.</summary>
    /// <returns>Name of the light.</returns>
    public extern string Name { [MethodImpl] get; [MethodImpl] set; }
  }
}
