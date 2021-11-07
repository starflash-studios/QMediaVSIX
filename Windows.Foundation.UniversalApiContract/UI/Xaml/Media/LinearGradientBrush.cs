// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LinearGradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Paints an area with a linear gradient.</summary>
  [Static(typeof (ILinearGradientBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ILinearGradientBrushFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class LinearGradientBrush : GradientBrush, ILinearGradientBrush
  {
    /// <summary>Initializes a new instance of the LinearGradientBrush class that has the specified GradientStopCollection and angle.</summary>
    /// <param name="gradientStopCollection">The GradientStops to set on this brush.</param>
    /// <param name="angle">A System.Double that represents the angle, in degrees, of the gradient. A value of 0 creates a horizontal gradient, and a value of 90 creates a vertical gradient. Negative values are permitted, as are values over 360 (which are treated as **mod** 360).</param>
    [MethodImpl]
    public extern LinearGradientBrush(GradientStopCollection gradientStopCollection, double angle);

    /// <summary>Initializes a new instance of the LinearGradientBrush class.</summary>
    [MethodImpl]
    public extern LinearGradientBrush();

    /// <summary>Gets or sets the starting two-dimensional coordinates of the linear gradient.</summary>
    /// <returns>The starting two-dimensional coordinates for the linear gradient. The default is a Point with value 0,0.</returns>
    public extern Point StartPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the ending two-dimensional coordinates of the linear gradient.</summary>
    /// <returns>The ending two-dimensional coordinates of the linear gradient. The default is a Point with value 1,1.</returns>
    public extern Point EndPoint { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the StartPoint dependency property.</summary>
    /// <returns>The identifier for the StartPoint dependency property.</returns>
    public static extern DependencyProperty StartPointProperty { [MethodImpl] get; }

    /// <summary>Identifies the EndPoint dependency property.</summary>
    /// <returns>The identifier for the EndPoint dependency property.</returns>
    public static extern DependencyProperty EndPointProperty { [MethodImpl] get; }
  }
}
