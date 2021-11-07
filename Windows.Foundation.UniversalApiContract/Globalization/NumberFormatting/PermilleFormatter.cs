// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.PermilleFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  /// <summary>Formats and parses permillages.</summary>
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IPermilleFormatterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PermilleFormatter : 
    INumberFormatterOptions,
    INumberFormatter,
    INumberFormatter2,
    INumberParser,
    ISignificantDigitsOption,
    INumberRounderOption,
    ISignedZeroOption
  {
    [MethodImpl]
    public extern PermilleFormatter(IIterable<string> languages, string geographicRegion);

    /// <summary>Creates a PermilleFormatter object and initializes it to default values.</summary>
    [MethodImpl]
    public extern PermilleFormatter();

    /// <summary>Gets the priority list of language identifiers that is used when formatting and parsing permille values.</summary>
    /// <returns>The priority list of language identifiers.</returns>
    public extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets the region that is used when formatting and parsing permille values.</summary>
    /// <returns>The region that is used.</returns>
    public extern string GeographicRegion { [MethodImpl] get; }

    /// <summary>Gets or sets the minimum number of digits to display for the integer part of the permillage.</summary>
    /// <returns>The minimum number of digits to display.</returns>
    public extern int IntegerDigits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum number of digits to display for the fraction part of the permillage.</summary>
    /// <returns>The minimum number of digits to display.</returns>
    public extern int FractionDigits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the integer part of the permillage should be grouped.</summary>
    /// <returns>**True** if the integer part of the permillage should be grouped, and **false** otherwise.</returns>
    public extern bool IsGrouped { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether the decimal point of the permillage should always be displayed.</summary>
    /// <returns>**True** if the decimal point of the permillage should always be displayed, and **false** otherwise.</returns>
    public extern bool IsDecimalPointAlwaysDisplayed { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the numbering system that is used to format and parse permille values.</summary>
    /// <returns>A string that indicates the numeral system of the formatter, such as "Latn" for the Latin numeral system (0123456789) or "Arab" for the Arabic-Indic numeral system (٠١٢٣٤٥٦٧٨٩). See the supported [NumeralSystem values](https://docs.microsoft.com/previous-versions/windows/apps/jj236471(v=win.10)).</returns>
    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the language that was most recently used to format or parse permille values.</summary>
    /// <returns>The language from the priority list of language identifiers that was most recently used to format or parse permille values.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Gets the geographic region that was most recently used to format or parse permille values.</summary>
    /// <returns>The geographic region that was most recently used to format or parse permille values.</returns>
    public extern string ResolvedGeographicRegion { [MethodImpl] get; }

    /// <summary>Returns a string representation of an **Int64** permillage.</summary>
    /// <param name="value">The **Int64** value to be formatted.</param>
    /// <returns>A string that represents the permillage.</returns>
    [Overload("FormatInt")]
    [MethodImpl]
    public extern string Format(long value);

    /// <summary>Returns a string representation of a **UInt64** permillage.</summary>
    /// <param name="value">The **UInt64** value to be formatted.</param>
    /// <returns>A string that represents the permillage.</returns>
    [Overload("FormatUInt")]
    [MethodImpl]
    public extern string Format(ulong value);

    /// <summary>Returns a string representation of a **Double** permillage.</summary>
    /// <param name="value">The **Double** value to be formatted.</param>
    /// <returns>A string that represents the permillage.</returns>
    [Overload("FormatDouble")]
    [DefaultOverload]
    [MethodImpl]
    public extern string Format(double value);

    /// <summary>Returns a string representation of an **Int64** permillage.</summary>
    /// <param name="value">The **Int64** value to be formatted.</param>
    /// <returns>A string that represents the permillage.</returns>
    [MethodImpl]
    public extern string FormatInt(long value);

    /// <summary>Returns a string representation of a **UInt64** permillage.</summary>
    /// <param name="value">The **UInt64** value to be formatted.</param>
    /// <returns>A string that represents the permillage.</returns>
    [MethodImpl]
    public extern string FormatUInt(ulong value);

    /// <summary>Returns a string representation of a **Double** permillage.</summary>
    /// <param name="value">The **Double** value to be formatted.</param>
    /// <returns>A string that represents the permillage.</returns>
    [MethodImpl]
    public extern string FormatDouble(double value);

    /// <summary>Attempts to parse a string representation of an integer permillage.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, an **Int64** that corresponds to the string representation, and otherwise **null**.</returns>
    [MethodImpl]
    public extern IReference<long> ParseInt(string text);

    /// <summary>Attempts to parse a string representation of an unsigned integer permillage.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, a **UInt64** that corresponds to the string representation, and otherwise **null**.</returns>
    [MethodImpl]
    public extern IReference<ulong> ParseUInt(string text);

    /// <summary>Attempts to parse a string representation of a **Double** permillage.</summary>
    /// <param name="text">The text to be parsed.</param>
    /// <returns>If successful, a **Double** that corresponds to the string representation, and otherwise **null**.</returns>
    [MethodImpl]
    public extern IReference<double> ParseDouble(string text);

    /// <summary>Gets or sets the current padding to significant digits when a permille is formatted.</summary>
    /// <returns>The number of significant digits.</returns>
    public extern int SignificantDigits { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the current rounding strategy to be used when formatting permilles.</summary>
    /// <returns>A number rounder object: IncrementNumberRounder or SignificantDigitsNumberRounder.</returns>
    public extern INumberRounder NumberRounder { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets whether -0 is formatted as "-0" or "0".</summary>
    /// <returns>**True** if -0 is formatted as "-0", and **false** if -0 is formatted as "0".</returns>
    public extern bool IsZeroSigned { [MethodImpl] get; [MethodImpl] set; }
  }
}
