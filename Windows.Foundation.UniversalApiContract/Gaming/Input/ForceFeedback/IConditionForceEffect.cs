// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IConditionForceEffect
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ExclusiveTo(typeof (ConditionForceEffect))]
  [Guid(852617832, 13973, 20073, 133, 192, 205, 25, 68, 24, 145, 64)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IConditionForceEffect : IForceFeedbackEffect
  {
    ConditionForceEffectKind Kind { get; }

    void SetParameters(
      Vector3 direction,
      float positiveCoefficient,
      float negativeCoefficient,
      float maxPositiveMagnitude,
      float maxNegativeMagnitude,
      float deadZone,
      float bias);
  }
}
