// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.AcrylicBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Paints an area with a semi-transparent material that uses multiple effects including blur and a noise texture.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IAcrylicBrushStatics2), 524288, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAcrylicBrushStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IAcrylicBrushFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  public class AcrylicBrush : XamlCompositionBrushBase, IAcrylicBrush, IAcrylicBrush2
  {
    /// <summary>Initializes a new instance of the AcrylicBrush class.</summary>
    [MethodImpl]
    public extern AcrylicBrush();

    /// <summary>Gets or sets a value that specifies whether the brush samples from the app content or from the content behind the app window.</summary>
    /// <returns>A value of the enumeration that specifies whether the brush samples from the app content or from the content behind the app window.</returns>
    public extern AcrylicBackgroundSource BackgroundSource { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the color tint for the semi-transparent acrylic material.</summary>
    /// <returns>The color tint for the semi-transparent acrylic material.</returns>
    public extern Color TintColor { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the degree of opacity of the color tint.</summary>
    /// <returns>The opacity expressed as a value between 0 and 1.0. The default value is 1.0, which is full opacity. 0 is transparent opacity.</returns>
    public extern double TintOpacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the length of the automatic transition animation used when the TintColor changes.</summary>
    /// <returns>The length of the automatic transition animation used when the TintColor changes.</returns>
    public extern TimeSpan TintTransitionDuration { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the brush is forced to the solid fallback color.</summary>
    /// <returns>**true** to always replace the acrylic material with the solid fallback color. Otherwise, **false**. The default is **false**.</returns>
    public extern bool AlwaysUseFallback { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the brightness amount between the TintColor and the underlying pixels behind the Acrylic surface.</summary>
    /// <returns>The amount of luminosity that is visible through the surface where Acrylic is applied.</returns>
    public extern IReference<double> TintLuminosityOpacity { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the TintLuminosityOpacity dependency property.</summary>
    /// <returns>The identifier for the TintLuminosityOpacity dependency property.</returns>
    public static extern DependencyProperty TintLuminosityOpacityProperty { [MethodImpl] get; }

    /// <summary>Identifies the BackgroundSource dependency property.</summary>
    /// <returns>The identifier for the BackgroundSource dependency property.</returns>
    public static extern DependencyProperty BackgroundSourceProperty { [MethodImpl] get; }

    /// <summary>Identifies the TintColor dependency property.</summary>
    /// <returns>The identifier for the TintColor dependency property.</returns>
    public static extern DependencyProperty TintColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the TintOpacity dependency property.</summary>
    /// <returns>The identifier for the TintOpacity dependency property.</returns>
    public static extern DependencyProperty TintOpacityProperty { [MethodImpl] get; }

    /// <summary>Identifies the TintTransitionDuration dependency property.</summary>
    /// <returns>The identifier for the TintTransitionDuration dependency property.</returns>
    public static extern DependencyProperty TintTransitionDurationProperty { [MethodImpl] get; }

    /// <summary>Identifies the AlwaysUseFallback dependency property.</summary>
    /// <returns>The identifier for the AlwaysUseFallback dependency property.</returns>
    public static extern DependencyProperty AlwaysUseFallbackProperty { [MethodImpl] get; }
  }
}
