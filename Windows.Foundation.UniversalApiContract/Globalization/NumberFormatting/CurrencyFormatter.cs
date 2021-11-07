// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.CurrencyFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>Formats and parses currencies.</summary>
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ICurrencyFormatterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  public sealed class CurrencyFormatter : 
    ICurrencyFormatter,
    INumberParser,
    INumberFormatter2,
    INumberFormatter,
    INumberFormatterOptions,
    ICurrencyFormatter2,
    ISignificantDigitsOption,
    INumberRounderOption,
    ISignedZeroOption
  {
    /// <summary>Creates a CurrencyFormatter object that is initialized with a currency identifier.</summary>
    /// <param name="currencyCode">The currency identifier to use when formatting and parsing currency values.</param>
    [MethodImpl]
    public extern CurrencyFormatter(string currencyCode);

    [MethodImpl]
    public extern CurrencyFormatter(
      string currencyCode,
      IIterable<string> languages,
      string geographicRegion);

    /// <summary>Gets the identifier for the currency to be used for formatting and parsing currency values.</summary>
    /// <returns>The currency identifier to use when formatting and parsing currency values.</returns>
    public extern string Currency { [MethodImpl] get; [Deprecated("Currency may be read-only for releases after Windows 8.1. Instead, use a new CurrencyFormatter.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] set; }

    /// <summary>Gets the priority list of language identifiers that is used when formatting and parsing currency values.</summary>
    /// <returns>The priority list of language identifiers.</returns>
    public extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets the region that is used when formatting and parsing currency values.</summary>
    /// <returns>The region that is used.</returns>
    public extern string GeographicRegion { [MethodImpl] get; }

    /// <summary>Gets or sets the minimum number of digits to display for the integer part of the currency value.</summary>
    /// <returns>The minimum number of digits to display.</returns>
    public extern int IntegerDigits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum number of digits to display for the fraction part of the currency value.</summary>
    /// <returns>The minimum number of digits to display.</returns>
    public extern int FractionDigits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the integer part of the currency value should be grouped. The default value is `false`.</summary>
    /// <returns>`true` if the integer part of the value should be grouped, otherwise `false`.</returns>
    public extern bool IsGrouped { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the decimal point of the currency value should always be displayed.</summary>
    /// <returns>**True** if the decimal point of the value should always be displayed, and **false** otherwise.</returns>
    public extern bool IsDecimalPointAlwaysDisplayed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the numbering system that is used to format and parse currency values.</summary>
    /// <returns>A string that indicates the numeral system of the formatter, such as "Latn" for the Latin numeral system (0123456789) or "Arab" for the Arabic-Indic numeral system (٠١٢٣٤٥٦٧٨٩). See the supported [NumeralSystem values](https://docs.microsoft.com/previous-versions/windows/apps/jj236471(v=win.10)).</returns>
    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the language that was most recently used to format or parse currency values.</summary>
    /// <returns>The language from the priority list of language identifiers that was most recently used to format or parse currency values.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Gets the geographic region that was most recently used to format or parse currency values.</summary>
    /// <returns>The geographic region that was most recently used to format or parse currency values.</returns>
    public extern string ResolvedGeographicRegion { [MethodImpl] get; }

    /// <summary>Returns a string representation of an **Int64** currency value.</summary>
    /// <param name="value">The **Int64** currency value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [Overload("FormatInt")]
    [MethodImpl]
    public extern string Format(long value);

    /// <summary>Returns a string representation of a **UInt64** currency value.</summary>
    /// <param name="value">The **UInt64** currency value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [Overload("FormatUInt")]
    [MethodImpl]
    public extern string Format(ulong value);

    /// <summary>Returns a string representation of a **Double** currency value.</summary>
    /// <param name="value">The **Double** currency value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [DefaultOverload]
    [Overload("FormatDouble")]
    [MethodImpl]
    public extern string Format(double value);

    /// <summary>Returns a string representation of an **Int64** currency value.</summary>
    /// <param name="value">The **Int64** currency value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [MethodImpl]
    public extern string FormatInt(long value);

    /// <summary>Returns a string representation of a **UInt64** currency value.</summary>
    /// <param name="value">The **UInt64** currency value to be formatted.</param>
    /// <returns>The **UInt64** currency value to be formatted.</returns>
    [MethodImpl]
    public extern string FormatUInt(ulong value);

    /// <summary>Returns a string representation of a **Double** currency value.</summary>
    /// <param name="value">The **Double** currency value to be formatted.</param>
    /// <returns>A string that represents the value.</returns>
    [MethodImpl]
    public extern string FormatDouble(double value);

    /// <summary>Attempts to parse a string representation of an integer currency value.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, an **Int64** that corresponds to the string representation, and otherwise **null**.</returns>
    [MethodImpl]
    public extern IReference<long> ParseInt(string text);

    /// <summary>Attempts to parse a string representation of an unsigned integer currency value.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, a **UInt64** that corresponds to the string representation, and otherwise **null**.</returns>
    [MethodImpl]
    public extern IReference<ulong> ParseUInt(string text);

    /// <summary>Attempts to parse a string representation of a **Double** currency value.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, a **Double** that corresponds to the string representation, and otherwise **null**.</returns>
    [MethodImpl]
    public extern IReference<double> ParseDouble(string text);

    /// <summary>Gets or sets whether the currency is formatted with the currency symbol or currency code.</summary>
    /// <returns>The CurrencyFormatterMode value which specifies how the currency is formatted.</returns>
    public extern CurrencyFormatterMode Mode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Applies the specified rounding algorithm to the CurrencyFormatter.</summary>
    /// <param name="roundingAlgorithm">A value of the RoundingAlgorithm enumeration.</param>
    [MethodImpl]
    public extern void ApplyRoundingForCurrency(RoundingAlgorithm roundingAlgorithm);

    /// <summary>Gets or sets the current padding to significant digits when a currency amount is formatted.</summary>
    /// <returns>The number of significant digits.</returns>
    public extern int SignificantDigits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current rounding strategy to be used when formatting currency amounts.</summary>
    /// <returns>A number rounder object: IncrementNumberRounder or SignificantDigitsNumberRounder.</returns>
    public extern INumberRounder NumberRounder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether -0 is formatted using the conventions for negative numbers or for positive numbers. (In the Latin numeral system, the choice is "-0" or "0".)</summary>
    /// <returns>**True** if -0 is formatted as a negative number, and **false** if -0 is formatted as a positive number ("-0" or "0" in the Latin numeral system).</returns>
    public extern bool IsZeroSigned { [MethodImpl] get; [MethodImpl] set; }
  }
}
