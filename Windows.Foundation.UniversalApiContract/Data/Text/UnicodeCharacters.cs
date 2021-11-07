// Decompiled with JetBrains decompiler
// Type: Windows.Data.Text.UnicodeCharacters
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Data.Text
{
  /// <summary>Provides a way for apps to get information about Unicode characters, per the Unicode Standard Annex #44.</summary>
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUnicodeCharactersStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class UnicodeCharacters
  {
    /// <summary>Returns the supplementary Unicode character for the specified high and low surrogate pair.</summary>
    /// <param name="highSurrogate">The high surrogate value. This must be in the proper range: 0xD800 &lt;= *highSurrogate* &lt;= 0xDBFF.</param>
    /// <param name="lowSurrogate">The low surrogate value. This must be in the proper range: 0xDC00 &lt;= *lowSurrogate* &lt;= 0xDFFF.</param>
    /// <returns>The supplementary Unicode character.</returns>
    [MethodImpl]
    public static extern uint GetCodepointFromSurrogatePair(uint highSurrogate, uint lowSurrogate);

    /// <summary>Returns the high and low surrogate pair values for the specified supplementary Unicode character.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <param name="highSurrogate">The high surrogate value returned.</param>
    /// <param name="lowSurrogate">The low surrogate value returned.</param>
    [MethodImpl]
    public static extern void GetSurrogatePairFromCodepoint(
      uint codepoint,
      out char highSurrogate,
      out char lowSurrogate);

    /// <summary>Determines if a specified Unicode character is a high surrogate.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is a high surrogate; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsHighSurrogate(uint codepoint);

    /// <summary>Determines if a specified Unicode character is a low surrogate.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is a low surrogate; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsLowSurrogate(uint codepoint);

    /// <summary>Determines if a specified Unicode character is a supplementary character.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is a supplementary character; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsSupplementary(uint codepoint);

    /// <summary>Determines if a specified codepoint is a non-character.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is a non-character; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsNoncharacter(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered whitespace.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is whitespace; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsWhitespace(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered alphabetic.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is alphabetic; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsAlphabetic(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered cased (uppercase, lowercase or titlecase).</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is cased; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsCased(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered an upper case character.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is an upper case character; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsUppercase(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered a lower case character.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is a lower case character; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsLowercase(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered the start character of an identifier in programming.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is the start character of an identifier in programming; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsIdStart(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered a continuation character of an identifier in programming.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is a continuation character of an identifier in programming; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsIdContinue(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered the beginning of a grapheme.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* is the beginning of a grapheme; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsGraphemeBase(uint codepoint);

    /// <summary>Determines if a specified Unicode character can be considered to continue a previous grapheme.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>**TRUE** if *codepoint* continues the previous grapheme; otherwise **FALSE**.</returns>
    [MethodImpl]
    public static extern bool IsGraphemeExtend(uint codepoint);

    /// <summary>Returns the UnicodeNumericType of the specified Unicode character.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>The Unicode numeric type for *codepoint*.</returns>
    [MethodImpl]
    public static extern UnicodeNumericType GetNumericType(uint codepoint);

    /// <summary>Returns the UnicodeGeneralCategory of the specified Unicode character.</summary>
    /// <param name="codepoint">A Unicode character. This must be in the proper range: 0 &lt;= *codepoint* &lt;= 0x10FFFF.</param>
    /// <returns>The Unicode general category for *codepoint*.</returns>
    [MethodImpl]
    public static extern UnicodeGeneralCategory GetGeneralCategory(
      uint codepoint);
  }
}
