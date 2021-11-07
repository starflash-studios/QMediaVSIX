// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ForceFeedbackMotor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  /// <summary>Encapsulates the force feedback hardware for a given input device.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class ForceFeedbackMotor : IForceFeedbackMotor
  {
    /// <summary>Boolean indicating whether force feedback effects are paused.</summary>
    /// <returns>Boolean indicating whether force feedback effects are paused.</returns>
    public extern bool AreEffectsPaused { [MethodImpl] get; }

    /// <summary>Specifies the percentage by which to reduce the force of all effects on the controller.</summary>
    /// <returns>Specifies the percentage by which to reduce the force of all effects on the controller.</returns>
    public extern double MasterGain { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Boolean indicating whether the force feedback motor is enabled.</summary>
    /// <returns>Boolean indicating whether the force feedback motor is enabled.</returns>
    public extern bool IsEnabled { [MethodImpl] get; }

    /// <summary>The axes supported by the force feedback motor.</summary>
    /// <returns>The axes supported by the force feedback motor.</returns>
    public extern ForceFeedbackEffectAxes SupportedAxes { [MethodImpl] get; }

    /// <summary>Attempts to asynchronously load a feedback effect to the device's internal memory.</summary>
    /// <param name="effect">The effect to load.</param>
    /// <returns>Returns the result of the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ForceFeedbackLoadEffectResult> LoadEffectAsync(
      IForceFeedbackEffect effect);

    /// <summary>Pauses all force feedback effects being executed.</summary>
    [MethodImpl]
    public extern void PauseAllEffects();

    /// <summary>Resumes all force feedback effects being executed.</summary>
    [MethodImpl]
    public extern void ResumeAllEffects();

    /// <summary>Stops all force feedback effects.</summary>
    [MethodImpl]
    public extern void StopAllEffects();

    /// <summary>Attempts to asynchronously disable the force feedback motor.</summary>
    /// <returns>Returns the result of the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryDisableAsync();

    /// <summary>Try to asynchronously enable the force feedback motor of the device.</summary>
    /// <returns>Returns the result of the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryEnableAsync();

    /// <summary>Attempts to asynchronously reset the device back to its initial state.</summary>
    /// <returns>Returns the result of the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryResetAsync();

    /// <summary>Attempts to asynchronously unload a feedback effect from the device's internal memory.</summary>
    /// <param name="effect">The effect to unload.</param>
    /// <returns>Returns the result of the asynchronous operation.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryUnloadEffectAsync(
      IForceFeedbackEffect effect);
  }
}
