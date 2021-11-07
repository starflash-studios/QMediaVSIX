// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.RadialControllerMenuItem
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.UI.Input
{
  /// <summary>Represents a single custom tool from the RadialController menu.</summary>
  [DualApiPartition(version = 167772162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IRadialControllerMenuItemStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IRadialControllerMenuItemStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RadialControllerMenuItem : IRadialControllerMenuItem
  {
    /// <summary>Gets the text string of the custom tool on the RadialController menu.</summary>
    /// <returns>The text string of the custom tool.</returns>
    public extern string DisplayText { [MethodImpl] get; }

    /// <summary>Gets or sets an object used to identify custom tools on the RadialController menu.</summary>
    /// <returns>Identifies custom tools on the RadialController menu.</returns>
    public extern object Tag { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }

    /// <summary>Occurs when a custom tool is selected from the RadialController menu.</summary>
    public extern event TypedEventHandler<RadialControllerMenuItem, object> Invoked;

    /// <summary>Creates a custom tool (using the specified text string and font glyph) on the RadialController menu.</summary>
    /// <param name="displayText">The text string to display for the custom tool.</param>
    /// <param name="glyph">The font glyph to display for the custom tool.</param>
    /// <param name="fontFamily">The font family that contains the glyph to display for the custom tool.</param>
    /// <returns>The custom tool.</returns>
    [Overload("CreateFromFontGlyph")]
    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily);

    [Overload("CreateFromFontGlyphWithUri")]
    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromFontGlyph(
      string displayText,
      string glyph,
      string fontFamily,
      Uri fontUri);

    /// <summary>Creates a custom tool (using the specified text string and custom icon) on the RadialController menu.</summary>
    /// <param name="displayText">The text string to display for the custom tool.</param>
    /// <param name="icon">The custom icon to display for the custom tool.</param>
    /// <returns>The custom tool.</returns>
    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromIcon(
      string displayText,
      RandomAccessStreamReference icon);

    /// <summary>Creates a custom tool (using the specified text string and system icon) on the RadialController menu.</summary>
    /// <param name="displayText">The text string to display for the custom tool.</param>
    /// <param name="value">The system icon to display for the custom tool.</param>
    /// <returns>The custom tool.</returns>
    [MethodImpl]
    public static extern RadialControllerMenuItem CreateFromKnownIcon(
      string displayText,
      RadialControllerMenuKnownIcon value);
  }
}
