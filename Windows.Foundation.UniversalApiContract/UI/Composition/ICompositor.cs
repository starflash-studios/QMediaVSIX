// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (Compositor))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Guid(3020147280, 32652, 20099, 152, 95, 204, 69, 6, 0, 54, 216)]
  internal interface ICompositor
  {
    ColorKeyFrameAnimation CreateColorKeyFrameAnimation();

    [Overload("CreateColorBrush")]
    CompositionColorBrush CreateColorBrush();

    [Overload("CreateColorBrushWithColor")]
    CompositionColorBrush CreateColorBrush(Color color);

    ContainerVisual CreateContainerVisual();

    CubicBezierEasingFunction CreateCubicBezierEasingFunction(
      Vector2 controlPoint1,
      Vector2 controlPoint2);

    [Overload("CreateEffectFactory")]
    CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect);

    [Overload("CreateEffectFactoryWithProperties")]
    CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect,
      IIterable<string> animatableProperties);

    [Overload("CreateExpressionAnimation")]
    ExpressionAnimation CreateExpressionAnimation();

    [Overload("CreateExpressionAnimationWithExpression")]
    ExpressionAnimation CreateExpressionAnimation(string expression);

    [Overload("CreateInsetClip")]
    InsetClip CreateInsetClip();

    [Overload("CreateInsetClipWithInsets")]
    InsetClip CreateInsetClip(
      float leftInset,
      float topInset,
      float rightInset,
      float bottomInset);

    LinearEasingFunction CreateLinearEasingFunction();

    CompositionPropertySet CreatePropertySet();

    QuaternionKeyFrameAnimation CreateQuaternionKeyFrameAnimation();

    ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation();

    CompositionScopedBatch CreateScopedBatch(CompositionBatchTypes batchType);

    SpriteVisual CreateSpriteVisual();

    [Overload("CreateSurfaceBrush")]
    CompositionSurfaceBrush CreateSurfaceBrush();

    [Overload("CreateSurfaceBrushWithSurface")]
    CompositionSurfaceBrush CreateSurfaceBrush(ICompositionSurface surface);

    CompositionTarget CreateTargetForCurrentView();

    Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation();

    Vector3KeyFrameAnimation CreateVector3KeyFrameAnimation();

    Vector4KeyFrameAnimation CreateVector4KeyFrameAnimation();

    CompositionCommitBatch GetCommitBatch(CompositionBatchTypes batchType);
  }
}
