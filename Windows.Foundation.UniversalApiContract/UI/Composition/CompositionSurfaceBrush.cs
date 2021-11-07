// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionSurfaceBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Paints a SpriteVisual with pixels from an ICompositionSurface.</summary>
  [DualApiPartition(version = 167772164)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class CompositionSurfaceBrush : 
    CompositionBrush,
    ICompositionSurfaceBrush,
    ICompositionSurfaceBrush2,
    ICompositionSurfaceBrush3
  {
    /// <summary>Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on SpriteVisual (as can happen under stretch, scale, rotation, and other transformations).</summary>
    /// <returns>Specifies the algorithm used for interpolating pixels from ICompositionSurface when they do not form a one-to-one mapping to pixels on SpriteVisual (as can happen under stretch, scale, rotation, and other transformations).</returns>
    public extern CompositionBitmapInterpolationMode BitmapInterpolationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Controls the positioning of the vertical axis of content with respect to the vertical axis of the SpriteVisual. The value is clamped from 0.0f to 1.0f with 0.0f representing the left vertical edge and 1.0f representing the right vertical edge of the SpriteVisual. By default this is set to 0.0f.</summary>
    /// <returns>The positioning of the vertical axis of content with respect to the vertical axis of the SpriteVisual. The value is clamped from 0.0f to 1.0f with 0.0f representing the left vertical edge and 1.0f representing the right vertical edge of the SpriteVisual. The default value is 0.5f.</returns>
    public extern float HorizontalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Controls the scaling that is applied to the contents the ICompositionSurface with respect to the size of the SpriteVisual that is being painted.</summary>
    /// <returns>Controls how the brush's content is scaled with respect to the size of the SpriteVisual it is painted onto.</returns>
    public extern CompositionStretch Stretch { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The ICompositionSurface associated with the CompositionSurfaceBrush.</summary>
    /// <returns>The composition surface associated with the CompositionSurfaceBrush.</returns>
    public extern ICompositionSurface Surface { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Controls the positioning of the horizontal axis of content with respect to the horizontal axis of the SpriteVisual. The value is clamped from 0.0f to 1.0f with 0.0f representing the top horizontal edge and 1.0f representing the bottom horizontal edge of the SpriteVisual. The default value is 0.5f.</summary>
    /// <returns>The positioning of the horizontal axis of content with respect to the horizontal axis of the SpriteVisual.</returns>
    public extern float VerticalAlignmentRatio { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The point on the brush to be positioned at the brush's offset. Value is normalized with respect to the size of the SpriteVisual.</summary>
    /// <returns>The point on the brush to be positioned at the brush's offset. Value is normalized with respect to the size of the SpriteVisual.</returns>
    public extern Vector2 AnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The point about which the brush is rotated and scaled.</summary>
    /// <returns>The point about which the brush is rotated and scaled.</returns>
    public extern Vector2 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The offset of the brush relative to its SpriteVisual.</summary>
    /// <returns>The offset of the brush relative to its SpriteVisual.</returns>
    public extern Vector2 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The rotation angle, in radians, of the brush.</summary>
    /// <returns>The rotation angle, in radians, of the brush.</returns>
    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The rotation angle, in degrees, of the brush.</summary>
    /// <returns>The rotation angle, in degrees, of the brush.</returns>
    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The scale to apply to the brush.</summary>
    /// <returns>The scale to apply to the brush.</returns>
    public extern Vector2 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>The transformation matrix to apply to the brush.</summary>
    /// <returns>The transformation matrix to apply to the brush.</returns>
    public extern Matrix3x2 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the surface brush aligns with pixels.</summary>
    /// <returns>**true** if the surface brush aligns with pixels; otherwise, **false**.</returns>
    public extern bool SnapToPixels { [MethodImpl] get; [MethodImpl] set; }
  }
}
