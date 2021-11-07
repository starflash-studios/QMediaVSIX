// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.EqualizerEffectDefinition
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
  /// <summary>Represents an equalizer effect definition supported by the audio graph.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Activatable(typeof (IEqualizerEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EqualizerEffectDefinition : IEqualizerEffectDefinition, IAudioEffectDefinition
  {
    /// <summary>Initializes a new instance of the EqualizerEffectDefinition class.</summary>
    /// <param name="audioGraph">The AudioGraph with which the effect will be used. Using effects outside of the audio graph it was created with is not supported.</param>
    [MethodImpl]
    public extern EqualizerEffectDefinition(AudioGraph audioGraph);

    /// <summary>Gets the bands included in the equalizer effect definition.</summary>
    /// <returns>A collection of objects indicating the equalizer bands.</returns>
    public extern IVectorView<EqualizerBand> Bands { [MethodImpl] get; }

    /// <summary>Gets the activatable class ID for the equalizer effect definition object.</summary>
    /// <returns>The activatable class ID.</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the properties supported by the equalizer effect definition.</summary>
    /// <returns>The set of properties.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
