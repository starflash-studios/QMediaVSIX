// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Compositor
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;
using Windows.System;

namespace Windows.UI.Composition
{
  /// <summary>Manages the session between an application and the system compositor process.</summary>
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICompositorStatics), 393216, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772164)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  public sealed class Compositor : 
    ICompositor,
    ICompositor2,
    ICompositor3,
    ICompositor4,
    ICompositor5,
    ICompositor6,
    ICompositorWithProjectedShadow,
    ICompositorWithRadialGradient,
    ICompositorWithVisualSurface,
    ICompositor7,
    ICompositorWithBlurredWallpaperBackdropBrush,
    IClosable
  {
    /// <summary>Creates an instance of Compositor.</summary>
    [MethodImpl]
    public extern Compositor();

    /// <summary>Creates an instance of ColorKeyFrameAnimation.</summary>
    /// <returns>Returns the created ColorKeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern ColorKeyFrameAnimation CreateColorKeyFrameAnimation();

    /// <summary>Creates an instance of CompositionColorBrush.</summary>
    /// <returns>Returns the created CompositionColorBrush object.</returns>
    [Overload("CreateColorBrush")]
    [MethodImpl]
    public extern CompositionColorBrush CreateColorBrush();

    /// <summary>Creates an instance of CompositionColorBrush using the specified color.</summary>
    /// <param name="color">The color for the brush to use.</param>
    /// <returns>Returns the created CompositionColorBrush object.</returns>
    [Overload("CreateColorBrushWithColor")]
    [MethodImpl]
    public extern CompositionColorBrush CreateColorBrush(Color color);

    /// <summary>Creates an instance of ContainerVisual.</summary>
    /// <returns>Returns the created ContainerVisual object.</returns>
    [MethodImpl]
    public extern ContainerVisual CreateContainerVisual();

    [MethodImpl]
    public extern CubicBezierEasingFunction CreateCubicBezierEasingFunction(
      Vector2 controlPoint1,
      Vector2 controlPoint2);

    /// <summary>Creates an instance of CompositionEffectFactory.</summary>
    /// <param name="graphicsEffect">The type of effect to create.</param>
    /// <returns>Returns the created CompositionEffectFactory object.</returns>
    [Overload("CreateEffectFactory")]
    [MethodImpl]
    public extern CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect);

    [Overload("CreateEffectFactoryWithProperties")]
    [MethodImpl]
    public extern CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect,
      IIterable<string> animatableProperties);

    /// <summary>Creates an instance of ExpressionAnimation.</summary>
    /// <returns>Returns the created ExpressionAnimation object.</returns>
    [Overload("CreateExpressionAnimation")]
    [MethodImpl]
    public extern ExpressionAnimation CreateExpressionAnimation();

    /// <summary>Creates an instance of ExpressionAnimation.</summary>
    /// <param name="expression">The expression describing how the ExpressionAnimation should calculate its current value.</param>
    /// <returns>Returns the created ExpressionAnimation object.</returns>
    [Overload("CreateExpressionAnimationWithExpression")]
    [MethodImpl]
    public extern ExpressionAnimation CreateExpressionAnimation(string expression);

    /// <summary>Creates an instance of InsetClip.</summary>
    /// <returns>Returns the created InsetClip object.</returns>
    [Overload("CreateInsetClip")]
    [MethodImpl]
    public extern InsetClip CreateInsetClip();

    /// <summary>Creates an instance of InsetClip.</summary>
    /// <param name="leftInset">Inset from the left of the visual.</param>
    /// <param name="topInset">Inset from the top of the visual.</param>
    /// <param name="rightInset">Inset from the right of the visual.</param>
    /// <param name="bottomInset">Inset from the bottom of the visual.</param>
    /// <returns>Returns the created InsetClip object.</returns>
    [Overload("CreateInsetClipWithInsets")]
    [MethodImpl]
    public extern InsetClip CreateInsetClip(
      float leftInset,
      float topInset,
      float rightInset,
      float bottomInset);

    /// <summary>Creates an instance of LinearEasingFunction.</summary>
    /// <returns>Returns the created LinearEasingFunction object.</returns>
    [MethodImpl]
    public extern LinearEasingFunction CreateLinearEasingFunction();

    /// <summary>Creates an instance of CompositionPropertySet.</summary>
    /// <returns>Returns the created CompositionPropertySet object.</returns>
    [MethodImpl]
    public extern CompositionPropertySet CreatePropertySet();

    /// <summary>Creates an instance of QuaternionKeyFrameAnimation.</summary>
    /// <returns>Returns the created QuaternionKeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern QuaternionKeyFrameAnimation CreateQuaternionKeyFrameAnimation();

    /// <summary>Creates an instance of ScalarKeyFrameAnimation.</summary>
    /// <returns>Returns the created ScalarKeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation();

    /// <summary>Creates an instance of CompositionScopedBatch.</summary>
    /// <param name="batchType">The type of composition batch to create.</param>
    /// <returns>Returns the created CompositionScopedBatch object.</returns>
    [MethodImpl]
    public extern CompositionScopedBatch CreateScopedBatch(
      CompositionBatchTypes batchType);

    /// <summary>Creates an instance of SpriteVisual.</summary>
    /// <returns>Returns the created SpriteVisual object.</returns>
    [MethodImpl]
    public extern SpriteVisual CreateSpriteVisual();

    /// <summary>Creates an instance of CompositionSurfaceBrush.</summary>
    /// <returns>Returns the created CompositionSurfaceBrush object.</returns>
    [Overload("CreateSurfaceBrush")]
    [MethodImpl]
    public extern CompositionSurfaceBrush CreateSurfaceBrush();

    /// <summary>Creates an instance of CompositionSurfaceBrush using the specified composition surface.</summary>
    /// <param name="surface">The composition surface to associate with the CompositionSurfaceBrush.</param>
    /// <returns>Returns the created CompositionSurfaceBrush object.</returns>
    [Overload("CreateSurfaceBrushWithSurface")]
    [MethodImpl]
    public extern CompositionSurfaceBrush CreateSurfaceBrush(
      ICompositionSurface surface);

    /// <summary>Creates a CompositionTarget for the current view.</summary>
    /// <returns>Returns the created CompositionTarget object.</returns>
    [MethodImpl]
    public extern CompositionTarget CreateTargetForCurrentView();

    /// <summary>Creates an instance of Vector2KeyFrameAnimation.</summary>
    /// <returns>Returns the created Vector2KeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation();

    /// <summary>Creates an instance of Vector3KeyFrameAnimation.</summary>
    /// <returns>Returns the created Vector3KeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern Vector3KeyFrameAnimation CreateVector3KeyFrameAnimation();

    /// <summary>Creates an instance of Vector4KeyFrameAnimation.</summary>
    /// <returns>Returns the created Vector4KeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern Vector4KeyFrameAnimation CreateVector4KeyFrameAnimation();

    /// <summary>Retrieves a commit batch for the current commit cycle.</summary>
    /// <param name="batchType">The batch type.</param>
    /// <returns>Returns a CompositionCommitBatch representing the retrieved commit batch.</returns>
    [MethodImpl]
    public extern CompositionCommitBatch GetCommitBatch(
      CompositionBatchTypes batchType);

    /// <summary>Creates an instance of AmbientLight.</summary>
    /// <returns>Returns the created AmbientLight object.</returns>
    [MethodImpl]
    public extern AmbientLight CreateAmbientLight();

    /// <summary>Creates an instance of CompositionAnimationGroup.</summary>
    /// <returns>Returns the created CompositionAnimationGroup object.</returns>
    [MethodImpl]
    public extern CompositionAnimationGroup CreateAnimationGroup();

    /// <summary>Creates an instance of CompositionBackdropBrush.</summary>
    /// <returns>Returns the created CompositionBackdropBrush object.</returns>
    [MethodImpl]
    public extern CompositionBackdropBrush CreateBackdropBrush();

    /// <summary>Creates an instance of DistantLight.</summary>
    /// <returns>Returns the created DistantLight object.</returns>
    [MethodImpl]
    public extern DistantLight CreateDistantLight();

    /// <summary>Creates an instance of DropShadow.</summary>
    /// <returns>Returns the created DropShadow object.</returns>
    [MethodImpl]
    public extern DropShadow CreateDropShadow();

    /// <summary>Creates an instance of ImplicitAnimationCollection.</summary>
    /// <returns>Returns the created ImplicitAnimationCollection object.</returns>
    [MethodImpl]
    public extern ImplicitAnimationCollection CreateImplicitAnimationCollection();

    /// <summary>Creates an instance of LayerVisual.</summary>
    /// <returns>Returns the created LayerVisual object.</returns>
    [MethodImpl]
    public extern LayerVisual CreateLayerVisual();

    /// <summary>Creates an instance of CompositionMaskBrush.</summary>
    /// <returns>Returns the created CompositionMaskBrush object.</returns>
    [MethodImpl]
    public extern CompositionMaskBrush CreateMaskBrush();

    /// <summary>Creates an instance of CompositionNineGridBrush.</summary>
    /// <returns>Returns the created CompositionNineGridBrush object.</returns>
    [MethodImpl]
    public extern CompositionNineGridBrush CreateNineGridBrush();

    /// <summary>Creates an instance of PointLight.</summary>
    /// <returns>Returns the created PointLight object.</returns>
    [MethodImpl]
    public extern PointLight CreatePointLight();

    /// <summary>Creates an instance of SpotLight.</summary>
    /// <returns>Returns the created SpotLight object.</returns>
    [MethodImpl]
    public extern SpotLight CreateSpotLight();

    /// <summary>Creates an instance of StepEasingFunction.</summary>
    /// <returns>Returns the created StepEasingFunction object.</returns>
    [Overload("CreateStepEasingFunction")]
    [MethodImpl]
    public extern StepEasingFunction CreateStepEasingFunction();

    /// <summary>Creates an instance of StepEasingFunction with the specified step count.</summary>
    /// <param name="stepCount">The step count for the StepEasingFunction.</param>
    /// <returns>Returns the created StepEasingFunction object.</returns>
    [Overload("CreateStepEasingFunctionWithStepCount")]
    [MethodImpl]
    public extern StepEasingFunction CreateStepEasingFunction(int stepCount);

    /// <summary>Creates an instance of  CompositionBackdropBrush that samples from the area behind the visual, before the window is drawn.</summary>
    /// <returns>Returns the created CompositionBackdropBrush.</returns>
    [MethodImpl]
    public extern CompositionBackdropBrush CreateHostBackdropBrush();

    /// <summary>Creates an instance of CompositionColorGradientStop.</summary>
    /// <returns>The created CompositionColorGradientStop object.</returns>
    [Overload("CreateColorGradientStop")]
    [MethodImpl]
    public extern CompositionColorGradientStop CreateColorGradientStop();

    /// <summary>Creates an instance of CompositionColorGradientStop with the specified offset and color.</summary>
    /// <param name="offset">The location of the gradient stop within the gradient vector.</param>
    /// <param name="color">The color of the gradient stop.</param>
    /// <returns>The created CompositionColorGradientStop object.</returns>
    [Overload("CreateColorGradientStopWithOffsetAndColor")]
    [MethodImpl]
    public extern CompositionColorGradientStop CreateColorGradientStop(
      float offset,
      Color color);

    /// <summary>Creates an instance of CompositionLinearGradientBrush.</summary>
    /// <returns>The created CompositionLinearGradientBrush object.</returns>
    [MethodImpl]
    public extern CompositionLinearGradientBrush CreateLinearGradientBrush();

    /// <summary>Creates an instance of SpringScalarNaturalMotionAnimation.</summary>
    /// <returns>The created SpringScalarNaturalMotionAnimation object.</returns>
    [MethodImpl]
    public extern SpringScalarNaturalMotionAnimation CreateSpringScalarAnimation();

    /// <summary>Creates an instance of SpringVector2NaturalMotionAnimation.</summary>
    /// <returns>The created SpringVector2NaturalMotionAnimation object.</returns>
    [MethodImpl]
    public extern SpringVector2NaturalMotionAnimation CreateSpringVector2Animation();

    /// <summary>Creates an instance of SpringVector3NaturalMotionAnimation.</summary>
    /// <returns>The created SpringVector3NaturalMotionAnimation object.</returns>
    [MethodImpl]
    public extern SpringVector3NaturalMotionAnimation CreateSpringVector3Animation();

    /// <summary>Gets or sets a string to associate with the Compositor.</summary>
    /// <returns>A string to associate with the Compositor.</returns>
    public extern string Comment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rate at which animation plays for all KeyFrame animations created by this compositor.</summary>
    /// <returns>The rate at which animation plays for all animations created by this compositor.</returns>
    public extern float GlobalPlaybackRate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Creates an instance of BounceScalarNaturalMotionAnimation.</summary>
    /// <returns>The created BounceScalarNaturalMotionAnimation object.</returns>
    [MethodImpl]
    public extern BounceScalarNaturalMotionAnimation CreateBounceScalarAnimation();

    /// <summary>Creates an instance of BounceVector2NaturalMotionAnimation.</summary>
    /// <returns>The created BounceVector2NaturalMotionAnimation object.</returns>
    [MethodImpl]
    public extern BounceVector2NaturalMotionAnimation CreateBounceVector2Animation();

    /// <summary>Creates an instance of BounceVector3NaturalMotionAnimation.</summary>
    /// <returns>The created BounceVector3NaturalMotionAnimation object.</returns>
    [MethodImpl]
    public extern BounceVector3NaturalMotionAnimation CreateBounceVector3Animation();

    /// <summary>Creates an instance of CompositionContainerShape.</summary>
    /// <returns>Returns the created CompositionContainerShape object.</returns>
    [MethodImpl]
    public extern CompositionContainerShape CreateContainerShape();

    /// <summary>Creates an instance of CompositionEllipseGeometry.</summary>
    /// <returns>Returns the created CompositionEllipseGeometry object.</returns>
    [MethodImpl]
    public extern CompositionEllipseGeometry CreateEllipseGeometry();

    /// <summary>Creates an instance of CompositionLineGeometry.</summary>
    /// <returns>Returns the created CompositionLineGeometry object.</returns>
    [MethodImpl]
    public extern CompositionLineGeometry CreateLineGeometry();

    /// <summary>Creates an instance of CompositionPathGeometry.</summary>
    /// <returns>Returns the created CompositionPathGeometry object.</returns>
    [Overload("CreatePathGeometry")]
    [MethodImpl]
    public extern CompositionPathGeometry CreatePathGeometry();

    /// <summary>Creates an instance of CompositionPathGeometry using the specified path.</summary>
    /// <param name="path">The path data.</param>
    /// <returns>Returns the created CompositionPathGeometry object.</returns>
    [Overload("CreatePathGeometryWithPath")]
    [MethodImpl]
    public extern CompositionPathGeometry CreatePathGeometry(
      CompositionPath path);

    /// <summary>Creates an instance of PathKeyFrameAnimation.</summary>
    /// <returns>Returns the created PathKeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern PathKeyFrameAnimation CreatePathKeyFrameAnimation();

    /// <summary>Creates an instance of CompositionRectangleGeometry.</summary>
    /// <returns>Returns the created CompositionRectangleGeometry object.</returns>
    [MethodImpl]
    public extern CompositionRectangleGeometry CreateRectangleGeometry();

    /// <summary>Creates an instance of CompositionRoundedRectangleGeometry.</summary>
    /// <returns>Returns the created CompositionRoundedRectangleGeometry object.</returns>
    [MethodImpl]
    public extern CompositionRoundedRectangleGeometry CreateRoundedRectangleGeometry();

    /// <summary>Creates an instance of ShapeVisual.</summary>
    /// <returns>Returns the created ShapeVisual object.</returns>
    [MethodImpl]
    public extern ShapeVisual CreateShapeVisual();

    /// <summary>Creates an instance of CompositionSpriteShape.</summary>
    /// <returns>Returns the created CompositionSpriteShape object.</returns>
    [Overload("CreateSpriteShape")]
    [MethodImpl]
    public extern CompositionSpriteShape CreateSpriteShape();

    /// <summary>Creates an instance of CompositionSpriteShape using the specified geometry.</summary>
    /// <param name="geometry">The geometry of the shape to create.</param>
    /// <returns>Returns the created CompositionSpriteShape object.</returns>
    [Overload("CreateSpriteShapeWithGeometry")]
    [MethodImpl]
    public extern CompositionSpriteShape CreateSpriteShape(
      CompositionGeometry geometry);

    /// <summary>Creates an instance of CompositionViewBox.</summary>
    /// <returns>Returns the created CompositionViewBox object.</returns>
    [MethodImpl]
    public extern CompositionViewBox CreateViewBox();

    /// <summary>Attempts to initiate a commit cycle ansynchronously.</summary>
    /// <returns>An ansynchronous action.</returns>
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RequestCommitAsync();

    /// <summary>Creates an instance of CompositionGeometricClip.</summary>
    /// <returns># Windows.UI.Composition.Compositor.CreateGeometricClip</returns>
    [Overload("CreateGeometricClip")]
    [MethodImpl]
    public extern CompositionGeometricClip CreateGeometricClip();

    /// <summary>Creates an instance of CompositionGeometricClip using the specified geometry.</summary>
    /// <param name="geometry">The geometry that defines the shape of the clip.</param>
    /// <returns>The created CompositionGeometricClip object.</returns>
    [Overload("CreateGeometricClipWithGeometry")]
    [MethodImpl]
    public extern CompositionGeometricClip CreateGeometricClip(
      CompositionGeometry geometry);

    /// <summary>Creates an instance of RedirectVisual.</summary>
    /// <returns>Returns the created RedirectVisual object.</returns>
    [Overload("CreateRedirectVisual")]
    [MethodImpl]
    public extern RedirectVisual CreateRedirectVisual();

    /// <summary>Creates an instance of RedirectVisual using the specified source.</summary>
    /// <param name="source">
    /// </param>
    /// <returns>Returns the created RedirectVisual object.</returns>
    [Overload("CreateRedirectVisualWithSourceVisual")]
    [MethodImpl]
    public extern RedirectVisual CreateRedirectVisual(Visual source);

    /// <summary>Creates an instance of BooleanKeyFrameAnimation.</summary>
    /// <returns>Returns the created BooleanKeyFrameAnimation object.</returns>
    [MethodImpl]
    public extern BooleanKeyFrameAnimation CreateBooleanKeyFrameAnimation();

    /// <summary>Creates an instance of CompositionProjectedShadowCaster.</summary>
    /// <returns>Returns the created CompositionProjectedShadowCaster object.</returns>
    [MethodImpl]
    public extern CompositionProjectedShadowCaster CreateProjectedShadowCaster();

    /// <summary>Creates an instance of CompositionProjectedShadow.</summary>
    /// <returns>Returns the created CompositionProjectedShadow object.</returns>
    [MethodImpl]
    public extern CompositionProjectedShadow CreateProjectedShadow();

    /// <summary>Creates an instance of CompositionProjectedShadowReceiver.</summary>
    /// <returns>Returns the created CompositionProjectedShadowReceiver object.</returns>
    [MethodImpl]
    public extern CompositionProjectedShadowReceiver CreateProjectedShadowReceiver();

    /// <summary>Creates an instance of CompositionRadialGradientBrush.</summary>
    /// <returns>Returns the created CompositionRadialGradientBrush object.</returns>
    [MethodImpl]
    public extern CompositionRadialGradientBrush CreateRadialGradientBrush();

    /// <summary>Creates an instance of CompositionVisualSurface.</summary>
    /// <returns>Returns the created CompositionVisualSurface object.</returns>
    [MethodImpl]
    public extern CompositionVisualSurface CreateVisualSurface();

    public extern DispatcherQueue DispatcherQueue { [MethodImpl] get; }

    [MethodImpl]
    public extern AnimationPropertyInfo CreateAnimationPropertyInfo();

    [Overload("CreateRectangleClip")]
    [MethodImpl]
    public extern RectangleClip CreateRectangleClip();

    [Overload("CreateRectangleClipWithSides")]
    [MethodImpl]
    public extern RectangleClip CreateRectangleClip(
      float left,
      float top,
      float right,
      float bottom);

    [Overload("CreateRectangleClipWithSidesAndRadius")]
    [MethodImpl]
    public extern RectangleClip CreateRectangleClip(
      float left,
      float top,
      float right,
      float bottom,
      Vector2 topLeftRadius,
      Vector2 topRightRadius,
      Vector2 bottomRightRadius,
      Vector2 bottomLeftRadius);

    [MethodImpl]
    public extern CompositionBackdropBrush TryCreateBlurredWallpaperBackdropBrush();

    [MethodImpl]
    public extern void Close();

    /// <summary>Gets the maximum allowed playback rate for all KeyFrame animations created by this compositor..</summary>
    /// <returns>The maximum allowed playback rate.</returns>
    public static extern float MaxGlobalPlaybackRate { [MethodImpl] get; }

    /// <summary>Gets the minimum allowed playback rate for all KeyFrame animations created by this compositor.</summary>
    /// <returns>The minimum allowed playback rate.</returns>
    public static extern float MinGlobalPlaybackRate { [MethodImpl] get; }
  }
}
