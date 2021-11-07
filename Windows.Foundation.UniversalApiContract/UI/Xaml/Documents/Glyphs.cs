// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.Glyphs
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Documents
{
  /// <summary>Provides a visual representation of letters, characters, or symbols, in a specific font and style.</summary>
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IGlyphsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IGlyphsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Glyphs : FrameworkElement, IGlyphs, IGlyphs2
  {
    /// <summary>Initializes a new instance of the Glyphs class.</summary>
    [MethodImpl]
    public extern Glyphs();

    /// <summary>Gets or sets the Unicode string to render in glyphs.</summary>
    /// <returns>A Unicode string with XAML-compatible encoding. The default is an empty string.</returns>
    public extern string UnicodeString { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a collection of glyph specifications that represents the Glyphs object.</summary>
    /// <returns>A collection of glyph specifications that represents the Glyphs object.</returns>
    public extern string Indices { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the location of the font used for rendering the glyphs.</summary>
    /// <returns>An object describing the Uniform Resource Identifier (URI) source of the font. The default is null.</returns>
    public extern Uri FontUri { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the style simulations applied to the glyphs.</summary>
    /// <returns>One of the enumeration values that specifies the style simulations to apply to the glyphs. The default is "None".</returns>
    public extern StyleSimulations StyleSimulations { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the em size used for rendering the glyphs.</summary>
    /// <returns>The em size used for rendering. The default is 0.</returns>
    public extern double FontRenderingEmSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the x origin for the glyphs.</summary>
    /// <returns>The x origin of the Glyphs, in pixels. The default is 0.</returns>
    public extern double OriginX { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the y origin for the glyphs.</summary>
    /// <returns>The y origin of the Glyphs, in pixels. The default is 0.</returns>
    public extern double OriginY { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Brush that is used to render the glyphs.</summary>
    /// <returns>The brush to use to render the glyphs. The default is **null**, which is evaluated as Transparent for rendering.</returns>
    public extern Brush Fill { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that determines whether font glyphs that contain color layers, such as Segoe UI Emoji, are rendered in color.</summary>
    /// <returns>**true** if color glyphs show in color; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsColorFontEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the index of the palette to use for the color font.</summary>
    /// <returns>The index of the palette to use for the color font.</returns>
    public extern int ColorFontPaletteIndex { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the IsColorFontEnabled dependency property.</summary>
    /// <returns>The identifier for the IsColorFontEnabled dependency property.</returns>
    public static extern DependencyProperty IsColorFontEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the ColorFontPaletteIndex dependency property.</summary>
    /// <returns>The identifier for the ColorFontPaletteIndex dependency property.</returns>
    public static extern DependencyProperty ColorFontPaletteIndexProperty { [MethodImpl] get; }

    /// <summary>Identifies the UnicodeString dependency property.</summary>
    /// <returns>The identifier for the UnicodeString dependency property.</returns>
    public static extern DependencyProperty UnicodeStringProperty { [MethodImpl] get; }

    /// <summary>Identifies the Indices dependency property.</summary>
    /// <returns>The identifier for the Indices dependency property.</returns>
    public static extern DependencyProperty IndicesProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontUri dependency property.</summary>
    /// <returns>The identifier for the FontUri dependency property.</returns>
    public static extern DependencyProperty FontUriProperty { [MethodImpl] get; }

    /// <summary>Identifies the StyleSimulations dependency property.</summary>
    /// <returns>The identifier for the StyleSimulations dependency property.</returns>
    public static extern DependencyProperty StyleSimulationsProperty { [MethodImpl] get; }

    /// <summary>Identifies the FontRenderingEmSize dependency property.</summary>
    /// <returns>The identifier for the FontRenderingEmSize dependency property.</returns>
    public static extern DependencyProperty FontRenderingEmSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the OriginX dependency property.</summary>
    /// <returns>The identifier for the OriginX dependency property.</returns>
    public static extern DependencyProperty OriginXProperty { [MethodImpl] get; }

    /// <summary>Identifies the OriginY dependency property.</summary>
    /// <returns>The identifier for the OriginY dependency property.</returns>
    public static extern DependencyProperty OriginYProperty { [MethodImpl] get; }

    /// <summary>Identifies the Fill dependency property.</summary>
    /// <returns>The identifier for the Fill dependency property.</returns>
    public static extern DependencyProperty FillProperty { [MethodImpl] get; }
  }
}
