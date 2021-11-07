// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.CompositeTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Applies multiple transform operations to an object.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICompositeTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CompositeTransform : Transform, ICompositeTransform
  {
    /// <summary>Initializes a new instance of the CompositeTransform class.</summary>
    [MethodImpl]
    public extern CompositeTransform();

    /// <summary>Gets or sets the x-coordinate of the center point for all transforms specified by the CompositeTransform in device-independent pixel (DIP) relative to the upper left-hand corner of the element.</summary>
    /// <returns>The x-coordinate of the center point for all transforms specified by the CompositeTransform.</returns>
    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-coordinate of the center point for all transforms specified by the CompositeTransform in device-independent pixel (DIP) relative to the upper left-hand corner of the element.</summary>
    /// <returns>The y-coordinate of the center point for all transforms specified by the CompositeTransform.</returns>
    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-axis scale factor. You can use this property to stretch or shrink an object horizontally.</summary>
    /// <returns>The scale factor along the x-axis. The default is 1.</returns>
    public extern double ScaleX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-axis scale factor. You can use this property to stretch or shrink an object vertically.</summary>
    /// <returns>The scale factor along the y-axis. The default is 1.</returns>
    public extern double ScaleY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-axis skew angle, which is measured in degrees counterclockwise from the y-axis. A skew transform can be useful for creating the illusion of three-dimensional depth in a two-dimensional object.</summary>
    /// <returns>The skew angle, which is measured in degrees counterclockwise from the y-axis. The default is 0.</returns>
    public extern double SkewX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-axis skew angle, which is measured in degrees counterclockwise from the x-axis. A skew transform can be useful for creating the illusion of three-dimensional depth in a two-dimensional object.</summary>
    /// <returns>The skew angle, which is measured in degrees counterclockwise from the x-axis. The default is 0.</returns>
    public extern double SkewY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle, in degrees, of clockwise rotation.</summary>
    /// <returns>The angle, in degrees, of clockwise rotation. The default is 0.</returns>
    public extern double Rotation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance to translate along the x-axis.</summary>
    /// <returns>The distance to translate (move) an object along the x-axis, in pixels. This property is read/write. The default is 0.</returns>
    public extern double TranslateX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance to translate (move) an object along the y-axis.</summary>
    /// <returns>The distance to translate (move) an object along the y-axis, in pixels. The default is 0.</returns>
    public extern double TranslateY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the CenterX dependency property.</summary>
    /// <returns>The identifier for the CenterX dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterY dependency property.</summary>
    /// <returns>The identifier for the CenterY dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the ScaleX dependency property.</summary>
    /// <returns>The identifier for the ScaleX dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the ScaleY dependency property.</summary>
    /// <returns>The identifier for the ScaleY dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the SkewX dependency property.</summary>
    /// <returns>The identifier for the SkewX dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty SkewXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the SkewY dependency property.</summary>
    /// <returns>The identifier for the SkewY dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty SkewYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the Rotation dependency property.</summary>
    /// <returns>The identifier for the Rotation dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty RotationProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the TranslateX dependency property.</summary>
    /// <returns>The identifier for the TranslateX dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the TranslateY dependency property.</summary>
    /// <returns>The identifier for the TranslateY dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
