// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICalendarDatePicker
// Assembly: Windows.Foundation.UniversalApiContract, Version=14.0.0.0, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: F62EFE2D-E4C7-4EB8-B17A-E7D33D1BB49F
// Assembly location: C:\Users\codyc\.nuget\packages\microsoft.windows.sdk.contracts\10.0.22000.196\ref\netstandard2.0\Windows.Foundation.UniversalApiContract.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1674166639, 26252, 17553, 148, 68, 212, 93, 139, 244, 250, 41)]
  [ExclusiveTo(typeof (CalendarDatePicker))]
  [WebHostHidden]
  internal interface ICalendarDatePicker
  {
    IReference<DateTime> Date { get; set; }

    bool IsCalendarOpen { get; set; }

    string DateFormat { get; set; }

    string PlaceholderText { get; set; }

    object Header { get; set; }

    DataTemplate HeaderTemplate { get; set; }

    Style CalendarViewStyle { get; set; }

    DateTime MinDate { get; set; }

    DateTime MaxDate { get; set; }

    bool IsTodayHighlighted { get; set; }

    CalendarViewDisplayMode DisplayMode { get; set; }

    DayOfWeek FirstDayOfWeek { get; set; }

    string DayOfWeekFormat { get; set; }

    string CalendarIdentifier { get; set; }

    bool IsOutOfScopeEnabled { get; set; }

    bool IsGroupLabelVisible { get; set; }

    event CalendarViewDayItemChangingEventHandler CalendarViewDayItemChanging;

    event TypedEventHandler<CalendarDatePicker, CalendarDatePickerDateChangedEventArgs> DateChanged;

    event EventHandler<object> Opened;

    event EventHandler<object> Closed;

    void SetDisplayDate(DateTime date);

    void SetYearDecadeDisplayDimensions(int columns, int rows);
  }
}
