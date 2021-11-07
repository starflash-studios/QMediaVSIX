// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IForceFeedbackMotor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2369601916, 42474, 17686, 128, 38, 43, 0, 247, 78, 246, 229)]
  [ExclusiveTo(typeof (ForceFeedbackMotor))]
  internal interface IForceFeedbackMotor
  {
    bool AreEffectsPaused { get; }

    double MasterGain { get; set; }

    bool IsEnabled { get; }

    ForceFeedbackEffectAxes SupportedAxes { get; }

    [RemoteAsync]
    IAsyncOperation<ForceFeedbackLoadEffectResult> LoadEffectAsync(
      IForceFeedbackEffect effect);

    void PauseAllEffects();

    void ResumeAllEffects();

    void StopAllEffects();

    [RemoteAsync]
    IAsyncOperation<bool> TryDisableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryEnableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryResetAsync();

    [RemoteAsync]
    IAsyncOperation<bool> TryUnloadEffectAsync(IForceFeedbackEffect effect);
  }
}
