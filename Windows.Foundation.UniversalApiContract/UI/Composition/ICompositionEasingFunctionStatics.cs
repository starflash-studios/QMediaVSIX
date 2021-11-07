// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEasingFunctionStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionEasingFunction))]
  [ContractVersion(typeof (UniversalApiContract), 786432)]
  [Guid(396846774, 10550, 21482, 181, 175, 198, 66, 244, 166, 16, 131)]
  internal interface ICompositionEasingFunctionStatics
  {
    CubicBezierEasingFunction CreateCubicBezierEasingFunction(
      Compositor owner,
      Vector2 controlPoint1,
      Vector2 controlPoint2);

    LinearEasingFunction CreateLinearEasingFunction(Compositor owner);

    [Overload("CreateStepEasingFunction")]
    StepEasingFunction CreateStepEasingFunction(Compositor owner);

    [Overload("CreateStepEasingFunctionWithStepCount")]
    StepEasingFunction CreateStepEasingFunction(Compositor owner, int stepCount);

    BackEasingFunction CreateBackEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      float amplitude);

    BounceEasingFunction CreateBounceEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      int bounces,
      float bounciness);

    CircleEasingFunction CreateCircleEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode);

    ElasticEasingFunction CreateElasticEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      int oscillations,
      float springiness);

    ExponentialEasingFunction CreateExponentialEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      float exponent);

    PowerEasingFunction CreatePowerEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      float power);

    SineEasingFunction CreateSineEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode);
  }
}
