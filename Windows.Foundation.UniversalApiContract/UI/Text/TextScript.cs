// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.TextScript
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the character repertoire (typically the script) for a run of character formatting.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum TextScript
  {
    /// <summary>Undefined</summary>
    Undefined,
    /// <summary>Latin 1 (ANSI)</summary>
    Ansi,
    /// <summary>Latin 1 and Latin 2</summary>
    EastEurope,
    /// <summary>Cyrillic</summary>
    Cyrillic,
    /// <summary>Greek</summary>
    Greek,
    /// <summary>Turkish (Latin 1 + dotless i, and so on)</summary>
    Turkish,
    /// <summary>Hebrew</summary>
    Hebrew,
    /// <summary>Arabic</summary>
    Arabic,
    /// <summary>From Latin 1 and 2</summary>
    Baltic,
    /// <summary>Latin 1 with some combining marks</summary>
    Vietnamese,
    /// <summary>Default character repertoire</summary>
    Default,
    /// <summary>Symbol character set (not Unicode)</summary>
    Symbol,
    /// <summary>Thai</summary>
    Thai,
    /// <summary>Japanese</summary>
    ShiftJis,
    /// <summary>Simplified Chinese</summary>
    GB2312,
    /// <summary>Hangul</summary>
    Hangul,
    /// <summary>Traditional Chinese</summary>
    Big5,
    /// <summary>PC437 character set (disk operating system (DOS))</summary>
    PC437,
    /// <summary>OEM character set (original PC)</summary>
    Oem,
    /// <summary>Main Macintosh character repertoire</summary>
    Mac,
    /// <summary>Armenian</summary>
    Armenian,
    /// <summary>Syriac</summary>
    Syriac,
    /// <summary>Thaana</summary>
    Thaana,
    /// <summary>Devanagari</summary>
    Devanagari,
    /// <summary>Bangla</summary>
    Bengali,
    /// <summary>Gurmukhi</summary>
    Gurmukhi,
    /// <summary>Gujarati</summary>
    Gujarati,
    /// <summary>Odia</summary>
    Oriya,
    /// <summary>Tamil</summary>
    Tamil,
    /// <summary>Telugu</summary>
    Telugu,
    /// <summary>Kannada</summary>
    Kannada,
    /// <summary>Malayalam</summary>
    Malayalam,
    /// <summary>Sinhala</summary>
    Sinhala,
    /// <summary>Lao</summary>
    Lao,
    /// <summary>Tibetan</summary>
    Tibetan,
    /// <summary>Myanmar</summary>
    Myanmar,
    /// <summary>Georgian</summary>
    Georgian,
    /// <summary>Jamo</summary>
    Jamo,
    /// <summary>Ethiopic</summary>
    Ethiopic,
    /// <summary>Cherokee</summary>
    Cherokee,
    /// <summary>Aboriginal</summary>
    Aboriginal,
    /// <summary>Ogham</summary>
    Ogham,
    /// <summary>Runic</summary>
    Runic,
    /// <summary>Khmer</summary>
    Khmer,
    /// <summary>Mongolian</summary>
    Mongolian,
    /// <summary>Braille</summary>
    Braille,
    /// <summary>Yi</summary>
    Yi,
    /// <summary>Limbu</summary>
    Limbu,
    /// <summary>TaiLe</summary>
    TaiLe,
    /// <summary>TaiLu</summary>
    NewTaiLue,
    /// <summary>Syloti Nagri</summary>
    SylotiNagri,
    /// <summary>Kharoshthi</summary>
    Kharoshthi,
    /// <summary>Kayahli</summary>
    Kayahli,
    /// <summary>Unicode symbol such as math operators</summary>
    UnicodeSymbol,
    /// <summary>Emoji</summary>
    Emoji,
    /// <summary>Glagolitic</summary>
    Glagolitic,
    /// <summary>Lisu</summary>
    Lisu,
    /// <summary>Vai</summary>
    Vai,
    /// <summary>NKo</summary>
    NKo,
    /// <summary>Osmanya</summary>
    Osmanya,
    /// <summary>PhagsPa</summary>
    PhagsPa,
    /// <summary>Gothic</summary>
    Gothic,
    /// <summary>Deseret</summary>
    Deseret,
    /// <summary>Tifinagh</summary>
    Tifinagh,
  }
}
