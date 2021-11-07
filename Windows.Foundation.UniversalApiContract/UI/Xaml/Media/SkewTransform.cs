// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.SkewTransform
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Represents a two-dimensional skew.</summary>
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISkewTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SkewTransform : Transform, ISkewTransform
  {
    /// <summary>Initializes a new instance of the SkewTransform class.</summary>
    [MethodImpl]
    public extern SkewTransform();

    /// <summary>Gets or sets the x-coordinate of the transform center.</summary>
    /// <returns>The x-coordinate of the transform center. The default is 0.</returns>
    public extern double CenterX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-coordinate of the transform center.</summary>
    /// <returns>The y-coordinate of the transform center. The default is 0.</returns>
    public extern double CenterY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x-axis skew angle, which is measured in degrees counterclockwise from the y-axis.</summary>
    /// <returns>The skew angle, which is measured in degrees counterclockwise from the y-axis. The default is 0.</returns>
    public extern double AngleX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y-axis skew angle, which is measured in degrees counterclockwise from the x-axis.</summary>
    /// <returns>The skew angle, which is measured in degrees counterclockwise from the x-axis. The default is 0.</returns>
    public extern double AngleY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the CenterX dependency property.</summary>
    /// <returns>The identifier for the CenterX dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the CenterY dependency property.</summary>
    /// <returns>The identifier for the CenterY dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty CenterYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the AngleX dependency property.</summary>
    /// <returns>The identifier for the AngleX dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty AngleXProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    /// <summary>Identifies the AngleY dependency property.</summary>
    /// <returns>The identifier for the AngleY dependency property.</returns>
    [ConditionallyIndependentlyAnimatable]
    public static extern DependencyProperty AngleYProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
