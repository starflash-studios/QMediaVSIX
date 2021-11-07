// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PlaneProjection
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a perspective transform (a 3-D-like effect) on an object.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPlaneProjectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PlaneProjection : Projection, IPlaneProjection
  {
    /// <summary>Initializes a new instance of the PlaneProjection class.</summary>
    [MethodImpl]
    public extern PlaneProjection();

    /// <summary>Gets or sets the distance that the object is translated along the x-axis of the plane of the object.</summary>
    /// <returns>The distance that the object is translated along the x-axis of the plane of the object.</returns>
    public extern double LocalOffsetX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance that the object is translated along the y-axis of the plane of the object.</summary>
    /// <returns>The distance that the object is translated along the y-axis of the plane of the object.</returns>
    public extern double LocalOffsetY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance that the object is translated along the z-axis of the plane of the object.</summary>
    /// <returns>The distance that the object is translated along the z-axis of the plane of the object.</returns>
    public extern double LocalOffsetZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of degrees to rotate the object around the x-axis of rotation.</summary>
    /// <returns>The number of degrees to rotate the object around the x-axis of rotation. The default is 0.</returns>
    public extern double RotationX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of degrees to rotate the object around the y-axis of rotation.</summary>
    /// <returns>The number of degrees to rotate the object around the y-axis of rotation. The default is 0.</returns>
    public extern double RotationY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of degrees to rotate the object around the z-axis of rotation.</summary>
    /// <returns>The number of degrees to rotate the object around the z-axis of rotation. The default is 0.</returns>
    public extern double RotationZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-coordinate of the center of rotation of the object that you rotate.</summary>
    /// <returns>The x-coordinate of the center of rotation of the object that you rotate. Typical values are between 0 and 1 with a value of 0 corresponding to one edge of the object and 1 to the opposite edge. Values outside this range are allowed and move the center of rotation accordingly. The default is 0.5 (the center of object).</returns>
    public extern double CenterOfRotationX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-coordinate of the center of rotation of the object that you rotate.</summary>
    /// <returns>The y-coordinate of the center of rotation of the object that you rotate. Typical values are between 0 and 1 with a value of 0 corresponding to one edge of the object and 1 to the opposite edge. Values outside this range are allowed and move the center of rotation accordingly. The default is 0.5 (the center of object).</returns>
    public extern double CenterOfRotationY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the z-coordinate of the center of rotation of the object that you rotate.</summary>
    /// <returns>The z-coordinate of the center of rotation of the object that you rotate. The default is 0. Values greater than 0 correspond to coordinates in front of the plane of the object, and negative values correspond to coordinates behind the plane of the object.</returns>
    public extern double CenterOfRotationZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance that the object is translated along the x-axis of the screen.</summary>
    /// <returns>The distance that the object is translated along the x-axis of the screen.</returns>
    public extern double GlobalOffsetX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance that the object is translated along the y-axis of the screen.</summary>
    /// <returns>The distance that the object is translated along the y-axis of the screen.</returns>
    public extern double GlobalOffsetY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the distance that the object is translated along the z-axis of the screen.</summary>
    /// <returns>The distance that the object is translated along the z-axis of the screen.</returns>
    public extern double GlobalOffsetZ { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the projection matrix of the PlaneProjection.</summary>
    /// <returns>The projection matrix of the PlaneProjection. The default value is null.</returns>
    public extern Matrix3D ProjectionMatrix { [MethodImpl] get; }

    /// <summary>Identifies the LocalOffsetX  dependency property.</summary>
    /// <returns>The identifier for the LocalOffsetX  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty LocalOffsetXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the LocalOffsetY  dependency property.</summary>
    /// <returns>The identifier for the LocalOffsetY  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty LocalOffsetYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the LocalOffsetZ  dependency property.</summary>
    /// <returns>The identifier for the LocalOffsetZ  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty LocalOffsetZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RotationX  dependency property.</summary>
    /// <returns>The identifier for the RotationX  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty RotationXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RotationY  dependency property.</summary>
    /// <returns>The identifier for the RotationY  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty RotationYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the RotationZ  dependency property.</summary>
    /// <returns>The identifier for the RotationZ  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty RotationZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterOfRotationX  dependency property.</summary>
    /// <returns>The identifier for the CenterOfRotationX  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterOfRotationXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterOfRotationY  dependency property.</summary>
    /// <returns>The identifier for the CenterOfRotationY  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterOfRotationYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterOfRotationZ  dependency property.</summary>
    /// <returns>The identifier for the CenterOfRotationZ  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterOfRotationZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the GlobalOffsetX  dependency property.</summary>
    /// <returns>The identifier for the GlobalOffsetX  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty GlobalOffsetXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the GlobalOffsetY  dependency property.</summary>
    /// <returns>The identifier for the GlobalOffsetY  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty GlobalOffsetYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the GlobalOffsetZ  dependency property.</summary>
    /// <returns>The identifier for the GlobalOffsetZ  dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty GlobalOffsetZProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the ProjectionMatrix dependency property.</summary>
    /// <returns>The identifier for the ProjectionMatrix dependency property.</returns>
    public static extern DependencyProperty ProjectionMatrixProperty { [MethodImpl] get; }
  }
}
