// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IConstantForceEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(2616852800, 62407, 16732, 176, 104, 15, 6, 135, 52, 188, 224)]
  [ExclusiveTo(typeof (ConstantForceEffect))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IConstantForceEffect : IForceFeedbackEffect
  {
    void SetParameters(Vector3 vector, TimeSpan duration);

    void SetParametersWithEnvelope(
      Vector3 vector,
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
