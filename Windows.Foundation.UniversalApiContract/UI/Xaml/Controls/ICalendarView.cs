// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (CalendarView))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3445854723, 57269, 17170, 172, 7, 192, 57, 24, 36, 96, 123)]
  internal interface ICalendarView
  {
    string CalendarIdentifier { get; set; }

    string DayOfWeekFormat { get; set; }

    bool IsGroupLabelVisible { get; set; }

    CalendarViewDisplayMode DisplayMode { get; set; }

    DayOfWeek FirstDayOfWeek { get; set; }

    bool IsOutOfScopeEnabled { get; set; }

    bool IsTodayHighlighted { get; set; }

    DateTime MaxDate { get; set; }

    DateTime MinDate { get; set; }

    int NumberOfWeeksInView { get; set; }

    IVector<DateTime> SelectedDates { get; }

    CalendarViewSelectionMode SelectionMode { get; set; }

    CalendarViewTemplateSettings TemplateSettings { get; }

    Brush FocusBorderBrush { get; set; }

    Brush SelectedHoverBorderBrush { get; set; }

    Brush SelectedPressedBorderBrush { get; set; }

    Brush SelectedBorderBrush { get; set; }

    Brush HoverBorderBrush { get; set; }

    Brush PressedBorderBrush { get; set; }

    Brush CalendarItemBorderBrush { get; set; }

    Brush OutOfScopeBackground { get; set; }

    Brush CalendarItemBackground { get; set; }

    Brush PressedForeground { get; set; }

    Brush TodayForeground { get; set; }

    Brush BlackoutForeground { get; set; }

    Brush SelectedForeground { get; set; }

    Brush OutOfScopeForeground { get; set; }

    Brush CalendarItemForeground { get; set; }

    FontFamily DayItemFontFamily { get; set; }

    double DayItemFontSize { get; set; }

    FontStyle DayItemFontStyle { get; set; }

    FontWeight DayItemFontWeight { get; set; }

    FontWeight TodayFontWeight { get; set; }

    FontFamily FirstOfMonthLabelFontFamily { get; set; }

    double FirstOfMonthLabelFontSize { get; set; }

    FontStyle FirstOfMonthLabelFontStyle { get; set; }

    FontWeight FirstOfMonthLabelFontWeight { get; set; }

    FontFamily MonthYearItemFontFamily { get; set; }

    double MonthYearItemFontSize { get; set; }

    FontStyle MonthYearItemFontStyle { get; set; }

    FontWeight MonthYearItemFontWeight { get; set; }

    FontFamily FirstOfYearDecadeLabelFontFamily { get; set; }

    double FirstOfYearDecadeLabelFontSize { get; set; }

    FontStyle FirstOfYearDecadeLabelFontStyle { get; set; }

    FontWeight FirstOfYearDecadeLabelFontWeight { get; set; }

    HorizontalAlignment HorizontalDayItemAlignment { get; set; }

    VerticalAlignment VerticalDayItemAlignment { get; set; }

    HorizontalAlignment HorizontalFirstOfMonthLabelAlignment { get; set; }

    VerticalAlignment VerticalFirstOfMonthLabelAlignment { get; set; }

    Thickness CalendarItemBorderThickness { get; set; }

    Style CalendarViewDayItemStyle { get; set; }

    event TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> CalendarViewDayItemChanging;

    event TypedEventHandler<CalendarView, CalendarViewSelectedDatesChangedEventArgs> SelectedDatesChanged;

    void SetDisplayDate(DateTime date);

    void SetYearDecadeDisplayDimensions(int columns, int rows);
  }
}
