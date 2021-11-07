// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEasingFunction
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Base class for interpolator functions to use with KeyFrameAnimations.</summary>
  [WebHostHidden]
  [Static(typeof (ICompositionEasingFunctionStatics), 786432, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772164)]
  [Composable(typeof (ICompositionEasingFunctionFactory), CompositionType.Public, 131072, "Windows.Foundation.UniversalApiContract")]
  public class CompositionEasingFunction : CompositionObject, ICompositionEasingFunction
  {
    [MethodImpl]
    public static extern CubicBezierEasingFunction CreateCubicBezierEasingFunction(
      Compositor owner,
      Vector2 controlPoint1,
      Vector2 controlPoint2);

    [MethodImpl]
    public static extern LinearEasingFunction CreateLinearEasingFunction(
      Compositor owner);

    [Overload("CreateStepEasingFunction")]
    [MethodImpl]
    public static extern StepEasingFunction CreateStepEasingFunction(
      Compositor owner);

    [Overload("CreateStepEasingFunctionWithStepCount")]
    [MethodImpl]
    public static extern StepEasingFunction CreateStepEasingFunction(
      Compositor owner,
      int stepCount);

    [MethodImpl]
    public static extern BackEasingFunction CreateBackEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      float amplitude);

    [MethodImpl]
    public static extern BounceEasingFunction CreateBounceEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      int bounces,
      float bounciness);

    [MethodImpl]
    public static extern CircleEasingFunction CreateCircleEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode);

    [MethodImpl]
    public static extern ElasticEasingFunction CreateElasticEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      int oscillations,
      float springiness);

    [MethodImpl]
    public static extern ExponentialEasingFunction CreateExponentialEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      float exponent);

    [MethodImpl]
    public static extern PowerEasingFunction CreatePowerEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode,
      float power);

    [MethodImpl]
    public static extern SineEasingFunction CreateSineEasingFunction(
      Compositor owner,
      CompositionEasingFunctionMode mode);
  }
}
