// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor5
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1223307693, 32717, 16502, 167, 156, 144, 204, 75, 133, 44, 155)]
  [ContractVersion(typeof (UniversalApiContract), 393216)]
  [ExclusiveTo(typeof (Compositor))]
  [WebHostHidden]
  internal interface ICompositor5
  {
    string Comment { get; set; }

    float GlobalPlaybackRate { get; set; }

    BounceScalarNaturalMotionAnimation CreateBounceScalarAnimation();

    BounceVector2NaturalMotionAnimation CreateBounceVector2Animation();

    BounceVector3NaturalMotionAnimation CreateBounceVector3Animation();

    CompositionContainerShape CreateContainerShape();

    CompositionEllipseGeometry CreateEllipseGeometry();

    CompositionLineGeometry CreateLineGeometry();

    [Overload("CreatePathGeometry")]
    CompositionPathGeometry CreatePathGeometry();

    [Overload("CreatePathGeometryWithPath")]
    CompositionPathGeometry CreatePathGeometry(CompositionPath path);

    PathKeyFrameAnimation CreatePathKeyFrameAnimation();

    CompositionRectangleGeometry CreateRectangleGeometry();

    CompositionRoundedRectangleGeometry CreateRoundedRectangleGeometry();

    ShapeVisual CreateShapeVisual();

    [Overload("CreateSpriteShape")]
    CompositionSpriteShape CreateSpriteShape();

    [Overload("CreateSpriteShapeWithGeometry")]
    CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry);

    CompositionViewBox CreateViewBox();

    [RemoteAsync]
    IAsyncAction RequestCommitAsync();
  }
}
