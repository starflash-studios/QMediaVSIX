// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.LimiterEffectDefinition
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
  /// <summary>Represents a limiter effect definition supported by the audio graph.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ILimiterEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class LimiterEffectDefinition : ILimiterEffectDefinition, IAudioEffectDefinition
  {
    /// <summary>Initializes a new instance of the LimiterEffectDefinition class.</summary>
    /// <param name="audioGraph">The AudioGraph with which the effect will be used. Using effects outside of the audio graph it was created with is not supported.</param>
    [MethodImpl]
    public extern LimiterEffectDefinition(AudioGraph audioGraph);

    /// <summary>Gets or sets the release included in the limiter effect definition.</summary>
    /// <returns>The release value.</returns>
    public extern uint Release { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the loudness included in the limiter effect definition.</summary>
    /// <returns>A value indicating the loudness.</returns>
    public extern uint Loudness { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the activatable class ID for the limiter effect definition object.</summary>
    /// <returns>The activatable class ID.</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets the properties supported by the limiter effect definition.</summary>
    /// <returns>The set of properties.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
