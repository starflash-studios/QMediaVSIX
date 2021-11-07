// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.FontEastAsianLanguage
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  /// <summary>Provides a mechanism for selecting font-specific versions of glyphs for a specified East Asian writing system or language.</summary>
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum FontEastAsianLanguage
  {
    /// <summary>No font-specific glyph versions are applied.</summary>
    Normal,
    /// <summary>Replaces default glyphs with the corresponding forms from the Hojo Kanji specification.</summary>
    HojoKanji,
    /// <summary>Replaces default Japanese glyphs with the corresponding forms from the JIS04 specification.</summary>
    Jis04,
    /// <summary>Replaces default Japanese glyphs with the corresponding forms from the JIS78 specification.</summary>
    Jis78,
    /// <summary>Replaces default Japanese glyphs with the corresponding forms from the JIS83 specification.</summary>
    Jis83,
    /// <summary>Replaces default Japanese glyphs with the corresponding forms from the JIS90 specification.</summary>
    Jis90,
    /// <summary>Replaces default glyphs with the corresponding forms from the NLC Kanji specification.</summary>
    NlcKanji,
    /// <summary>Replaces traditional Chinese or Japanese forms with their corresponding simplified forms.</summary>
    Simplified,
    /// <summary>Replaces simplified Chinese or Japanese forms with their corresponding traditional forms.</summary>
    Traditional,
    /// <summary>Replaces simplified Kanji forms with their corresponding traditional forms. This glyph set is explicitly limited to the traditional forms considered proper for use in personal names.</summary>
    TraditionalNames,
  }
}
