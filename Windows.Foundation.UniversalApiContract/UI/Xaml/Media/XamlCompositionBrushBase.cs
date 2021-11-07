// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.XamlCompositionBrushBase
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media
{
  /// <summary>Provides a base class used to create XAML brushes that paint an area with a CompositionBrush.</summary>
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Composable(typeof (IXamlCompositionBrushBaseFactory), CompositionType.Protected, 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IXamlCompositionBrushBaseStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public class XamlCompositionBrushBase : 
    Brush,
    IXamlCompositionBrushBase,
    IXamlCompositionBrushBaseProtected,
    IXamlCompositionBrushBaseOverrides
  {
    /// <summary>Provides base class initialization behavior for **XamlCompositionBrushBase** derived classes.</summary>
    [MethodImpl]
    protected extern XamlCompositionBrushBase();

    /// <summary>The color to use for rendering in case the CompositionBrush can't be rendered.</summary>
    /// <returns>The color to use for rendering in place of the composition brush.</returns>
    public extern Color FallbackColor { [MethodImpl] get; [MethodImpl] set; }

    extern CompositionBrush IXamlCompositionBrushBaseProtected.CompositionBrush { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IXamlCompositionBrushBaseOverrides.OnConnected();

    [MethodImpl]
    extern void IXamlCompositionBrushBaseOverrides.OnDisconnected();

    /// <summary>Identifies the **FallbackColor** dependency property.</summary>
    /// <returns>The identifier for the **FallbackColor** dependency property.</returns>
    public static extern DependencyProperty FallbackColorProperty { [MethodImpl] get; }
  }
}
