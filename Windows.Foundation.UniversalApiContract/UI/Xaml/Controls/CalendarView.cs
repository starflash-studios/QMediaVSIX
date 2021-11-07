// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarView
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;
using Windows.UI.Text;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that enables a user to select a date by using a visual calendar display.</summary>
  [Composable(typeof (ICalendarViewFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICalendarViewStatics2), 917504, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICalendarViewStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class CalendarView : Control, ICalendarView, ICalendarView2
  {
    /// <summary>Initializes a new instance of the CalendarView class.</summary>
    [MethodImpl]
    public extern CalendarView();

    /// <summary>Gets or sets the calendar system to use.</summary>
    /// <returns>The calendar system to use.</returns>
    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the day of the week headers.</summary>
    /// <returns>The display format for the day of the week header values.</returns>
    public extern string DayOfWeekFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the month name is shown with the first day of the </summary>
    /// <returns>**true** if the month name is shown with the first day of the month; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsGroupLabelVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the calendar shows a picker for month, year, or decade.</summary>
    /// <returns>A value of the enumeration that indicates whether the calendar shows a picker for month, year, or decade. The default is **Month**.</returns>
    public extern CalendarViewDisplayMode DisplayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates which day is shown as the first day of the week.</summary>
    /// <returns>A value of the enumeration that indicates which day is shown as the first day of the week.</returns>
    public extern DayOfWeek FirstDayOfWeek { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether out-of-scope calendar items are shown with a unique foreground color.</summary>
    /// <returns>**true** if out-of-scope calendar items are shown with a unique color; **false** if they are shown with the same color as in-scope items. The default is **true**.</returns>
    public extern bool IsOutOfScopeEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the current date is highlighted.</summary>
    /// <returns>**true** if the current date is highlighted; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTodayHighlighted { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the last date to be displayed.</summary>
    /// <returns>The last date to display.</returns>
    public extern DateTime MaxDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the first date to display.</summary>
    /// <returns>The first date to display.</returns>
    public extern DateTime MinDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the number of weeks shown in the calendar view.</summary>
    /// <returns>The number of weeks shown in the calendar view. The default is 6.</returns>
    public extern int NumberOfWeeksInView { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets a collection of selected dates.</summary>
    /// <returns>A collection that contains the currently selected dates. The default is an empty collection.</returns>
    public extern IVector<DateTime> SelectedDates { [MethodImpl] get; }

    /// <summary>Gets or sets a value that indicates what kind of selections are allowed.</summary>
    /// <returns>An enumeration value that indicates the current selection mode. The default is **Single**.</returns>
    public extern CalendarViewSelectionMode SelectionMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets an object that provides calculated values that can be referenced as {TemplateBinding} markup extension sources when defining templates for a CalendarView control.</summary>
    /// <returns>An object that provides calculated values for templates.</returns>
    public extern CalendarViewTemplateSettings TemplateSettings { [MethodImpl] get; }

    /// <summary>Gets or sets a brush that provides the border of a calendar item that has focus.</summary>
    /// <returns>A brush that provides the border of a calendar item that has focus.</returns>
    public extern Brush FocusBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the border of a selected calendar item while the pointer is over it.</summary>
    /// <returns>A brush that provides the border of a selected calendar item while the pointer is over it.</returns>
    public extern Brush SelectedHoverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the border of a selected calendar item while it's pressed.</summary>
    /// <returns>A brush that provides the border of a selected calendar item while it's pressed.</returns>
    public extern Brush SelectedPressedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the border of the currently selected calendar item.</summary>
    /// <returns>A brush that provides the border of the currently selected calendar item.</returns>
    public extern Brush SelectedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the border of a calendar item while the pointer is over it.</summary>
    /// <returns>A brush that provides the border of a calendar item while the pointer is over it.</returns>
    public extern Brush HoverBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the border of a calendar item while it's pressed.</summary>
    /// <returns>A brush that provides the border of a calendar item while it's pressed.</returns>
    public extern Brush PressedBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the border of a calendar item.</summary>
    /// <returns>A brush that provides the border of a calendar item.</returns>
    public extern Brush CalendarItemBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the background of a date that's out of scope.</summary>
    /// <returns>A brush that provides the background of a date that's out of scope.</returns>
    public extern Brush OutOfScopeBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the background of a calendar item.</summary>
    /// <returns>A brush that provides the background of a calendar item.</returns>
    public extern Brush CalendarItemBackground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the foreground of a calendar item while it's pressed.</summary>
    /// <returns>A brush that provides the foreground of a calendar item while it's pressed.</returns>
    public extern Brush PressedForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the foreground of the calendar item for the current date.</summary>
    /// <returns>A brush that provides the foreground of the calendar item for the current date.</returns>
    public extern Brush TodayForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the foreground of a date that can't be selected.</summary>
    /// <returns>A brush that provides the foreground of a date that can't be selected.</returns>
    public extern Brush BlackoutForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the foreground of a calendar item that's selected.</summary>
    /// <returns>A brush that provides the foreground of a calendar item that's selected.</returns>
    public extern Brush SelectedForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the foreground of calendar items that are outside the current scope (month, year, or decade).</summary>
    /// <returns>A brush that provides the foreground of calendar items that are outside the current scope.</returns>
    public extern Brush OutOfScopeForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a brush that provides the foreground of a calendar item.</summary>
    /// <returns>A brush that provides the foreground of a calendar item.</returns>
    public extern Brush CalendarItemForeground { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font used to display day values in the calendar.</summary>
    /// <returns>The font used to display day values in the calendar.</returns>
    public extern FontFamily DayItemFontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font size used to display day values in the calendar.</summary>
    /// <returns>The font size used to display day values in the calendar.</returns>
    public extern double DayItemFontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style used to display day values in the calendar.</summary>
    /// <returns>The font style used to display day values in the calendar.</returns>
    public extern FontStyle DayItemFontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font weight used to display day values in the calendar.</summary>
    /// <returns>The font weight used to display day values in the calendar.</returns>
    public extern FontWeight DayItemFontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font weight used to display the current date in the calendar.</summary>
    /// <returns>The font weight used to display the current date in the calendar.</returns>
    public extern FontWeight TodayFontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font used to display the first-of-month banner in the calendar.</summary>
    /// <returns>The font used to display the first-of-month banner in the calendar.</returns>
    public extern FontFamily FirstOfMonthLabelFontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font size used to display the first-of-month banner in the calendar.</summary>
    /// <returns>The font size used to display the first-of-month banner in the calendar.</returns>
    public extern double FirstOfMonthLabelFontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style used to display the first-of-month banner in the calendar.</summary>
    /// <returns>The font style used to display the first-of-month banner in the calendar.</returns>
    public extern FontStyle FirstOfMonthLabelFontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font weight used to display the first-of-month banner in the calendar.</summary>
    /// <returns>The font weight used to display the first-of-month banner in the calendar.</returns>
    public extern FontWeight FirstOfMonthLabelFontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font used to display the month and year items in the calendar.</summary>
    /// <returns>The font used to display the month and year items in the calendar.</returns>
    public extern FontFamily MonthYearItemFontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font size used to display the month and year items in the calendar.</summary>
    /// <returns>The font size used to display the month and year items in the calendar.</returns>
    public extern double MonthYearItemFontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style used to display the month and year items in the calendar.</summary>
    /// <returns>The font style used to display the month and year items in the calendar.</returns>
    public extern FontStyle MonthYearItemFontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font weight used to display the month and year items in the calendar.</summary>
    /// <returns>The font weight used to display the month and year items in the calendar.</returns>
    public extern FontWeight MonthYearItemFontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font used to display the first-of-year banner in the calendar.</summary>
    /// <returns>The font used to display the first-of-year banner in the calendar.</returns>
    public extern FontFamily FirstOfYearDecadeLabelFontFamily { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font size used to display the first-of-year banner in the calendar.</summary>
    /// <returns>The font size used to display the first-of-year banner in the calendar.</returns>
    public extern double FirstOfYearDecadeLabelFontSize { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font style used to display the first-of-year banner in the calendar.</summary>
    /// <returns>The font style used to display the first-of-year banner in the calendar.</returns>
    public extern FontStyle FirstOfYearDecadeLabelFontStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the font weight used to display the first-of-year banner in the calendar.</summary>
    /// <returns>The font weight used to display the first-of-year banner in the calendar.</returns>
    public extern FontWeight FirstOfYearDecadeLabelFontWeight { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal alignment of day items in the calendar.</summary>
    /// <returns>An enumeration value that indicates the horizontal alignment of day items in the calendar.</returns>
    public extern HorizontalAlignment HorizontalDayItemAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment of day items in the calendar.</summary>
    /// <returns>An enumeration value that indicates the vertical alignment of day items in the calendar.</returns>
    public extern VerticalAlignment VerticalDayItemAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the horizontal alignment of the first-of-month banner text.</summary>
    /// <returns>An enumeration value that indicates the horizontal alignment of the first-of-month banner text.</returns>
    public extern HorizontalAlignment HorizontalFirstOfMonthLabelAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the vertical alignment of the first-of-month banner text.</summary>
    /// <returns>An enumeration value that indicates the vertical alignment of the first-of-month banner text.</returns>
    public extern VerticalAlignment VerticalFirstOfMonthLabelAlignment { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the thickness of a calendar item's border.</summary>
    /// <returns>The thickness of a calendar item's border.</returns>
    public extern Thickness CalendarItemBorderThickness { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Style associated with the control's internal CalendarViewDayItem object.</summary>
    /// <returns>The Style associated with the control's internal CalendarViewDayItem object.</returns>
    public extern Style CalendarViewDayItemStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a CalendarViewDayItem is loading.</summary>
    public extern event TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> CalendarViewDayItemChanging;

    /// <summary>Occurs when the collection of selected dates is changed.</summary>
    public extern event TypedEventHandler<CalendarView, CalendarViewSelectedDatesChangedEventArgs> SelectedDatesChanged;

    [MethodImpl]
    public extern void SetDisplayDate(DateTime date);

    /// <summary>Sets the number of rows and columns to use in the Year and Decade display modes.</summary>
    /// <param name="columns">The number of columns in the view.</param>
    /// <param name="rows">The number of rows in the view.</param>
    [MethodImpl]
    public extern void SetYearDecadeDisplayDimensions(int columns, int rows);

    public extern Brush SelectedDisabledBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodaySelectedInnerBorderBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush BlackoutStrikethroughBrush { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush BlackoutBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CalendarItemHoverBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CalendarItemPressedBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush CalendarItemDisabledBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodayBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodayBlackoutBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodayHoverBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodayPressedBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodayDisabledBackground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush TodayBlackoutForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedHoverForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedPressedForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush SelectedDisabledForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush OutOfScopeHoverForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush OutOfScopePressedForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush DisabledForeground { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness DayItemMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness MonthYearItemMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness FirstOfMonthLabelMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern Thickness FirstOfYearDecadeLabelMargin { [MethodImpl] get; [MethodImpl] set; }

    public extern CornerRadius CalendarItemCornerRadius { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty SelectedDisabledBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodaySelectedInnerBorderBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty BlackoutStrikethroughBrushProperty { [MethodImpl] get; }

    public static extern DependencyProperty BlackoutBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemHoverBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemPressedBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemDisabledBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayBlackoutBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayHoverBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayPressedBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayDisabledBackgroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty TodayBlackoutForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedHoverForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedPressedForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedDisabledForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty OutOfScopeHoverForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty OutOfScopePressedForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisabledForegroundProperty { [MethodImpl] get; }

    public static extern DependencyProperty DayItemMarginProperty { [MethodImpl] get; }

    public static extern DependencyProperty MonthYearItemMarginProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfMonthLabelMarginProperty { [MethodImpl] get; }

    public static extern DependencyProperty FirstOfYearDecadeLabelMarginProperty { [MethodImpl] get; }

    public static extern DependencyProperty CalendarItemCornerRadiusProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarIdentifier  dependency property.</summary>
    /// <returns>The identifier for the   CalendarIdentifier dependency property.</returns>
    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    /// <summary>Identifies the DayOfWeekFormat  dependency property.</summary>
    /// <returns>The identifier for the DayOfWeekFormat   dependency property.</returns>
    public static extern DependencyProperty DayOfWeekFormatProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsGroupLabelVisible dependency property.</summary>
    /// <returns>The identifier for the IsGroupLabelVisible dependency property.</returns>
    public static extern DependencyProperty IsGroupLabelVisibleProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisplayMode  dependency property.</summary>
    /// <returns>The identifier for the   DisplayMode dependency property.</returns>
    public static extern DependencyProperty DisplayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstDayOfWeek  dependency property.</summary>
    /// <returns>The identifier for the   FirstDayOfWeek dependency property.</returns>
    public static extern DependencyProperty FirstDayOfWeekProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsOutOfScopeEnabled  dependency property.</summary>
    /// <returns>The identifier for the IsOutOfScopeEnabled   dependency property.</returns>
    public static extern DependencyProperty IsOutOfScopeEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTodayHighlighted  dependency property.</summary>
    /// <returns>The identifier for the IsTodayHighlighted   dependency property.</returns>
    public static extern DependencyProperty IsTodayHighlightedProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxDate  dependency property.</summary>
    /// <returns>The identifier for the   MaxDate dependency property.</returns>
    public static extern DependencyProperty MaxDateProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinDate  dependency property.</summary>
    /// <returns>The identifier for the   MinDate dependency property.</returns>
    public static extern DependencyProperty MinDateProperty { [MethodImpl] get; }

    /// <summary>Identifies the NumberOfWeeksInView  dependency property.</summary>
    /// <returns>The identifier for the NumberOfWeeksInView   dependency property.</returns>
    public static extern DependencyProperty NumberOfWeeksInViewProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedDates  dependency property.</summary>
    /// <returns>The identifier for the   SelectedDates dependency property.</returns>
    public static extern DependencyProperty SelectedDatesProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectionMode  dependency property.</summary>
    /// <returns>The identifier for the SelectionMode   dependency property.</returns>
    public static extern DependencyProperty SelectionModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the TemplateSettings  dependency property.</summary>
    /// <returns>The identifier for the TemplateSettings   dependency property.</returns>
    public static extern DependencyProperty TemplateSettingsProperty { [MethodImpl] get; }

    /// <summary>Identifies the FocusBorderBrush  dependency property.</summary>
    /// <returns>The identifier for the FocusBorderBrush   dependency property.</returns>
    public static extern DependencyProperty FocusBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the  SelectedHoverBorderBrush dependency property.</summary>
    /// <returns>The identifier for the SelectedHoverBorderBrush   dependency property.</returns>
    public static extern DependencyProperty SelectedHoverBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the  SelectedPressedBorderBrush dependency property.</summary>
    /// <returns>The identifier for the   SelectedPressedBorderBrush dependency property.</returns>
    public static extern DependencyProperty SelectedPressedBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the  SelectedBorderBrush dependency property.</summary>
    /// <returns>The identifier for the SelectedBorderBrush   dependency property.</returns>
    public static extern DependencyProperty SelectedBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the HoverBorderBrush  dependency property.</summary>
    /// <returns>The identifier for the HoverBorderBrush   dependency property.</returns>
    public static extern DependencyProperty HoverBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the PressedBorderBrush  dependency property.</summary>
    /// <returns>The identifier for the PressedBorderBrush   dependency property.</returns>
    public static extern DependencyProperty PressedBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarItemBorderBrush  dependency property.</summary>
    /// <returns>The identifier for the CalendarItemBorderBrush   dependency property.</returns>
    public static extern DependencyProperty CalendarItemBorderBrushProperty { [MethodImpl] get; }

    /// <summary>Identifies the OutOfScopeBackground  dependency property.</summary>
    /// <returns>The identifier for the   OutOfScopeBackground dependency property.</returns>
    public static extern DependencyProperty OutOfScopeBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarItemBackground  dependency property.</summary>
    /// <returns>The identifier for the CalendarItemBackground   dependency property.</returns>
    public static extern DependencyProperty CalendarItemBackgroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the PressedForeground  dependency property.</summary>
    /// <returns>The identifier for the PressedForeground   dependency property.</returns>
    public static extern DependencyProperty PressedForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the TodayForeground  dependency property.</summary>
    /// <returns>The identifier for the TodayForeground   dependency property.</returns>
    public static extern DependencyProperty TodayForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the BlackoutForeground  dependency property.</summary>
    /// <returns>The identifier for the BlackoutForeground   dependency property.</returns>
    public static extern DependencyProperty BlackoutForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the SelectedForeground  dependency property.</summary>
    /// <returns>The identifier for the SelectedForeground   dependency property.</returns>
    public static extern DependencyProperty SelectedForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the  OutOfScopeForeground dependency property.</summary>
    /// <returns>The identifier for the OutOfScopeForeground   dependency property.</returns>
    public static extern DependencyProperty OutOfScopeForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarItemForeground  dependency property.</summary>
    /// <returns>The identifier for the   CalendarItemForeground dependency property.</returns>
    public static extern DependencyProperty CalendarItemForegroundProperty { [MethodImpl] get; }

    /// <summary>Identifies the DayItemFontFamily  dependency property.</summary>
    /// <returns>The identifier for the DayItemFontFamily   dependency property.</returns>
    public static extern DependencyProperty DayItemFontFamilyProperty { [MethodImpl] get; }

    /// <summary>Identifies the DayItemFontSize  dependency property.</summary>
    /// <returns>The identifier for the DayItemFontSize   dependency property.</returns>
    public static extern DependencyProperty DayItemFontSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the DayItemFontStyle  dependency property.</summary>
    /// <returns>The identifier for the DayItemFontStyle   dependency property.</returns>
    public static extern DependencyProperty DayItemFontStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the DayItemFontWeight  dependency property.</summary>
    /// <returns>The identifier for the DayItemFontWeight   dependency property.</returns>
    public static extern DependencyProperty DayItemFontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the TodayFontWeight  dependency property.</summary>
    /// <returns>The identifier for the TodayFontWeight   dependency property.</returns>
    public static extern DependencyProperty TodayFontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfMonthLabelFontFamily  dependency property.</summary>
    /// <returns>The identifier for the   FirstOfMonthLabelFontFamily dependency property.</returns>
    public static extern DependencyProperty FirstOfMonthLabelFontFamilyProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfMonthLabelFontSize  dependency property.</summary>
    /// <returns>The identifier for the FirstOfMonthLabelFontSize   dependency property.</returns>
    public static extern DependencyProperty FirstOfMonthLabelFontSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfMonthLabelFontStyle  dependency property.</summary>
    /// <returns>The identifier for the FirstOfMonthLabelFontStyle   dependency property.</returns>
    public static extern DependencyProperty FirstOfMonthLabelFontStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfMonthLabelFontWeight  dependency property.</summary>
    /// <returns>The identifier for the FirstOfMonthLabelFontWeight   dependency property.</returns>
    public static extern DependencyProperty FirstOfMonthLabelFontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the MonthYearItemFontFamily  dependency property.</summary>
    /// <returns>The identifier for the MonthYearItemFontFamily   dependency property.</returns>
    public static extern DependencyProperty MonthYearItemFontFamilyProperty { [MethodImpl] get; }

    /// <summary>Identifies the MonthYearItemFontSize  dependency property.</summary>
    /// <returns>The identifier for the   MonthYearItemFontSize dependency property.</returns>
    public static extern DependencyProperty MonthYearItemFontSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the MonthYearItemFontStyle  dependency property.</summary>
    /// <returns>The identifier for the MonthYearItemFontStyle   dependency property.</returns>
    public static extern DependencyProperty MonthYearItemFontStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the MonthYearItemFontWeight  dependency property.</summary>
    /// <returns>The identifier for the MonthYearItemFontWeight   dependency property.</returns>
    public static extern DependencyProperty MonthYearItemFontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfYearDecadeLabelFontFamily  dependency property.</summary>
    /// <returns>The identifier for the FirstOfYearDecadeLabelFontFamily   dependency property.</returns>
    public static extern DependencyProperty FirstOfYearDecadeLabelFontFamilyProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfYearDecadeLabelFontSize  dependency property.</summary>
    /// <returns>The identifier for the FirstOfYearDecadeLabelFontSize   dependency property.</returns>
    public static extern DependencyProperty FirstOfYearDecadeLabelFontSizeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfYearDecadeLabelFontStyle  dependency property.</summary>
    /// <returns>The identifier for the FirstOfYearDecadeLabelFontStyle   dependency property.</returns>
    public static extern DependencyProperty FirstOfYearDecadeLabelFontStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstOfYearDecadeLabelFontWeight  dependency property.</summary>
    /// <returns>The identifier for the FirstOfYearDecadeLabelFontWeight   dependency property.</returns>
    public static extern DependencyProperty FirstOfYearDecadeLabelFontWeightProperty { [MethodImpl] get; }

    /// <summary>Identifies the  HorizontalDayItemAlignment dependency property.</summary>
    /// <returns>The identifier for the HorizontalDayItemAlignment   dependency property.</returns>
    public static extern DependencyProperty HorizontalDayItemAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalDayItemAlignment  dependency property.</summary>
    /// <returns>The identifier for the VerticalDayItemAlignment   dependency property.</returns>
    public static extern DependencyProperty VerticalDayItemAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the HorizontalFirstOfMonthLabelAlignment  dependency property.</summary>
    /// <returns>The identifier for the HorizontalFirstOfMonthLabelAlignment   dependency property.</returns>
    public static extern DependencyProperty HorizontalFirstOfMonthLabelAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the VerticalFirstOfMonthLabelAlignment  dependency property.</summary>
    /// <returns>The identifier for the VerticalFirstOfMonthLabelAlignment   dependency property.</returns>
    public static extern DependencyProperty VerticalFirstOfMonthLabelAlignmentProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarItemBorderThickness  dependency property.</summary>
    /// <returns>The identifier for the CalendarItemBorderThickness   dependency property.</returns>
    public static extern DependencyProperty CalendarItemBorderThicknessProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarViewDayItemStyle  dependency property.</summary>
    /// <returns>The identifier for the CalendarViewDayItemStyle   dependency property.</returns>
    public static extern DependencyProperty CalendarViewDayItemStyleProperty { [MethodImpl] get; }
  }
}
