// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.SpotLight
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>A light source that casts inner and outer cones of light. For example, a flashlight.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  public sealed class SpotLight : CompositionLight, ISpotLight, ISpotLight2, ISpotLight3
  {
    /// <summary>The constant coefficient in the light's attenuation equation. Controls light intensity. Animatable.</summary>
    /// <returns>The constant coefficient in the light's attenuation equation. Controls light intensity. Range is from 0 to infinity.</returns>
    public extern float ConstantAttenuation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The Visual used to determine the light's direction and offset. The light's offset and direction properties are relative to this Visual's coordinate space.</summary>
    /// <returns>The visual the light's offset is relative to.</returns>
    public extern Visual CoordinateSpace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The direction in which the light is pointing, specified relative to its CoordinateSpace Visual.</summary>
    /// <returns>The direction in which the light is pointing, specified relative to its coordinate space Visual.</returns>
    public extern Vector3 Direction { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The SpotLight’s inner cone angle, expressed as a semi-vertical angle in radians. Animatable.</summary>
    /// <returns>The SpotLight’s inner cone angle, expressed as a semi-vertical angle in radians.</returns>
    public extern float InnerConeAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The SpotLight’s inner cone angle, expressed as a semi-vertical angle in degrees. Animatable.</summary>
    /// <returns>The SpotLight’s inner cone angle, expressed as a semi-vertical angle in degrees.</returns>
    public extern float InnerConeAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Color of the spotlight's inner cone. Animatable.</summary>
    /// <returns>Color of the spotlight's inner cone.</returns>
    public extern Color InnerConeColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The linear coefficient in the light's attenuation equation that determines how the light falls off with distance. Animatable.</summary>
    /// <returns>The linear coefficient in the light's attenuation equation that determines how the light falls off with distance. Range is from 0 to infinity.</returns>
    public extern float LinearAttenuation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Offset of the light source relative to its CoordinateSpace Visual. Animatable.</summary>
    /// <returns>Offset of the light source relative to its coordinate space Visual.</returns>
    public extern Vector3 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The SpotLight’s outer cone angle, expressed as a semi-vertical angle in radians. Animatable.</summary>
    /// <returns>The SpotLight’s outer cone angle, expressed as a semi-vertical angle in radians. The value must be between 0 and pi.</returns>
    public extern float OuterConeAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The semi-vertical angle, in degrees, of the SpotLight's outer cone. Animatable.</summary>
    /// <returns>The semi-vertical angle, in degrees, of the SpotLight's outer cone.</returns>
    public extern float OuterConeAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The color of the spotlight's outer cone. Animatable.</summary>
    /// <returns>The color of the spotlight's outer cone.</returns>
    public extern Color OuterConeColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The quadratic portion of the attenuation equation that determines how the light falls off with distance. Animatable.</summary>
    /// <returns>The quadratic coefficient in the light's attenuation equation. Controls light intensity falloff based on distance squared. Range is from 0 to infinity.</returns>
    public extern float QuadraticAttenuation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the intensity of the light in the spotlight's inner cone.</summary>
    /// <returns>The intensity of the light.</returns>
    public extern float InnerConeIntensity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the intensity of the light in the spotlight's outer cone.</summary>
    /// <returns>The intensity of the light.</returns>
    public extern float OuterConeIntensity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum range at which this light is effective.</summary>
    /// <returns>The minimum range at which this light is effective. The default is 0.0.</returns>
    public extern float MinAttenuationCutoff { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum range at which this light is effective.</summary>
    /// <returns>The maximum range at which this light is effective. The default is 0.0.</returns>
    public extern float MaxAttenuationCutoff { [MethodImpl] get; [MethodImpl] set; }
  }
}
