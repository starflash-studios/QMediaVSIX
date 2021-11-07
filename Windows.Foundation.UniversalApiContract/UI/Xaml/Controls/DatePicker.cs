// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.DatePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls
{
  /// <summary>Represents a control that allows a user to pick a date value.</summary>
  [Static(typeof (IDatePickerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Header")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IDatePickerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IDatePickerStatics3), 458752, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IDatePickerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public class DatePicker : Control, IDatePicker, IDatePicker2, IDatePicker3
  {
    /// <summary>Initializes a new instance of the DatePicker class.</summary>
    [MethodImpl]
    public extern DatePicker();

    /// <summary>Gets or sets the content for the control's header.</summary>
    /// <returns>The content of the control's header. The default is **null**.</returns>
    public extern object Header { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the DataTemplate used to display the content of the control's header.</summary>
    /// <returns>The template that specifies the visualization of the header object. The default is **null**.</returns>
    public extern DataTemplate HeaderTemplate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the calendar system to use.</summary>
    /// <returns>The calendar system to use.</returns>
    public extern string CalendarIdentifier { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date currently set in the date picker.</summary>
    /// <returns>The date currently set in the picker.</returns>
    public extern DateTime Date { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the day selector is shown.</summary>
    /// <returns>**true** if the day selector is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool DayVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the month selector is shown.</summary>
    /// <returns>**true** if the month selector is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool MonthVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the year selector is shown.</summary>
    /// <returns>**true** if the year selector is shown; otherwise, **false**. The default is **true**.</returns>
    public extern bool YearVisible { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the day value.</summary>
    /// <returns>The display format for the day value.</returns>
    public extern string DayFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the month value.</summary>
    /// <returns>The display format for the month value.</returns>
    public extern string MonthFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the display format for the year value.</summary>
    /// <returns>The display format for the year value.</returns>
    public extern string YearFormat { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the minimum Gregorian year available for picking.</summary>
    /// <returns>The minimum Gregorian year available for picking.</returns>
    public extern DateTime MinYear { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the maximum Gregorian year available for picking.</summary>
    /// <returns>The maximum Gregorian year available for picking.</returns>
    public extern DateTime MaxYear { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets a value that indicates whether the day, month, and year selectors are stacked horizontally or vertically.</summary>
    /// <returns>A named constant of the enumeration that indicates whether the day, month, and year selectors are stacked horizontally or vertically. The default is Horizontal.</returns>
    public extern Orientation Orientation { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the date value is changed.</summary>
    public extern event EventHandler<DatePickerValueChangedEventArgs> DateChanged;

    /// <summary>Gets or sets a value that specifies whether the area outside of a *light-dismiss* UI is darkened.</summary>
    /// <returns>A value of the enumeration that specifies whether the area outside of a light-dismiss UI is darkened. The default is **Auto**.</returns>
    public extern LightDismissOverlayMode LightDismissOverlayMode { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Gets or sets the date currently selected in the date picker, or **null** if no date is selected.</summary>
    /// <returns>The date currently selected in the picker, or **null** if no date is selected.</returns>
    public extern IReference<DateTime> SelectedDate { [MethodImpl] get; [MethodImpl] set; }

    /// <summary>Occurs when the date value is changed.</summary>
    public extern event TypedEventHandler<DatePicker, DatePickerSelectedValueChangedEventArgs> SelectedDateChanged;

    /// <summary>Identifies the SelectedDate dependency property.</summary>
    /// <returns>The identifier for the SelectedDate dependency property.</returns>
    public static extern DependencyProperty SelectedDateProperty { [MethodImpl] get; }

    /// <summary>Identifies the LightDismissOverlayMode dependency property.</summary>
    /// <returns>The identifier for the LightDismissOverlayMode dependency property.</returns>
    public static extern DependencyProperty LightDismissOverlayModeProperty { [MethodImpl] get; }

    /// <summary>Identifies the Header dependency property.</summary>
    /// <returns>The identifier for the Header dependency property.</returns>
    public static extern DependencyProperty HeaderProperty { [MethodImpl] get; }

    /// <summary>Identifies the HeaderTemplate dependency property.</summary>
    /// <returns>The identifier for the HeaderTemplate dependency property.</returns>
    public static extern DependencyProperty HeaderTemplateProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the CalendarIdentifier dependency property.</summary>
    /// <returns>The identifier for the CalendarIdentifier dependency property.</returns>
    public static extern DependencyProperty CalendarIdentifierProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Date dependency property.</summary>
    /// <returns>The identifier for the Date dependency property.</returns>
    public static extern DependencyProperty DateProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DayVisible dependency property.</summary>
    /// <returns>The identifier for the DayVisible dependency property.</returns>
    public static extern DependencyProperty DayVisibleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MonthVisible dependency property.</summary>
    /// <returns>The identifier for the MonthVisible dependency property.</returns>
    public static extern DependencyProperty MonthVisibleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the YearVisible dependency property.</summary>
    /// <returns>The identifier for the YearVisible dependency property.</returns>
    public static extern DependencyProperty YearVisibleProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the DayFormat dependency property.</summary>
    /// <returns>The identifier for the DayFormat dependency property.</returns>
    public static extern DependencyProperty DayFormatProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MonthFormat dependency property.</summary>
    /// <returns>The identifier for the MonthFormat dependency property.</returns>
    public static extern DependencyProperty MonthFormatProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the YearFormat dependency property.</summary>
    /// <returns>The identifier for the YearFormat dependency property.</returns>
    public static extern DependencyProperty YearFormatProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MinYear dependency property.</summary>
    /// <returns>The identifier for the MinYear dependency property.</returns>
    public static extern DependencyProperty MinYearProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the MaxYear dependency property.</summary>
    /// <returns>The identifier for the MaxYear dependency property.</returns>
    public static extern DependencyProperty MaxYearProperty { [MethodImpl] get; }

    /// <summary>Gets the identifier for the Orientation dependency property.</summary>
    /// <returns>The identifier for the Orientation dependency property.</returns>
    public static extern DependencyProperty OrientationProperty { [MethodImpl] get; }
  }
}
