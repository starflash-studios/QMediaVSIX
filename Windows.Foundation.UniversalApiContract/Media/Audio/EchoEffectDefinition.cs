// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.EchoEffectDefinition
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
  /// <summary>Represents an echo effect definition supported by the audio graph.</summary>
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IEchoEffectDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public sealed class EchoEffectDefinition : IEchoEffectDefinition, IAudioEffectDefinition
  {
    /// <summary>Creates an EchoEffectDefinition object.</summary>
    /// <param name="audioGraph">The AudioGraph with which the effect will be used. Using effects outside of the audio graph it was created with is not supported.</param>
    [MethodImpl]
    public extern EchoEffectDefinition(AudioGraph audioGraph);

    /// <summary>Gets or sets the wet-dry audio voice mix for the echo effect definition.</summary>
    /// <returns>A value indicating the wet-dry audio voice mix.</returns>
    public extern double WetDryMix { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the feedback included in the echo effect definition.</summary>
    /// <returns>A feedback value.</returns>
    public extern double Feedback { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets or sets the delay time, in milliseconds, of the echo effect definition.</summary>
    /// <returns>A value indicating the delay, in milliseconds.</returns>
    public extern double Delay { [MethodImpl] set; [MethodImpl] get; }

    /// <summary>Gets the activatable class ID for the echo effect definition object.</summary>
    /// <returns>The activatable class ID.</returns>
    public extern string ActivatableClassId { [MethodImpl] get; }

    /// <summary>Gets or sets the properties supported by the echo effect definition.</summary>
    /// <returns>The set of properties.</returns>
    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
