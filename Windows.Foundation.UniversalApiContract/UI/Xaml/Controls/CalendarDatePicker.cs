// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.CalendarDatePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that allows a user to pick a date from a calendar display.</summary>
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICalendarDatePickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICalendarDatePickerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (ICalendarDatePickerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ICalendarDatePickerStatics3), 458752, "Windows.Foundation.UniversalApiContract")]
  public class CalendarDatePicker : 
    Control,
    ICalendarDatePicker,
    ICalendarDatePicker2,
    ICalendarDatePicker3
  {
    /// <summary>Initializes a new instance of the CalendarDatePicker class.</summary>
    [MethodImpl]
    public extern CalendarDatePicker();

    /// <summary>Gets or sets the date currently set in the calendar picker.</summary>
    /// <returns>The date currently set in the calendar picker.</returns>
    public extern IReference<DateTime> Date { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the calendar view of the CalendarDatePicker is currently shown.</summary>
    /// <returns>**true** if the calendar view is shown; otherwise, **false**. The default is **false**.</returns>
    public extern bool IsCalendarOpen { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the date value in the picker's text box.</summary>
    /// <returns>The string format to use to display the date in the picker's text box.</returns>
    public extern string DateFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the text that is displayed in the picker's text box until the value is changed by a user action or some other operation.</summary>
    /// <returns>The text that is displayed in the control when no value is entered. The default is an empty string ("").</returns>
    public extern string PlaceholderText { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the content for the calendar picker's header.</summary>
    /// <returns>The content of the header. The default value is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the Style associated with the control's internal CalendarView object.</summary>
    /// <returns>The current style of the CalendarView object.</returns>
    public extern Style CalendarViewStyle { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the earliest date that can be set in the picker.</summary>
    /// <returns>The earliest date that can be set.</returns>
    public extern DateTime MinDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the latest date that can be set in the picker.</summary>
    /// <returns>The latest date that can be set.</returns>
    public extern DateTime MaxDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the current date is highlighted in the picker's CalendarView.</summary>
    /// <returns>**true** if the current date is highlighted; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsTodayHighlighted { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the calendar shows selections for month, year, or decade in the picker's CalendarView.</summary>
    /// <returns>A value of the enumeration that indicates whether the calendar shows selections for month, year, or decade. The default is **Month**.</returns>
    public extern CalendarViewDisplayMode DisplayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates which day is shown as the first day of the week in the picker's CalendarView.</summary>
    /// <returns>A value of the enumeration that indicates which day is shown as the first day of the week.</returns>
    public extern DayOfWeek FirstDayOfWeek { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the day of the week headers in the picker's CalendarView.</summary>
    /// <returns>The string format to use to display the day of the week headers in the picker's CalendarView.</returns>
    public extern string DayOfWeekFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the calendar system to use.</summary>
    /// <returns>The name of the calendar system to use.</returns>
    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether out-of-scope calendar items are shown with a unique foreground color in the picker's CalendarView.</summary>
    /// <returns>**true** if out-of-scope calendar items are shown with a unique color; **false** if they are shown with the same color as in-scope items. The default is **true**.</returns>
    public extern bool IsOutOfScopeEnabled { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the month name is shown with the first day of the month in the picker's CalendarView.</summary>
    /// <returns>**true** if the month name is shown with the first day of the month; otherwise, **false**. The default is **true**.</returns>
    public extern bool IsGroupLabelVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when a CalendarViewDayItem is loading in the picker's CalendarView.</summary>
    public extern event CalendarViewDayItemChangingEventHandler CalendarViewDayItemChanging;

    /// <summary>Occurs when the date value is changed.</summary>
    public extern event TypedEventHandler<CalendarDatePicker, CalendarDatePickerDateChangedEventArgs> DateChanged;

    /// <summary>Occurs when the picker's CalendarView is shown.</summary>
    public extern event EventHandler<object> Opened;

    /// <summary>Occurs when the picker's CalendarView is hidden.</summary>
    public extern event EventHandler<object> Closed;

    [MethodImpl]
    public extern void SetDisplayDate(DateTime date);

    /// <summary>Sets the number of rows and columns to use in the **Year** and **Decade** display modes of the picker's CalendarView.</summary>
    /// <param name="columns">The number of columns in the view.</param>
    /// <param name="rows">The number of rows in the view.</param>
    [MethodImpl]
    public extern void SetYearDecadeDisplayDimensions(int columns, int rows);

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets content that is shown below the control. The content should provide guidance about the input expected by the control.</summary>
    /// <returns>The content to be displayed below the control. The default is **null**.</returns>
    public extern object Description { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Identifies the Description dependency property.</summary>
    /// <returns>The identifier for the Description dependency property.</returns>
    public static extern DependencyProperty DescriptionProperty { [MethodImpl] get; }

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Date dependency property.</summary>
    /// <returns>The identifier for the Date dependency property.</returns>
    public static extern DependencyProperty DateProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsCalendarOpen dependency property.</summary>
    /// <returns>The identifier for the IsCalendarOpen dependency property.</returns>
    public static extern DependencyProperty IsCalendarOpenProperty { [MethodImpl] get; }

    /// <summary>Identifies the DateFormat dependency property.</summary>
    /// <returns>The identifier for the DateFormat dependency property.</returns>
    public static extern DependencyProperty DateFormatProperty { [MethodImpl] get; }

    /// <summary>Identifies the PlaceholderText dependency property.</summary>
    /// <returns>The identifier for the PlaceholderText dependency property.</returns>
    public static extern DependencyProperty PlaceholderTextProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarViewStyle dependency property.</summary>
    /// <returns>The identifier for the CalendarViewStyle dependency property.</returns>
    public static extern DependencyProperty CalendarViewStyleProperty { [MethodImpl] get; }

    /// <summary>Identifies the MinDate dependency property.</summary>
    /// <returns>The identifier for the MinDate dependency property.</returns>
    public static extern DependencyProperty MinDateProperty { [MethodImpl] get; }

    /// <summary>Identifies the MaxDate dependency property.</summary>
    /// <returns>The identifier for the MaxDate dependency property.</returns>
    public static extern DependencyProperty MaxDateProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsTodayHighlighted dependency property.</summary>
    /// <returns>The identifier for the IsTodayHighlighted dependency property.</returns>
    public static extern DependencyProperty IsTodayHighlightedProperty { [MethodImpl] get; }

    /// <summary>Identifies the DisplayMode dependency property.</summary>
    /// <returns>The identifier for the DisplayMode dependency property.</returns>
    public static extern DependencyProperty DisplayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the FirstDayOfWeek dependency property.</summary>
    /// <returns>The identifier for the FirstDayOfWeek dependency property.</returns>
    public static extern DependencyProperty FirstDayOfWeekProperty { [MethodImpl] get; }

    /// <summary>Identifies the DayOfWeekFormat dependency property.</summary>
    /// <returns>The identifier for the DayOfWeekFormat dependency property.</returns>
    public static extern DependencyProperty DayOfWeekFormatProperty { [MethodImpl] get; }

    /// <summary>Identifies the CalendarIdentifier dependency property.</summary>
    /// <returns>The identifier for the CalendarIdentifier dependency property.</returns>
    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsOutOfScopeEnabled dependency property.</summary>
    /// <returns>The identifier for the IsOutOfScopeEnabled dependency property.</returns>
    public static extern DependencyProperty IsOutOfScopeEnabledProperty { [MethodImpl] get; }

    /// <summary>Identifies the IsGroupLabelVisible  dependency property.</summary>
    /// <returns>The identifier for the IsGroupLabelVisible   dependency property.</returns>
    public static extern DependencyProperty IsGroupLabelVisibleProperty { [MethodImpl] get; }
  }
}
