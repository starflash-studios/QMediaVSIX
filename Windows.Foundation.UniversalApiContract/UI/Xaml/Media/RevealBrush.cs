// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.RevealBrush
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Base class for brushes that use composition effects and lighting to implement the reveal visual design treatment.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Composable(typeof (IRevealBrushFactory), CompositionType.Protected, 327680, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRevealBrushStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public class RevealBrush : XamlCompositionBrushBase, IRevealBrush
  {
    /// <summary>Provides base class initialization behavior for RevealBrush-derived classes.</summary>
    [MethodImpl]
    protected extern RevealBrush();

    /// <summary>Gets or sets a value that specifies the base background color for the brush.</summary>
    /// <returns>The base background color for the brush. The default value is transparent white (0x00FFFFFF).</returns>
    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies the theme used to draw the brush and light, to ensure that the correct composition effect recipe is used for the desired theme.</summary>
    /// <returns>An ApplicationTheme value.</returns>
    public extern ApplicationTheme TargetTheme { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that specifies whether the brush is forced to the solid fallback color.</summary>
    /// <returns>**true** to always replace the reveal effect with the solid fallback color. Otherwise, **false**. The default is **false**.</returns>
    public extern bool AlwaysUseFallback { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Color dependency property.</summary>
    /// <returns>The identifier for the Color dependency property.</returns>
    public static extern DependencyProperty ColorProperty { [MethodImpl] get; }

    /// <summary>Identifies the TargetTheme dependency property.</summary>
    /// <returns>The identifier for the TargetTheme dependency property.</returns>
    public static extern DependencyProperty TargetThemeProperty { [MethodImpl] get; }

    /// <summary>Identifies the AlwaysUseFallback dependency property.</summary>
    /// <returns>The identifier for the AlwaysUseFallback dependency property.</returns>
    public static extern DependencyProperty AlwaysUseFallbackProperty { [MethodImpl] get; }

    /// <summary>Identifies the RevealBrush.State attached property</summary>
    /// <returns>The identifier for the RevealBrush.State attached property.</returns>
    public static extern DependencyProperty StateProperty { [MethodImpl] get; }

    /// <summary>Sets the value of the RevealBrush.State XAML attached property for a target element.</summary>
    /// <param name="element">The object to which the property value is written.</param>
    /// <param name="value">The value to set.</param>
    [MethodImpl]
    public static extern void SetState(UIElement element, RevealBrushState value);

    /// <summary>Gets the value of the RevealBrush.State XAML attached property for the target element.</summary>
    /// <param name="element">The object from which the property value is read.</param>
    /// <returns>The RevealBrush.State XAML attached property value of the specified object.</returns>
    [MethodImpl]
    public static extern RevealBrushState GetState(UIElement element);
  }
}
