// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.SolidColorBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Paints an area with a solid color. The solid color is defined by a Color value.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISolidColorBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ISolidColorBrushFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Color")]
  public sealed class SolidColorBrush : Brush, ISolidColorBrush
  {
    /// <summary>Initializes a new instance of the SolidColorBrush class with the specified Color.</summary>
    /// <param name="color">The color to apply to the brush.</param>
    [MethodImpl]
    public extern SolidColorBrush(Color color);

    /// <summary>Initializes a new instance of the SolidColorBrush class with no color.</summary>
    [MethodImpl]
    public extern SolidColorBrush();

    /// <summary>Gets or sets the color of this SolidColorBrush.</summary>
    /// <returns>The brush's color. The default value is Transparent.</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Color dependency property.</summary>
    /// <returns>The identifier for the Color dependency property.</returns>
    [IndependentlyAnimatable]
    public static extern DependencyProperty ColorProperty { [IndependentlyAnimatable, MethodImpl] get; }
  }
}
