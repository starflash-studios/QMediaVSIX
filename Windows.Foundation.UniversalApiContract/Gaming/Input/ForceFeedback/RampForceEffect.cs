// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.RampForceEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>A force feedback effect which applies a linearly increasing or decreasing force along a vector.</summary>
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class RampForceEffect : IForceFeedbackEffect, IRampForceEffect
  {
    /// <summary>Creates an instance of RampForceEffect.</summary>
    [MethodImpl]
    public extern RampForceEffect();

    /// <summary>Specifies the percentage by which to reduce the force of the effect.</summary>
    /// <returns>Specifies the percentage by which to reduce the force of the effect.</returns>
    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The current state of the effect.</summary>
    /// <returns>The current state of the effect.</returns>
    public extern ForceFeedbackEffectState State { [MethodImpl] get; }

    /// <summary>Starts the force feedback effect.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the effect.</summary>
    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void SetParameters(Vector3 startVector, Vector3 endVector, TimeSpan duration);

    [MethodImpl]
    public extern void SetParametersWithEnvelope(
      Vector3 startVector,
      Vector3 endVector,
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
