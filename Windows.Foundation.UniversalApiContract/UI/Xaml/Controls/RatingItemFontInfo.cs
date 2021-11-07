// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.RatingItemFontInfo
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents information about the visual states of font elements that represent a rating.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 327680)]
  [Static(typeof (IRatingItemFontInfoStatics), 327680, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Composable(typeof (IRatingItemFontInfoFactory), CompositionType.Public, 327680, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class RatingItemFontInfo : RatingItemInfo, IRatingItemFontInfo
  {
    /// <summary>Initializes a new instance of the RatingItemFontInfo class.</summary>
    [MethodImpl]
    public extern RatingItemFontInfo();

    /// <summary>Gets or sets a Segoe MDL2 Assets font glyph that represents a rating element that is disabled.</summary>
    /// <returns>The hexadecimal character code for the rating element glyph.</returns>
    public extern string DisabledGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Segoe MDL2 Assets font glyph that represents a rating element that has been set by the user.</summary>
    /// <returns>The hexadecimal character code for the rating element glyph.</returns>
    public extern string Glyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Segoe MDL2 Assets font glyph that represents a rating element that has the pointer over it.</summary>
    /// <returns>The hexadecimal character code for the rating element glyph.</returns>
    public extern string PointerOverGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Segoe MDL2 Assets font glyph that represents a rating element showing a placeholder value with the pointer over it.</summary>
    /// <returns>The hexadecimal character code for the rating element glyph.</returns>
    public extern string PointerOverPlaceholderGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Segoe MDL2 Assets font glyph that represents a rating element that is showing a placeholder value.</summary>
    /// <returns>The hexadecimal character code for the rating element glyph.</returns>
    public extern string PlaceholderGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a Segoe MDL2 Assets font glyph that represents a rating element that has not been set.</summary>
    /// <returns>The hexadecimal character code for the rating element glyph.</returns>
    public extern string UnsetGlyph { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the DisabledGlyph dependency property.</summary>
    /// <returns>The identifier for DisabledGlyph dependency property.</returns>
    public static extern DependencyProperty DisabledGlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the Glyph dependency property.</summary>
    /// <returns>The identifier for Glyph dependency property.</returns>
    public static extern DependencyProperty GlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderGlyph dependency property.</summary>
    /// <returns>The identifier for PlaceholderGlyph dependency property.</returns>
    public static extern DependencyProperty PlaceholderGlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the PointerOverGlyph dependency property.</summary>
    /// <returns>The identifier for PointerOverGlyph dependency property.</returns>
    public static extern DependencyProperty PointerOverGlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the PointerOverPlaceholderGlyph dependency property.</summary>
    /// <returns>The identifier for PointerOverPlaceholderGlyph dependency property.</returns>
    public static extern DependencyProperty PointerOverPlaceholderGlyphProperty { [MethodImpl] get; }

    /// <summary>Identifies the UnsetGlyph dependency property.</summary>
    /// <returns>The identifier for UnsetGlyph dependency property.</returns>
    public static extern DependencyProperty UnsetGlyphProperty { [MethodImpl] get; }
  }
}
