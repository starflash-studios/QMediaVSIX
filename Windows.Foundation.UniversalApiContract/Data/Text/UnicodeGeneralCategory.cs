// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.UnicodeGeneralCategory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Defines the Unicode general category of a character.</summary>
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum UnicodeGeneralCategory
  {
    /// <summary>Uppercase letter. Signified by the Unicode designation "Lu" (letter, uppercase).</summary>
    UppercaseLetter,
    /// <summary>Lowercase letter. Signified by the Unicode designation "Ll" (letter, lowercase).</summary>
    LowercaseLetter,
    /// <summary>Titlecase letter. Signified by the Unicode designation "Lt" (letter, titlecase).</summary>
    TitlecaseLetter,
    /// <summary>Modifier letter character, which is a free-standing spacing character that indicates modifications of a preceding letter. Signified by the Unicode designation "Lm" (letter, modifier).</summary>
    ModifierLetter,
    /// <summary>Letter that is not an uppercase letter, a lowercase letter, a titlecase letter, or a modifier letter. Signified by the Unicode designation "Lo" (letter, other).</summary>
    OtherLetter,
    /// <summary>Nonspacing character that indicates modifications of a base character. Signified by the Unicode designation "Mn" (mark, nonspacing),</summary>
    NonspacingMark,
    /// <summary>Spacing character that indicates modifications of a base character and affects the width of the glyph for that base character. Signified by the Unicode designation "Mc" (mark, spacing combining).</summary>
    SpacingCombiningMark,
    /// <summary>Enclosing mark character, which is a nonspacing combining character that surrounds all previous characters up to and including a base character. Signified by the Unicode designation "Me" (mark, enclosing).</summary>
    EnclosingMark,
    /// <summary>Decimal digit character, which is a character in the range 0 through 9. Signified by the Unicode designation "Nd" (number, decimal digit).</summary>
    DecimalDigitNumber,
    /// <summary>Number represented by a letter, instead of a decimal digit. For example, the Roman numeral for five, which is "V". The indicator is signified by the Unicode designation "Nl" (number, letter).</summary>
    LetterNumber,
    /// <summary>Number that is neither a decimal digit nor a letter number. For example, the fraction 1/2. The indicator is signified by the Unicode designation "No" (number, other).</summary>
    OtherNumber,
    /// <summary>Space character, which has no glyph but is not a control or format character. Signified by the Unicode designation "Zs" (separator, space).</summary>
    SpaceSeparator,
    /// <summary>Character that is used to separate lines of text. Signified by the Unicode designation "Zl" (separator, line).</summary>
    LineSeparator,
    /// <summary>Character that is used to separate paragraphs. Signified by the Unicode designation "Zp" (separator, paragraph).</summary>
    ParagraphSeparator,
    /// <summary>Control code character, with a Unicode value of U+007F or in the range U+0000 through U+001F or U+0080 through U+009F. Signified by the Unicode designation "Cc" (other, control).</summary>
    Control,
    /// <summary>Format character that affects the layout of text or the operation of text processes, but is not normally rendered. Signified by the Unicode designation "Cf" (other, format).</summary>
    Format,
    /// <summary>High surrogate or low surrogate character. Surrogate code values are in the range U+D800 through U+DFFF. Signified by the Unicode designation "Cs" (other, surrogate).</summary>
    Surrogate,
    /// <summary>Private-use character, with a Unicode value in the range U+E000 through U+F8FF. Signified by the Unicode designation "Co" (other, private use).</summary>
    PrivateUse,
    /// <summary>Connector punctuation character that connects two characters. Signified by the Unicode designation "Pc" (punctuation, connector).</summary>
    ConnectorPunctuation,
    /// <summary>Dash or hyphen character. Signified by the Unicode designation "Pd" (punctuation, dash).</summary>
    DashPunctuation,
    /// <summary>Opening character of one of the paired punctuation marks, such as parentheses, square brackets, and braces. Signified by the Unicode designation "Ps" (punctuation, open).</summary>
    OpenPunctuation,
    /// <summary>Closing character of one of the paired punctuation marks, such as parentheses, square brackets, and braces. Signified by the Unicode designation "Pe" (punctuation, close).</summary>
    ClosePunctuation,
    /// <summary>Opening or initial quotation mark character. Signified by the Unicode designation "Pi" (punctuation, initial quote).</summary>
    InitialQuotePunctuation,
    /// <summary>Closing or final quotation mark character. Signified by the Unicode designation "Pf" (punctuation, final quote).</summary>
    FinalQuotePunctuation,
    /// <summary>Punctuation character that is not a connector, a dash, open punctuation, close punctuation, an initial quote, or a final quote. Signified by the Unicode designation "Po" (punctuation, other).</summary>
    OtherPunctuation,
    /// <summary>Mathematical symbol character, such as "+" or "=". Signified by the Unicode designation "Sm" (symbol, math).</summary>
    MathSymbol,
    /// <summary>Currency symbol character. Signified by the Unicode designation "Sc" (symbol, currency).</summary>
    CurrencySymbol,
    /// <summary>Modifier symbol character, which indicates modifications of surrounding characters. For example, the fraction slash indicates that the number to the left is the numerator and the number to the right is the denominator. The indicator is signified by the Unicode designation "Sk" (symbol, modifier).</summary>
    ModifierSymbol,
    /// <summary>Symbol character that is not a mathematical symbol, a currency symbol or a modifier symbol. Signified by the Unicode designation "So" (symbol, other).</summary>
    OtherSymbol,
    /// <summary>Character that is not assigned to any Unicode category. Signified by the Unicode code designation "Cn" (other, not assigned).</summary>
    NotAssigned,
  }
}
