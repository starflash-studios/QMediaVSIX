// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.DateTimeFormatting.IDateTimeFormatter
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.DateTimeFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DateTimeFormatter))]
  [Guid(2515454480, 29664, 20043, 161, 131, 61, 106, 208, 186, 53, 236)]
  internal interface IDateTimeFormatter
  {
    IVectorView<string> Languages { get; }

    string GeographicRegion { get; }

    string Calendar { get; }

    string Clock { get; }

    string NumeralSystem { get; set; }

    IVectorView<string> Patterns { get; }

    string Template { get; }

    string Format(DateTime value);

    YearFormat IncludeYear { get; }

    MonthFormat IncludeMonth { get; }

    DayOfWeekFormat IncludeDayOfWeek { get; }

    DayFormat IncludeDay { get; }

    HourFormat IncludeHour { get; }

    MinuteFormat IncludeMinute { get; }

    SecondFormat IncludeSecond { get; }

    string ResolvedLanguage { get; }

    string ResolvedGeographicRegion { get; }
  }
}
