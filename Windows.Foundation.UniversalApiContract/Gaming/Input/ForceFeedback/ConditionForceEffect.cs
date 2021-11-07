// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ConditionForceEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>Conditional force effects are forces applied in response to current sensor values within the device. In other words, conditional force effects require information about device motion, such as position or velocity of a joystick handle. In general, conditional force effects are not associated with individual events during a game or other application. A conditional force effect does not have a predefined magnitude.</summary>
  [Activatable(typeof (IConditionForceEffectFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConditionForceEffect : IForceFeedbackEffect, IConditionForceEffect
  {
    /// <summary>Creates an instance of ConditionForceEffect.</summary>
    /// <param name="effectKind">The type of effect to create.</param>
    [MethodImpl]
    public extern ConditionForceEffect(ConditionForceEffectKind effectKind);

    /// <summary>Specifies the percentage by which to reduce the force of the effect.</summary>
    /// <returns>Specifies the percentage by which to reduce the force of the effect.</returns>
    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The current state of the effect.</summary>
    /// <returns>The current state of the effect.</returns>
    public extern ForceFeedbackEffectState State { [MethodImpl] get; }

    /// <summary>Starts the force feedback effect.</summary>
    [MethodImpl]
    public extern void Start();

    /// <summary>Stops the force feedback effect.</summary>
    [MethodImpl]
    public extern void Stop();

    /// <summary>The type of force feedback effect.</summary>
    /// <returns>The type of force feedback effect.</returns>
    public extern ConditionForceEffectKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetParameters(
      Vector3 direction,
      float positiveCoefficient,
      float negativeCoefficient,
      float maxPositiveMagnitude,
      float maxNegativeMagnitude,
      float deadZone,
      float bias);
  }
}
