// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.PeriodicForceEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>A force feedback effect which applies a varying force, defined by a waveform, along a vector.</summary>
  [Activatable(typeof (IPeriodicForceEffectFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PeriodicForceEffect : IForceFeedbackEffect, IPeriodicForceEffect
  {
    /// <summary>Creates an instance of PeriodicForceEffect.</summary>
    /// <param name="effectKind">The type of effect to create.</param>
    [MethodImpl]
    public extern PeriodicForceEffect(PeriodicForceEffectKind effectKind);

    /// <summary>Specifies the percentage by which to reduce the force of the effect.</summary>
    /// <returns>Specifies the percentage by which to reduce the force of the effect.</returns>
    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The current state of the force feedback effect.</summary>
    /// <returns>The current state of the force feedback effect.</returns>
    public extern ForceFeedbackEffectState State { [MethodImpl] get; }

    /// <summary>Starts the force feedback effect.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the force feedback effect.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>The type of periodic force feedback effect.</summary>
    /// <returns>The type of periodic force feedback effect.</returns>
    public extern PeriodicForceEffectKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetParameters(
      Vector3 vector,
      float frequency,
      float phase,
      float bias,
      TimeSpan duration);

    [MethodImpl]
    public extern void SetParametersWithEnvelope(
      Vector3 vector,
      float frequency,
      float phase,
      float bias,
      float attackGain,
      float sustainGain,
      float releaseGain,
      TimeSpan startDelay,
      TimeSpan attackDuration,
      TimeSpan sustainDuration,
      TimeSpan releaseDuration,
      uint repeatCount);
  }
}
