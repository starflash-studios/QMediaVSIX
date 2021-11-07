// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.MarkerType
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text
{
  /// <summary>Specifies the kind of characters used to mark the item paragraphs in a list.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MarkerType
  {
    /// <summary>The list type is not defined.</summary>
    Undefined,
    /// <summary>Not a list paragraph.</summary>
    None,
    /// <summary>The list uses bullets (character code 0x2022).</summary>
    Bullet,
    /// <summary>The list is numbered with Arabic numerals (0, 1, 2, ...).</summary>
    Arabic,
    /// <summary>The list is ordered with lowercase letters (a, b, c, ...).</summary>
    LowercaseEnglishLetter,
    /// <summary>The list is ordered with uppercase letters (A, B, C, ...).</summary>
    UppercaseEnglishLetter,
    /// <summary>The list is ordered with lowercase Roman letters (i, ii, iii, ...).</summary>
    LowercaseRoman,
    /// <summary>The list is ordered with uppercase Roman letters (I, II, III, ...).</summary>
    UppercaseRoman,
    /// <summary>The value returned by ITextParagraphFormat.ListStart is treated as the first code in a Unicode sequence.</summary>
    UnicodeSequence,
    /// <summary>The list is ordered with Unicode circled numbers &lt;img alt="Unicode numbers in a circle." src="./windows.ui.text/images/unicodecirclednumbers.png" /&gt;</summary>
    CircledNumber,
    /// <summary>The list is ordered with Wingdings black circled digits &lt;img alt="Circled black digits." src="./windows.ui.text/images/wingdingblackcircleddigits.png" /&gt;</summary>
    BlackCircleWingding,
    /// <summary>The list is ordered with Wingdings white circled digits &lt;img alt="White digits in a black circle." src="./windows.ui.text/images/wingdingwhitecircleddigits.png" /&gt;</summary>
    WhiteCircleWingding,
    /// <summary>Full-width ASCII (０, １, ２, ３, …).</summary>
    ArabicWide,
    /// <summary>Chinese with 十 only in items 10 through 99 (一, 二, 三, 四, …).</summary>
    SimplifiedChinese,
    /// <summary>Chinese with 十 only in items 10 through 19.</summary>
    TraditionalChinese,
    /// <summary>Chinese with a full-width period, no 十.</summary>
    JapanSimplifiedChinese,
    /// <summary>Chinese with no 十.</summary>
    JapanKorea,
    /// <summary>Arabic alphabetic ( أ ,ب ,ت ,ث ,…).</summary>
    ArabicDictionary,
    /// <summary>Arabic abjadi ( أ ,ب ,ج ,د ,…).</summary>
    ArabicAbjad,
    /// <summary>Hebrew alphabet (א, ב, ג, ד, …).</summary>
    Hebrew,
    /// <summary>Thai alphabetic (ก, ข,ค, ง, …).</summary>
    ThaiAlphabetic,
    /// <summary>Thai numbers (๑, ๒,๓, ๔, …).</summary>
    ThaiNumeric,
    /// <summary>Devanāgarī vowels (अ, आ, इ, ई, …).</summary>
    DevanagariVowel,
    /// <summary>Devanāgarī consonants (क, ख, ग, घ, …).</summary>
    DevanagariConsonant,
    /// <summary>Devanāgarī numbers (१, २, ३, ४, …).</summary>
    DevanagariNumeric,
  }
}
