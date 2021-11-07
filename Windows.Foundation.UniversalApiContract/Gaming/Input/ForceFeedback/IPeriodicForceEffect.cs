// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IPeriodicForceEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PeriodicForceEffect))]
  [Guid(1548826839, 64629, 19794, 154, 10, 239, 228, 202, 181, 254, 100)]
  internal interface IPeriodicForceEffect : IForceFeedbackEffect
  {
    PeriodicForceEffectKind Kind { get; }

    void SetParameters(
      Vector3 vector,
      float frequency,
      float phase,
      float bias,
      TimeSpan duration);

    void SetParametersWithEnvelope(
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
