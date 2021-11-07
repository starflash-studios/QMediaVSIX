// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FontVariants
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Describes a font variant value for the Typography.Variants attached property.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public enum FontVariants
  {
    /// <summary>Default font behavior. Font scaling and positioning is normal.</summary>
    Normal,
    /// <summary>Replaces a default glyph with a superscript glyph. Superscript is commonly used for footnotes.</summary>
    Superscript,
    /// <summary>Replaces a default glyph with a subscript glyph.</summary>
    Subscript,
    /// <summary>Replaces a default glyph with an ordinal glyph, or it may combine glyph substitution with positioning adjustments for proper placement. Ordinal forms are normally associated with numeric notation of an ordinal word, such as "1st" for "first".</summary>
    Ordinal,
    /// <summary>Replaces a default glyph with an inferior glyph, or it may combine glyph substitution with positioning adjustments for proper placement. Inferior forms are typically used in chemical formulas or mathematical notation.</summary>
    Inferior,
    /// <summary>Replaces a default glyph with a smaller Japanese Kana glyph. This is used to clarify the meaning of Kanji, which may be unfamiliar to the reader.</summary>
    Ruby,
  }
}
