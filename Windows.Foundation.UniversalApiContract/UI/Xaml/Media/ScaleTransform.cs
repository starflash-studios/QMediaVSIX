// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ScaleTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Scales an object in the two-dimensional x-y coordinate system.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IScaleTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ScaleTransform : Transform, IScaleTransform
  {
    /// <summary>Initializes a new instance of the ScaleTransform class.</summary>
    [MethodImpl]
    public extern ScaleTransform();

    /// <summary>Gets or sets the x-coordinate of the center point of this ScaleTransform.</summary>
    /// <returns>The x-coordinate of the center point of this ScaleTransform. The default is 0.</returns>
    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-coordinate of the center point of this ScaleTransform.</summary>
    /// <returns>The y-coordinate of the center point of this ScaleTransform. The default is 0.</returns>
    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-axis scale factor.</summary>
    /// <returns>The scale factor along the x-axis. The default is 1.</returns>
    public extern double ScaleX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-axis scale factor.</summary>
    /// <returns>The scale factor along the y-axis. The default is 1.</returns>
    public extern double ScaleY { [MethodImpl] get; [MethodImpl] set; }

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
  }
}
