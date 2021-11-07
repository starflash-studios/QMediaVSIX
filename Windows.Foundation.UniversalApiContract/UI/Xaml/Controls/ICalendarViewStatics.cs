// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarViewStatics
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1918955972, 12125, 16829, 153, 187, 69, 113, 178, 11, 121, 168)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CalendarView))]
  internal interface ICalendarViewStatics
  {
    DependencyProperty CalendarIdentifierProperty { get; }

    DependencyProperty DayOfWeekFormatProperty { get; }

    DependencyProperty IsGroupLabelVisibleProperty { get; }

    DependencyProperty DisplayModeProperty { get; }

    DependencyProperty FirstDayOfWeekProperty { get; }

    DependencyProperty IsOutOfScopeEnabledProperty { get; }

    DependencyProperty IsTodayHighlightedProperty { get; }

    DependencyProperty MaxDateProperty { get; }

    DependencyProperty MinDateProperty { get; }

    DependencyProperty NumberOfWeeksInViewProperty { get; }

    DependencyProperty SelectedDatesProperty { get; }

    DependencyProperty SelectionModeProperty { get; }

    DependencyProperty TemplateSettingsProperty { get; }

    DependencyProperty FocusBorderBrushProperty { get; }

    DependencyProperty SelectedHoverBorderBrushProperty { get; }

    DependencyProperty SelectedPressedBorderBrushProperty { get; }

    DependencyProperty SelectedBorderBrushProperty { get; }

    DependencyProperty HoverBorderBrushProperty { get; }

    DependencyProperty PressedBorderBrushProperty { get; }

    DependencyProperty CalendarItemBorderBrushProperty { get; }

    DependencyProperty OutOfScopeBackgroundProperty { get; }

    DependencyProperty CalendarItemBackgroundProperty { get; }

    DependencyProperty PressedForegroundProperty { get; }

    DependencyProperty TodayForegroundProperty { get; }

    DependencyProperty BlackoutForegroundProperty { get; }

    DependencyProperty SelectedForegroundProperty { get; }

    DependencyProperty OutOfScopeForegroundProperty { get; }

    DependencyProperty CalendarItemForegroundProperty { get; }

    DependencyProperty DayItemFontFamilyProperty { get; }

    DependencyProperty DayItemFontSizeProperty { get; }

    DependencyProperty DayItemFontStyleProperty { get; }

    DependencyProperty DayItemFontWeightProperty { get; }

    DependencyProperty TodayFontWeightProperty { get; }

    DependencyProperty FirstOfMonthLabelFontFamilyProperty { get; }

    DependencyProperty FirstOfMonthLabelFontSizeProperty { get; }

    DependencyProperty FirstOfMonthLabelFontStyleProperty { get; }

    DependencyProperty FirstOfMonthLabelFontWeightProperty { get; }

    DependencyProperty MonthYearItemFontFamilyProperty { get; }

    DependencyProperty MonthYearItemFontSizeProperty { get; }

    DependencyProperty MonthYearItemFontStyleProperty { get; }

    DependencyProperty MonthYearItemFontWeightProperty { get; }

    DependencyProperty FirstOfYearDecadeLabelFontFamilyProperty { get; }

    DependencyProperty FirstOfYearDecadeLabelFontSizeProperty { get; }

    DependencyProperty FirstOfYearDecadeLabelFontStyleProperty { get; }

    DependencyProperty FirstOfYearDecadeLabelFontWeightProperty { get; }

    DependencyProperty HorizontalDayItemAlignmentProperty { get; }

    DependencyProperty VerticalDayItemAlignmentProperty { get; }

    DependencyProperty HorizontalFirstOfMonthLabelAlignmentProperty { get; }

    DependencyProperty VerticalFirstOfMonthLabelAlignmentProperty { get; }

    DependencyProperty CalendarItemBorderThicknessProperty { get; }

    DependencyProperty CalendarViewDayItemStyleProperty { get; }
  }
}
