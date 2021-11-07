// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  /// <summary>Represents a brush that describes a gradient, composed of gradient stops.</summary>
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (ICompositionGradientBrushFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class CompositionGradientBrush : 
    CompositionBrush,
    ICompositionGradientBrush,
    ICompositionGradientBrush2
  {
    /// <summary>Gets or sets the point on the brush to be positioned at the brush's offset.</summary>
    /// <returns>The point on the brush to be positioned at the brush's offset.</returns>
    public extern Vector2 AnchorPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the point about which the brush is rotated and scaled.</summary>
    /// <returns>The point about which the brush is rotated and scaled.</returns>
    public extern Vector2 CenterPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the brush's gradient stops.</summary>
    /// <returns>A collection of the CompositionColorGradientStop objects associated with the brush, each of which specifies a color and an offset along the brush's gradient axis. The default is an empty CompositionColorGradientStopCollection.</returns>
    public extern CompositionColorGradientStopCollection ColorStops { [MethodImpl] get; }

    /// <summary>Gets or sets a value that specifies how to draw the gradient outside the brush's gradient vector or space.</summary>
    /// <returns>The mode used to paint the gradient.</returns>
    public extern CompositionGradientExtendMode ExtendMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies how the gradient's colors are interpolated.</summary>
    /// <returns>A value of the enumeration that specifies how the gradient's colors are interpolated.</returns>
    public extern CompositionColorSpace InterpolationSpace { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the offset of the brush relative to the object being painted.</summary>
    /// <returns>The offset of the brush relative to the object being painted.</returns>
    public extern Vector2 Offset { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rotation angle of the brush in radians.</summary>
    /// <returns>The rotation angle of the brush in radians.</returns>
    public extern float RotationAngle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the rotation angle of the brush in degrees.</summary>
    /// <returns>The rotation angle of the brush in degrees.</returns>
    public extern float RotationAngleInDegrees { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the scale to apply to the brush.</summary>
    /// <returns>The scale to apply to the brush.</returns>
    public extern Vector2 Scale { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the matrix of transforms to apply to the brush.</summary>
    /// <returns>The matrix of transforms to apply to the brush.</returns>
    public extern Matrix3x2 TransformMatrix { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the gradient brush's positioning coordinates (StartPoint, EndPoint) are absolute or relative to the output area.</summary>
    /// <returns>A value of the enumeration that indicates whether the gradient brush's positioning coordinates (StartPoint, EndPoint) are absolute or relative to the output area.</returns>
    public extern CompositionMappingMode MappingMode { [MethodImpl] get; [MethodImpl] set; }
  }
}
