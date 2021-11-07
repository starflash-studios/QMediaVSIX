// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.Calendar
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization
{
  /// <summary>Manipulates the representation of a DateTime within a given calendar and clock.</summary>
  [Activatable(typeof (ICalendarFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (ICalendarFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Calendar : ICalendar, ITimeZoneOnCalendar
  {
    [MethodImpl]
    public extern Calendar(
      IIterable<string> languages,
      string calendar,
      string clock,
      string timeZoneId);

    [MethodImpl]
    public extern Calendar(IIterable<string> languages);

    [MethodImpl]
    public extern Calendar(IIterable<string> languages, string calendar, string clock);

    /// <summary>Creates a Calendar object and initializes it to the current DateTime.</summary>
    [MethodImpl]
    public extern Calendar();

    /// <summary>Creates a copy of the Calendar object.</summary>
    /// <returns>A copy of the Calendar.</returns>
    [MethodImpl]
    public extern Calendar Clone();

    /// <summary>Sets the components of this Calendar object to the earliest DateTime supported.</summary>
    [MethodImpl]
    public extern void SetToMin();

    /// <summary>Sets the components of this Calendar object to the latest DateTime supported.</summary>
    [MethodImpl]
    public extern void SetToMax();

    /// <summary>Gets the priority list of language identifiers that is used when formatting components as strings.</summary>
    /// <returns>The list of language identifiers.</returns>
    public extern IVectorView<string> Languages { [MethodImpl] get; }

    /// <summary>Gets or sets the numbering system that is used when formatting components as strings.</summary>
    /// <returns>A string that indicates the numeral system of the calendar, such as "Latn" for the Latin numeral system (0123456789) or "Arab" for the Arabic-Indic numeral system (٠١٢٣٤٥٦٧٨٩). See the supported [NumeralSystem values](https://docs.microsoft.com/previous-versions/windows/apps/jj236471(v=win.10)).</returns>
    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets the calendar system that is used by this Calendar object.</summary>
    /// <returns>The identifier of the calendar system.</returns>
    [MethodImpl]
    public extern string GetCalendarSystem();

    /// <summary>Sets a new calendar system to be used by this Calendar object.</summary>
    /// <param name="value">The calendar identifier to use.</param>
    [MethodImpl]
    public extern void ChangeCalendarSystem(string value);

    /// <summary>Gets the clock that is used by this Calendar object.</summary>
    /// <returns>The identifier of the clock.</returns>
    [MethodImpl]
    public extern string GetClock();

    /// <summary>Sets a new clock to be used by this Calendar object.</summary>
    /// <param name="value">The clock identifier to use.</param>
    [MethodImpl]
    public extern void ChangeClock(string value);

    /// <summary>Builds a date and time, given the components of this Calendar object.</summary>
    /// <returns>The DateTime representing the date and time of this Calendar.</returns>
    [MethodImpl]
    public extern DateTime GetDateTime();

    [MethodImpl]
    public extern void SetDateTime(DateTime value);

    /// <summary>Sets the components of this Calendar object to the current DateTime.</summary>
    [MethodImpl]
    public extern void SetToNow();

    /// <summary>Gets the first Era available in the calendar.</summary>
    /// <returns>The first Era in the calendar.</returns>
    public extern int FirstEra { [MethodImpl] get; }

    /// <summary>Gets the last Era available in the calendar.</summary>
    /// <returns>The last Era in the calendar.</returns>
    public extern int LastEra { [MethodImpl] get; }

    /// <summary>Gets the number of eras in this Calendar object.</summary>
    /// <returns>The number of eras in the Calendar, or – 1 if the number of eras in the Calendar is unknown.</returns>
    public extern int NumberOfEras { [MethodImpl] get; }

    /// <summary>Gets or sets the era.</summary>
    /// <returns>The integer that represents the era.</returns>
    public extern int Era { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the era.</summary>
    /// <param name="eras">The number of eras by which to increment the era (if the value is positive) or decrement the era (if the value is negative).</param>
    [MethodImpl]
    public extern void AddEras(int eras);

    /// <summary>Returns a string representation of the era.</summary>
    /// <returns>A string representation of the era, using the most common abbreviation available.</returns>
    [Overload("EraAsFullString")]
    [MethodImpl]
    public extern string EraAsString();

    /// <summary>Returns a string representation of the era. The string chosen is closest in length to the ideal length.</summary>
    /// <param name="idealLength">A positive integer specifying the ideal length, in characters, for the returned string, or 0 specifying the most common abbreviation available.</param>
    /// <returns>A string representation of the era.</returns>
    [Overload("EraAsString")]
    [MethodImpl]
    public extern string EraAsString(int idealLength);

    /// <summary>Gets the first Year of the current Era.</summary>
    /// <returns>The first Year of the current Era.</returns>
    public extern int FirstYearInThisEra { [MethodImpl] get; }

    /// <summary>Gets the last Year of the current Era.</summary>
    /// <returns>The last Year of the current Era.</returns>
    public extern int LastYearInThisEra { [MethodImpl] get; }

    /// <summary>Gets the number of years in the current era of this Calendar object.</summary>
    /// <returns>The number of years in the current era, or – 1 if there is no known bound to the number of years in the current era.</returns>
    public extern int NumberOfYearsInThisEra { [MethodImpl] get; }

    /// <summary>Gets or sets the year.</summary>
    /// <returns>The year.</returns>
    public extern int Year { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the year.</summary>
    /// <param name="years">The number of years by which to increment the year (if the value is positive) or decrement the year (if the value is negative).</param>
    [MethodImpl]
    public extern void AddYears(int years);

    /// <summary>Returns a string representation of the year without any initial zero padding.</summary>
    /// <returns>A string representation of the year.</returns>
    [MethodImpl]
    public extern string YearAsString();

    /// <summary>Returns a string representation of the year, optionally truncated.</summary>
    /// <param name="remainingDigits">A positive integer that represents the number of least significant digits that should be included. For example, for the year 1234, a parameter of 2 returns 34, and a parameter of 4 or larger returns 1234.</param>
    /// <returns>A string representation of the year.</returns>
    [MethodImpl]
    public extern string YearAsTruncatedString(int remainingDigits);

    /// <summary>Returns a string representation of the year, optionally zero-padded.</summary>
    /// <param name="minDigits">The minimum number of integer digits to be displayed. If the year does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the year 42, a parameter of 1 or 2 returns 42, and a parameter of 3 returns 042.</param>
    /// <returns>A string representation of the year.</returns>
    [MethodImpl]
    public extern string YearAsPaddedString(int minDigits);

    /// <summary>Gets the first Month of the current Year.</summary>
    /// <returns>The first Month of the current Year.</returns>
    public extern int FirstMonthInThisYear { [MethodImpl] get; }

    /// <summary>Gets the last Month of the current Year.</summary>
    /// <returns>The last Month of the current Year.</returns>
    public extern int LastMonthInThisYear { [MethodImpl] get; }

    /// <summary>Gets the number of months in the current year of this Calendar object.</summary>
    /// <returns>The number of months in the current year, or – 1 if the number of months in the current year is unknown.</returns>
    public extern int NumberOfMonthsInThisYear { [MethodImpl] get; }

    /// <summary>Gets or sets the month.</summary>
    /// <returns>The month.</returns>
    public extern int Month { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the month.</summary>
    /// <param name="months">The number of months by which to increment the month (if the value is positive) or decrement the month (if the value is negative).</param>
    [MethodImpl]
    public extern void AddMonths(int months);

    /// <summary>Returns a string representation of the month suitable for inclusion with other date components.</summary>
    /// <returns>A string representation of the month, using the most common abbreviation available.</returns>
    [Overload("MonthAsFullString")]
    [MethodImpl]
    public extern string MonthAsString();

    /// <summary>Returns a string representation of the month suitable for inclusion with other date components.</summary>
    /// <param name="idealLength">A positive integer specifying the ideal length, in characters, for the returned string, or 0 specifying the most common abbreviation available.</param>
    /// <returns>A string representation of the month.</returns>
    [Overload("MonthAsString")]
    [MethodImpl]
    public extern string MonthAsString(int idealLength);

    /// <summary>Returns a string representation of the month suitable for stand-alone display.</summary>
    /// <returns>A string representation of the month, using the most common abbreviation available.</returns>
    [Overload("MonthAsFullSoloString")]
    [MethodImpl]
    public extern string MonthAsSoloString();

    /// <summary>Returns a string representation of the month suitable for stand-alone display.</summary>
    /// <param name="idealLength">A positive integer specifying the ideal length, in characters, for the returned string, or 0 specifying the most common abbreviation available.</param>
    /// <returns>A string representation of the month.</returns>
    [Overload("MonthAsSoloString")]
    [MethodImpl]
    public extern string MonthAsSoloString(int idealLength);

    /// <summary>Returns a string that contains the numeric representation of the month.</summary>
    /// <returns>A string representation of the month.</returns>
    [MethodImpl]
    public extern string MonthAsNumericString();

    /// <summary>Returns a string representation of the month, optionally zero-padded.</summary>
    /// <param name="minDigits">The minimum number of integer digits to be displayed. If the month does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the month 3, a parameter of 1 returns 3, and a parameter of 2 returns 03.</param>
    /// <returns>A string representation of the month.</returns>
    [MethodImpl]
    public extern string MonthAsPaddedNumericString(int minDigits);

    /// <summary>Increments or decrements the day by the specified number of weeks.</summary>
    /// <param name="weeks">The number of weeks by which to increment the day (if the value is positive) or decrement the day (if the value is negative).</param>
    [MethodImpl]
    public extern void AddWeeks(int weeks);

    /// <summary>Gets the first Day of the current Month.</summary>
    /// <returns>The first Day of the current Month.</returns>
    public extern int FirstDayInThisMonth { [MethodImpl] get; }

    /// <summary>Gets the last Day of the current Month.</summary>
    /// <returns>The last Day of the current Month.</returns>
    public extern int LastDayInThisMonth { [MethodImpl] get; }

    /// <summary>Gets the number of days in the current month of this Calendar object.</summary>
    /// <returns>The number of days in the current month, or – 1 if the number of days in the current month is unknown.</returns>
    public extern int NumberOfDaysInThisMonth { [MethodImpl] get; }

    /// <summary>Gets or sets the day.</summary>
    /// <returns>The day.</returns>
    public extern int Day { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the day.</summary>
    /// <param name="days">The number of days by which to increment the day (if the value is positive) or decrement the day (if the value is negative).</param>
    [MethodImpl]
    public extern void AddDays(int days);

    /// <summary>Returns a string that contains the numeric representation of the day.</summary>
    /// <returns>A string representation of the day.</returns>
    [MethodImpl]
    public extern string DayAsString();

    /// <summary>Returns a string representation of the day, optionally zero-padded.</summary>
    /// <param name="minDigits">The minimum number of integer digits to be displayed. If the day does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the day 3, a parameter of 1 returns 3, and a parameter of 2 returns 03.</param>
    /// <returns>A string representation of the day.</returns>
    [MethodImpl]
    public extern string DayAsPaddedString(int minDigits);

    /// <summary>Gets the day of the week.</summary>
    /// <returns>The day of the week.</returns>
    public extern DayOfWeek DayOfWeek { [MethodImpl] get; }

    /// <summary>Returns a string representation of the day of the week suitable for inclusion with other date components.</summary>
    /// <returns>A string representation of the day of the week, using the most common abbreviation available.</returns>
    [Overload("DayOfWeekAsFullString")]
    [MethodImpl]
    public extern string DayOfWeekAsString();

    /// <summary>Returns a string representation of the day of the week suitable for inclusion with other date components.</summary>
    /// <param name="idealLength">A positive integer specifying the ideal length, in characters, for the returned string, or 0 specifying the most common abbreviation available.</param>
    /// <returns>A string representation of the day of the week.</returns>
    [Overload("DayOfWeekAsString")]
    [MethodImpl]
    public extern string DayOfWeekAsString(int idealLength);

    /// <summary>Returns a string representation of the day of the week suitable for stand-alone display.</summary>
    /// <returns>A string representation of the day of the week, using the most common abbreviation available.</returns>
    [Overload("DayOfWeekAsFullSoloString")]
    [MethodImpl]
    public extern string DayOfWeekAsSoloString();

    /// <summary>Returns a string representation of the day of the week suitable for stand-alone display.</summary>
    /// <param name="idealLength">A positive integer specifying the ideal length, in characters, for the returned string, or 0 specifying the most common abbreviation available.</param>
    /// <returns>A string representation of the day of the week.</returns>
    [Overload("DayOfWeekAsSoloString")]
    [MethodImpl]
    public extern string DayOfWeekAsSoloString(int idealLength);

    /// <summary>Gets the first Period of the current Day.</summary>
    /// <returns>The first Period of the current Day.</returns>
    public extern int FirstPeriodInThisDay { [MethodImpl] get; }

    /// <summary>Gets the last Period of the current Day.</summary>
    /// <returns>The last Period of the current Day.</returns>
    public extern int LastPeriodInThisDay { [MethodImpl] get; }

    /// <summary>Gets the number of periods in the current day of this Calendar object.</summary>
    /// <returns>The number of periods in the current day, or – 1 if the number of periods in the current day is unknown.</returns>
    public extern int NumberOfPeriodsInThisDay { [MethodImpl] get; }

    /// <summary>Gets or sets the period of the current day.</summary>
    /// <returns>A numeric representation of the current day period. With a 12-hour clock, for example, the first period of the day is 1, representing AM, and the second period is 2, representing PM.</returns>
    public extern int Period { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the period.</summary>
    /// <param name="periods">The number of periods by which to increment the period (if the value is positive) or decrement the period (if the value is negative).</param>
    [MethodImpl]
    public extern void AddPeriods(int periods);

    /// <summary>Returns a string representation of the day period, such as AM or PM, that uses the most common abbreviation available.</summary>
    /// <returns>A string representation of the day period.</returns>
    [Overload("PeriodAsFullString")]
    [MethodImpl]
    public extern string PeriodAsString();

    /// <summary>Returns a string representation of the day period, such as AM or PM.</summary>
    /// <param name="idealLength">A positive integer that specifies the ideal length, in characters, for the returned string; or a zero that specifies the most common abbreviation available.</param>
    /// <returns>A string representation for the day period.</returns>
    [Overload("PeriodAsString")]
    [MethodImpl]
    public extern string PeriodAsString(int idealLength);

    /// <summary>Gets the first Hour of the current Period.</summary>
    /// <returns>The first Hour of the current Period.</returns>
    public extern int FirstHourInThisPeriod { [MethodImpl] get; }

    /// <summary>Gets the last Hour of the current Period.</summary>
    /// <returns>The last Hour of the current Period.</returns>
    public extern int LastHourInThisPeriod { [MethodImpl] get; }

    /// <summary>Gets the number of hours in the current day period of this Calendar object.</summary>
    /// <returns>The number of hours in the current day period, or – 1 if the number of hours in the current day period is unknown.</returns>
    public extern int NumberOfHoursInThisPeriod { [MethodImpl] get; }

    /// <summary>Gets or sets the hour.</summary>
    /// <returns>The hour.</returns>
    public extern int Hour { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the hour.</summary>
    /// <param name="hours">The number of hours by which to increment the hour (if the value is positive) or decrement the hour (if the value is negative).</param>
    [MethodImpl]
    public extern void AddHours(int hours);

    /// <summary>Returns a string that contains the numeric representation of the hour.</summary>
    /// <returns>A string representation of the hour.</returns>
    [MethodImpl]
    public extern string HourAsString();

    /// <summary>Returns a string representation of the hour, optionally zero-padded.</summary>
    /// <param name="minDigits">The minimum number of integer digits to be displayed. If the hour does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the hour 3, a parameter of 1 returns 3, and a parameter of 2 returns 03.</param>
    /// <returns>A string representation of the hour.</returns>
    [MethodImpl]
    public extern string HourAsPaddedString(int minDigits);

    /// <summary>Gets or sets the minute.</summary>
    /// <returns>The minute.</returns>
    public extern int Minute { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the minute.</summary>
    /// <param name="minutes">The number of minutes by which to increment the minute (if the value is positive) or decrement the minute (if the value is negative).</param>
    [MethodImpl]
    public extern void AddMinutes(int minutes);

    /// <summary>Returns a string that contains the numeric representation of the minute.</summary>
    /// <returns>A string representation of the minute.</returns>
    [MethodImpl]
    public extern string MinuteAsString();

    /// <summary>Returns a string representation of the minute, optionally zero-padded.</summary>
    /// <param name="minDigits">The minimum number of integer digits to be displayed. If the minute does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the minute 3, a parameter of 1 returns 3, and a parameter of 2 returns 03.</param>
    /// <returns>A string representation of the minute.</returns>
    [MethodImpl]
    public extern string MinuteAsPaddedString(int minDigits);

    /// <summary>Gets or sets the second.</summary>
    /// <returns>The second.</returns>
    public extern int Second { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the second.</summary>
    /// <param name="seconds">The number of seconds by which to increment the second (if the value is positive) or decrement the second (if the value is negative).</param>
    [MethodImpl]
    public extern void AddSeconds(int seconds);

    /// <summary>Returns a string that contains the numeric representation of the second.</summary>
    /// <returns>A string representation of the second.</returns>
    [MethodImpl]
    public extern string SecondAsString();

    /// <summary>Returns a string representation of the second, optionally zero-padded.</summary>
    /// <param name="minDigits">The minimum number of integer digits to be displayed. If the second does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the second 3, a parameter of 1 returns 3, and a parameter of 2 returns 03.</param>
    /// <returns>A string representation of the second.</returns>
    [MethodImpl]
    public extern string SecondAsPaddedString(int minDigits);

    /// <summary>Gets or sets the nanosecond.</summary>
    /// <returns>The nanosecond.</returns>
    public extern int Nanosecond { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Increments or decrements the nanosecond.</summary>
    /// <param name="nanoseconds">The number of nanoseconds by which to increment the nanosecond (if the value is positive) or decrement the nanosecond (if the value is negative).</param>
    [MethodImpl]
    public extern void AddNanoseconds(int nanoseconds);

    /// <summary>Returns a string that contains the numeric representation of the nanosecond.</summary>
    /// <returns>A string representation of the nanosecond.</returns>
    [MethodImpl]
    public extern string NanosecondAsString();

    /// <summary>Returns a string representation of the nanosecond, optionally zero-padded.</summary>
    /// <param name="minDigits">The minimum number of integer digits to be displayed. If the nanosecond does not have enough integer digits, it will be padded with zeros to the correct amount. For example, for the nanosecond 42, a parameter of 1 or 2 returns 42, and a parameter of 3 returns 042.</param>
    /// <returns>A string representation of the nanosecond.</returns>
    [MethodImpl]
    public extern string NanosecondAsPaddedString(int minDigits);

    /// <summary>Compares this calendar to another Calendar object and indicates whether the DateTime of one is earlier, equal to, or later than that of the other.</summary>
    /// <param name="other">The Calendar object to compare to the current calendar.</param>
    /// <returns>One of the following values:</returns>
    [MethodImpl]
    public extern int Compare(Calendar other);

    [MethodImpl]
    public extern int CompareDateTime(DateTime other);

    /// <summary>Copies the values from another Calendar object into this Calendar.</summary>
    /// <param name="other">The Calendar object to be copied.</param>
    [MethodImpl]
    public extern void CopyTo(Calendar other);

    /// <summary>Gets the first Minute of the current Hour.</summary>
    /// <returns>The first Minute of the current Hour.</returns>
    public extern int FirstMinuteInThisHour { [MethodImpl] get; }

    /// <summary>Gets the last Minute of the current Hour.</summary>
    /// <returns>The last Minute of the current Hour.</returns>
    public extern int LastMinuteInThisHour { [MethodImpl] get; }

    /// <summary>Gets the number of Minute s in the current Hour.</summary>
    /// <returns>The number of Minute s in the current Hour.</returns>
    public extern int NumberOfMinutesInThisHour { [MethodImpl] get; }

    /// <summary>Gets the first Second of the current Minute.</summary>
    /// <returns>The first Second of the current Minute.</returns>
    public extern int FirstSecondInThisMinute { [MethodImpl] get; }

    /// <summary>Gets the last Second of the current Minute.</summary>
    /// <returns>The last Second of the current Minute.</returns>
    public extern int LastSecondInThisMinute { [MethodImpl] get; }

    /// <summary>Gets the number of Second s in the current Minute.</summary>
    /// <returns>The number of Second s in the current Minute.</returns>
    public extern int NumberOfSecondsInThisMinute { [MethodImpl] get; }

    /// <summary>Gets the language that was most recently used to perform calendar formatting or operations.</summary>
    /// <returns>The language from the priority list of language identifiers that was most recently used to perform calendar formatting or operations.</returns>
    public extern string ResolvedLanguage { [MethodImpl] get; }

    /// <summary>Gets a Boolean indicating if Daylight Saving Time is in effect for the date of this Calendar object.</summary>
    /// <returns>**True** if Daylight Saving Time is in effect for the date; otherwise, **False**.</returns>
    public extern bool IsDaylightSavingTime { [MethodImpl] get; }

    /// <summary>Gets the identifier that identifies the time zone that is used by this Calendar object.</summary>
    /// <returns>The identifier from the IANA Time Zone Database that identifies the time zone that is used by this Calendar object. (An example is "America/Los_Angeles" for Pacific Time.)</returns>
    [MethodImpl]
    public extern string GetTimeZone();

    /// <summary>Sets a new time zone to be used by this Calendar object.</summary>
    /// <param name="timeZoneId">An identifier from the IANA Time Zone Database which identifies the time zone that should be used (for example, "America/Los_Angeles" for Pacific Time).</param>
    [MethodImpl]
    public extern void ChangeTimeZone(string timeZoneId);

    /// <summary>Returns the full time zone name applicable at the instant of time that this Calendar object represents.</summary>
    /// <returns>The full time zone name. This usually differs depending on whether the time zone is observing Daylight Saving Time or not. It also may differ due to historical changes. (An example is "America/Los_Angeles" for Pacific Time.)</returns>
    [Overload("TimeZoneAsFullString")]
    [MethodImpl]
    public extern string TimeZoneAsString();

    /// <summary>Returns the abbreviated time zone name applicable at the instant of time that this Calendar object represents.</summary>
    /// <param name="idealLength">The desired length of the abbreviation to be returned. Use 0 to request the abbreviation in most common use.</param>
    /// <returns>The time zone abbreviation that is closest in length to *idealLength*. If there is a tie, the shorter abbreviation is returned. If *idealLength* is 0, the abbreviation in most common use is returned. (An example is "America/Los_Angeles" for Pacific Time.)</returns>
    [Overload("TimeZoneAsString")]
    [MethodImpl]
    public extern string TimeZoneAsString(int idealLength);
  }
}
