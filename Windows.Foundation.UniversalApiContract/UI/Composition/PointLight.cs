// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.PointLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>A point source of light that emanates light in all directions.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class PointLight : CompositionLight, IPointLight, IPointLight2, IPointLight3
  {
    /// <summary>Color of the light.</summary>
    /// <returns>Color of the light.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The constant coefficient in the light's attenuation equation. Controls light intensity.</summary>
    /// <returns>The constant coefficient in the light's attenuation equation. Controls light intensity. Range is from 0 to infinity.</returns>
    public extern float ConstantAttenuation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The Visual used to determine the light's offset. The light's offset property is relative to this Visual's coordinate space.</summary>
    /// <returns>The Visual used to determine the light's offset.</returns>
    public extern Visual CoordinateSpace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The linear coefficient in the light's attenuation equation that determines how the light falls-off with distance.</summary>
    /// <returns>The linear coefficient in the light's attenuation equation that determines how the light falls-off with distance. Range is from 0 to infinity.</returns>
    public extern float LinearAttenuation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Offset of the light source relative to its coordinate space Visual.</summary>
    /// <returns>Offset of the light source relative to its coordinate space Visual.</returns>
    public extern Vector3 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The quadratic portion of the attenuation equation that determines how the light falls off with distance.</summary>
    /// <returns>The quadratic portion of the attenuation equation that determines how the light falls off with distance. Controls light intensity falloff based on distance squared. Range is from 0 to infinity.</returns>
    public extern float QuadraticAttenuation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the intensity of the light.</summary>
    /// <returns>The intensity of the light.</returns>
    public extern float Intensity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum range at which this light is effective.</summary>
    /// <returns>The minimum range at which this light is effective. The default is 0.0.</returns>
    public extern float MinAttenuationCutoff { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum range at which this light is effective.</summary>
    /// <returns>The maximum range at which this light is effective. The default is 0.0.</returns>
    public extern float MaxAttenuationCutoff { [MethodImpl] get; [MethodImpl] set; }
  }
}
