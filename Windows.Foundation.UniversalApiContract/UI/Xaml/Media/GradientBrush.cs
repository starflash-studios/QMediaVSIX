// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GradientBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  /// <summary>An abstract class that describes a gradient, composed of gradient stops. Parent class for LinearGradientBrush.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IGradientBrushFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGradientBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "GradientStops")]
  [WebHostHidden]
  public class GradientBrush : Brush, IGradientBrush
  {
    /// <summary>Provides base class initialization behavior for GradientBrush -derived classes.</summary>
    [MethodImpl]
    protected extern GradientBrush();

    /// <summary>Gets or sets the type of spread method that specifies how to draw a gradient that starts or ends inside the bounds of the object to be painted.</summary>
    /// <returns>The type of spread method used to paint the gradient. The default is **Pad**.</returns>
    public extern GradientSpreadMethod SpreadMethod { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a BrushMappingMode enumeration value that specifies whether the positioning coordinates of the gradient brush are absolute or relative to the output area.</summary>
    /// <returns>A BrushMappingMode value that specifies how to interpret the gradient brush's positioning coordinates. The default is **RelativeToBoundingBox**.</returns>
    public extern BrushMappingMode MappingMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a ColorInterpolationMode enumeration value that specifies how the gradient's colors are interpolated.</summary>
    /// <returns>Specifies how the colors in a gradient are interpolated. The default is **SRgbLinearInterpolation**.</returns>
    public extern ColorInterpolationMode ColorInterpolationMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brush's gradient stops.</summary>
    /// <returns>A collection of the GradientStop objects associated with the brush, each of which specifies a color and an offset along the brush's gradient axis. The default is an empty GradientStopCollection.</returns>
    public extern GradientStopCollection GradientStops { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the SpreadMethod dependency property.</summary>
    /// <returns>The identifier for the SpreadMethod dependency property.</returns>
    public static extern DependencyProperty SpreadMethodProperty { [MethodImpl] get; }

    /// <summary>Identifies the MappingMode dependency property.</summary>
    /// <returns>The identifier for the MappingMode dependency property.</returns>
    public static extern DependencyProperty MappingModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the ColorInterpolationMode dependency property.</summary>
    /// <returns>The identifier for the ColorInterpolationMode dependency property.</returns>
    public static extern DependencyProperty ColorInterpolationModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the GradientStops dependency property.</summary>
    /// <returns>The identifier for the GradientStops dependency property.</returns>
    public static extern DependencyProperty GradientStopsProperty { [MethodImpl] get; }
  }
}
