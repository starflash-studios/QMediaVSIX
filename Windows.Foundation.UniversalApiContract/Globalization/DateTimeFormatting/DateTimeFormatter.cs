// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.DateTimeFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  /// <summary>Formats dates and times.</summary>
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IDateTimeFormatterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IDateTimeFormatterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class DateTimeFormatter : IDateTimeFormatter, IDateTimeFormatter2
  {
    /// <summary>Creates a DateTimeFormatter object that is initialized by a format template string.</summary>
    /// <param name="formatTemplate">A format template string that specifies the requested components. The order of the components is irrelevant. This can also be a format pattern. See the remarks for the DateTimeFormatter class for a list of valid format templates and format patterns.</param>
    [MethodImpl]
    public extern DateTimeFormatter(string formatTemplate);

    [MethodImpl]
    public extern DateTimeFormatter(string formatTemplate, IIterable<string> languages);

    [MethodImpl]
    public extern DateTimeFormatter(
      string formatTemplate,
      IIterable<string> languages,
      string geographicRegion,
      string calendar,
      string clock);

    /// <summary>Creates a DateTimeFormatter object that is initialized with year, month, day, and day of week formats.</summary>
    /// <param name="yearFormat">The desired year format to include in the template.</param>
    /// <param name="monthFormat">The desired month format to include in the template.</param>
    /// <param name="dayFormat">The desired day format to include in the template.</param>
    /// <param name="dayOfWeekFormat">The desired day of week format to include in the template.</param>
    [MethodImpl]
    public extern DateTimeFormatter(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat);

    /// <summary>Creates a DateTimeFormatter object that is initialized with hour, minute, and second formats.</summary>
    /// <param name="hourFormat">The desired hour format to include in the template.</param>
    /// <param name="minuteFormat">The desired minute format to include in the template.</param>
    /// <param name="secondFormat">The desired second format to include in the template.</param>
    [MethodImpl]
    public extern DateTimeFormatter(
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat);

    [MethodImpl]
    public extern DateTimeFormatter(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat,
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat,
      IIterable<string> languages);

    [MethodImpl]
    public extern DateTimeFormatter(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat,
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat,
      IIterable<string> languages,
      string geographicRegion,
      string calendar,
      string clock);

    /// <summary>Gets the priority list of language identifiers that is used when formatting dates and times.</summary>
    /// <returns>The list of languages that is used.</returns>
    public extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets or sets the region that is used when formatting dates and times.</summary>
    /// <returns>The region that is used.</returns>
    public extern string GeographicRegion { [MethodImpl] get; }

    /// <summary>Gets the calendar that is used when formatting dates.</summary>
    /// <returns>The calendar that is used.</returns>
    public extern string Calendar { [MethodImpl] get; }

    /// <summary>Gets the clock that is used when formatting times.</summary>
    /// <returns>The clock that is used.</returns>
    public extern string Clock { [MethodImpl] get; }

    /// <summary>Gets or sets the numbering system that is used to format dates and times.</summary>
    /// <returns>A string that indicates the numeral system of the formatter, such as "Latn" for the Latin numeral system (0123456789) or "Arab" for the Arabic-Indic numeral system (٠١٢٣٤٥ ٦٧٨٩).</returns>
    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the patterns corresponding to this template that are used when formatting dates and times.</summary>
    /// <returns>The pattern that provides the requested components in the template. See the remarks for the DateTimeFormatter class for a list of valid format patterns.</returns>
    public extern IVectorView<string> Patterns { [MethodImpl] get; }

    /// <summary>Gets a string representation of this format template.</summary>
    /// <returns>A string that represents this format template. If the DateTimeFormatter object was constructed with a format template or format enumerations, the string can be used to construct the same DateTimeFormatter. If a pattern was used to construct the DateTimeFormatter, this property returns the empty string. See the remarks for the DateTimeFormatter class for a list of valid format templates.</returns>
    public extern string Template { [MethodImpl] get; }

    [MethodImpl]
    public extern string Format(DateTime value);

    /// <summary>Gets the YearFormat in the template.</summary>
    /// <returns>Specifies whether the year is included. If it is, this format specifies the format for the year in the template.</returns>
    public extern YearFormat IncludeYear { [MethodImpl] get; }

    /// <summary>Gets the MonthFormat in the template.</summary>
    /// <returns>Specifies whether the month is included. If it is, this property specifies the format for the month in the template.</returns>
    public extern MonthFormat IncludeMonth { [MethodImpl] get; }

    /// <summary>Gets the DayOfWeekFormat in the template.</summary>
    /// <returns>Specifies whether the day of week is included. If it is, this property specifies the format for the day of week in the template.</returns>
    public extern DayOfWeekFormat IncludeDayOfWeek { [MethodImpl] get; }

    /// <summary>Gets the DayFormat in the template.</summary>
    /// <returns>Specifies whether the day is included. If it is, this property specifies the format for the day in the template.</returns>
    public extern DayFormat IncludeDay { [MethodImpl] get; }

    /// <summary>Gets the HourFormat in the template.</summary>
    /// <returns>Specifies whether the hour is included. If it is, this property specifies the format for the hour in the template.</returns>
    public extern HourFormat IncludeHour { [MethodImpl] get; }

    /// <summary>Gets the MinuteFormat in the template.</summary>
    /// <returns>Specifies whether the minute is included. If it is, this property specifies the format for the minute in the template.</returns>
    public extern MinuteFormat IncludeMinute { [MethodImpl] get; }

    /// <summary>Gets the SecondFormat in the template.</summary>
    /// <returns>Specifies whether the second is included. If it is, this property specifies the format for the second in the template.</returns>
    public extern SecondFormat IncludeSecond { [MethodImpl] get; }

    /// <summary>Gets the language that was most recently used to format dates and times.</summary>
    /// <returns>The language from the priority list of language identifiers that was most recently used to format dates and times.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Gets the geographic region that was most recently used to format dates and times.</summary>
    /// <returns>The geographic region that was most recently used to format dates and times.</returns>
    public extern string ResolvedGeographicRegion { [MethodImpl] get; }

    [Overload("FormatUsingTimeZone")]
    [MethodImpl]
    public extern string Format(DateTime datetime, string timeZoneId);

    /// <summary>Gets the DateTimeFormatter object that formats dates according to the user's choice of long date pattern.</summary>
    /// <returns>A DateTimeFormatter object equivalent to one constructed with the "longdate" template.</returns>
    public static extern DateTimeFormatter LongDate { [MethodImpl] get; }

    /// <summary>Gets the DateTimeFormatter object that formats times according to the user's choice of long time pattern.</summary>
    /// <returns>A DateTimeFormatter object equivalent to one constructed with the "longtime" template.</returns>
    public static extern DateTimeFormatter LongTime { [MethodImpl] get; }

    /// <summary>Gets the DateTimeFormatter object that formats dates according to the user's choice of short date pattern.</summary>
    /// <returns>A DateTimeFormatter object equivalent to one constructed with the "shortdate" template.</returns>
    public static extern DateTimeFormatter ShortDate { [MethodImpl] get; }

    /// <summary>Gets the DateTimeFormatter object that formats times according to the user's choice of short time pattern.</summary>
    /// <returns>A DateTimeFormatter object equivalent to one constructed with the "shorttime" template.</returns>
    public static extern DateTimeFormatter ShortTime { [MethodImpl] get; }
  }
}
