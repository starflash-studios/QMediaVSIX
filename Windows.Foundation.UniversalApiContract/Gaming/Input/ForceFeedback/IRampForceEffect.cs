// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IRampForceEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(4059566681, 7334, 16512, 181, 109, 180, 63, 51, 84, 208, 82)]
  [ExclusiveTo(typeof (RampForceEffect))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRampForceEffect : IForceFeedbackEffect
  {
    void SetParameters(Vector3 startVector, Vector3 endVector, TimeSpan duration);

    void SetParametersWithEnvelope(
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
