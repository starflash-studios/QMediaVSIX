// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.IDateTimeFormatterFactory
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3968698963, 6702, 16685, 136, 21, 59, 116, 95, 177, 162, 160)]
  [ExclusiveTo(typeof (DateTimeFormatter))]
  internal interface IDateTimeFormatterFactory
  {
    DateTimeFormatter CreateDateTimeFormatter(string formatTemplate);

    DateTimeFormatter CreateDateTimeFormatterLanguages(
      string formatTemplate,
      IIterable<string> languages);

    DateTimeFormatter CreateDateTimeFormatterContext(
      string formatTemplate,
      IIterable<string> languages,
      string geographicRegion,
      string calendar,
      string clock);

    DateTimeFormatter CreateDateTimeFormatterDate(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat);

    DateTimeFormatter CreateDateTimeFormatterTime(
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat);

    DateTimeFormatter CreateDateTimeFormatterDateTimeLanguages(
      YearFormat yearFormat,
      MonthFormat monthFormat,
      DayFormat dayFormat,
      DayOfWeekFormat dayOfWeekFormat,
      HourFormat hourFormat,
      MinuteFormat minuteFormat,
      SecondFormat secondFormat,
      IIterable<string> languages);

    DateTimeFormatter CreateDateTimeFormatterDateTimeContext(
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
  }
}
