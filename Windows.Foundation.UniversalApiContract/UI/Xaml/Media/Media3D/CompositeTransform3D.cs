// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.CompositeTransform3D
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media.Media3D
{
  /// <summary>Represents 3-D scale, rotation, and translate transforms to be applied to an element.</summary>
  [WebHostHidden]
  [Static(typeof (ICompositeTransform3DStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CompositeTransform3D : Transform3D, ICompositeTransform3D
  {
    /// <summary>Initializes a new instance of the CompositeTransform3D class.</summary>
    [MethodImpl]
    public extern CompositeTransform3D();

    /// <summary>Gets the x-coordinate of the center point in pixels for all transforms specified by the CompositeTransform3D.</summary>
    /// <returns>The x-coordinate of the center point for all transforms specified by the CompositeTransform3D. The default value is 0.</returns>
    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the y-coordinate of the center point in pixels for all transforms specified by the CompositeTransform3D.</summary>
    /// <returns>The y-coordinate of the center point for all transforms specified by the CompositeTransform3D. The default value is 0.</returns>
    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the z-coordinate of the center point in pixels for all transforms specified by the CompositeTransform3D.</summary>
    /// <returns>The z-coordinate of the center point for all transforms specified by the CompositeTransform3D. The default value is 0.</returns>
    public extern double CenterZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle in degrees of counterclockwise rotation around the x-axis.</summary>
    /// <returns>The angle of rotation around the x-axis, given in degrees in a counterclockwise direction. The default value is 0 degrees.</returns>
    public extern double RotationX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle in degrees of counterclockwise rotation around the y-axis.</summary>
    /// <returns>The angle of rotation around the y-axis, given in degrees in a counterclockwise direction. The default value is 0 degrees.</returns>
    public extern double RotationY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle in degrees of counterclockwise rotation around the z-axis.</summary>
    /// <returns>The angle of rotation around the z-axis, given in degrees in a counterclockwise direction. The default value is 0 degrees.</returns>
    public extern double RotationZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-axis scale factor. You can use this property to stretch or shrink an object along this axis.</summary>
    /// <returns>The scale factor along the x-axis. The default is 1.</returns>
    public extern double ScaleX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-axis scale factor. You can use this property to stretch or shrink an object along this axis.</summary>
    /// <returns>The scale factor along the y-axis. The default is 1.</returns>
    public extern double ScaleY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the z-axis scale factor. You can use this property to stretch or shrink an object along this axis.</summary>
    /// <returns>The scale factor along the z-axis. The default is 1.</returns>
    public extern double ScaleZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance to translate along the x-axis in pixels.</summary>
    /// <returns>The distance to translate (move) an object along the x-axis, in pixels. The default value is 0.</returns>
    public extern double TranslateX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance to translate along the y-axis in pixels.</summary>
    /// <returns>The distance to translate (move) an object along the y-axis, in pixels. The default value is 0.</returns>
    public extern double TranslateY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance to translate along the z-axis in pixels.</summary>
    /// <returns>The distance to translate (move) an object along the z-axis, in pixels. The default value is 0.</returns>
    public extern double TranslateZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the CenterX dependency property.</summary>
    /// <returns>The CenterX dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterY dependency property.</summary>
    /// <returns>The CenterY dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterZ dependency property.</summary>
    /// <returns>The CenterZ dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RotationX dependency property.</summary>
    /// <returns>The RotationX dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RotationY dependency property.</summary>
    /// <returns>The RotationY dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RotationZ dependency property.</summary>
    /// <returns>The RotationZ dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the ScaleX dependency property.</summary>
    /// <returns>The ScaleX dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty ScaleXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the ScaleY dependency property.</summary>
    /// <returns>The ScaleY dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty ScaleYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the ScaleZ dependency property.</summary>
    /// <returns>The ScaleZ dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty ScaleZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the TranslateX dependency property.</summary>
    /// <returns>The TranslateX dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty TranslateXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the TranslateY dependency property.</summary>
    /// <returns>The TranslateY dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty TranslateYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the TranslateZ dependency property.</summary>
    /// <returns>The TranslateZ dependency property identifier.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty TranslateZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
