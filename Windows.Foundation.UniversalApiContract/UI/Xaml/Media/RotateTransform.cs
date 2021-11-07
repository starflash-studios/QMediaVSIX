// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RotateTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Rotates an object around a specified point in a two-dimensional x-y coordinate system.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IRotateTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RotateTransform : Transform, IRotateTransform
  {
    /// <summary>Initializes a new instance of the RotateTransform class.</summary>
    [MethodImpl]
    public extern RotateTransform();

    /// <summary>Gets or sets the x-coordinate of the rotation center point for this transformation.</summary>
    /// <returns>The x-coordinate of the center of rotation, in pixels within the transform's frame of reference. The default is 0.</returns>
    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-coordinate of the rotation center point for this transformation.</summary>
    /// <returns>The y-coordinate of the center of rotation, in pixels within the transform's frame of reference. The default is 0.</returns>
    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the angle, in degrees, of clockwise rotation.</summary>
    /// <returns>The angle, in degrees, of clockwise rotation. The default is 0.</returns>
    public extern double Angle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the CenterX dependency property.</summary>
    /// <returns>The identifier for the CenterX dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterY dependency property.</summary>
    /// <returns>The identifier for the CenterY dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the Angle dependency property.</summary>
    /// <returns>The identifier for the Angle dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty AngleProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
