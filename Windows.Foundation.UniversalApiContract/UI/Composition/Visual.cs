// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Visual
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>The base visual object in the visual hierarchy.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772164)]
  [Composable(typeof (IVisualFactory), CompositionType.Public, 131072, "Windows.Foundation.UniversalApiContract")]
  public class Visual : CompositionObject, IVisual, IVisual2, IVisual3, IVisual4
  {
    /// <summary>The point on the visual to be positioned at the visual's offset. Value is normalized with respect to the size of the visual. Animatable.</summary>
    /// <returns>The point on the visual to be positioned at the visual's offset. Value is normalized with respect to the size of the visual.</returns>
    public extern Vector2 AnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies whether the back face of the visual should be visible during a 3D transform.</summary>
    /// <returns>Whether the back face of the visual should be visible during a 3D transform.</returns>
    public extern CompositionBackfaceVisibility BackfaceVisibility { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies how to compose the edges of bitmaps and clips associated with a visual, or with all visuals in the subtree rooted at this visual. Setting BorderMode at a parent Visual will affect all children visuals in the subtree and can be selectively turned off at each child visual.</summary>
    /// <returns>How to compose the edges of bitmaps and clips associated with a visual, or with all visuals in the subtree rooted at this visual.</returns>
    public extern CompositionBorderMode BorderMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The point about which rotation or scaling occurs. Animatable</summary>
    /// <returns>The point about which rotation or scaling occurs.</returns>
    public extern Vector3 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the clipping region for the visual. When a visual is rendered, only the portion of the visual that falls inside the clipping region is displayed, while any content that extends outside the clipping region is clipped (that is, not displayed).</summary>
    /// <returns>Specifies the clipping region for the visual.</returns>
    public extern CompositionClip Clip { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies how a visual's bitmap is blended with the screen.</summary>
    /// <returns>How a visual's bitmap is blended with the screen.</returns>
    public extern CompositionCompositeMode CompositeMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Indicates whether the visual and its entire subtree of child visuals is visible.</summary>
    /// <returns>Indicates whether the visual and its entire subtree of child visuals is visible.</returns>
    public extern bool IsVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The offset of the visual relative to its parent or for a root visual the offset relative to the upper-left corner of the windows that hosts the visual. Animatable.</summary>
    /// <returns>Offset of the visual relative to its parent.</returns>
    public extern Vector3 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The opacity of the visual. Animatable.</summary>
    /// <returns>The opacity of the visual.</returns>
    public extern float Opacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>A quaternion describing an orientation and rotation in 3D space that will be applied to the visual. Animatable.</summary>
    /// <returns>A Quaternion describing an orientation and rotation in 3D space that will be applied to the visual.</returns>
    public extern Quaternion Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The parent of the visual.</summary>
    /// <returns>The parent of the visual.</returns>
    public extern ContainerVisual Parent { [MethodImpl] get; }

    /// <summary>The rotation angle in radians of the visual. Animatable.</summary>
    /// <returns>The rotation angle in radians of the visual.</returns>
    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The rotation angle of the visual in degrees. Animatable.</summary>
    /// <returns>The rotation angle of the visual in degrees.</returns>
    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The axis to rotate the visual around. Animatable.</summary>
    /// <returns>The axis to rotate the visual around. For example, a value of Vector3(1,0,0) indicates rotation along the x-axis.</returns>
    public extern Vector3 RotationAxis { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The scale to apply to the visual.</summary>
    /// <returns>The scale to apply to the visual. A value of Vector3 (1.0,1.0,1.0) is equivalent to 100%.</returns>
    public extern Vector3 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The width and height of the visual. Animatable.</summary>
    /// <returns>The width and height of the visual.</returns>
    public extern Vector2 Size { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The transformation matrix to apply to the visual. Animatable.</summary>
    /// <returns>The transformation matrix to apply to the visual.</returns>
    public extern Matrix4x4 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Visual specifying the coordinate system in which this visual is composed.</summary>
    /// <returns>Visual specifying the coordinate system in which this visual is composed.</returns>
    public extern Visual ParentForTransform { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Specifies the offset of the visual with respect to the size of its parent visual.</summary>
    /// <returns>The offset of the visual with respect to the size of its parent visual.</returns>
    public extern Vector3 RelativeOffsetAdjustment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The size of the visual with respect to the size of its parent visual.</summary>
    /// <returns>The size of the visual with respect to the size of its parent visual.</returns>
    public extern Vector2 RelativeSizeAdjustment { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsHitTestVisible { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPixelSnappingEnabled { [MethodImpl] get; [MethodImpl] set; }
  }
}
