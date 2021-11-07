// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.ReverbEffectDefinition
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Effects;

namespace Windows.Media.Audio
{
  /// <summary>Represents a reverberation effect definition supported by the audio graph.</summary>
  [Activatable(typeof (IReverbEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ReverbEffectDefinition : IReverbEffectDefinition, IAudioEffectDefinition
  {
    /// <summary>Initializes a new instance of the ReverbffectDefinition class.</summary>
    /// <param name="audioGraph">The AudioGraph with which the effect will be used. Using effects outside of the audio graph it was created with is not supported.</param>
    [MethodImpl]
    public extern ReverbEffectDefinition(AudioGraph audioGraph);

    /// <summary>Gets or sets the wet-dry audio voice mix for the reverberation effect definition.</summary>
    /// <returns>The wet-dry audio voice mix.</returns>
    public extern double WetDryMix { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the reflections delay included in the reverberation effect definition.</summary>
    /// <returns>The reflections delay value.</returns>
    public extern uint ReflectionsDelay { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the reverberation delay included in the reverberation effect definition.</summary>
    /// <returns>The reverberation delay value.</returns>
    public extern byte ReverbDelay { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the rear delay included in the reverberation effect definition.</summary>
    /// <returns>The rear delay value.</returns>
    public extern byte RearDelay { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the position left included in the reverberation effect definition.</summary>
    /// <returns>The position left value.</returns>
    public extern byte PositionLeft { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the position right included in the reverberation effect definition.</summary>
    /// <returns>The position right value.</returns>
    public extern byte PositionRight { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the matrix position left included in the reverberation effect definition.</summary>
    /// <returns>The matrix position left value.</returns>
    public extern byte PositionMatrixLeft { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the matrix position right included in the reverberation effect definition.</summary>
    /// <returns>The matrix position right value.</returns>
    public extern byte PositionMatrixRight { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the early diffusion value for the reverberation effect definition.</summary>
    /// <returns>The early diffusion value.</returns>
    public extern byte EarlyDiffusion { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the late diffusion included in the reverberation effect definition.</summary>
    /// <returns>The late diffusion value.</returns>
    public extern byte LateDiffusion { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the low equalization gain included in the reverberation effect definition.</summary>
    /// <returns>The low equalization gain value.</returns>
    public extern byte LowEQGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the low equalization cutoff included in the reverberation effect definition.</summary>
    /// <returns>The low equalization cutoff value.</returns>
    public extern byte LowEQCutoff { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the high equalization gain included in the reverberation effect definition.</summary>
    /// <returns>The high equalization gain value.</returns>
    public extern byte HighEQGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the high equalization cutoff included in the reverberation effect definition.</summary>
    /// <returns>The high equalization cutoff value.</returns>
    public extern byte HighEQCutoff { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the room filter frequency included in the reverberation effect definition.</summary>
    /// <returns>The room filter frequency value.</returns>
    public extern double RoomFilterFreq { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the main room filter included in the reverberation effect definition.</summary>
    /// <returns>The main room filter value.</returns>
    public extern double RoomFilterMain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the room filter high frequency included in the reverberation effect definition.</summary>
    /// <returns>The room filter high frequency value.</returns>
    public extern double RoomFilterHF { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the reflections gain included in the reverberation effect definition.</summary>
    /// <returns>The reflections gain value.</returns>
    public extern double ReflectionsGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the reverberation gain included in the reverberation effect definition.</summary>
    /// <returns>The reverberation gain value.</returns>
    public extern double ReverbGain { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the decay time supported by the reverberation effect definition.</summary>
    /// <returns>The decay time.</returns>
    public extern double DecayTime { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the density included in the reverberation effect definition.</summary>
    /// <returns>The density value.</returns>
    public extern double Density { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the room size included in the reverberation effect definition.</summary>
    /// <returns>A value indicating the room size.</returns>
    public extern double RoomSize { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets a value indicating if the reverberation effect disables late fields.</summary>
    /// <returns>True if the reverberation effect disables late fields, and false otherwise.</returns>
    public extern bool DisableLateField { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the activatable class ID for the reverberation effect definition object.</summary>
    /// <returns>The activatable class ID.</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the properties supported by the reverberation effect definition.</summary>
    /// <returns>The set of properties.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
